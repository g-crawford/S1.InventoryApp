
namespace C968___Inventory_Application
{
    partial class MainScreen
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
            this.IVMLabel = new System.Windows.Forms.Label();
            this.PartsPanel = new System.Windows.Forms.Panel();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartsDeleteButton = new System.Windows.Forms.Button();
            this.PartsModifyButton = new System.Windows.Forms.Button();
            this.PartsAddButton = new System.Windows.Forms.Button();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductsDeleteButton = new System.Windows.Forms.Button();
            this.ProductsModifyButton = new System.Windows.Forms.Button();
            this.ProductsSearchBar = new System.Windows.Forms.TextBox();
            this.ProductsAddButton = new System.Windows.Forms.Button();
            this.ProductsSearchButton = new System.Windows.Forms.Button();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            this.ProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IVMLabel
            // 
            this.IVMLabel.AutoSize = true;
            this.IVMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVMLabel.Location = new System.Drawing.Point(16, 11);
            this.IVMLabel.Name = "IVMLabel";
            this.IVMLabel.Size = new System.Drawing.Size(229, 20);
            this.IVMLabel.TabIndex = 0;
            this.IVMLabel.Text = "Inventory Management System";
            // 
            // PartsPanel
            // 
            this.PartsPanel.Controls.Add(this.PartsDataGridView);
            this.PartsPanel.Controls.Add(this.PartsDeleteButton);
            this.PartsPanel.Controls.Add(this.PartsModifyButton);
            this.PartsPanel.Controls.Add(this.PartsAddButton);
            this.PartsPanel.Controls.Add(this.PartsLabel);
            this.PartsPanel.Controls.Add(this.PartsSearchButton);
            this.PartsPanel.Controls.Add(this.PartsSearchBox);
            this.PartsPanel.Location = new System.Drawing.Point(18, 41);
            this.PartsPanel.Name = "PartsPanel";
            this.PartsPanel.Size = new System.Drawing.Size(587, 310);
            this.PartsPanel.TabIndex = 1;
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(14, 56);
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.Size = new System.Drawing.Size(554, 212);
            this.PartsDataGridView.TabIndex = 14;
            this.PartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellClick);
            // 
            // PartsDeleteButton
            // 
            this.PartsDeleteButton.Location = new System.Drawing.Point(509, 274);
            this.PartsDeleteButton.Name = "PartsDeleteButton";
            this.PartsDeleteButton.Size = new System.Drawing.Size(57, 26);
            this.PartsDeleteButton.TabIndex = 6;
            this.PartsDeleteButton.Text = "Delete";
            this.PartsDeleteButton.UseVisualStyleBackColor = true;
            this.PartsDeleteButton.Click += new System.EventHandler(this.PartsDeleteButton_Click);
            // 
            // PartsModifyButton
            // 
            this.PartsModifyButton.Location = new System.Drawing.Point(446, 274);
            this.PartsModifyButton.Name = "PartsModifyButton";
            this.PartsModifyButton.Size = new System.Drawing.Size(58, 26);
            this.PartsModifyButton.TabIndex = 5;
            this.PartsModifyButton.Text = "Modify";
            this.PartsModifyButton.UseVisualStyleBackColor = true;
            this.PartsModifyButton.Click += new System.EventHandler(this.PartsModifyButton_Click);
            // 
            // PartsAddButton
            // 
            this.PartsAddButton.Location = new System.Drawing.Point(382, 274);
            this.PartsAddButton.Name = "PartsAddButton";
            this.PartsAddButton.Size = new System.Drawing.Size(58, 26);
            this.PartsAddButton.TabIndex = 4;
            this.PartsAddButton.Text = "Add";
            this.PartsAddButton.UseVisualStyleBackColor = true;
            this.PartsAddButton.Click += new System.EventHandler(this.PartsAddButton_Click);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(10, 30);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(46, 20);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "Parts";
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.Location = new System.Drawing.Point(290, 30);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(86, 20);
            this.PartsSearchButton.TabIndex = 2;
            this.PartsSearchButton.Text = "Search";
            this.PartsSearchButton.UseVisualStyleBackColor = false;
            this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(382, 31);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(184, 20);
            this.PartsSearchBox.TabIndex = 1;
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.ProductsDataGridView);
            this.ProductsPanel.Controls.Add(this.ProductsDeleteButton);
            this.ProductsPanel.Controls.Add(this.ProductsModifyButton);
            this.ProductsPanel.Controls.Add(this.ProductsSearchBar);
            this.ProductsPanel.Controls.Add(this.ProductsAddButton);
            this.ProductsPanel.Controls.Add(this.ProductsSearchButton);
            this.ProductsPanel.Controls.Add(this.ProductsLabel);
            this.ProductsPanel.Location = new System.Drawing.Point(611, 41);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(589, 310);
            this.ProductsPanel.TabIndex = 2;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(556, 212);
            this.ProductsDataGridView.TabIndex = 15;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            // 
            // ProductsDeleteButton
            // 
            this.ProductsDeleteButton.Location = new System.Drawing.Point(512, 274);
            this.ProductsDeleteButton.Name = "ProductsDeleteButton";
            this.ProductsDeleteButton.Size = new System.Drawing.Size(57, 26);
            this.ProductsDeleteButton.TabIndex = 13;
            this.ProductsDeleteButton.Text = "Delete";
            this.ProductsDeleteButton.UseVisualStyleBackColor = true;
            this.ProductsDeleteButton.Click += new System.EventHandler(this.ProductsDeleteButton_Click);
            // 
            // ProductsModifyButton
            // 
            this.ProductsModifyButton.Location = new System.Drawing.Point(449, 274);
            this.ProductsModifyButton.Name = "ProductsModifyButton";
            this.ProductsModifyButton.Size = new System.Drawing.Size(58, 26);
            this.ProductsModifyButton.TabIndex = 12;
            this.ProductsModifyButton.Text = "Modify";
            this.ProductsModifyButton.UseVisualStyleBackColor = true;
            this.ProductsModifyButton.Click += new System.EventHandler(this.ProductsModifyButton_Click);
            // 
            // ProductsSearchBar
            // 
            this.ProductsSearchBar.Location = new System.Drawing.Point(385, 30);
            this.ProductsSearchBar.Name = "ProductsSearchBar";
            this.ProductsSearchBar.Size = new System.Drawing.Size(183, 20);
            this.ProductsSearchBar.TabIndex = 8;
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.Location = new System.Drawing.Point(385, 274);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(58, 26);
            this.ProductsAddButton.TabIndex = 11;
            this.ProductsAddButton.Text = "Add";
            this.ProductsAddButton.UseVisualStyleBackColor = true;
            this.ProductsAddButton.Click += new System.EventHandler(this.ProductsAddButton_Click);
            // 
            // ProductsSearchButton
            // 
            this.ProductsSearchButton.Location = new System.Drawing.Point(293, 31);
            this.ProductsSearchButton.Name = "ProductsSearchButton";
            this.ProductsSearchButton.Size = new System.Drawing.Size(86, 20);
            this.ProductsSearchButton.TabIndex = 9;
            this.ProductsSearchButton.Text = "Search";
            this.ProductsSearchButton.UseVisualStyleBackColor = false;
            this.ProductsSearchButton.Click += new System.EventHandler(this.ProductsSearchButton_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(9, 30);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(72, 20);
            this.ProductsLabel.TabIndex = 10;
            this.ProductsLabel.Text = "Products";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1127, 357);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 29);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1200, 398);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProductsPanel);
            this.Controls.Add(this.PartsPanel);
            this.Controls.Add(this.IVMLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.PartsPanel.ResumeLayout(false);
            this.PartsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            this.ProductsPanel.ResumeLayout(false);
            this.ProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label IVMLabel;
        private System.Windows.Forms.Panel PartsPanel;
        private System.Windows.Forms.Button PartsDeleteButton;
        private System.Windows.Forms.Button PartsModifyButton;
        private System.Windows.Forms.Button PartsAddButton;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Button PartsSearchButton;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Button ProductsDeleteButton;
        private System.Windows.Forms.Button ProductsModifyButton;
        private System.Windows.Forms.TextBox ProductsSearchBar;
        private System.Windows.Forms.Button ProductsAddButton;
        private System.Windows.Forms.Button ProductsSearchButton;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
    }
}

#endregion