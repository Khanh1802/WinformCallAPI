using ClassLibrary1.Dtos.ProductDtos;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ConnectToAPI.FormProducts
{
    public partial class FormAddProduct : Form
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        public bool IsDeleted = false;
        public FormAddProduct(IMemoryCache memoryCache, IConfiguration configuration, HttpClient httpClient)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            _configuration = configuration;
            _httpClient = httpClient;
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
                        var create = await _httpClient.PostAsJsonAsync("Product", createProduct);
                        if (create.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Create new product success", "Done", MessageBoxButtons.OK);
                            IsDeleted = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"{create.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
