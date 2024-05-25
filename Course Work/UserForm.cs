using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_Work
{
    public partial class UserForm : Form
    {
        private Client client;
        private UserLoader loader;

        public UserForm(Client client)
        {
            InitializeComponent();

            this.client = client;

            this.loader = new UserLoader();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    this.loader.LoadProducts(productsTable);
                    break;

                case 1:
                    this.loader.LoadActiveOrders(activeOrdersTable, client);
                    break;

                case 2:
                    this.loader.LoadCompletedOrders(completedOrdersTable, client);
                    break;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.loader.LoadProducts(productsTable);
        }

        private void btnRefreshCreateOrder_Click(object sender, EventArgs e)
        {
            this.loader.LoadProducts(productsTable);
        }

        private void brnRefreshActiveOrders_Click(object sender, EventArgs e)
        {
            this.loader.LoadActiveOrders(activeOrdersTable, client);
        }

        private void btnRefreshCompletedOrders_Click(object sender, EventArgs e)
        {
            this.loader.LoadCompletedOrders(completedOrdersTable, client);
        }

        private void productsTable_SelectionChanged(object sender, EventArgs e)
        {
            quantityNumericUpDown.Value = 1;

            if (productsTable.SelectedRows.Count == 0 || Convert.ToInt32(productsTable.SelectedRows[0].Cells[4].Value) == 0)
            {
                quantityNumericUpDown.Enabled = false;
                totalPriceLabel.Text = "0";
                btnCreateOrder.Enabled = false;
                return;
            }

            quantityNumericUpDown.Enabled = true;
            totalPriceLabel.Text = Convert.ToString(productsTable.SelectedRows[0].Cells[5].Value);
            btnCreateOrder.Enabled = true;
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count == 0 || Convert.ToInt32(productsTable.SelectedRows[0].Cells[4].Value) == 0)
            {
                return;
            }

            int productPrice = Convert.ToInt32(productsTable.SelectedRows[0].Cells[5].Value);

            int quantity = Convert.ToInt32(quantityNumericUpDown.Value);
            int productQuantity = Convert.ToInt32(productsTable.SelectedRows[0].Cells[4].Value);

            if (quantity > productQuantity)
            {
                quantity = productQuantity;
            }

            totalPriceLabel.Text = Convert.ToString(quantity * productPrice);
            quantityNumericUpDown.Value = quantity;
        }

        private void activeOrdersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (activeOrdersTable.SelectedRows.Count == 0 || activeOrdersTable.SelectedRows[0].Cells[6].Value == "Скасовано")
            {
                btnCancelMyOrder.Enabled = false;
                return;
            }

            btnCancelMyOrder.Enabled = true;
        }

        private void btnCancelMyOrder_Click(object sender, EventArgs e)
        {
            this.loader.CancelOrder(activeOrdersTable);

            this.activeOrdersTable_SelectionChanged(sender, e);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(quantityNumericUpDown.Value);
            int totalPrice = Convert.ToInt32(totalPriceLabel.Text);

            this.loader.CreateOrder(productsTable, this.client, quantity, totalPrice);

            this.productsTable_SelectionChanged(sender, e);
        }
    }
}
