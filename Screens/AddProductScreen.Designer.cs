
namespace C968___Inventory_Application
{
    partial class AddProductScreen
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
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InventoryTextbox = new System.Windows.Forms.TextBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.CandidatePartsPanel = new System.Windows.Forms.Panel();
            this.CandidatePartsAddButton = new System.Windows.Forms.Button();
            this.CandidatePartsDataGrid = new System.Windows.Forms.DataGridView();
            this.CandidatePartsLabel = new System.Windows.Forms.Label();
            this.CandidatePartsTextbox = new System.Windows.Forms.TextBox();
            this.CandidatePartsSearchButton = new System.Windows.Forms.Button();
            this.AssociatedPartsPanel = new System.Windows.Forms.Panel();
            this.AssociatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.AssociatedPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsTextbox = new System.Windows.Forms.TextBox();
            this.AssociatedPartsSearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CandidatePartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsDataGrid)).BeginInit();
            this.AssociatedPartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(25, 20);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(97, 20);
            this.AddProductLabel.TabIndex = 0;
            this.AddProductLabel.Text = "Add Product";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(81, 139);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 1;
            this.ID_Label.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 177);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Location = new System.Drawing.Point(130, 136);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(123, 20);
            this.ID_Textbox.TabIndex = 3;
            this.ID_Textbox.TextChanged += new System.EventHandler(this.ID_Textbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(130, 174);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(123, 20);
            this.NameTextbox.TabIndex = 4;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // InventoryTextbox
            // 
            this.InventoryTextbox.Location = new System.Drawing.Point(130, 214);
            this.InventoryTextbox.Name = "InventoryTextbox";
            this.InventoryTextbox.Size = new System.Drawing.Size(123, 20);
            this.InventoryTextbox.TabIndex = 6;
            this.InventoryTextbox.TextChanged += new System.EventHandler(this.InventoryTextbox_TextChanged);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(48, 217);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 5;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(130, 253);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(123, 20);
            this.PriceTextbox.TabIndex = 8;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(68, 256);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price";
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(228, 293);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(72, 20);
            this.MaxTextbox.TabIndex = 10;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(195, 296);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 9;
            this.MaxLabel.Text = "Max";
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(106, 293);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(72, 20);
            this.MinTextbox.TabIndex = 12;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(76, 296);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 11;
            this.MinLabel.Text = "Min";
            // 
            // CandidatePartsPanel
            // 
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsAddButton);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsDataGrid);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsLabel);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsTextbox);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsSearchButton);
            this.CandidatePartsPanel.Location = new System.Drawing.Point(413, 20);
            this.CandidatePartsPanel.Name = "CandidatePartsPanel";
            this.CandidatePartsPanel.Size = new System.Drawing.Size(653, 229);
            this.CandidatePartsPanel.TabIndex = 15;
            // 
            // CandidatePartsAddButton
            // 
            this.CandidatePartsAddButton.Location = new System.Drawing.Point(601, 202);
            this.CandidatePartsAddButton.Name = "CandidatePartsAddButton";
            this.CandidatePartsAddButton.Size = new System.Drawing.Size(52, 24);
            this.CandidatePartsAddButton.TabIndex = 4;
            this.CandidatePartsAddButton.Text = "Add";
            this.CandidatePartsAddButton.UseVisualStyleBackColor = true;
            this.CandidatePartsAddButton.Click += new System.EventHandler(this.CandidatePartsAddButton_Click);
            // 
            // CandidatePartsDataGrid
            // 
            this.CandidatePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatePartsDataGrid.Location = new System.Drawing.Point(6, 31);
            this.CandidatePartsDataGrid.Name = "CandidatePartsDataGrid";
            this.CandidatePartsDataGrid.Size = new System.Drawing.Size(643, 165);
            this.CandidatePartsDataGrid.TabIndex = 3;
            this.CandidatePartsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidatePartsDataGrid_CellClick);
            // 
            // CandidatePartsLabel
            // 
            this.CandidatePartsLabel.AutoSize = true;
            this.CandidatePartsLabel.Location = new System.Drawing.Point(13, 11);
            this.CandidatePartsLabel.Name = "CandidatePartsLabel";
            this.CandidatePartsLabel.Size = new System.Drawing.Size(96, 13);
            this.CandidatePartsLabel.TabIndex = 2;
            this.CandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // CandidatePartsTextbox
            // 
            this.CandidatePartsTextbox.Location = new System.Drawing.Point(472, 6);
            this.CandidatePartsTextbox.Name = "CandidatePartsTextbox";
            this.CandidatePartsTextbox.Size = new System.Drawing.Size(177, 20);
            this.CandidatePartsTextbox.TabIndex = 1;
            // 
            // CandidatePartsSearchButton
            // 
            this.CandidatePartsSearchButton.Location = new System.Drawing.Point(409, 5);
            this.CandidatePartsSearchButton.Name = "CandidatePartsSearchButton";
            this.CandidatePartsSearchButton.Size = new System.Drawing.Size(57, 21);
            this.CandidatePartsSearchButton.TabIndex = 0;
            this.CandidatePartsSearchButton.Text = "Search";
            this.CandidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.CandidatePartsSearchButton.Click += new System.EventHandler(this.CandidatePartsSearchButton_Click);
            // 
            // AssociatedPartsPanel
            // 
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsDeleteButton);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsDataGrid);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsLabel);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsTextbox);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsSearchButton);
            this.AssociatedPartsPanel.Location = new System.Drawing.Point(413, 259);
            this.AssociatedPartsPanel.Name = "AssociatedPartsPanel";
            this.AssociatedPartsPanel.Size = new System.Drawing.Size(653, 229);
            this.AssociatedPartsPanel.TabIndex = 16;
            // 
            // AssociatedPartsDeleteButton
            // 
            this.AssociatedPartsDeleteButton.Location = new System.Drawing.Point(597, 202);
            this.AssociatedPartsDeleteButton.Name = "AssociatedPartsDeleteButton";
            this.AssociatedPartsDeleteButton.Size = new System.Drawing.Size(52, 24);
            this.AssociatedPartsDeleteButton.TabIndex = 4;
            this.AssociatedPartsDeleteButton.Text = "Delete";
            this.AssociatedPartsDeleteButton.UseVisualStyleBackColor = true;
            this.AssociatedPartsDeleteButton.Click += new System.EventHandler(this.AssociatedPartsDeleteButton_Click);
            // 
            // AssociatedPartsDataGrid
            // 
            this.AssociatedPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsDataGrid.Location = new System.Drawing.Point(6, 31);
            this.AssociatedPartsDataGrid.Name = "AssociatedPartsDataGrid";
            this.AssociatedPartsDataGrid.Size = new System.Drawing.Size(643, 165);
            this.AssociatedPartsDataGrid.TabIndex = 3;
            this.AssociatedPartsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataGrid_CellClick);
            // 
            // AssociatedPartsLabel
            // 
            this.AssociatedPartsLabel.AutoSize = true;
            this.AssociatedPartsLabel.Location = new System.Drawing.Point(13, 11);
            this.AssociatedPartsLabel.Name = "AssociatedPartsLabel";
            this.AssociatedPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.AssociatedPartsLabel.TabIndex = 2;
            this.AssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AssociatedPartsTextbox
            // 
            this.AssociatedPartsTextbox.Location = new System.Drawing.Point(477, 5);
            this.AssociatedPartsTextbox.Name = "AssociatedPartsTextbox";
            this.AssociatedPartsTextbox.Size = new System.Drawing.Size(172, 20);
            this.AssociatedPartsTextbox.TabIndex = 1;
            // 
            // AssociatedPartsSearchButton
            // 
            this.AssociatedPartsSearchButton.Location = new System.Drawing.Point(414, 4);
            this.AssociatedPartsSearchButton.Name = "AssociatedPartsSearchButton";
            this.AssociatedPartsSearchButton.Size = new System.Drawing.Size(57, 21);
            this.AssociatedPartsSearchButton.TabIndex = 0;
            this.AssociatedPartsSearchButton.Text = "Search";
            this.AssociatedPartsSearchButton.UseVisualStyleBackColor = true;
            this.AssociatedPartsSearchButton.Click += new System.EventHandler(this.AssociatedPartsSearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(934, 503);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(61, 30);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1001, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(61, 30);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 548);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AssociatedPartsPanel);
            this.Controls.Add(this.CandidatePartsPanel);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InventoryTextbox);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.ID_Textbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.AddProductLabel);
            this.Name = "AddProductScreen";
            this.Text = "Products";
            this.CandidatePartsPanel.ResumeLayout(false);
            this.CandidatePartsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsDataGrid)).EndInit();
            this.AssociatedPartsPanel.ResumeLayout(false);
            this.AssociatedPartsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InventoryTextbox;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Panel CandidatePartsPanel;
        private System.Windows.Forms.DataGridView CandidatePartsDataGrid;
        private System.Windows.Forms.Label CandidatePartsLabel;
        private System.Windows.Forms.TextBox CandidatePartsTextbox;
        private System.Windows.Forms.Button CandidatePartsSearchButton;
        private System.Windows.Forms.Button CandidatePartsAddButton;
        private System.Windows.Forms.Panel AssociatedPartsPanel;
        private System.Windows.Forms.Button AssociatedPartsDeleteButton;
        private System.Windows.Forms.DataGridView AssociatedPartsDataGrid;
        private System.Windows.Forms.Label AssociatedPartsLabel;
        private System.Windows.Forms.TextBox AssociatedPartsTextbox;
        private System.Windows.Forms.Button AssociatedPartsSearchButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}