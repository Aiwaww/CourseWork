using Guna.UI2.WinForms;
using Npgsql;
using System.Data;
using System.Windows.Forms;
namespace Course_Work


{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            productsTable = new DataGridView();
            product_idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            btnSave = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            tabControl1 = new TabControl();
            productsPage = new TabPage();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            totalQuantityLabel = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            statisticPage = new TabPage();
            label5 = new Label();
            cmbBoxProducts = new ComboBox();
            statisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            cmbBoxPeriod = new ComboBox();
            label3 = new Label();
            btnGenerate = new Button();
            panel12 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel13 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            totalQuantityLabel2 = new Label();
            panel6 = new Panel();
            panel11 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            totalRevenueLabel = new Label();
            panel5 = new Panel();
            panel8 = new Panel();
            totalCustomersLabel = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            cmbBoxType = new ComboBox();
            btnRefreshStatistic = new Button();
            popularProductsTable = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productidDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productcategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productmanufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalquantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalrevenueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statisticBindingSource = new BindingSource(components);
            ordersPage = new TabPage();
            btnRefreshOrders = new Button();
            btnCancelOrder = new Button();
            btnConfirmOrder = new Button();
            ordersTable = new DataGridView();
            orderidDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productcategoryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productmanufacturerDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            clientnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            productsPage.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            statisticPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statisticChart).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popularProductsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statisticBindingSource).BeginInit();
            ordersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // productsTable
            // 
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
            productsTable.Columns.AddRange(new DataGridViewColumn[] { product_idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, manufacturerDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            productsTable.DataSource = productBindingSource;
            productsTable.EnableHeadersVisualStyles = false;
            productsTable.GridColor = Color.Fuchsia;
            productsTable.Location = new Point(327, 64);
            productsTable.MultiSelect = false;
            productsTable.Name = "productsTable";
            productsTable.RowHeadersVisible = false;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(774, 526);
            productsTable.TabIndex = 0;
            productsTable.DataError += productsTable_DataError;
            // 
            // product_idDataGridViewTextBoxColumn
            // 
            product_idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_idDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            product_idDataGridViewTextBoxColumn.HeaderText = "ID";
            product_idDataGridViewTextBoxColumn.Name = "product_idDataGridViewTextBoxColumn";
            product_idDataGridViewTextBoxColumn.Width = 48;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 89;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(42, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Зберегти зміни";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(42, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(213, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(57, 30);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(20, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(187, 26);
            textBoxSearch.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(productsPage);
            tabControl1.Controls.Add(statisticPage);
            tabControl1.Controls.Add(ordersPage);
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(-3, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1162, 702);
            tabControl1.TabIndex = 8;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // productsPage
            // 
            productsPage.BackColor = Color.LavenderBlush;
            productsPage.Controls.Add(panel4);
            productsPage.Controls.Add(panel3);
            productsPage.Controls.Add(panel2);
            productsPage.Controls.Add(productsTable);
            productsPage.Controls.Add(textBoxSearch);
            productsPage.Controls.Add(btnSearch);
            productsPage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsPage.Location = new Point(4, 27);
            productsPage.Name = "productsPage";
            productsPage.Padding = new Padding(3);
            productsPage.Size = new Size(1154, 671);
            productsPage.TabIndex = 1;
            productsPage.Text = "Інвентар";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(36, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 38);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(14, 11);
            label2.Name = "label2";
            label2.Size = new Size(197, 18);
            label2.TabIndex = 11;
            label2.Text = "Загальна кількість товару";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(totalQuantityLabel);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(36, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 123);
            panel3.TabIndex = 9;
            // 
            // totalQuantityLabel
            // 
            totalQuantityLabel.AutoSize = true;
            totalQuantityLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalQuantityLabel.ForeColor = Color.Fuchsia;
            totalQuantityLabel.Location = new Point(106, 60);
            totalQuantityLabel.Name = "totalQuantityLabel";
            totalQuantityLabel.Size = new Size(26, 29);
            totalQuantityLabel.TabIndex = 11;
            totalQuantityLabel.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.HotPink;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(20, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 526);
            panel2.TabIndex = 8;
            // 
            // statisticPage
            // 
            statisticPage.BackColor = Color.LavenderBlush;
            statisticPage.Controls.Add(label5);
            statisticPage.Controls.Add(cmbBoxProducts);
            statisticPage.Controls.Add(statisticChart);
            statisticPage.Controls.Add(label4);
            statisticPage.Controls.Add(cmbBoxPeriod);
            statisticPage.Controls.Add(label3);
            statisticPage.Controls.Add(btnGenerate);
            statisticPage.Controls.Add(panel12);
            statisticPage.Controls.Add(panel10);
            statisticPage.Controls.Add(panel9);
            statisticPage.Controls.Add(panel7);
            statisticPage.Controls.Add(panel6);
            statisticPage.Controls.Add(panel5);
            statisticPage.Controls.Add(cmbBoxType);
            statisticPage.Controls.Add(btnRefreshStatistic);
            statisticPage.Controls.Add(popularProductsTable);
            statisticPage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticPage.Location = new Point(4, 27);
            statisticPage.Name = "statisticPage";
            statisticPage.Padding = new Padding(3);
            statisticPage.Size = new Size(1154, 671);
            statisticPage.TabIndex = 2;
            statisticPage.Text = "Статистика";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(560, 134);
            label5.Name = "label5";
            label5.Size = new Size(67, 18);
            label5.TabIndex = 47;
            label5.Text = "Продукт";
            label5.Visible = false;
            // 
            // cmbBoxProducts
            // 
            cmbBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxProducts.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxProducts.FormattingEnabled = true;
            cmbBoxProducts.Items.AddRange(new object[] { "День", "Місяць", "Рік" });
            cmbBoxProducts.Location = new Point(630, 132);
            cmbBoxProducts.Name = "cmbBoxProducts";
            cmbBoxProducts.Size = new Size(203, 26);
            cmbBoxProducts.TabIndex = 46;
            cmbBoxProducts.Visible = false;
            cmbBoxProducts.SelectedIndexChanged += cmbBoxProducts_SelectedIndexChanged;
            // 
            // statisticChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            statisticChart.ChartAreas.Add(chartArea1);
            statisticChart.Location = new Point(11, 198);
            statisticChart.Name = "statisticChart";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            statisticChart.Series.Add(series1);
            statisticChart.Size = new Size(1134, 463);
            statisticChart.TabIndex = 45;
            statisticChart.Text = "chart1";
            statisticChart.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 135);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 44;
            label4.Text = "Період";
            // 
            // cmbBoxPeriod
            // 
            cmbBoxPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxPeriod.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxPeriod.FormattingEnabled = true;
            cmbBoxPeriod.Items.AddRange(new object[] { "Day", "Month", "Year" });
            cmbBoxPeriod.Location = new Point(368, 130);
            cmbBoxPeriod.Name = "cmbBoxPeriod";
            cmbBoxPeriod.Size = new Size(186, 28);
            cmbBoxPeriod.TabIndex = 43;
            cmbBoxPeriod.SelectedIndexChanged += cmbBoxPeriod_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 134);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 42;
            label3.Text = "Тип";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(1088, 132);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(30, 30);
            btnGenerate.TabIndex = 41;
            btnGenerate.Text = "G";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.HotPink;
            panel12.Location = new Point(484, 93);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 10);
            panel12.TabIndex = 40;
            // 
            // panel10
            // 
            panel10.BackColor = Color.HotPink;
            panel10.Location = new Point(22, 17);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 10);
            panel10.TabIndex = 39;
            // 
            // panel9
            // 
            panel9.BackColor = Color.HotPink;
            panel9.Location = new Point(918, 17);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 10);
            panel9.TabIndex = 38;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel13);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(totalQuantityLabel2);
            panel7.Location = new Point(918, 17);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 86);
            panel7.TabIndex = 36;
            // 
            // panel13
            // 
            panel13.BackColor = Color.HotPink;
            panel13.Location = new Point(0, 76);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 10);
            panel13.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 18);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 11;
            label7.Text = "Продажі";
            // 
            // totalQuantityLabel2
            // 
            totalQuantityLabel2.AutoSize = true;
            totalQuantityLabel2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalQuantityLabel2.Location = new Point(19, 42);
            totalQuantityLabel2.Name = "totalQuantityLabel2";
            totalQuantityLabel2.Size = new Size(22, 24);
            totalQuantityLabel2.TabIndex = 10;
            totalQuantityLabel2.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(totalRevenueLabel);
            panel6.Location = new Point(22, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 86);
            panel6.TabIndex = 35;
            // 
            // panel11
            // 
            panel11.BackColor = Color.HotPink;
            panel11.Location = new Point(0, 76);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 10);
            panel11.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(146, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 10;
            label1.Text = "Дохід";
            // 
            // totalRevenueLabel
            // 
            totalRevenueLabel.AutoSize = true;
            totalRevenueLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalRevenueLabel.Location = new Point(19, 42);
            totalRevenueLabel.Name = "totalRevenueLabel";
            totalRevenueLabel.Size = new Size(22, 24);
            totalRevenueLabel.TabIndex = 9;
            totalRevenueLabel.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(totalCustomersLabel);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(484, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 86);
            panel5.TabIndex = 34;
            // 
            // panel8
            // 
            panel8.BackColor = Color.HotPink;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 10);
            panel8.TabIndex = 10;
            // 
            // totalCustomersLabel
            // 
            totalCustomersLabel.AutoSize = true;
            totalCustomersLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalCustomersLabel.Location = new Point(17, 42);
            totalCustomersLabel.Name = "totalCustomersLabel";
            totalCustomersLabel.Size = new Size(22, 24);
            totalCustomersLabel.TabIndex = 8;
            totalCustomersLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 18);
            label6.Name = "label6";
            label6.Size = new Size(60, 18);
            label6.TabIndex = 10;
            label6.Text = "Клієнти";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(137, 33);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // cmbBoxType
            // 
            cmbBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxType.FormattingEnabled = true;
            cmbBoxType.Items.AddRange(new object[] { "Найпопулярніші товари", "Найменш популярні товари", "Продажі" });
            cmbBoxType.Location = new Point(71, 132);
            cmbBoxType.Name = "cmbBoxType";
            cmbBoxType.Size = new Size(226, 26);
            cmbBoxType.TabIndex = 32;
            cmbBoxType.SelectedIndexChanged += cmbBoxType_SelectedIndexChanged;
            // 
            // btnRefreshStatistic
            // 
            btnRefreshStatistic.Location = new Point(1052, 132);
            btnRefreshStatistic.Name = "btnRefreshStatistic";
            btnRefreshStatistic.Size = new Size(30, 30);
            btnRefreshStatistic.TabIndex = 31;
            btnRefreshStatistic.Text = "↻";
            btnRefreshStatistic.UseVisualStyleBackColor = true;
            btnRefreshStatistic.Click += btnRefreshStatistic_Click;
            // 
            // popularProductsTable
            // 
            popularProductsTable.AllowUserToAddRows = false;
            popularProductsTable.AllowUserToDeleteRows = false;
            popularProductsTable.AllowUserToOrderColumns = true;
            popularProductsTable.AllowUserToResizeColumns = false;
            popularProductsTable.AllowUserToResizeRows = false;
            popularProductsTable.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            popularProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            popularProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            popularProductsTable.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, productidDataGridViewTextBoxColumn1, productnameDataGridViewTextBoxColumn, productcategoryDataGridViewTextBoxColumn, productmanufacturerDataGridViewTextBoxColumn, totalquantityDataGridViewTextBoxColumn, totalrevenueDataGridViewTextBoxColumn, totalordersDataGridViewTextBoxColumn });
            popularProductsTable.DataSource = statisticBindingSource;
            popularProductsTable.EnableHeadersVisualStyles = false;
            popularProductsTable.Location = new Point(11, 198);
            popularProductsTable.MultiSelect = false;
            popularProductsTable.Name = "popularProductsTable";
            popularProductsTable.ReadOnly = true;
            popularProductsTable.RowHeadersVisible = false;
            popularProductsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            popularProductsTable.Size = new Size(1134, 463);
            popularProductsTable.TabIndex = 48;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 67;
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            productidDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productidDataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            productidDataGridViewTextBoxColumn1.HeaderText = "ID";
            productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            productidDataGridViewTextBoxColumn1.ReadOnly = true;
            productidDataGridViewTextBoxColumn1.Width = 50;
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
            // totalquantityDataGridViewTextBoxColumn
            // 
            totalquantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalquantityDataGridViewTextBoxColumn.DataPropertyName = "total_quantity";
            totalquantityDataGridViewTextBoxColumn.HeaderText = "Total quantity";
            totalquantityDataGridViewTextBoxColumn.Name = "totalquantityDataGridViewTextBoxColumn";
            totalquantityDataGridViewTextBoxColumn.ReadOnly = true;
            totalquantityDataGridViewTextBoxColumn.Width = 119;
            // 
            // totalrevenueDataGridViewTextBoxColumn
            // 
            totalrevenueDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalrevenueDataGridViewTextBoxColumn.DataPropertyName = "total_revenue";
            totalrevenueDataGridViewTextBoxColumn.HeaderText = "Total revenue";
            totalrevenueDataGridViewTextBoxColumn.Name = "totalrevenueDataGridViewTextBoxColumn";
            totalrevenueDataGridViewTextBoxColumn.ReadOnly = true;
            totalrevenueDataGridViewTextBoxColumn.Width = 118;
            // 
            // totalordersDataGridViewTextBoxColumn
            // 
            totalordersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalordersDataGridViewTextBoxColumn.DataPropertyName = "total_orders";
            totalordersDataGridViewTextBoxColumn.HeaderText = "Total orders";
            totalordersDataGridViewTextBoxColumn.Name = "totalordersDataGridViewTextBoxColumn";
            totalordersDataGridViewTextBoxColumn.ReadOnly = true;
            totalordersDataGridViewTextBoxColumn.Width = 108;
            // 
            // statisticBindingSource
            // 
            statisticBindingSource.DataSource = typeof(Statistic);
            // 
            // ordersPage
            // 
            ordersPage.BackColor = Color.LavenderBlush;
            ordersPage.Controls.Add(btnRefreshOrders);
            ordersPage.Controls.Add(btnCancelOrder);
            ordersPage.Controls.Add(btnConfirmOrder);
            ordersPage.Controls.Add(ordersTable);
            ordersPage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordersPage.Location = new Point(4, 27);
            ordersPage.Name = "ordersPage";
            ordersPage.Size = new Size(1154, 671);
            ordersPage.TabIndex = 3;
            ordersPage.Text = "Замовлення";
            // 
            // btnRefreshOrders
            // 
            btnRefreshOrders.Location = new Point(1110, 593);
            btnRefreshOrders.Name = "btnRefreshOrders";
            btnRefreshOrders.Size = new Size(35, 35);
            btnRefreshOrders.TabIndex = 3;
            btnRefreshOrders.Text = "↻";
            btnRefreshOrders.UseVisualStyleBackColor = true;
            btnRefreshOrders.Click += btnRefreshOrders_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.Red;
            btnCancelOrder.Enabled = false;
            btnCancelOrder.Location = new Point(982, 593);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(122, 35);
            btnCancelOrder.TabIndex = 2;
            btnCancelOrder.Text = "Скасувати";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.Lime;
            btnConfirmOrder.Enabled = false;
            btnConfirmOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmOrder.Location = new Point(854, 593);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(122, 35);
            btnConfirmOrder.TabIndex = 1;
            btnConfirmOrder.Text = "Підтвердити";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // ordersTable
            // 
            ordersTable.AllowUserToAddRows = false;
            ordersTable.AllowUserToDeleteRows = false;
            ordersTable.AllowUserToResizeColumns = false;
            ordersTable.AllowUserToResizeRows = false;
            ordersTable.AutoGenerateColumns = false;
            ordersTable.BackgroundColor = Color.LavenderBlush;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ordersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ordersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersTable.Columns.AddRange(new DataGridViewColumn[] { orderidDataGridViewTextBoxColumn1, productnameDataGridViewTextBoxColumn1, productcategoryDataGridViewTextBoxColumn1, productmanufacturerDataGridViewTextBoxColumn1, clientnameDataGridViewTextBoxColumn1, quantityDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn1, statusDataGridViewTextBoxColumn1, createdDataGridViewTextBoxColumn, updatedDataGridViewTextBoxColumn, productidDataGridViewTextBoxColumn, clientidDataGridViewTextBoxColumn });
            ordersTable.DataSource = orderBindingSource;
            ordersTable.EnableHeadersVisualStyles = false;
            ordersTable.GridColor = Color.Fuchsia;
            ordersTable.Location = new Point(11, 12);
            ordersTable.MultiSelect = false;
            ordersTable.Name = "ordersTable";
            ordersTable.ReadOnly = true;
            ordersTable.RowHeadersVisible = false;
            ordersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersTable.Size = new Size(1134, 575);
            ordersTable.TabIndex = 0;
            ordersTable.SelectionChanged += ordersTable_SelectionChanged;
            // 
            // orderidDataGridViewTextBoxColumn1
            // 
            orderidDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderidDataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            orderidDataGridViewTextBoxColumn1.HeaderText = "ID";
            orderidDataGridViewTextBoxColumn1.Name = "orderidDataGridViewTextBoxColumn1";
            orderidDataGridViewTextBoxColumn1.ReadOnly = true;
            orderidDataGridViewTextBoxColumn1.Width = 48;
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            productnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            productnameDataGridViewTextBoxColumn1.HeaderText = "Product";
            productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            productnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productcategoryDataGridViewTextBoxColumn1
            // 
            productcategoryDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productcategoryDataGridViewTextBoxColumn1.DataPropertyName = "product_category";
            productcategoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            productcategoryDataGridViewTextBoxColumn1.Name = "productcategoryDataGridViewTextBoxColumn1";
            productcategoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productmanufacturerDataGridViewTextBoxColumn1
            // 
            productmanufacturerDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productmanufacturerDataGridViewTextBoxColumn1.DataPropertyName = "product_manufacturer";
            productmanufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer";
            productmanufacturerDataGridViewTextBoxColumn1.Name = "productmanufacturerDataGridViewTextBoxColumn1";
            productmanufacturerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientnameDataGridViewTextBoxColumn1
            // 
            clientnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientnameDataGridViewTextBoxColumn1.DataPropertyName = "client_name";
            clientnameDataGridViewTextBoxColumn1.HeaderText = "Client";
            clientnameDataGridViewTextBoxColumn1.Name = "clientnameDataGridViewTextBoxColumn1";
            clientnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn2
            // 
            quantityDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn2.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn2.HeaderText = "QTY";
            quantityDataGridViewTextBoxColumn2.Name = "quantityDataGridViewTextBoxColumn2";
            quantityDataGridViewTextBoxColumn2.ReadOnly = true;
            quantityDataGridViewTextBoxColumn2.Width = 63;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalDataGridViewTextBoxColumn1.DataPropertyName = "total";
            totalDataGridViewTextBoxColumn1.HeaderText = "Total $";
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
            totalDataGridViewTextBoxColumn1.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Width = 77;
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
            // productidDataGridViewTextBoxColumn
            // 
            productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            productidDataGridViewTextBoxColumn.ReadOnly = true;
            productidDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            clientidDataGridViewTextBoxColumn.HeaderText = "Client ID";
            clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            clientidDataGridViewTextBoxColumn.ReadOnly = true;
            clientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 70);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 772);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            productsPage.ResumeLayout(false);
            productsPage.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            statisticPage.ResumeLayout(false);
            statisticPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statisticChart).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)popularProductsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)statisticBindingSource).EndInit();
            ordersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsTable;
        private Button btnSave;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private TabControl tabControl1;
        private TabPage productsPage;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox3;
        private Label totalQuantityLabel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn product_idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private TabPage ordersPage;
        private DataGridView ordersTable;
        private DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productcategoryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productmanufacturerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private Button btnCancelOrder;
        private Button btnConfirmOrder;
        private TabPage statisticPage;
        private Label label4;
        private ComboBox cmbBoxPeriod;
        private Label label3;
        private Button btnGenerate;
        private Panel panel12;
        private Panel panel10;
        private Panel panel9;
        private Panel panel7;
        private Panel panel13;
        private PictureBox pictureBox2;
        private Label label7;
        private Label totalQuantityLabel2;
        private Panel panel6;
        private Panel panel11;
        private PictureBox pictureBox5;
        private Label label1;
        private Label totalRevenueLabel;
        private Panel panel5;
        private Panel panel8;
        private Label totalCustomersLabel;
        private Label label6;
        private PictureBox pictureBox4;
        private ComboBox cmbBoxType;
        private Button btnRefreshStatistic;
        private Button btnRefreshOrders;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart;
        private Label label5;
        private ComboBox cmbBoxProducts;
        private DataGridView popularProductsTable;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productcategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productmanufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalquantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalrevenueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalordersDataGridViewTextBoxColumn;
        private BindingSource statisticBindingSource;
    }
}