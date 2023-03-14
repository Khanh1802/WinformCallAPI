using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectToAPI.FormProducts
{
    public partial class FormProduct : Form
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IProductService _productService;
        private int _skipCount = 0;
        private int _takeMaxResultCount = 0;
        private Guid? _productId = null;
        private int _currentPage = 1;

        internal bool _isLoadingDone = false;

        public FormProduct(IMemoryCache memoryCache, IProductService productService)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            CbbFilterPrice_Date.DataSource = EnumHelpers.GetEnumList<EnumProductFilter>();
            CbbFilterPrice_Date.DisplayMember = "Name";
            CbbPageIndex.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            CbbPageIndex.DisplayMember = "Name";
            _productService = productService;
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
                    var update = await _productService.UpdateAsync((Guid)_productId, updateProduct);
                    if (update is not null)
                    {
                        MessageBox.Show("Update success", "Done", MessageBoxButtons.OK);
                        await RefreshDataGirdView();
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
                            var delete = await _productService.DeletedAsync((Guid)_productId);
                            if (delete)
                            {
                                MessageBox.Show("Deleted product success", "Done", MessageBoxButtons.OK);
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
            if (CbbPageIndex.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takeMaxResultCount = Convert.ToInt32(indexPage.Name);
            }
            FilterProductDto filterProduct = new FilterProductDto()
            {
                PriceMin = NumericPriceMin.Value,
                Pricemax = NumericPriceMax.Value,
                SkipCount = _skipCount,
                TakeMaxResultCount = _takeMaxResultCount
            };

            if (CbbFilterPrice_Date.SelectedItem is CommonEnumDto<EnumProductFilter> filter)
            {
                filterProduct.Choice = Convert.ToInt32(filter.Id);
            }
            await DataPageList(filterProduct);
            RefesheButton();
        }

        private void RefesheButton()
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
            _isLoadingDone = true;
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            _isLoadingDone = false;
            _skipCount = 0;
            if (CbbPageIndex.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takeMaxResultCount = Convert.ToInt32(indexPage.Name);
            }
            if (!string.IsNullOrEmpty(TbSearch.Text))
            {
                CbAllResult.Checked = false;
                var filterProduct = new FilterProductDto()
                {
                    PriceMin = NumericPriceMin.Value,
                    SkipCount = _skipCount,
                    TakeMaxResultCount = _takeMaxResultCount
                };
                if (Guid.TryParse(TbSearch.Text, out var guid))
                {
                    filterProduct.Id = guid;
                }
                else
                {
                    filterProduct.Name = TbSearch.Text;
                }
                if (NumericPriceMax.Value > 0)
                {
                    filterProduct.Pricemax = NumericPriceMax.Value;
                }
                if (CbbFilterPrice_Date.SelectedItem is CommonEnumDto<EnumProductFilter> choice)
                {
                    filterProduct.Choice = Convert.ToInt32(choice.Id);
                }
                try
                {
                    _isLoadingDone = false;
                    await DataPageList(filterProduct);
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
                RefesheButton();
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

        private async void CbbFilterPrice_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void BtNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                _currentPage++;
                if (CbbPageIndex.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
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
                _currentPage--;
                if (CbbPageIndex.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _skipCount -= Convert.ToInt32(indexPage.Name);
                }
                await RefreshDataGirdView();
            }
        }

        private async void CbbPageIndex_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbPageIndex.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
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
                _currentPage = 1;
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

        private async Task DataPageList(FilterProductDto filterProduct)
        {
            var data = await _productService.GetListAsync(filterProduct);
            Dtg.DataSource = data.Data;

            TbCurrentPage.Text = $"{_currentPage}/{Convert.ToString(data.TotalPage)}";
            BtNextPage.Enabled = data.HasNextPage == true ? true : false;
            BtReversePage.Enabled = data.HasReversePage == true ? true : false;
            if (Dtg?.Columns != null && Dtg.Columns.Contains("Id"))
            {
                Dtg.Columns["Id"]!.Visible = false;
            }

            if (Dtg?.Columns != null && Dtg.Columns.Contains("PriceBuy"))
            {
                Dtg.Columns["PriceBuy"]!.Visible = false;
            }
        }
    }
}
