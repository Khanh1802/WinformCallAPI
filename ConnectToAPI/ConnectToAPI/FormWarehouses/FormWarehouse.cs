using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ConnectToAPI.FormWarehouses
{
    public partial class FormWarehouse : Form
    {
        private readonly IWarehouseService _warehouseService;
        private readonly OptionsWarehouses _optionsWarehouses;
        private int _skipCount = 0;
        private int _takeMaxResultCount = 10;
        private bool _isLoadingDone = false;
        private Guid? _wareHouseId;
        public FormWarehouse(IWarehouseService warehouseService, IOptions<OptionsWarehouses> optionsWarehouses)
        {
            InitializeComponent();
            _warehouseService = warehouseService;
            _optionsWarehouses = optionsWarehouses.Value; 
            FormWarehousePage.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            FormWarehousePage.DisplayMember = "Name";
        }
        private async void BtAdd_Click(object sender, EventArgs e)
        {
            var pageAddWareHouse = Program.ServiceProvider.GetService<FormAddWarehouse>();
            pageAddWareHouse.ShowDialog();
            if (pageAddWareHouse.IsDeleted == true)
            {
                await RefreshDataGirdView();
            }
        }

        private async void BtUpdate_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (!string.IsNullOrEmpty(TbName.Text))
                {
                    var updateWareHouse = new UpdateWarehouseDto()
                    {
                        Id = (Guid)_wareHouseId,
                        Name = TbName.Text,
                    };
                    try
                    {
                        _isLoadingDone = false;
                        await _warehouseService.UpdateAsync(_wareHouseId.Value, updateWareHouse);
                        MessageBox.Show("Delete success", "Done", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        await RefreshDataGirdView();
                    }
                }
                else
                {
                    MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtRemove_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (_wareHouseId.HasValue)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        try
                        {
                            _isLoadingDone = false;
                            await _warehouseService.DeletedAsync(_wareHouseId.Value);
                            MessageBox.Show("Deleted WareHouse success", "Done", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            await RefreshDataGirdView();
                        }
                    }
                }
            }
        }

        private void Dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                BtAdd.Enabled = true;
                BtRemove.Enabled = false;
                BtUpdate.Enabled = false;
                TbName.Text = string.Empty;
                _wareHouseId = null;
                TbName.Enabled = false;
            }
            else
            {
                BtAdd.Enabled = false;
                BtRemove.Enabled = true;
                BtUpdate.Enabled = true;
                if (Dtg.Rows[e.RowIndex].DataBoundItem is WarehouseDto)
                {
                    var wareHouse = Dtg.Rows[e.RowIndex].DataBoundItem as WarehouseDto;
                    _wareHouseId = wareHouse.Id;
                    TbName.Text = wareHouse.Name;
                    TbName.Enabled = true;
                }
            }
        }

        private async void FormWareHouse_Load(object sender, EventArgs e)
        {
            await RefreshDataGirdView();
        }

        private async void CbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RefreshDataGirdView();
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbFind.Text) || !string.IsNullOrEmpty(TbId.Text))
            {
                CbAllResult.Checked = false;
                var filter = new FilterWarehouseDto()
                {
                    Name = TbFind.Text,
                    SkipCount = _skipCount,
                    MaxResultCount = _takeMaxResultCount
                };
                if (!string.IsNullOrEmpty(TbId.Text))
                {
                    Guid.TryParse(TbId.Text, out var id);
                    filter.Id = id;
                }
                try
                {
                    _isLoadingDone = false;
                    var find = await _warehouseService.GetListAsync(filter);
                    Dtg.DataSource = find;
                    _isLoadingDone = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                await RefreshDataGirdView();
            }
        }
        private async Task RefreshDataGirdView()
        {
            try
            {
                _isLoadingDone = false;
                if (FormWarehousePage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _takeMaxResultCount = Convert.ToInt32(indexPage.Name);
                }
                var filter = new FilterWarehouseDto()
                {
                    Name = TbFind.Text,
                    SkipCount = _skipCount,
                    MaxResultCount = _takeMaxResultCount
                };
                Dtg.DataSource = await _warehouseService.GetListAsync(filter);
                if (Dtg?.Columns != null && Dtg.Columns.Contains("Id"))
                {
                    Dtg.Columns["Id"]!.Visible = false;
                }
                BtAdd.Enabled = true;
                BtRemove.Enabled = false;
                BtUpdate.Enabled = false;
                TbName.Text = string.Empty;
                _wareHouseId = null;
                TbName.Enabled = false;
                _isLoadingDone = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormWareHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLoadingDone)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private async void BtNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                //_currentPage++;
                if (FormWarehousePage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipCount += Convert.ToInt32(indexPage.Name);
                }
                await RefreshDataGirdView();
            }
        }

        private async void BtReversePage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                //_currentPage--;
                if (FormWarehousePage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipCount -= Convert.ToInt32(indexPage.Name);
                }
                await RefreshDataGirdView();
            }
        }
        private async void FormWarehousePage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && FormWarehousePage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void CbAllResult_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbAllResult.Checked)
            {
                _skipCount = 0;
                //_currentPage = 1;
                await RefreshDataGirdView();
            }
        }
    }
}
