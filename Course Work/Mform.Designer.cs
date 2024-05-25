namespace Course_Work
{
    partial class Mform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mform));
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            visible = new Button();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            users = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Continue = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(116, 76);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.CausesValidation = false;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(224, 169);
            button1.Name = "button1";
            button1.Size = new Size(141, 30);
            button1.TabIndex = 1;
            button1.Text = "Вхід";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(163, 76);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ім'я користувача";
            textBox1.Size = new Size(245, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(116, 125);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(163, 123);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(202, 25);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // visible
            // 
            visible.Image = (Image)resources.GetObject("visible.Image");
            visible.Location = new Point(371, 125);
            visible.Name = "visible";
            visible.Size = new Size(37, 23);
            visible.TabIndex = 5;
            visible.UseVisualStyleBackColor = true;
            visible.Click += visible_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 26);
            label3.Name = "label3";
            label3.Size = new Size(175, 22);
            label3.TabIndex = 6;
            label3.Text = "ВХІД В СИСТЕМУ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(576, 273);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LavenderBlush;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(visible);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(568, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Адмін";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LavenderBlush;
            tabPage2.Controls.Add(users);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(Continue);
            tabPage2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(568, 245);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Користувач";
            // 
            // users
            // 
            users.DisplayMember = "name";
            users.DropDownStyle = ComboBoxStyle.DropDownList;
            users.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users.FormattingEnabled = true;
            users.Location = new Point(214, 71);
            users.Name = "users";
            users.Size = new Size(141, 25);
            users.TabIndex = 15;
            users.SelectedIndexChanged += users_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 29);
            label4.Name = "label4";
            label4.Size = new Size(175, 22);
            label4.TabIndex = 13;
            label4.Text = "ВХІД В СИСТЕМУ";
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(181, 73);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 7;
            // 
            // Continue
            // 
            Continue.BackColor = SystemColors.ButtonHighlight;
            Continue.CausesValidation = false;
            Continue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Continue.ForeColor = Color.Black;
            Continue.Location = new Point(214, 125);
            Continue.Name = "Continue";
            Continue.Size = new Size(141, 30);
            Continue.TabIndex = 8;
            Continue.Text = "Вхід";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // Mform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(575, 272);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Mform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mform";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button visible;
        private Label label3;
        private ComboBox AorU;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label5;
        private Button Continue;
        private ComboBox users;
    }
}