using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Course_Work
{
    public class Loader
    {
        protected NpgsqlConnection connection;

        public Loader()
        {
            this.connection = new NpgsqlConnection(
                "Host=localhost; Username=postgres; Password=1111; Database=shop"
            );

            this.connection.Open();
        }

        public NpgsqlConnection GetConnection()
        {
            return this.connection;
        }

        ~Loader()
        {
            this.connection.Close();
        }
    }

    public class AdminLoader: Loader
    {
        private void SetSelectedOrderStatus(DataGridView ordersTable, string status)
        {

            var selectedRow = ordersTable.SelectedRows[0];
            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string updated = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("yyyy-MM-dd");

            string query = $"UPDATE orders " +
                           $"SET \"Status\" = '{status}', \"Updated\" = '{updated}' " +
                           $"WHERE \"Order_id\" = {orderId};";
            
            NpgsqlCommand command = new NpgsqlCommand(query, this.connection);
            command.ExecuteNonQuery();

            selectedRow.Cells[7].Value = status;
            selectedRow.Cells[9].Value = updated;
        }

        private void ReturnProductsFromSelectedOrder(DataGridView ordersTable)
        {
            var selectedRow = ordersTable.SelectedRows[0];
            
            int productId = Convert.ToInt32(selectedRow.Cells[10].Value);
            int productQuantity = Convert.ToInt32(selectedRow.Cells[5].Value);

            NpgsqlCommand command = new NpgsqlCommand(
                $"UPDATE products SET \"Quantity\" = \"Quantity\" + {productQuantity} WHERE \"Product_id\" = {productId};",
                this.connection
            );
            command.ExecuteNonQuery();
        }

        public void ConfirmOrder(DataGridView ordersTable)
        {
            this.SetSelectedOrderStatus(ordersTable, "Доставлено");
        }

        public void CancelOrder(DataGridView ordersTable)
        {
            this.SetSelectedOrderStatus(ordersTable, "Скасовано");
            this.ReturnProductsFromSelectedOrder(ordersTable);
        }

        public void LoadProductsPage(DataGridView productsTable, Label totalQuantityLabel)
        {
            string query = $"SELECT * " +
                           $"FROM products " +
                           $"ORDER BY \"Product_id\" ASC;";

            NpgsqlDataAdapter productsAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable productsDataTable = new DataTable();
            productsAdapter.Fill(productsDataTable);
            productsTable.DataSource = productsDataTable;

            NpgsqlCommand command = new NpgsqlCommand("SELECT COALESCE(SUM(\"Quantity\"), 0) FROM products;", this.connection);
            totalQuantityLabel.Text = command.ExecuteScalar().ToString();
        }

        public void LoadOrdersPage(DataGridView ordersTable)
        {
            string query = $"SELECT orders.\"Order_id\", " +
                           $"  orders.\"Product_id\", " +
                           $"  orders.\"Client_id\", " +
                           $"  orders.\"Quantity\", " +
                           $"  orders.\"Total\", " +
                           $"  orders.\"Status\", " +
                           $"  orders.\"Created\", " +
                           $"  orders.\"Updated\", " +
                           $"  products.\"Name\" AS \"Product_name\", " +
                           $"  products.\"Category\" AS \"Product_category\", " +
                           $"  products.\"Manufacturer\" AS \"Product_manufacturer\", " +
                           $"  clients.\"Name\" AS \"Client_name\" " +
                           $"FROM orders " +
                           $"INNER JOIN products ON products.\"Product_id\" = orders.\"Product_id\" " +
                           $"INNER JOIN clients ON clients.\"Client_id\" = orders.\"Client_id\" " +
                           $"ORDER BY orders.\"Updated\" DESC, orders.\"Order_id\" DESC;";

            NpgsqlDataAdapter ordersAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable ordersDataTable = new DataTable();
            ordersAdapter.Fill(ordersDataTable);
            ordersTable.DataSource = new SortableBindingList<Order>(
                ordersDataTable.AsEnumerable().Select((dr) => new Order {
                    order_id = dr.Field<int>("Order_id"),
                    product_id = dr.Field<int>("Product_id"),
                    client_id = dr.Field<int>("Client_id"),
                    quantity = dr.Field<int>("Quantity"),
                    total = dr.Field<double>("Total"),
                    status = dr.Field<string>("Status"),
                    product_name = dr.Field<string>("Product_name"),
                    product_category = dr.Field<string>("Product_category"),
                    product_manufacturer = dr.Field<string>("Product_manufacturer"),
                    client_name = dr.Field<string>("Client_name"),
                    created = dr.Field<DateTime>("Created").ToString("yyyy-MM-dd"),
                    updated = dr.Field<DateTime>("Updated").ToString("yyyy-MM-dd"),
                }).ToList()
            );
        }

        public void LoadStatisticTotal(Label totalRevenueLabel, Label totalCustomersLabel, Label totalQuantityLabel)
        {
            // Обрахунок суми
            NpgsqlCommand totalRevenueCommand = new NpgsqlCommand(
                "SELECT COALESCE(SUM(\"Total\"), 0) FROM orders WHERE \"Status\" = 'Доставлено'",
                this.connection
            );
            totalRevenueLabel.Text = totalRevenueCommand.ExecuteScalar().ToString();

            // Підраховуємо суму користувачів та виводимо на label12
            NpgsqlCommand totalCustomersCommand= new NpgsqlCommand(
                "SELECT COUNT(DISTINCT \"Client_id\") FROM orders",
                this.connection
            );
            totalCustomersLabel.Text = totalCustomersCommand.ExecuteScalar().ToString();

            // Обрахунок загальної кількості
            NpgsqlCommand totalQuantityCommand = new NpgsqlCommand("SELECT COALESCE(SUM(\"Quantity\"), 0) FROM orders", this.connection);
            totalQuantityLabel.Text = totalQuantityCommand.ExecuteScalar().ToString();
        }

        public void LoadStatisticTable(DataGridView popularProductsTable, int typeIndex, int periodIndex)
        {
            string mode = "MAX";
            switch (typeIndex)
            {
                case 0:
                    mode = "MAX";
                    break;

                case 1:
                    mode = "MIN";
                    break;
            }

            string timeUnit = "day";
            switch (periodIndex)
            {
                case 0:
                    timeUnit = "day";
                    break;

                case 1:
                    timeUnit = "month";
                    break;

                case 2:
                    timeUnit = "year";
                    break;
            }

            string query = $"WITH _max_quantity AS ( " +
                           $"	SELECT DATE_TRUNC('{timeUnit}', \"Updated\") AS \"Date\", \"Product_id\", SUM(\"Quantity\")::int AS \"Total_quantity\", SUM(\"Total\")::int AS \"Total_revenue\", COUNT(*)::int AS \"Total_orders\" " +
                           $"	FROM orders " +
                           $"	WHERE \"Status\" = 'Доставлено' " +
                           $"	GROUP BY \"Date\", orders.\"Product_id\" " +
                           $"), max_quantity AS ( " +
                           $"	SELECT dm1.\"Date\", dm1.\"Product_id\", dm1.\"Total_quantity\", dm1.\"Total_revenue\", dm1.\"Total_orders\" " +
                           $"	FROM _max_quantity AS dm1 " +
                           $"	INNER JOIN ( " +
                           $"		SELECT \"Date\", {mode}(\"Total_quantity\") AS \"Mode_total_quantity\" " +
                           $"		FROM _max_quantity " +
                           $"		GROUP BY \"Date\" " +
                           $"	) AS dm2 ON dm1.\"Date\" = dm2.\"Date\" " +
                           $"	WHERE dm1.\"Total_quantity\" = dm2.\"Mode_total_quantity\" " +
                           $") " +
                           $"SELECT \"Date\", products.\"Product_id\", \"Total_quantity\", \"Total_revenue\", \"Total_orders\", \"Name\", \"Category\", \"Manufacturer\" " +
                           $"FROM max_quantity " +
                           $"INNER JOIN products ON products.\"Product_id\" = max_quantity.\"Product_id\" " +
                           $"ORDER BY \"Date\" DESC, products.\"Product_id\" DESC;";

            NpgsqlDataAdapter ordersAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable ordersDataTable = new DataTable();
            ordersAdapter.Fill(ordersDataTable);

            popularProductsTable.DataSource = new SortableBindingList<Statistic>(
                ordersDataTable.AsEnumerable().Select((dr) => new Statistic
                {
                    date = dr.Field<DateTime>("Date").ToString("yyyy-MM-dd"),
                    product_id = dr.Field<int>("Product_id"),
                    total_quantity = dr.Field<int>("Total_quantity"),
                    total_revenue = dr.Field<int>("Total_revenue"),
                    total_orders = dr.Field<int>("Total_orders"),
                    product_name = dr.Field<string>("Name"),
                    product_category = dr.Field<string>("Category"),
                    product_manufacturer = dr.Field<string>("Manufacturer")
                }).ToList()
            );
        }

        public void LoadStatisticChart(Chart statisticChart, ComboBox cmbBoxProducts, int periodIndex, string status)
        {
            statisticChart.Series[0].Points.Clear();

            Product product = (Product)cmbBoxProducts.SelectedItem;

            string timeUnit = "day", timeRange = "current_date - INTERVAL '30 day', current_date, '1 day'";
            switch (periodIndex)
            {
                case 0:
                    timeUnit = "day";
                    timeRange = "current_date - INTERVAL '30 day', current_date, '1 day'";
                    break;

                case 1:
                    timeUnit = "month";
                    timeRange = "DATE_TRUNC('month', current_date - INTERVAL '12 month'), current_date, '1 month'";
                    break;

                case 2:
                    timeUnit = "year";
                    timeRange = "DATE_TRUNC('year', current_date - INTERVAL '2 year'), current_date, '1 year'";
                    break;
            }

            string query = $"SELECT \"Date\", \"Status\", COALESCE(SUM(\"Quantity\"), 0)::int AS \"Total_quantity\" " +
                           $"FROM (SELECT generate_series({timeRange}) AS \"Date\") " +
                           $"LEFT JOIN orders ON " +
                           $"	\"Date\" = DATE_TRUNC('{timeUnit}', orders.\"Updated\") AND " +
                           $"	orders.\"Product_id\" = {product.product_id} AND " +
                           $"	orders.\"Status\" = '{status}' " +
                           $"GROUP BY \"Date\", \"Status\"  " +
                           $"ORDER BY \"Date\" ASC;";

            NpgsqlDataAdapter ordersAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable ordersDataTable = new DataTable();
            ordersAdapter.Fill(ordersDataTable);

            ordersDataTable.AsEnumerable().ToList().ForEach(dr =>
            {
                statisticChart.Series[0].Points.AddXY(
                    dr.Field<DateTime>("Date"),
                    dr.Field<int>("Total_quantity")
                );
            });
        }

        public void LoadProductsInComboBox(ComboBox cmbBoxProducts)
        {
            cmbBoxProducts.Items.Clear();

            string query = $"SELECT \"Product_id\", \"Name\" " +
                           $"FROM products " +
                           $"ORDER BY \"Product_id\" ASC;";

            NpgsqlDataAdapter productsAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable productsDataTable = new DataTable();
            productsAdapter.Fill(productsDataTable);
            productsDataTable.AsEnumerable().ToList().ForEach(
                dr => cmbBoxProducts.Items.Add(
                    new Product { product_id = dr.Field<int>("Product_id"), name = dr.Field<string>("Name") }
                )
            );
        }

        public void GenerateOrders()
        {
            // Очистити таблицю "orders"
            NpgsqlCommand clearCmd = new NpgsqlCommand("TRUNCATE TABLE orders;", this.connection);
            clearCmd.ExecuteNonQuery();


            // Запит, щоб отримати імена клієнтів з таблиці clients
            List<Client> clients = new List<Client>();
            NpgsqlCommand clientCmd = new NpgsqlCommand("SELECT * FROM clients;", this.connection);
            using (NpgsqlDataReader reader = clientCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    clients.Add(new Client(reader.GetInt32(0), reader.GetString(1)));
                }
            }


            // Запит, щоб отримати імена клієнтів з таблиці clients
            List<Product> products = new List<Product>();
            NpgsqlCommand productCmd = new NpgsqlCommand("SELECT * FROM products;", this.connection);
            using (NpgsqlDataReader reader = productCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        product_id = reader.GetInt32(0),
                        category = reader.GetString(1),
                        name = reader.GetString(2),
                        quantity = reader.GetInt32(3),
                        price = reader.GetInt32(4),
                        manufacturer = reader.GetString(5)
                    };

                    products.Add(product);
                }
            }


            Random rand = new Random();

            int totalOrders = 3000; // Змініть це число на бажану кількість товарів

            for (int i = 0; i < totalOrders; i++)
            {
                Product product = products[rand.Next(products.Count)]; // Отримуємо випадковий продукт зі списку
                Client client = clients[rand.Next(clients.Count)]; // Отримуємо випадкового користувача зі списку
                int quantity = rand.Next(1, 6); // Отримуємо випадкову кількість товару
                int total = product.price * quantity; // Отримуємо загальну вартість замовлення

                string status;
                int statusRandomizer = rand.Next(10);
                if (statusRandomizer == 0)
                {
                    status = "Скасовано";
                } else if (statusRandomizer == 1)
                {
                    status = "Обробляється";
                } else
                {
                    status = "Доставлено";
                }

                DateTime startOfTheYear = new DateTime(2022, 1, 1);
                DateTime createdDate = startOfTheYear.AddDays(rand.Next(860));
                DateTime updatedDate = status == "Обробляється" ? createdDate : createdDate.AddDays(rand.Next(10));

                if (DateTime.Now < createdDate)
                {
                    continue;
                }

                if (DateTime.Now < updatedDate)
                {
                    int daysRange = Convert.ToInt32((DateTime.Now - createdDate).TotalDays);
                    updatedDate = createdDate.AddDays(rand.Next(daysRange));
                }

                string query = $"INSERT INTO orders (\"Product_id\", \"Client_id\", \"Quantity\", \"Total\", \"Status\", \"Created\", \"Updated\") " +
                    $"VALUES ({product.product_id}, {client.client_id}, {quantity}, {total}, '{status}', '{createdDate.ToString("yyyy-MM-dd")}', '{updatedDate.ToString("yyyy-MM-dd")}');";

                NpgsqlCommand command = new NpgsqlCommand(query, this.connection);
                command.ExecuteNonQuery();
            }
        }
    }
    ///////////////////////////USERLOADER : LOADER///////////////////////////////////////
    public class UserLoader: Loader
    {
        // tab 1
        public void LoadProducts(DataGridView productsTable)
        {
            string query = $"SELECT * " +
                           $"FROM products " +
                           $"ORDER BY \"Product_id\" ASC;";

            NpgsqlDataAdapter productsAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable productsDataTable = new DataTable();
            productsAdapter.Fill(productsDataTable);
            productsTable.DataSource = new SortableBindingList<Product>(
                productsDataTable.AsEnumerable().Select((dr) => new Product
                {
                    product_id = dr.Field<int>("Product_id"),
                    quantity = dr.Field<int>("Quantity"),
                    price = dr.Field<int>("Price"),
                    name = dr.Field<string>("Name"),
                    category = dr.Field<string>("Category"),
                    manufacturer = dr.Field<string>("Manufacturer"),
                }).ToList()
            );
        }

        public void CreateOrder(DataGridView productsTable, Client client, int quantity, int totalPrice)
        {
            var selectedRow = productsTable.SelectedRows[0];

            int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
            int clientId = client.client_id;
            string now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("yyyy-MM-dd");

            string query = $"INSERT INTO orders (\"Product_id\", \"Client_id\", \"Quantity\", \"Total\", \"Status\", \"Created\", \"Updated\") " +
                           $"VALUES ({productId}, {clientId}, {quantity}, {totalPrice}, 'Обробляється', '{now}', '{now}');";

            NpgsqlCommand createOrderCommand = new NpgsqlCommand(query, this.connection);
            createOrderCommand.ExecuteNonQuery();

            ///////////////////////////////////////////////////////////////////////////

            int productQuantity = Convert.ToInt32(selectedRow.Cells[4].Value);
            int newQuantity = productQuantity - quantity;

            NpgsqlCommand updateProductQuantityCommand = new NpgsqlCommand(
                $"UPDATE products SET \"Quantity\" = {newQuantity} WHERE \"Product_id\" = {productId};",
                this.connection
            );
            updateProductQuantityCommand.ExecuteNonQuery();

            selectedRow.Cells[4].Value = newQuantity;
        }

        // tab 2
        public void LoadActiveOrders(DataGridView ordersTable, Client client)
        {
            string query = $"SELECT orders.\"Order_id\", " +
                           $"  orders.\"Quantity\", " +
                           $"  orders.\"Total\", " +
                           $"  orders.\"Status\", " +
                           $"  orders.\"Created\", " +
                           $"  orders.\"Updated\", " +
                           $"  orders.\"Product_id\", " +
                           $"  products.\"Name\" AS \"Product_name\", " +
                           $"  products.\"Category\" AS \"Product_category\", " +
                           $"  products.\"Manufacturer\" AS \"Product_manufacturer\" " +
                           $"FROM orders " +
                           $"INNER JOIN products ON products.\"Product_id\" = orders.\"Product_id\" " +
                           $"WHERE orders.\"Client_id\" = {client.client_id} " +
                           $"AND orders.\"Status\" = 'Обробляється' " +
                           $"ORDER BY orders.\"Updated\" DESC, orders.\"Order_id\" DESC;";

            NpgsqlDataAdapter ordersAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable ordersDataTable = new DataTable();
            ordersAdapter.Fill(ordersDataTable);
            ordersTable.DataSource = new SortableBindingList<Order>(
                ordersDataTable.AsEnumerable().Select((dr) => new Order
                {
                    order_id = dr.Field<int>("Order_id"),
                    product_id = dr.Field<int>("Product_id"),
                    quantity = dr.Field<int>("Quantity"),
                    total = dr.Field<double>("Total"),
                    status = dr.Field<string>("Status"),
                    product_name = dr.Field<string>("Product_name"),
                    product_category = dr.Field<string>("Product_category"),
                    product_manufacturer = dr.Field<string>("Product_manufacturer"),
                    created = dr.Field<DateTime>("Created").ToString("yyyy-MM-dd"),
                    updated = dr.Field<DateTime>("Updated").ToString("yyyy-MM-dd"),
                }).ToList()
            );
        }

        public void CancelOrder(DataGridView ordersTable)
        {
            var selectedRow = ordersTable.SelectedRows[0];

            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("yyyy-MM-dd");

            string query = $"UPDATE orders " +
               $"SET \"Status\" = 'Скасовано', \"Updated\" = '{now}' " +
               $"WHERE \"Order_id\" = {orderId};";

            NpgsqlCommand cancelOrderCommand = new NpgsqlCommand(query, this.connection);
            cancelOrderCommand.ExecuteNonQuery();

            ///////////////////////////////////////////////////////////////////////////

            int productId = Convert.ToInt32(selectedRow.Cells[9].Value);
            int quantity = Convert.ToInt32(selectedRow.Cells[4].Value);

            NpgsqlCommand updateProductQuantityCommand = new NpgsqlCommand(
                $"UPDATE products SET \"Quantity\" = \"Quantity\" + {quantity} WHERE \"Product_id\" = {productId};",
                this.connection
            );
            updateProductQuantityCommand.ExecuteNonQuery();

            selectedRow.Cells[6].Value = "Скасовано";
            selectedRow.Cells[8].Value = now;
        }

        // tab 3
        public void LoadCompletedOrders(DataGridView ordersTable, Client client)
        {
            string query = $"SELECT orders.\"Order_id\", " +                       
                           $"  orders.\"Quantity\", " +
                           $"  orders.\"Total\", " +
                           $"  orders.\"Status\", " +
                           $"  orders.\"Created\", " +
                           $"  orders.\"Updated\", " +
                           $"  products.\"Name\" AS \"Product_name\", " +
                           $"  products.\"Category\" AS \"Product_category\", " +
                           $"  products.\"Manufacturer\" AS \"Product_manufacturer\" " +
                           $"FROM orders " +
                           $"INNER JOIN products ON products.\"Product_id\" = orders.\"Product_id\" " +
                           $"WHERE orders.\"Client_id\" = {client.client_id} " +
                           $"AND orders.\"Status\" IN ('Доставлено', 'Скасовано') " +
                           $"ORDER BY orders.\"Updated\" DESC, orders.\"Order_id\" DESC;";

            NpgsqlDataAdapter ordersAdapter = new NpgsqlDataAdapter(query, this.connection);
            DataTable ordersDataTable = new DataTable();
            ordersAdapter.Fill(ordersDataTable);
            ordersTable.DataSource = new SortableBindingList<Order>(
                ordersDataTable.AsEnumerable().Select((dr) => new Order
                {
                    order_id = dr.Field<int>("Order_id"),
                    quantity = dr.Field<int>("Quantity"),
                    total = dr.Field<double>("Total"),
                    status = dr.Field<string>("Status"),
                    product_name = dr.Field<string>("Product_name"),
                    product_category = dr.Field<string>("Product_category"),
                    product_manufacturer = dr.Field<string>("Product_manufacturer"),
                    created = dr.Field<DateTime>("Created").ToString("yyyy-MM-dd"),
                    updated = dr.Field<DateTime>("Updated").ToString("yyyy-MM-dd"),
                }).ToList()
            );
        }
    }
}
