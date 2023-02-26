using CafeManagement.Application.Contracts.Services;
using ClassLibrary1.Dtos.ProductDtos;
using Microsoft.Extensions.Caching.Memory;

namespace ConnectToAPI.FormProducts
{
    public partial class FormAddProduct : Form
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IProductService _productService;
        public bool IsDeleted = false;
        public FormAddProduct(IMemoryCache memoryCache, IProductService productService)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            _productService = productService;
        }
        private async void BtAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbName.Text))
            {
                if (NUDPriceBuy.Value == 0)
                {
                    MessageBox.Show("Price buy is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (NUDPriceSell.Value == 0)
                {
                    MessageBox.Show("Price sell is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var createProduct = new CreateProductDto()
                    {
                        Name = TbName.Text,
                        PriceBuy = NUDPriceBuy.Value,
                        PriceSell = NUDPriceSell.Value
                    };
                    try
                    {
                        var create = await _productService.AddAsync(createProduct);
                        if (create is not null)
                        {
                            MessageBox.Show("Create new product success", "Done", MessageBoxButtons.OK);
                            IsDeleted = true;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
