namespace Course_Work
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            productsTable = new DataGridView();
            productidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            totalPriceLabel = new Label();
            btnRefreshCreateOrder = new Button();
            label1 = new Label();
            btnCreateOrder = new Button();
            quantityNumericUpDown = new NumericUpDown();
            label2 = new Label();
            tabPage2 = new TabPage();
            brnRefreshActiveOrders = new Button();
            btnCancelMyOrder = new Button();
            activeOrdersTable = new DataGridView();
            orderidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productcategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productmanufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            btnRefreshCompletedOrders = new Button();
            completedOrdersTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            busket = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeOrdersTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)completedOrdersTable).BeginInit();
            SuspendLayout();
            // 
            // productsTable
            // 
            productsTable.AllowUserToAddRows = false;
            productsTable.AllowUserToDeleteRows = false;
            productsTable.AllowUserToResizeColumns = false;
            productsTable.AllowUserToResizeRows = false;
            productsTable.AutoGenerateColumns = false;
            productsTable.BackgroundColor = Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Columns.AddRange(new DataGridViewColumn[] { productidDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, manufacturerDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            productsTable.DataSource = productBindingSource;
            productsTable.EnableHeadersVisualStyles = false;
            productsTable.GridColor = Color.Fuchsia;
            productsTable.Location = new Point(55, 71);
            productsTable.MultiSelect = false;
            productsTable.Name = "productsTable";
            productsTable.ReadOnly = true;
            productsTable.RowHeadersVisible = false;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(904, 367);
            productsTable.TabIndex = 0;
            productsTable.SelectionChanged += productsTable_SelectionChanged;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            productidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            productidDataGridViewTextBoxColumn.HeaderText = "ID";
            productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            productidDataGridViewTextBoxColumn.ReadOnly = true;
            productidDataGridViewTextBoxColumn.Width = 48;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 89;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1025, 568);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LavenderBlush;
            tabPage1.Controls.Add(totalPriceLabel);
            tabPage1.Controls.Add(btnRefreshCreateOrder);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnCreateOrder);
            tabPage1.Controls.Add(quantityNumericUpDown);
            tabPage1.Controls.Add(productsTable);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1017, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Створити замовлення";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.BackColor = Color.Transparent;
            totalPriceLabel.Font = new Font("Segoe UI", 12F);
            totalPriceLabel.Location = new Point(582, 453);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(19, 21);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "0";
            // 
            // btnRefreshCreateOrder
            // 
            btnRefreshCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshCreateOrder.Location = new Point(924, 444);
            btnRefreshCreateOrder.Name = "btnRefreshCreateOrder";
            btnRefreshCreateOrder.Size = new Size(37, 34);
            btnRefreshCreateOrder.TabIndex = 9;
            btnRefreshCreateOrder.Text = "↻";
            btnRefreshCreateOrder.UseVisualStyleBackColor = true;
            btnRefreshCreateOrder.Click += btnRefreshCreateOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(349, 451);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 6;
            label1.Text = "Кількість";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateOrder.Location = new Point(711, 444);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(207, 34);
            btnCreateOrder.TabIndex = 5;
            btnCreateOrder.Text = "Створити замовлення";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Font = new Font("Segoe UI", 12F);
            quantityNumericUpDown.Location = new Point(423, 449);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(84, 29);
            quantityNumericUpDown.TabIndex = 2;
            quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.ValueChanged += quantityNumericUpDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(513, 453);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 7;
            label2.Text = "Сума: ₴";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LavenderBlush;
            tabPage2.Controls.Add(brnRefreshActiveOrders);
            tabPage2.Controls.Add(btnCancelMyOrder);
            tabPage2.Controls.Add(activeOrdersTable);
            tabPage2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1017, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Активні замовлення";
            // 
            // brnRefreshActiveOrders
            // 
            brnRefreshActiveOrders.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brnRefreshActiveOrders.Location = new Point(923, 444);
            brnRefreshActiveOrders.Name = "brnRefreshActiveOrders";
            brnRefreshActiveOrders.Size = new Size(37, 34);
            brnRefreshActiveOrders.TabIndex = 2;
            brnRefreshActiveOrders.Text = "↻";
            brnRefreshActiveOrders.UseVisualStyleBackColor = true;
            brnRefreshActiveOrders.Click += brnRefreshActiveOrders_Click;
            // 
            // btnCancelMyOrder
            // 
            btnCancelMyOrder.Enabled = false;
            btnCancelMyOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelMyOrder.Location = new Point(711, 444);
            btnCancelMyOrder.Name = "btnCancelMyOrder";
            btnCancelMyOrder.Size = new Size(206, 34);
            btnCancelMyOrder.TabIndex = 1;
            btnCancelMyOrder.Text = "Скасувати замовлення";
            btnCancelMyOrder.UseVisualStyleBackColor = true;
            btnCancelMyOrder.Click += btnCancelMyOrder_Click;
            // 
            // activeOrdersTable
            // 
            activeOrdersTable.AllowUserToAddRows = false;
            activeOrdersTable.AllowUserToDeleteRows = false;
            activeOrdersTable.AllowUserToResizeColumns = false;
            activeOrdersTable.AllowUserToResizeRows = false;
            activeOrdersTable.AutoGenerateColumns = false;
            activeOrdersTable.BackgroundColor = Color.LavenderBlush;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            activeOrdersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            activeOrdersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeOrdersTable.Columns.AddRange(new DataGridViewColumn[] { orderidDataGridViewTextBoxColumn, productnameDataGridViewTextBoxColumn, productcategoryDataGridViewTextBoxColumn, productmanufacturerDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, createdDataGridViewTextBoxColumn, updatedDataGridViewTextBoxColumn, product_id });
            activeOrdersTable.DataSource = orderBindingSource;
            activeOrdersTable.EnableHeadersVisualStyles = false;
            activeOrdersTable.GridColor = Color.Fuchsia;
            activeOrdersTable.Location = new Point(55, 71);
            activeOrdersTable.MultiSelect = false;
            activeOrdersTable.Name = "activeOrdersTable";
            activeOrdersTable.ReadOnly = true;
            activeOrdersTable.RowHeadersVisible = false;
            activeOrdersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            activeOrdersTable.Size = new Size(904, 367);
            activeOrdersTable.TabIndex = 0;
            activeOrdersTable.SelectionChanged += activeOrdersTable_SelectionChanged;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            orderidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            orderidDataGridViewTextBoxColumn.HeaderText = "ID";
            orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            orderidDataGridViewTextBoxColumn.ReadOnly = true;
            orderidDataGridViewTextBoxColumn.Width = 48;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            productnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            productnameDataGridViewTextBoxColumn.HeaderText = "Name";
            productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcategoryDataGridViewTextBoxColumn
            // 
            productcategoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productcategoryDataGridViewTextBoxColumn.DataPropertyName = "product_category";
            productcategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            productcategoryDataGridViewTextBoxColumn.Name = "productcategoryDataGridViewTextBoxColumn";
            productcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productmanufacturerDataGridViewTextBoxColumn
            // 
            productmanufacturerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productmanufacturerDataGridViewTextBoxColumn.DataPropertyName = "product_manufacturer";
            productmanufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            productmanufacturerDataGridViewTextBoxColumn.Name = "productmanufacturerDataGridViewTextBoxColumn";
            productmanufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            quantityDataGridViewTextBoxColumn1.Width = 89;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total $";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 77;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            createdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            createdDataGridViewTextBoxColumn.DataPropertyName = "created";
            createdDataGridViewTextBoxColumn.HeaderText = "Created";
            createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            createdDataGridViewTextBoxColumn.ReadOnly = true;
            createdDataGridViewTextBoxColumn.Width = 90;
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            updatedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            updatedDataGridViewTextBoxColumn.DataPropertyName = "updated";
            updatedDataGridViewTextBoxColumn.HeaderText = "Updated";
            updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            updatedDataGridViewTextBoxColumn.ReadOnly = true;
            updatedDataGridViewTextBoxColumn.Width = 93;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Visible = false;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LavenderBlush;
            tabPage3.Controls.Add(btnRefreshCompletedOrders);
            tabPage3.Controls.Add(completedOrdersTable);
            tabPage3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1017, 540);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Завершені замовлення";
            // 
            // btnRefreshCompletedOrders
            // 
            btnRefreshCompletedOrders.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshCompletedOrders.Location = new Point(922, 444);
            btnRefreshCompletedOrders.Name = "btnRefreshCompletedOrders";
            btnRefreshCompletedOrders.Size = new Size(37, 34);
            btnRefreshCompletedOrders.TabIndex = 4;
            btnRefreshCompletedOrders.Text = "↻";
            btnRefreshCompletedOrders.UseVisualStyleBackColor = true;
            btnRefreshCompletedOrders.Click += btnRefreshCompletedOrders_Click;
            // 
            // completedOrdersTable
            // 
            completedOrdersTable.AllowUserToAddRows = false;
            completedOrdersTable.AllowUserToDeleteRows = false;
            completedOrdersTable.AllowUserToResizeColumns = false;
            completedOrdersTable.AllowUserToResizeRows = false;
            completedOrdersTable.AutoGenerateColumns = false;
            completedOrdersTable.BackgroundColor = Color.LavenderBlush;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            completedOrdersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            completedOrdersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedOrdersTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            completedOrdersTable.DataSource = orderBindingSource;
            completedOrdersTable.EnableHeadersVisualStyles = false;
            completedOrdersTable.GridColor = Color.Fuchsia;
            completedOrdersTable.Location = new Point(55, 71);
            completedOrdersTable.MultiSelect = false;
            completedOrdersTable.Name = "completedOrdersTable";
            completedOrdersTable.ReadOnly = true;
            completedOrdersTable.RowHeadersVisible = false;
            completedOrdersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            completedOrdersTable.Size = new Size(904, 367);
            completedOrdersTable.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "product_name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "product_category";
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "product_manufacturer";
            dataGridViewTextBoxColumn4.HeaderText = "Manufacturer";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 89;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "total";
            dataGridViewTextBoxColumn6.HeaderText = "Total $";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 78;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "status";
            dataGridViewTextBoxColumn7.HeaderText = "Status";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 77;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn8.DataPropertyName = "created";
            dataGridViewTextBoxColumn8.HeaderText = "Created";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn9.DataPropertyName = "updated";
            dataGridViewTextBoxColumn9.HeaderText = "Updated";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 93;
            // 
            // busket
            // 
            busket.Name = "busket";
            busket.Size = new Size(32, 19);
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 70);
            panel1.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 634);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)activeOrdersTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)completedOrdersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsTable;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem busket;
        private TabPage tabPage3;
        private Button btnCreateOrder;
        private Button Updatebtn;
        private Label totalPriceLabel;
        private Button Adding;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private NumericUpDown quantityNumericUpDown;
        private Button brnRefreshActiveOrders;
        private Button btnCancelMyOrder;
        private DataGridView activeOrdersTable;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private Button btnRefreshCompletedOrders;
        private DataGridView completedOrdersTable;
        private Button btnRefreshCreateOrder;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productcategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productmanufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn product_id;
    }
}