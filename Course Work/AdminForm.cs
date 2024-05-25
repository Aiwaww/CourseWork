using Npgsql;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Course_Work
{
    partial class AdminForm : Form
    {
        private NpgsqlConnection connection;
        private AdminLoader loader;

        public AdminForm()
        {
            InitializeComponent();

            this.loader = new AdminLoader();

            this.connection = this.loader.GetConnection();
        }

        /////////////// GENERAL EVENTS ///////////////
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.loader.LoadProductsPage(productsTable, totalQuantityLabel);
        }

        private void productsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                MessageBox.Show("Некоректний ввід!. Будь ласка введіть дійсне знаачення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    this.loader.LoadProductsPage(productsTable, totalQuantityLabel);
                    break;

                case 1:
                    cmbBoxType.SelectedIndex = 0;
                    cmbBoxPeriod.SelectedIndex = 0;
                    this.loader.LoadStatisticTotal(totalRevenueLabel, totalCustomersLabel, totalQuantityLabel2);
                    this.loader.LoadStatisticTable(popularProductsTable, 0, 0);
                    this.loader.LoadProductsInComboBox(cmbBoxProducts);
                    cmbBoxProducts.SelectedIndex = 0;
                    break;

                case 2:
                    this.loader.LoadOrdersPage(ordersTable);
                    break;
            }
        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int type = cmbBoxType.SelectedIndex;
            int period = cmbBoxPeriod.SelectedIndex;
            cmbBoxPeriod.Items.Clear();
            if (type <= 1)
            {   
                cmbBoxPeriod.Items.AddRange(new object[] { "День", "Місяць", "Рік" });
            }
            else
            {
                cmbBoxPeriod.Items.AddRange(new object[] { "30 днів", "12 місяців", "3 роки" });
            }
            cmbBoxPeriod.SelectedIndex = period;

            btnRefreshStatistic_Click(sender, e);
        }

        private void cmbBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRefreshStatistic_Click(sender, e);
        }

        private void cmbBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRefreshStatistic_Click(sender, e);
        }

        private void ordersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersTable.SelectedRows.Count == 0)
            {
                btnConfirmOrder.Enabled = false;
                btnCancelOrder.Enabled = false;
                return;
            };

            switch (ordersTable.SelectedRows[0].Cells[7].Value)
            {
                case "Обробляється":
                    btnConfirmOrder.Enabled = true;
                    btnCancelOrder.Enabled = true;
                    break;

                case "Доставлено":
                case "Скасовано":
                    btnConfirmOrder.Enabled = false;
                    btnCancelOrder.Enabled = false;
                    break;
            }
        }

        /////////////// PRODUCTS ///////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)productsTable.DataSource;

                // Перевірка, чи всі поля заповнені
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item == null || string.IsNullOrWhiteSpace(item.ToString()))
                        {
                            MessageBox.Show("Всі комірки рядку повинні бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM products", this.connection);
                NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(da);

                da.Update(dt);

                MessageBox.Show("Зміни успішно збережені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректний ввід!. Будь ласка введіть дійсне знаачення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.loader.LoadProductsPage(productsTable, totalQuantityLabel);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;

            string query = "SELECT * FROM products " +
                $"WHERE \"Product_id\"::text ILIKE '%{search}%' " +
                $"OR \"Category\" ILIKE '%{search}%' " +
                $"OR \"Name\" ILIKE '%{search}%' " +
                $"OR \"Manufacturer\" ILIKE '%{search}%';";

            NpgsqlDataAdapter productsAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable productsDataTable = new DataTable();
            productsAdapter.Fill(productsDataTable);

            if (productsDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не знайдено жодного рядку!", "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.productsTable.DataSource = productsDataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка оберіть рядок для видалення.");
                return;
            }

            int ProductId = Convert.ToInt32(productsTable.SelectedRows[0].Cells[0].Value);

            string query = $"DELETE FROM products WHERE \"Product_id\" = {ProductId}";

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                MessageBox.Show("Жодного рядку не видалено!");
                return;
            }

            this.loader.LoadProductsPage(productsTable, totalQuantityLabel);

            MessageBox.Show("Рядок видалено успішно!");
        }

        /////////////// STATISTICS ///////////////

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.loader.GenerateOrders();
            btnRefreshStatistic_Click(sender, e);
        }

        private void btnRefreshStatistic_Click(object sender, EventArgs e)
        {
            int type = cmbBoxType.SelectedIndex;
            int period = cmbBoxPeriod.SelectedIndex;
            this.loader.LoadStatisticTotal(totalRevenueLabel, totalCustomersLabel, totalQuantityLabel2);

            if (type <= 1)
            {
                label5.Visible = false;
                cmbBoxProducts.Visible = false;

                popularProductsTable.Visible = true;
                statisticChart.Visible = false;

                this.loader.LoadStatisticTable(popularProductsTable, type, period);
            }
            else
            {
                label5.Visible = true;
                cmbBoxProducts.Visible = true;

                popularProductsTable.Visible = false;
                statisticChart.Visible = true;

                this.loader.LoadStatisticChart(statisticChart, cmbBoxProducts, period, "Доставлено");
            }
        }

        /////////////// ORDERS ///////////////

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            this.loader.ConfirmOrder(ordersTable);
            ordersTable_SelectionChanged(sender, e);
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.loader.CancelOrder(ordersTable);
            ordersTable_SelectionChanged(sender, e);
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            this.loader.LoadOrdersPage(ordersTable);
        }
    }
}
