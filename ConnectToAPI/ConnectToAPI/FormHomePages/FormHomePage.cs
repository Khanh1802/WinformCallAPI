using ConnectToAPI.FormHistories;
using ConnectToAPI.FormInventories;
using ConnectToAPI.FormOrders;
using ConnectToAPI.FormProducts;
using ConnectToAPI.FormStatistics;
using ConnectToAPI.FormWarehouses;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectToAPI.FormHomePages
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void BtPageProduct_Click(object sender, EventArgs e)
        {
            var pageProduct = Program.ServiceProvider.GetService<FormProduct>();
            pageProduct.ShowDialog();
        }

        private void BtPageWareHouse_Click(object sender, EventArgs e)
        {
            var pageWarehouse = Program.ServiceProvider.GetService<FormWarehouse>();
            pageWarehouse.ShowDialog();
        }

        private void BtPageInventory_Click(object sender, EventArgs e)
        {
            var pageInventory = Program.ServiceProvider.GetService<FormInventory>();
            pageInventory.ShowDialog();
        }

        private void BtStatistic_Click(object sender, EventArgs e)
        {
            var pageStatistics = Program.ServiceProvider.GetService<FormStatistic>();
            pageStatistics.ShowDialog();
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
            var pageOrder = Program.ServiceProvider.GetService<FormOrder>();
            pageOrder.ShowDialog();
        }

        private void BtHistory_Click(object sender, EventArgs e)
        {
            var pageHistory = Program.ServiceProvider.GetService<FormHistory>();
            pageHistory.ShowDialog();
        }
    }
}
