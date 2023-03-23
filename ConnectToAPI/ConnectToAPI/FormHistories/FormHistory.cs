using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;
using CafeManagement.Shared.Helper;

namespace ConnectToAPI.FormHistories
{
    public partial class FormHistory : Form
    {
        private readonly IInventoryTransactionService _inventoryTransactionService;
        private readonly IProductService _productService;
        private readonly IWarehouseService _wareHouseService;

        private bool _isLoadingDone = false;
        private int _currentPage = 1;
        private int _skipCount = 0;
        private int _maxResultCount = 0;
        public FormHistory(IInventoryTransactionService inventoryTransactionService, IProductService productService, IWarehouseService wareHouseService)
        {
            _inventoryTransactionService = inventoryTransactionService;
            _productService = productService;
            _wareHouseService = wareHouseService;
            InitializeComponent();
            RefreshCbb();
            RefreshComBoBox();
        }
        private void RefreshComBoBox()
        {
            _isLoadingDone = false;
            CbbPage.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            CbbPage.DisplayMember = "Name";
            CbbType.DataSource = EnumHelpers.GetEnumList<EnumInventoryTransationType>();
            CbbType.DisplayMember = "Name";
            CbbFilter.DataSource = EnumHelpers.GetEnumList<EnumInventoryTransactionFilter>();
            CbbFilter.DisplayMember = "Name";
            _isLoadingDone = true;
        }
        private async Task RefreshDataGirdView()
        {
            _isLoadingDone = false;
            _currentPage = 1;
            var filter = new FilterInventoryTransactionDto();
            if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _maxResultCount = Convert.ToInt32(indexPage.Name);
            }
            if (CbbType.SelectedItem is CommonEnumDto<EnumInventoryTransationType> type)
            {
                filter.Type = type.Id;
            }
            if (CbbFilter.SelectedItem is CommonEnumDto<EnumInventoryTransactionFilter> choice)
            {
                filter.Choice = choice.Id;
            }
            filter.SkipCount = _skipCount;
            filter.MaxResultCount = _maxResultCount;
            filter.FromDate = DTPFormDate.Value;
            filter.ToDate = DTPToDate.Value;
            var pagination = (await _inventoryTransactionService.GetListAsync(filter));
            Pagination(pagination);
            _isLoadingDone = true;
        }

        private void Pagination(CommonPageDto<InventoryTransactionDto> pagination)
        {
            Dtg.DataSource = pagination.Data;
            var allowNextPage = pagination.HasNextPage == true ? BtNextPage.Enabled = true : BtNextPage.Enabled = false;
            var allowReversPage = pagination.HasReversePage == true ? BtReversePage.Enabled = true : BtReversePage.Enabled = false;
            TbCurrentPage.Text = $"{_currentPage}/{pagination.TotalPage}";
            if (Dtg?.Columns != null && Dtg.Columns.Contains("InventoryId"))
            {
                Dtg.Columns["InventoryId"].Visible = false;
            }
        }

        private async Task RefreshCbb()
        {
            _isLoadingDone = false;
            var filterProductDto = new FilterProductDto()
            {
                MaxResultCount = 100,
                SkipCount = 0,
                Choice = 0
            };
            var filterWarehouseDto = new FilterWarehouseDto()
            {
                MaxResultCount = 100,
                SkipCount = 0
            };
            var products = await _productService.GetListAsync(filterProductDto);
            CbbProduct.DataSource = products.Data;
            CbbProduct.DisplayMember = "Name";
            var warehouses = await _wareHouseService.GetListAsync(filterWarehouseDto);
            CbbWareHouse.DataSource = warehouses.Data;
            CbbWareHouse.DisplayMember = "Name";
            _isLoadingDone = true;
        }
        private async void CbbPage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void BtReversePage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _currentPage--;
                _skipCount -= Convert.ToInt32(indexPage.Name);
                await RefreshDataGirdView();
            }
        }

        private async void BtNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _currentPage++;
                _skipCount += Convert.ToInt32(indexPage.Name);
                await RefreshDataGirdView();
            }
        }

        private async void CbbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                CbAllResult.Checked = false;
                BtNextPage.Enabled = false;
                BtReversePage.Enabled = false;
                _skipCount = 0;
                _currentPage = 1;
                var filter = new FilterInventoryTransactionDto()
                {
                    SkipCount = _skipCount,
                    MaxResultCount = _maxResultCount
                };

                if (CbbProduct.SelectedItem is ProductDto product)
                {
                    filter.ProductId = product.Id;
                }
                if (CbbWareHouse.SelectedItem is WarehouseDto warehouse)
                {
                    filter.WarehouseId = warehouse.Id;
                }
                if (CbbType.SelectedItem is CommonEnumDto<EnumInventoryTransationType> type)
                {
                    filter.Type = type.Id;
                }
                if (CbbFilter.SelectedItem is CommonEnumDto<EnumInventoryTransactionFilter> choice)
                {
                    filter.Choice = choice.Id;
                }
                filter.FromDate = DTPFormDate.Value;
                filter.ToDate = DTPToDate.Value;
                var data = await _inventoryTransactionService.GetListAsync(filter);
                Pagination(data);
                _isLoadingDone = true;
            }
        }

        private async void CbAllResult_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone && CbAllResult.Checked)
            {
                _currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }

        private async void FormHistory_Load(object sender, EventArgs e)
        {
            await RefreshDataGirdView();
        }

        private async void CbbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _currentPage = 1;
                _skipCount = 0;
                await RefreshDataGirdView();
            }
        }
    }
}
