namespace CRUDTRES
{
    partial class CustomersForm
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
            label1 = new Label();
            CustomersDataGrid = new DataGridView();
            Leer = new Button();
            CompanyName = new TextBox();
            ContactName = new TextBox();
            Address = new TextBox();
            City = new TextBox();
            Region = new TextBox();
            PostalCode = new TextBox();
            Country = new TextBox();
            Phone = new TextBox();
            Fax = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            CustomerID = new ComboBox();
            label11 = new Label();
            panel1 = new Panel();
            ContactTittle = new TextBox();
            label12 = new Label();
            Actualizar = new Button();
            Agregar = new Button();
            Eliminar = new Button();
            Vaciar = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(111, 224);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 1;
            label1.Text = "ID Del Cliente";
            // 
            // CustomersDataGrid
            // 
            CustomersDataGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersDataGrid.Location = new Point(51, 596);
            CustomersDataGrid.Name = "CustomersDataGrid";
            CustomersDataGrid.RowHeadersWidth = 51;
            CustomersDataGrid.Size = new Size(1090, 264);
            CustomersDataGrid.TabIndex = 2;
            CustomersDataGrid.CellContentClick += CustomersDataGrid_CellContentClick;
            // 
            // Leer
            // 
            Leer.Anchor = AnchorStyles.None;
            Leer.BackColor = Color.FromArgb(192, 255, 255);
            Leer.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            Leer.ForeColor = SystemColors.ActiveCaptionText;
            Leer.Location = new Point(425, 532);
            Leer.Name = "Leer";
            Leer.Size = new Size(111, 41);
            Leer.TabIndex = 3;
            Leer.Text = "Leer";
            Leer.UseVisualStyleBackColor = false;
            Leer.Click += Leer_Click;
            // 
            // CompanyName
            // 
            CompanyName.Anchor = AnchorStyles.None;
            CompanyName.Font = new Font("Times New Roman", 12F);
            CompanyName.Location = new Point(374, 273);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(254, 30);
            CompanyName.TabIndex = 0;
            // 
            // ContactName
            // 
            ContactName.Anchor = AnchorStyles.None;
            ContactName.Font = new Font("Times New Roman", 12F);
            ContactName.Location = new Point(374, 331);
            ContactName.Name = "ContactName";
            ContactName.Size = new Size(254, 30);
            ContactName.TabIndex = 0;
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.None;
            Address.Font = new Font("Times New Roman", 12F);
            Address.Location = new Point(374, 422);
            Address.Name = "Address";
            Address.Size = new Size(303, 30);
            Address.TabIndex = 0;
            // 
            // City
            // 
            City.Anchor = AnchorStyles.None;
            City.Font = new Font("Times New Roman", 12F);
            City.Location = new Point(374, 473);
            City.Name = "City";
            City.Size = new Size(196, 30);
            City.TabIndex = 0;
            // 
            // Region
            // 
            Region.Anchor = AnchorStyles.None;
            Region.Font = new Font("Times New Roman", 12F);
            Region.Location = new Point(892, 229);
            Region.Name = "Region";
            Region.Size = new Size(71, 30);
            Region.TabIndex = 0;
            // 
            // PostalCode
            // 
            PostalCode.Anchor = AnchorStyles.None;
            PostalCode.Font = new Font("Times New Roman", 12F);
            PostalCode.Location = new Point(892, 284);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(137, 30);
            PostalCode.TabIndex = 0;
            // 
            // Country
            // 
            Country.Anchor = AnchorStyles.None;
            Country.Font = new Font("Times New Roman", 12F);
            Country.Location = new Point(892, 339);
            Country.Name = "Country";
            Country.Size = new Size(137, 30);
            Country.TabIndex = 0;
            // 
            // Phone
            // 
            Phone.Anchor = AnchorStyles.None;
            Phone.Font = new Font("Times New Roman", 12F);
            Phone.Location = new Point(892, 387);
            Phone.Name = "Phone";
            Phone.Size = new Size(159, 30);
            Phone.TabIndex = 0;
            // 
            // Fax
            // 
            Fax.Anchor = AnchorStyles.None;
            Fax.Font = new Font("Times New Roman", 12F);
            Fax.Location = new Point(892, 438);
            Fax.Name = "Fax";
            Fax.Size = new Size(159, 30);
            Fax.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(111, 276);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre De La Compañia";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(111, 331);
            label3.Name = "label3";
            label3.Size = new Size(188, 23);
            label3.TabIndex = 1;
            label3.Text = "Nombre De Contacto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(111, 422);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 1;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(111, 473);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 1;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(739, 232);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 1;
            label6.Text = "Región";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(739, 284);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 1;
            label7.Text = "Codigo Postal";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(739, 339);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 1;
            label8.Text = "País";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(739, 387);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 1;
            label9.Text = "Teléfono";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(739, 438);
            label10.Name = "label10";
            label10.Size = new Size(41, 23);
            label10.TabIndex = 1;
            label10.Text = "Fax";
            // 
            // CustomerID
            // 
            CustomerID.Anchor = AnchorStyles.None;
            CustomerID.FormattingEnabled = true;
            CustomerID.Location = new Point(374, 218);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(151, 28);
            CustomerID.TabIndex = 4;
            CustomerID.SelectedIndexChanged += CustomerID_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(452, 92);
            label11.Name = "label11";
            label11.Size = new Size(333, 45);
            label11.TabIndex = 1;
            label11.Text = "Gestionar Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 41);
            panel1.TabIndex = 5;
            // 
            // ContactTittle
            // 
            ContactTittle.Anchor = AnchorStyles.None;
            ContactTittle.Font = new Font("Times New Roman", 12F);
            ContactTittle.Location = new Point(374, 380);
            ContactTittle.Name = "ContactTittle";
            ContactTittle.Size = new Size(254, 30);
            ContactTittle.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(111, 380);
            label12.Name = "label12";
            label12.Size = new Size(171, 23);
            label12.TabIndex = 1;
            label12.Text = "Titulo De Contacto";
            // 
            // Actualizar
            // 
            Actualizar.BackColor = Color.DodgerBlue;
            Actualizar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            Actualizar.ForeColor = SystemColors.ActiveCaptionText;
            Actualizar.Location = new Point(579, 532);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(127, 41);
            Actualizar.TabIndex = 6;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = false;
            Actualizar.Click += Actualizar_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.FromArgb(128, 255, 128);
            Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            Agregar.ForeColor = SystemColors.ActiveCaptionText;
            Agregar.Location = new Point(740, 532);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(119, 41);
            Agregar.TabIndex = 7;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.Red;
            Eliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            Eliminar.ForeColor = SystemColors.ActiveCaptionText;
            Eliminar.Location = new Point(884, 532);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(130, 41);
            Eliminar.TabIndex = 8;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Vaciar
            // 
            Vaciar.BackColor = Color.FromArgb(255, 128, 128);
            Vaciar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vaciar.ForeColor = SystemColors.ControlText;
            Vaciar.Location = new Point(249, 532);
            Vaciar.Name = "Vaciar";
            Vaciar.Size = new Size(137, 41);
            Vaciar.TabIndex = 9;
            Vaciar.Text = "Vaciar Campos";
            Vaciar.UseVisualStyleBackColor = false;
            Vaciar.Click += Vaciar_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1184, 861);
            Controls.Add(Vaciar);
            Controls.Add(Eliminar);
            Controls.Add(Agregar);
            Controls.Add(Actualizar);
            Controls.Add(panel1);
            Controls.Add(CustomerID);
            Controls.Add(Leer);
            Controls.Add(CustomersDataGrid);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(Fax);
            Controls.Add(City);
            Controls.Add(Phone);
            Controls.Add(Address);
            Controls.Add(Country);
            Controls.Add(ContactTittle);
            Controls.Add(ContactName);
            Controls.Add(PostalCode);
            Controls.Add(CompanyName);
            Controls.Add(Region);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)CustomersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView CustomersDataGrid;
        private Button Leer;
        private TextBox CompanyName;
        private TextBox ContactName;
        private TextBox Address;
        private TextBox City;
        private TextBox Region;
        private TextBox PostalCode;
        private TextBox Country;
        private TextBox Phone;
        private TextBox Fax;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox CustomerID;
        private Label label11;
        private Panel panel1;
        private TextBox ContactTittle;
        private Label label12;
        private Button Actualizar;
        private Button Agregar;
        private Button Eliminar;
        private Button Vaciar;
    }
}