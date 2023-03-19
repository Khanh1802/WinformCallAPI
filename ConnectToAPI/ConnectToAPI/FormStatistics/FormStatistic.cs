using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;

namespace ConnectToAPI.FormStatistics
{
    public partial class FormStatistic : Form
    {
        private readonly IInventoryTransactionService _inventoryTransactionService;
        private readonly IWarehouseService _wareHouseService;
        private readonly IProductService _productService;

        internal bool _isLoadingDone = false;
        private int _skipCount = 0;
        private int _takeCount = 0;
        public FormStatistic(IInventoryTransactionService inventoryTransactionService, IWarehouseService wareHouseService, IProductService productService)
        {
            InitializeComponent();
            _inventoryTransactionService = inventoryTransactionService;
            _wareHouseService = wareHouseService;
            _productService = productService;
        }
        private async void FormInventoryTransaction_Load(object sender, EventArgs e)
        {
            await LoadComboboxData();
            await RefreshDataGirdView();
        }

        private async Task LoadComboboxData()
        {
            CbbFilter.DataSource = EnumHelpers.GetEnumList<EnumInventoryTransactionFilter>();
            CbbFilter.DisplayMember = "Name";
            CbbType.DataSource = EnumHelpers.GetEnumList<EnumInventoryTransationType>();
            CbbType.DisplayMember = "Name";
            CbbPage.DataSource = EnumHelpers.GetEnumList<EnumIndexPage>();
            CbbPage.DisplayMember = "Name";
            if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
            {
                _takeCount = Convert.ToInt32(indexPage.Name);
            }
            await RefreshCbb();
        }

        private async Task RefreshCbb()
        {
            _isLoadingDone = false;
            var product = new FilterProductDto()
            {
                MaxResultCount = 100,
                SkipCount = 0,
                Choice = 0
            };
            var warehouse = new FilterWarehouseDto()
            {
                MaxResultCount = 100,
                SkipCount = 0
            };
            CbbProduct.DataSource = (await _productService.GetListAsync(product)).Data;
            CbbProduct.DisplayMember = "Name";
            CbbWarehouse.DataSource = (await _wareHouseService.GetListAsync(warehouse)).Data;
            CbbWarehouse.DisplayMember = "Name";
            _isLoadingDone = true;
        }
        private async Task RefreshDataGirdView()
        {
            _isLoadingDone = false;
            var filter = new FilterInventoryTransactionDto()
            {
                MaxResultCount = _takeCount,
                SkipCount = _skipCount
            };
            if (CbbFilter.SelectedItem is CommonEnumDto<EnumInventoryTransactionFilter> choice)
            {
                filter.Choice = Convert.ToInt32(choice.Id);
            }
            if (CbbType.SelectedItem is CommonEnumDto<EnumInventoryTransationType> type)
            {
                filter.Type = Convert.ToInt32(type.Id);
            }
            var inventoryTransactions = await _inventoryTransactionService.GetListAsync(filter);
            Dtg.DataSource = inventoryTransactions;

            if (Dtg?.Columns != null && Dtg.Columns.Contains("Id"))
            {
                Dtg.Columns["Id"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("InventoryId"))
            {
                Dtg.Columns["InventoryId"]!.Visible = false;
            }
            if (Dtg?.Columns != null && Dtg.Columns.Contains("Inventory"))
            {
                Dtg.Columns["Inventory"]!.Visible = false;
            }
            _isLoadingDone = true;
        }

        private async void BtFind_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                CbAllResult.Checked = false;
                _skipCount = 0;
                var filter = new FilterInventoryTransactionDto()
                {
                    MaxResultCount = _takeCount,
                    SkipCount = _skipCount,

                };
                if (CbbWarehouse.SelectedItem is WarehouseDto warehouse)
                {
                    filter.WarehouseId = warehouse.Id;
                }
                if (CbbProduct.SelectedItem is ProductDto product)
                {
                    filter.ProductId = product.Id;
                }
                if (CbbType.SelectedItem is CommonEnumDto<EnumInventoryTransationType> type)
                {
                    filter.Type = Convert.ToInt32(type.Id);
                }
                if (CbbFilter.SelectedItem is CommonEnumDto<EnumInventoryTransactionFilter> choice)
                {
                    filter.Choice = Convert.ToInt32(choice.Id);
                }
                if (!string.IsNullOrEmpty(TbId.Text))
                {
                    var convertGuid = Guid.TryParse(TbId.Text, out var id);
                    if (convertGuid)
                    {
                        filter.Id = id;
                    }
                    else
                    {
                        filter.NameSearch = TbId.Text;
                    }
                }
                filter.FromDate = DTPFormDate?.Value ?? null;
                filter.ToDate = DTPToDate?.Value ?? null;
                var resultFilter = await _inventoryTransactionService.GetListAsync(filter);
                Dtg.DataSource = resultFilter;
                //BtNextPage.Enabled = false;
                //BtReversePage.Enabled = false;
                TbCurrentPage.Text = $"{1} / {1}";
                _isLoadingDone = true;
            }
        }

        private async void CbbPage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                if (CbbPage.SelectedItem is CommonEnumDto<EnumIndexPage> indexPage)
                {
                    _takeCount = Convert.ToInt32(indexPage.Name);
                    _skipCount = 0;
                }
                if (!CbAllResult.Checked)
                {
                    await RefreshDataGirdView();
                }
                else
                {
                    await RefreshCheckBoxWarehouse();
                }
            }
        }

        private async Task RefreshCheckBoxWarehouse()
        {
            var filter = new FilterInventoryTransactionDto()
            {
                MaxResultCount = _takeCount,
                SkipCount = _skipCount,
            };
            if (CbbType.SelectedItem is CommonEnumDto<EnumInventoryTransationType> transation)
            {
                filter.Type = Convert.ToInt32(transation.Id);
            }
            var inventoryTransactions = await _inventoryTransactionService.GetListAsync(filter);
            Dtg.DataSource = inventoryTransactions;
        }

        private async void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            await RefreshCheckBoxWarehouse();
        }

        private async void CbbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                await RefreshDataGirdView();
            }
        }

        private void BtNextPage_Click(object sender, EventArgs e)
        {

        }

        private void BtReversePage_Click(object sender, EventArgs e)
        {

        }
    }
}
