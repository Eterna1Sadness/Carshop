namespace TRPO_carshop
{
    partial class AdvancedSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HighPriceBox = new System.Windows.Forms.TextBox();
            this.LowPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvancedButton = new System.Windows.Forms.Button();
            this.FuelBox = new System.Windows.Forms.ComboBox();
            this.MarkaBox = new System.Windows.Forms.ComboBox();
            this.dataMenu2 = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.CarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HighPriceBox);
            this.panel1.Controls.Add(this.LowPriceBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdvancedButton);
            this.panel1.Controls.Add(this.FuelBox);
            this.panel1.Controls.Add(this.MarkaBox);
            this.panel1.Controls.Add(this.dataMenu2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MainButton);
            this.panel1.Controls.Add(this.MenuLabel);
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Controls.Add(this.dataMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 578);
            this.panel1.TabIndex = 1;
            // 
            // HighPriceBox
            // 
            this.HighPriceBox.Location = new System.Drawing.Point(33, 230);
            this.HighPriceBox.Name = "HighPriceBox";
            this.HighPriceBox.Size = new System.Drawing.Size(155, 20);
            this.HighPriceBox.TabIndex = 12;
            // 
            // LowPriceBox
            // 
            this.LowPriceBox.Location = new System.Drawing.Point(33, 204);
            this.LowPriceBox.Name = "LowPriceBox";
            this.LowPriceBox.Size = new System.Drawing.Size(155, 20);
            this.LowPriceBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "От:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Цена";
            // 
            // AdvancedButton
            // 
            this.AdvancedButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdvancedButton.Location = new System.Drawing.Point(13, 254);
            this.AdvancedButton.Name = "AdvancedButton";
            this.AdvancedButton.Size = new System.Drawing.Size(176, 36);
            this.AdvancedButton.TabIndex = 5;
            this.AdvancedButton.Text = "Поиск";
            this.AdvancedButton.UseVisualStyleBackColor = true;
            this.AdvancedButton.Click += new System.EventHandler(this.AdvancedButton_Click);
            // 
            // FuelBox
            // 
            this.FuelBox.FormattingEnabled = true;
            this.FuelBox.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "ДТ"});
            this.FuelBox.Location = new System.Drawing.Point(82, 146);
            this.FuelBox.Name = "FuelBox";
            this.FuelBox.Size = new System.Drawing.Size(106, 21);
            this.FuelBox.TabIndex = 10;
            this.FuelBox.SelectedIndexChanged += new System.EventHandler(this.FuelBox_SelectedIndexChanged);
            // 
            // MarkaBox
            // 
            this.MarkaBox.FormattingEnabled = true;
            this.MarkaBox.Items.AddRange(new object[] {
            "Audi",
            "Opel",
            "Subaru",
            "Volkswagen",
            "Toyoto",
            "Mercedes-Benz",
            "Ford"});
            this.MarkaBox.Location = new System.Drawing.Point(63, 119);
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.Size = new System.Drawing.Size(125, 21);
            this.MarkaBox.TabIndex = 9;
            this.MarkaBox.SelectedIndexChanged += new System.EventHandler(this.MarkaBox_SelectedIndexChanged);
            // 
            // dataMenu2
            // 
            this.dataMenu2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu2.Location = new System.Drawing.Point(202, 70);
            this.dataMenu2.Name = "dataMenu2";
            this.dataMenu2.Size = new System.Drawing.Size(742, 508);
            this.dataMenu2.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 538);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 29);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.MainLabel);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.SearchField);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 67);
            this.panel2.TabIndex = 2;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainLabel.Location = new System.Drawing.Point(3, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(193, 60);
            this.MainLabel.TabIndex = 4;
            this.MainLabel.Text = "Главная";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(827, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 38);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchField
            // 
            this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(202, 20);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(619, 26);
            this.SearchField.TabIndex = 1;
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(12, 468);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(180, 29);
            this.MainButton.TabIndex = 7;
            this.MainButton.Text = "Главная";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuLabel.Location = new System.Drawing.Point(3, 70);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(202, 27);
            this.MenuLabel.TabIndex = 5;
            this.MenuLabel.Text = "Расширенный поиск";
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(12, 503);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(180, 29);
            this.ProfileButton.TabIndex = 5;
            this.ProfileButton.Text = "Профиль";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // dataMenu
            // 
            this.dataMenu.AllowUserToDeleteRows = false;
            this.dataMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarName,
            this.CarPrice,
            this.CarModel,
            this.CarFuel});
            this.dataMenu.Location = new System.Drawing.Point(356, 204);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenu.Size = new System.Drawing.Size(120, 245);
            this.dataMenu.TabIndex = 0;
            // 
            // CarName
            // 
            this.CarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarName.FillWeight = 96.32967F;
            this.CarName.HeaderText = "CarName";
            this.CarName.Name = "CarName";
            this.CarName.ReadOnly = true;
            this.CarName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CarPrice
            // 
            this.CarPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarPrice.FillWeight = 128.1766F;
            this.CarPrice.HeaderText = "CarPrice";
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.ReadOnly = true;
            this.CarPrice.Width = 72;
            // 
            // CarModel
            // 
            this.CarModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarModel.FillWeight = 114.5801F;
            this.CarModel.HeaderText = "CarModel";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            this.CarModel.Width = 77;
            // 
            // CarFuel
            // 
            this.CarFuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarFuel.FillWeight = 60.9137F;
            this.CarFuel.HeaderText = "CarFuel";
            this.CarFuel.Name = "CarFuel";
            this.CarFuel.ReadOnly = true;
            this.CarFuel.Width = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Марка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Топливо:";
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 578);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.DataGridView dataMenu2;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarFuel;
        private System.Windows.Forms.ComboBox FuelBox;
        private System.Windows.Forms.ComboBox MarkaBox;
        private System.Windows.Forms.Button AdvancedButton;
        private System.Windows.Forms.TextBox HighPriceBox;
        private System.Windows.Forms.TextBox LowPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}