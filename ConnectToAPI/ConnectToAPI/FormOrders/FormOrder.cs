using CafeManagement.Application.Contracts.Dtos.OrderDetailDto;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;

namespace ConnectToAPI.FormOrders
{
    public partial class FormOrder : Form
    {
        private readonly IProductService _productService;
        private readonly IOrderDetailService _orderDetailService;
        private int _skipCount = 0;
        private readonly OptionsProductst _options;
        public FormOrder(IProductService productService, IOptions<OptionsProductst> options, IOrderDetailService orderDetailService)
        {
            _productService = productService;
            _orderDetailService = orderDetailService;
            _options = options.Value;
            InitializeComponent();
        }
        private async void BtFind_Click(object sender, EventArgs e)
        {
            var filterProduct = new FilterProductDto()
            {
                PriceMin = 0,
                SkipCount = _skipCount,
                TakeMaxResultCount = 5,
                Name = CbbSearch.Text,
                Choice = 1
            };

            var data = await _productService.GetListAsync(filterProduct);
            if (data.Data.Count == 0)
            {
                MessageBox.Show($"Not found {CbbSearch.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbbSearch.Text = string.Empty;
                return;
            }
            var orders = new List<GetNameAndPriceProductDto>();
            foreach (var p in data.Data)
            {
                var orderDtoNameAndPrice = new GetNameAndPriceProductDto()
                {
                    ProductId = p.Id,
                    NameAndPrice = p.Name + " - " + p.PriceSell,
                    Name = p.Name,
                    Price = p.PriceSell
                };
                orders.Add(orderDtoNameAndPrice);
            }
            CbbSearch.DisplayMember = "NameAndPrice";
            CbbSearch.DataSource = orders;
        }

        private void BtAddCart_Click(object sender, EventArgs e)
        {
            bool notFound = false;
            var listViewItem = new ListViewItem();
            var totalPrice = 0M;
            if (CbbSearch.SelectedItem is GetNameAndPriceProductDto nameAndPriceProductDto)
            {
                var create = new CreateOrderDetailDto()
                {
                    ProductId = nameAndPriceProductDto.ProductId,
                    Name = nameAndPriceProductDto.Name,
                    Price = nameAndPriceProductDto.Price,
                    Quantity = Convert.ToInt32(NUDQuantity.Value),
                    STT = listView1.Items.Count + 1
                };

                if (listView1.Items.Count != 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        var productId = listView1.Items[i].Tag?.ToString();
                        if (productId.Equals(create.ProductId.ToString()))
                        {
                            var quantityOld = listView1.Items[i].SubItems[2].Text;
                            var quantityNew = Convert.ToInt32(quantityOld) + NUDQuantity.Value;
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(quantityNew);
                            listView1.Items[i].SubItems[4].Text = $"{Convert.ToInt32(quantityNew) * nameAndPriceProductDto.Price}";
                            notFound = true;
                            break;
                        }

                    }
                }

                create.TotalPrice = Convert.ToInt32(NUDQuantity.Value) * nameAndPriceProductDto.Price;
                string[] row =
                    { $"{create.STT}",create.Name, $"{create.Quantity}", $"{create.Price}", $"{create.TotalPrice}" };
                listViewItem = new ListViewItem(row);
                listViewItem.Tag = nameAndPriceProductDto.ProductId;

                var totalBillOld = TbTotalBill.Text;
                if (!string.IsNullOrEmpty(totalBillOld))
                {
                    var totalBillNew = Convert.ToDecimal(totalBillOld) + create.TotalPrice;
                    TbTotalBill.Text = $"{totalBillNew}";
                }
                else
                {
                    var totalBillNew = create.TotalPrice;
                    TbTotalBill.Text = $"{totalBillNew}";
                }
                if (!notFound)
                {
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            // Add a column with width 20 and left alignment.
            listView1.Columns.Add("STT", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Price", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Total price", 200, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var item = listView1.SelectedItems[0].Tag.ToString();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var productId = listView1.Items[i].Tag?.ToString();
                if (productId.Equals(item))
                {
                    var Price = Convert.ToDecimal(listView1.Items[i].SubItems[4].Text);
                    var totalBillOld = Convert.ToDecimal(TbTotalBill.Text);
                    TbTotalBill.Text = $"{totalBillOld - Price}";

                    break;
                }

            }
            listView1.Items.Remove(listView1.SelectedItems[0]);
            //var quantityOld = listView1.Items[i].SubItems[2].Text;
            MessageBox.Show("Remove success");

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            var name = item.SubItems[1].Text;
            var quantity = item.SubItems[2].Text;
            var price = item.SubItems[3].Text;
            CbbSearch.Text = $"{name} - {price}";
            NUDQuantity.Text = quantity;
        }

        private void BtAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
