using ConnectToAPI.FormProducts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
