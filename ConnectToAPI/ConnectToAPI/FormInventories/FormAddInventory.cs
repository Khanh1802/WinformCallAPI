using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;

namespace ConnectToAPI.FormInventories
{
    public partial class FormAddInventory : Form
    {
        private readonly IProductService _productService;
        private readonly IWarehouseService _warehouseService;
        private readonly IInventoryService _inventoryService;
        private bool _isLoadingDone = false;
        public FormAddInventory(IProductService productService,
            IWarehouseService warehouseService,
            IInventoryService inventoryService)
        {
            InitializeComponent();
            _productService = productService;
            _warehouseService = warehouseService;
            _inventoryService = inventoryService;
        }
        private async void BtAdd_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                var create = new CreateInventoryDto();
                create.Quatity = Convert.ToInt32(NUDQuatity.Value);
                if (NUDQuatity.Value <= 0)
                {
                    MessageBox.Show("Quatity is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CbbProduct.SelectedIndex < 0)
                {
                    MessageBox.Show("Product is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CbbWarehouse.SelectedIndex < 0)
                {
                    MessageBox.Show("Warehouse is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CbbProduct.SelectedItem is ProductDto productDto && CbbWarehouse.SelectedItem is WarehouseDto warehouseDto)
                {
                    create.ProductId = productDto.Id;
                    create.WareHouseId = warehouseDto.Id;
                }
                if (create.ProductId != null && create.WareHouseId != null)
                {
                    try
                    {
                        await _inventoryService.AddAsync(create);
                        MessageBox.Show("Create new inventory success", "Done", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void FormAddInventory_Load(object sender, EventArgs e)
        {
            await RefreshCbbAsync();
            _isLoadingDone = true;
        }

        private async Task RefreshCbbAsync()
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
            CbbWarehouse.DataSource = (await _warehouseService.GetListAsync(warehouse)).Data;
            CbbWarehouse.DisplayMember = "Name";
            _isLoadingDone = true;
        }
    }
}
