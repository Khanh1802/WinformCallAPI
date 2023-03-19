using CafeManagement.Application.Contracts.Dtos.CartDto;
using CafeManagement.Application.Contracts.Dtos.OrderDtos;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Enums;
using Microsoft.Extensions.Caching.Memory;

namespace ConnectToAPI.FormOrders
{
    public partial class FormOrder : Form
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMemoryCache _memoryCache;
        private readonly ICartService _cartService;
        private int _skipCount = 0;
        public FormOrder(IProductService productService, IMemoryCache memoryCache, ICartService cartService, IOrderService orderService)
        {
            _productService = productService;
            _memoryCache = memoryCache;
            _cartService = cartService;
            _orderService = orderService;
            InitializeComponent();
            CbbDelivery.DataSource = EnumHelpers.GetEnumList<EnumDelivery>();
            CbbDelivery.DisplayMember = "Name";
        }
        private async void BtFind_Click(object sender, EventArgs e)
        {
            var filterProduct = new FilterProductDto()
            {
                PriceMin = 0,
                SkipCount = _skipCount,
                MaxResultCount = 5,
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
            var andPriceProductDtos = new List<GetNameAndPriceProductDto>();
            foreach (var p in data.Data)
            {
                var NameAndPrice = new GetNameAndPriceProductDto()
                {
                    ProductId = p.Id,
                    NameAndPrice = p.Name + " - " + p.PriceSell,
                    Name = p.Name,
                    Price = p.PriceSell
                };
                andPriceProductDtos.Add(NameAndPrice);
            }
            CbbSearch.DisplayMember = "NameAndPrice";
            CbbSearch.DataSource = andPriceProductDtos;
        }

        private async void BtAddCart_Click(object sender, EventArgs e)
        {
            var createCart = new CreateCartDto();
            if (string.IsNullOrEmpty(TbPhone.Text))
            {
                MessageBox.Show("Phone is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TbAddress.Text))
            {
                MessageBox.Show("Phone is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TbName.Text))
            {
                MessageBox.Show("Phone is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (CbbDelivery.SelectedItem is CommonEnumDto<EnumDelivery> delivery)
            //{
            //    createCart.Delivery = delivery.Id;
            //}
            if (CbbSearch.SelectedItem is GetNameAndPriceProductDto nameAndPriceProductDto)
            {
                createCart.NameProduct = nameAndPriceProductDto.Name;
                createCart.Price = nameAndPriceProductDto.Price;
                createCart.Quantity = Convert.ToInt32(NUDQuantity.Value);
                createCart.ProductId = nameAndPriceProductDto.ProductId;
            }
            createCart.CustomerName = TbName.Text;
            createCart.Address = TbAddress.Text;
            createCart.Phone = TbPhone.Text;

            if (createCart.ProductId == Guid.Empty)
            {
                MessageBox.Show("Choice product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var createAsync = await _cartService.CreateCartAsync(createCart);
                await Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region CodeOld
            //bool notFound = false;
            //var listViewItem = new ListViewItem();
            //var totalPrice = 0M;
            //if (CbbSearch.SelectedItem is GetNameAndPriceProductDto nameAndPriceProductDto)
            //{
            //    var create = new CreateOrderDetailDto()
            //    {
            //        ProductId = nameAndPriceProductDto.ProductId,
            //        Name = nameAndPriceProductDto.Name,
            //        Price = nameAndPriceProductDto.Price,
            //        Quantity = Convert.ToInt32(NUDQuantity.Value),
            //        STT = listView1.Items.Count + 1
            //    };

            //    if (listView1.Items.Count != 0)
            //    {
            //        for (int i = 0; i < listView1.Items.Count; i++)
            //        {
            //            var productId = listView1.Items[i].Tag?.ToString();
            //            if (productId.Equals(create.ProductId.ToString()))
            //            {
            //                var quantityOld = listView1.Items[i].SubItems[2].Text;
            //                var quantityNew = Convert.ToInt32(quantityOld) + NUDQuantity.Value;
            //                listView1.Items[i].SubItems[2].Text = Convert.ToString(quantityNew);
            //                listView1.Items[i].SubItems[4].Text = $"{Convert.ToInt32(quantityNew) * nameAndPriceProductDto.Price}";
            //                notFound = true;
            //                break;
            //            }
            //        }
            //    }

            //    create.TotalPrice = Convert.ToInt32(NUDQuantity.Value) * nameAndPriceProductDto.Price;
            //    string[] row =
            //        { $"{create.STT}",create.Name, $"{create.Quantity}", $"{create.Price}", $"{create.TotalPrice}" };
            //    listViewItem = new ListViewItem(row);
            //    listViewItem.Tag = nameAndPriceProductDto.ProductId;

            //    var totalBillOld = TbTotalBill.Text;
            //    if (!string.IsNullOrEmpty(totalBillOld))
            //    {
            //        var totalBillNew = Convert.ToDecimal(totalBillOld) + create.TotalPrice;
            //        TbTotalBill.Text = $"{totalBillNew}";
            //    }
            //    else
            //    {
            //        var totalBillNew = create.TotalPrice;
            //        TbTotalBill.Text = $"{totalBillNew}";
            //    }
            //    if (!notFound)
            //    {
            //        listView1.Items.Add(listViewItem);
            //    }

            //    object a = listView1;
            //    _memoryCache.Set<ListView>(OrderCacheKey.OrderKey, listView1, new MemoryCacheEntryOptions
            //    {
            //        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            //    });
            //} 
            #endregion
        }

        private async void FormOrder_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            // Add a column with width 20 and left alignment.
            listView1.Columns.Add("Id", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Price", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Total price", 200, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
            BtAccept.Enabled = false;
            #region MyRegion
            //_memoryCache.TryGetValue<ListView>(OrderCacheKey.OrderKey, out var result);
            //if (result != null)
            //{
            //    for (int i = 0; i < result.Items.Count; i++)
            //    {
            //        string[] row =
            //            { $"{result.Items[i].SubItems[0].Text}",$"{result.Items[i].SubItems[1].Text}",$"{result.Items[i].SubItems[2].Text}",
            //                $" {result.Items[i].SubItems[3].Text}",$"{result.Items[i].SubItems[4].Text}"};
            //        var listViewItem = new ListViewItem(row);
            //        listView1.Items.Add(listViewItem);
            //    }
            //}
            #endregion
            await Refresh();
        }

        private async Task Refresh()
        {
            var totalBill = 0M;
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }

            if (!string.IsNullOrEmpty(TbPhone.Text))
            {
                var getCart = await _cartService.GetCartAsync(TbPhone.Text);

                if (getCart.Carts != null)
                {
                    for (int i = 0; i < getCart.Carts.Count; i++)
                    {
                        string[] row = {getCart.Carts[i].ProductId.ToString(), getCart.Carts[i].ProductName, getCart.Carts[i].Quantity.ToString()
                            , getCart.Carts[i].Price.ToString(), getCart.Carts[i].TotalPrice.ToString()};
                        var listItem = new ListViewItem(row);
                        listView1.Items.Add(listItem);
                    }
                }
                AllowBtAccept(getCart.Carts.Count);
                TbTotalBill.Text = getCart.TotalBill.ToString();
            }
        }

        private async void BtRemove_Click(object sender, EventArgs e)
        {
            #region CodeOld
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    return;
            //}

            //var item = listView1.SelectedItems[0].Tag.ToString();
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    var productId = listView1.Items[i].Tag?.ToString();
            //    if (productId.Equals(item))
            //    {
            //        var Price = Convert.ToDecimal(listView1.Items[i].SubItems[4].Text);
            //        var totalBillOld = Convert.ToDecimal(TbTotalBill.Text);
            //        TbTotalBill.Text = $"{totalBillOld - Price}";
            //        break;
            //    }
            //}
            //listView1.Items.Remove(listView1.SelectedItems[0]);
            #endregion
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    var guid = Guid.Parse(item.SubItems[0].Text);
                    var delete = new UpdateCartDto()
                    {
                        Phone = TbPhone.Text,
                        ProductId = guid
                    };
                    try
                    {
                        await _cartService.UpdateAsync(delete);
                        MessageBox.Show("Remove success");
                        await Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

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

        private async void BtAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbPhone.Text))
            {
                return;
            }
            var cartDto = await _cartService.GetCartAsync(TbPhone.Text);
            var createOrder = new CreateOrderDto()
            {
                Phone = TbPhone.Text,
                TotalBill = cartDto.TotalBill,
                CustomerName = cartDto.CustomerName,
                OrderDetails = cartDto.Carts
            };

            if (CbbDelivery.SelectedItem is CommonEnumDto<EnumDelivery> delivery)
            {
                createOrder.Delivery = delivery.Id;
            }
            AllowBtAccept(cartDto.Carts.Count);
            try
            {
                await _orderService.AddAsync(createOrder);
                BtAccept.Enabled = false;
                RemoveText(); 
                MessageBox.Show("Create order succsess", "Conratugration", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveText()
        {
            TbPhone.Text = string.Empty;
            TbAddress.Text = string.Empty;
            TbName.Text = string.Empty;
            TbTotalBill.Text = string.Empty;
            listView1.Items.Clear();
        }

        private void AllowBtAccept(int count)
        {
            if (count > 0)
            {
                BtAccept.Enabled = true;
            }
            else
            {
                BtAccept.Enabled = false;
            }
        }
    }
}
