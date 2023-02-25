using ClassLibrary1.Dtos.Generics;
using ClassLibrary1.Dtos.ProductDtos;
using ClassLibrary1.Enums;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConnectToAPI.FormProducts
{
    public partial class FormProduct : Form
    {
        private readonly IMemoryCache _memoryCache;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private int _skipCount = 0;
        private int _takeMaxResultCount = 0;
        private Guid? _productId = null;

        internal bool _isLoadingDone = false;

        public FormProduct(IMemoryCache memoryCache, HttpClient httpClient, IConfiguration configuration)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            _httpClient = httpClient;
            _configuration = configuration;
            CbbFilter.DataSource = EnumHelpers.GetEnumList<EnumProductFilter>();
            CbbFilter.DisplayMember = "Name";
            CbbIndexPage.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            CbbIndexPage.DisplayMember = "Name";
        }
        private async void BtAdd_Click(object sender, EventArgs e)
        {
            var pageAddProduct = Program.ServiceProvider.GetService<FormAddProduct>();
            pageAddProduct.ShowDialog();
            if (pageAddProduct.IsDeleted == true)
            {
                await RefreshDataGirdView();
            }
        }
        private async void BtUpdate_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone && _productId.HasValue && !string.IsNullOrEmpty(TbName.Text))
            {
                _isLoadingDone = false;
                var updateProduct = new UpdateProductDto()
                {
                    Name = TbName.Text,
                    PriceBuy = NUDPriceBuy.Value,
                    PriceSell = NUDPriceSell.Value
                };
                try
                {
                    var update = await _httpClient.PutAsJsonAsync($"{_configuration["CafeManagement:PutProduct"]}/{(Guid)_productId}", updateProduct);
                    if (update.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Update success", "Done", MessageBoxButtons.OK);
                        await RefreshDataGirdView();
                    }
                    else
                    {
                        MessageBox.Show($"{update.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private async void BtRemove_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (_productId.HasValue)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        try
                        {
                            _isLoadingDone = false;
                            var delete = await _httpClient.DeleteAsync($"{_configuration["CafeManagement:DeleteProduct"]}/{_productId}");
                            if (delete.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Deleted product success", "Done", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show($"{delete.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private async void FormProduct_Load(object sender, EventArgs e)
        {
            await RefreshDataGirdView();
        }

        private async Task RefreshDataGirdView()
        {
            _isLoadingDone = false;
            if (CbbIndexPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takeMaxResultCount = Convert.ToInt32(indexPage.Name);
            }
            var choice = -1;

            if (CbbFilter.SelectedItem is CommonEnumDto<EnumProductFilter> filter)
            {
                choice = Convert.ToInt32(filter.Id);
            }

            var getAll = await _httpClient.GetAsync($"{_configuration["CafeManagement:GetProduct"]}?SkipCount={_skipCount}&MaxResultCount={_takeMaxResultCount}");
            try
            {
                if (getAll.IsSuccessStatusCode)
                {
                    var data = (await getAll.Content.ReadFromJsonAsync<Generic<List<ProductDto>>>()).Data;
                    Dtg.DataSource = data;

                    if (Dtg?.Columns != null && Dtg.Columns.Contains("Id"))
                    {
                        Dtg.Columns["Id"]!.Visible = false;
                    }

                    if (Dtg?.Columns != null && Dtg.Columns.Contains("PriceBuy"))
                    {
                        Dtg.Columns["PriceBuy"]!.Visible = false;
                    }

                    BtAdd.Enabled = true;
                    BtRemove.Enabled = false;
                    BtUpdate.Enabled = false;
                    TbName.Text = string.Empty;
                    NUDPriceBuy.Value = 0;
                    NUDPriceSell.Value = 0;
                    _productId = null;
                    TbName.Enabled = false;
                    NUDPriceBuy.Enabled = false;
                    NUDPriceSell.Enabled = false;
                    _isLoadingDone = true;

                }
                else
                {
                    MessageBox.Show($"{getAll.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            _isLoadingDone = false;
            if (!string.IsNullOrEmpty(TbFind.Text))
            {
                CbAllResult.Checked = false;
                var filter = new FilterProductDto()
                {
                    Name = TbFind.Text,
                };
                try
                {
                    _isLoadingDone = false;
                    var find = await _httpClient.GetAsync($"{_configuration["CafeManagement:FindProduct"]}?name={TbFind.Text}");
                    if (find.IsSuccessStatusCode)
                    {
                        var data = (await find.Content.ReadFromJsonAsync<Generic<List<ProductDto>>>()).Data;
                        Dtg.DataSource = data;
                        if (data.Count == 0)
                        {
                            MessageBox.Show($"{find.StatusCode}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Not found any thing with \"{TbFind.Text}\"", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    _isLoadingDone = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Search is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _isLoadingDone = true;
        }

        private void Dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                BtAdd.Enabled = true;
                BtRemove.Enabled = false;
                BtUpdate.Enabled = false;
                TbName.Text = string.Empty;
                NUDPriceBuy.Value = 0;
                NUDPriceSell.Value = 0;
                _productId = null;
                TbName.Enabled = false;
                NUDPriceBuy.Enabled = false;
                NUDPriceSell.Enabled = false;
            }
            else
            {
                BtAdd.Enabled = false;
                BtRemove.Enabled = true;
                BtUpdate.Enabled = true;
                if (Dtg.Rows[e.RowIndex].DataBoundItem is ProductDto)
                {
                    var productDto = Dtg.Rows[e.RowIndex].DataBoundItem as ProductDto;
                    _productId = productDto.Id;
                    TbName.Text = productDto.Name;
                    NUDPriceBuy.Value = productDto.PriceBuy;
                    NUDPriceSell.Value = productDto.PriceSell;
                    TbName.Enabled = true;
                    NUDPriceBuy.Enabled = true;
                    NUDPriceSell.Enabled = true;
                }
            }
        }


        private async void CbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                //_currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void BtNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                //_currentPage++;
                if (CbbIndexPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
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
                if (CbbIndexPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipCount -= Convert.ToInt32(indexPage.Name);
                }
                await RefreshDataGirdView();
            }
        }

        private async void CbbIndexPage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbIndexPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
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

        private void FormProduct_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
