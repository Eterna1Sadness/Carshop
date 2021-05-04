namespace TRPO_carshop
{
    partial class MainForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ProSearchButton = new System.Windows.Forms.Button();
            this.dataMenu2 = new System.Windows.Forms.DataGridView();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.CarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MainButton);
            this.panel1.Controls.Add(this.MenuLabel);
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Controls.Add(this.ProSearchButton);
            this.panel1.Controls.Add(this.dataMenu2);
            this.panel1.Controls.Add(this.dataMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 578);
            this.panel1.TabIndex = 0;
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
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchField
            // 
            this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(202, 20);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(619, 26);
            this.SearchField.TabIndex = 1;
            this.SearchField.Enter += new System.EventHandler(this.SearchField_Enter);
            this.SearchField.Leave += new System.EventHandler(this.SearchField_Leave);
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(12, 134);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(180, 29);
            this.MainButton.TabIndex = 7;
            this.MainButton.Text = "Главная";
            this.MainButton.UseVisualStyleBackColor = true;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuLabel.Location = new System.Drawing.Point(39, 70);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(113, 45);
            this.MenuLabel.TabIndex = 5;
            this.MenuLabel.Text = "Меню";
            // 
            // ProfileButton
            // 
            this.ProfileButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(12, 204);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(180, 29);
            this.ProfileButton.TabIndex = 5;
            this.ProfileButton.Text = "Профиль";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // ProSearchButton
            // 
            this.ProSearchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProSearchButton.Location = new System.Drawing.Point(12, 169);
            this.ProSearchButton.Name = "ProSearchButton";
            this.ProSearchButton.Size = new System.Drawing.Size(181, 29);
            this.ProSearchButton.TabIndex = 4;
            this.ProSearchButton.Text = "Расширенный поиск";
            this.ProSearchButton.UseVisualStyleBackColor = true;
            this.ProSearchButton.Click += new System.EventHandler(this.ProSearchButton_Click);
            // 
            // dataMenu2
            // 
            this.dataMenu2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu2.Location = new System.Drawing.Point(201, 70);
            this.dataMenu2.Name = "dataMenu2";
            this.dataMenu2.Size = new System.Drawing.Size(743, 508);
            this.dataMenu2.TabIndex = 3;
            this.dataMenu2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenu2_CellContentClick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 579);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarFuel;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataMenu2;
        private System.Windows.Forms.Button ProSearchButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}