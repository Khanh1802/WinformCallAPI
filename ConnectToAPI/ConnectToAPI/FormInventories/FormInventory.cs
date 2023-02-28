using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;
using ClassLibrary1.Dtos.ProductDtos;
using ClassLibrary1.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectToAPI.FormInventories
{
    public partial class FormInventory : Form
    {
        private readonly IInventoryService _inventoryService;
        private readonly IProductService _productService;
        private readonly IWarehouseService _wareHouseService;
        internal bool _isLoadingDone = false;
        private Guid? _InventoryId;
        private int _takePage = 0;
        private int _skipPage = 0;

        public FormInventory(IInventoryService inventoryService,
            IProductService productService,
            IWarehouseService wareHouseService)
        {
            InitializeComponent();
            _inventoryService = inventoryService;
            _productService = productService;
            _wareHouseService = wareHouseService;
            CbbPage.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            CbbPage.DisplayMember = "Name";
            if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takePage = Convert.ToInt32(indexPage.Name);
            }
            CbbInventoryFilter.DataSource = EnumHelpers.GetEnumList<EnumChoiceFilter>();
            CbbInventoryFilter.DisplayMember = "Name";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                var pageAddInventory = Program.ServiceProvider.GetService<FormAddInventory>();
                pageAddInventory.ShowDialog();
            }
        }

        private void Dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                BtRemove.Enabled = false;
                TbQuatity.ReadOnly = true;
                TbQuatity.Text = string.Empty;
                _InventoryId = null;
            }
            else
            {
                BtRemove.Enabled = true;
                if (Dtg.Rows[e.RowIndex].DataBoundItem is InventoryDto)
                {
                    var inventory = Dtg.Rows[e.RowIndex].DataBoundItem as InventoryDto;
                    _InventoryId = inventory.Id;
                    TbQuatity.Text = Convert.ToString(inventory.Quatity);
                    TbQuatity.ReadOnly = false;
                }
            }
        }

        private async void FormInventory_Load(object sender, EventArgs e)
        {
            await RefreshCbb();
            await RefreshDataGirdView();
        }

        private async Task RefreshCbb()
        {
            _isLoadingDone = false;
            var product = new FilterProductDto()
            {
                TakeMaxResultCount = 100,
                SkipCount = 0,
                Choice = 0
            };
            var warehouse = new FilterWarehouseDto()
            {
                TakeMaxResultCount = 100,
                SkipCount = 0
            };
            CbbProduct.DataSource = await _productService.GetListAsync(product);
            CbbProduct.DisplayMember = "Name";
            CbbWareHouse.DataSource = await _wareHouseService.GetListAsync(warehouse);
            CbbWareHouse.DisplayMember = "Name";
            _isLoadingDone = true;
        }

        private async void CbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbProduct.SelectedIndex >= 0)
            {
                await RefreshDataGirdView();
            }
        }

        private async Task RefreshDataGirdView()
        {
            _isLoadingDone = false;
            var filter = new FilterInventoryDto()
            {
                TakeMaxResultCount = _takePage,
                SkipCount = _skipPage,
            };
            if (CbbInventoryFilter.SelectedItem is CommonEnumDto<EnumChoiceFilter> enumFilter)
            {
                filter.Choice = (int)enumFilter.Id;
            }
            var data = await _inventoryService.GetListAsync(filter);
            Dtg.DataSource = data;

            if (Dtg?.Columns != null && Dtg.Columns.Contains("Id"))
            {
                Dtg.Columns["Id"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("ProductId"))
            {
                Dtg.Columns["ProductId"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("WareHouseId"))
            {
                Dtg.Columns["WareHouseId"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("Product"))
            {
                Dtg.Columns["Product"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("WareHouse"))
            {
                Dtg.Columns["WareHouse"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("IsDeleted"))
            {
                Dtg.Columns["IsDeleted"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("DeletetionTime"))
            {
                Dtg.Columns["DeletetionTime"]!.Visible = false;
            }

            BtRemove.Enabled = false;
            TbQuatity.Text = string.Empty;
            TbQuatity.ReadOnly = false;
            _isLoadingDone = true;
        }

        private async void BtReversePage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipPage -= Convert.ToInt32(indexPage.Name);
                    await RefreshDataGirdView();
                }
            }
        }

        private async void BtNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipPage += Convert.ToInt32(indexPage.Name);
                    await RefreshDataGirdView();
                }
            }
        }

        private async void CbbPage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _takePage = Convert.ToInt32(indexPage.Name);
                    _skipPage = 0;
                    await RefreshDataGirdView();
                }
            }
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                CbAllResult.Checked = false;
                var dataGirdView = new List<InventoryDto>();
                _isLoadingDone = false;
                var filter = new FilterInventoryDto();
                if (CbbProduct.SelectedItem is ProductDto productDto)
                {
                    filter.ProductId = productDto.Id;
                }
                if (CbbWareHouse.SelectedItem is WarehouseDto warehouseDto)
                {
                    filter.WareHouseId = warehouseDto.Id;
                }
                if (filter.ProductId != null && filter.WareHouseId != null)
                {
                    //dataGirdView = await _inventoryService.FilterAsync(filter);
                    //Dtg.DataSource = dataGirdView;
                }

                BtRemove.Enabled = false;
                BtNextPage.Enabled = true;
                BtReversePage.Enabled = true;
                TbQuatity.ReadOnly = false;
                TbQuatity.Text = string.Empty;
                _InventoryId = null;
                _isLoadingDone = true;
            }
        }

        private async void CbbInventoryFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takePage = Convert.ToInt32(indexPage.Name);
                _skipPage = 0;
                await RefreshDataGirdView();
            }
        }

        private async void BtRemove_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone && _InventoryId is not null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        _isLoadingDone = false;
                        if (_InventoryId.HasValue)
                        {
                            await _inventoryService.DeletedAsync(_InventoryId.Value);
                        }
                        MessageBox.Show("Deleted inventory success", "Done", MessageBoxButtons.OK);
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

        private async void CbAllResult_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                await RefreshDataGirdView();
            }
        }

        private async void BtUpdate_Click(object sender, EventArgs e)
        {
            _isLoadingDone = false;
            if (string.IsNullOrEmpty(TbQuatity.Text))
            {
                MessageBox.Show("Quantity is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CbbProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Product is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CbbWareHouse.SelectedIndex < 0)
            {
                MessageBox.Show("Product or Warehouse is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var quatity = Convert.ToInt32(TbQuatity.Text);
            if (_InventoryId.HasValue && CbbProduct.SelectedValue is ProductDto && CbbWareHouse.SelectedValue is WarehouseDto
                && _InventoryId.HasValue)
            {
                var updateInventory = new UpdateInventoryDto()
                {
                    Id = _InventoryId,
                    Quatity = quatity,
                };
                try
                {
                    await _inventoryService.UpdateAsync(_InventoryId.Value, updateInventory);
                    MessageBox.Show("Update success", "Done", MessageBoxButtons.OK);
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

        private void Dtg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                RefresheButton();
            }
            else
            {
                BtAdd.Enabled = false;
                BtRemove.Enabled = true;
                BtUpdate.Enabled = true;
                if (Dtg.Rows[e.RowIndex].DataBoundItem is InventoryDto)
                {
                    var InventoryDto = Dtg.Rows[e.RowIndex].DataBoundItem as InventoryDto;
                    _InventoryId = InventoryDto.Id;
                }
            }
        }
        private void RefresheButton()
        {
            BtAdd.Enabled = true;
            BtRemove.Enabled = false;
            BtUpdate.Enabled = false;
            _InventoryId = null;
            _isLoadingDone = true;
        }
    }
}
