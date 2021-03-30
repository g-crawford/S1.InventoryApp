
namespace C968___Inventory_Application
{
    partial class ModifyProductScreen
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AssociatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.AssociatedPartsLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsTextbox = new System.Windows.Forms.TextBox();
            this.AssociatedPartsSearchButton = new System.Windows.Forms.Button();
            this.AssociatedPartsPanel = new System.Windows.Forms.Panel();
            this.AssociatedPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.CandidatePartsAddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CandidatePartsPanel = new System.Windows.Forms.Panel();
            this.CandidatePartsDataGrid = new System.Windows.Forms.DataGridView();
            this.CandidatePartsLabel = new System.Windows.Forms.Label();
            this.CandidatePartsTextbox = new System.Windows.Forms.TextBox();
            this.CandidatePartsSearchButton = new System.Windows.Forms.Button();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.InventoryTextbox = new System.Windows.Forms.TextBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).BeginInit();
            this.CandidatePartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1002, 506);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(61, 30);
            this.CancelButton.TabIndex = 35;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AssociatedPartsDeleteButton
            // 
            this.AssociatedPartsDeleteButton.Location = new System.Drawing.Point(598, 209);
            this.AssociatedPartsDeleteButton.Name = "AssociatedPartsDeleteButton";
            this.AssociatedPartsDeleteButton.Size = new System.Drawing.Size(52, 24);
            this.AssociatedPartsDeleteButton.TabIndex = 4;
            this.AssociatedPartsDeleteButton.Text = "Delete";
            this.AssociatedPartsDeleteButton.UseVisualStyleBackColor = true;
            this.AssociatedPartsDeleteButton.Click += new System.EventHandler(this.AssociatedPartsDeleteButton_Click);
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
            this.AssociatedPartsTextbox.Location = new System.Drawing.Point(460, 5);
            this.AssociatedPartsTextbox.Name = "AssociatedPartsTextbox";
            this.AssociatedPartsTextbox.Size = new System.Drawing.Size(190, 20);
            this.AssociatedPartsTextbox.TabIndex = 1;
            // 
            // AssociatedPartsSearchButton
            // 
            this.AssociatedPartsSearchButton.Location = new System.Drawing.Point(397, 5);
            this.AssociatedPartsSearchButton.Name = "AssociatedPartsSearchButton";
            this.AssociatedPartsSearchButton.Size = new System.Drawing.Size(57, 21);
            this.AssociatedPartsSearchButton.TabIndex = 0;
            this.AssociatedPartsSearchButton.Text = "Search";
            this.AssociatedPartsSearchButton.UseVisualStyleBackColor = true;
            this.AssociatedPartsSearchButton.Click += new System.EventHandler(this.AssociatedPartsSearchButton_Click);
            // 
            // AssociatedPartsPanel
            // 
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsDeleteButton);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsDataGrid);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsLabel);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsTextbox);
            this.AssociatedPartsPanel.Controls.Add(this.AssociatedPartsSearchButton);
            this.AssociatedPartsPanel.Location = new System.Drawing.Point(413, 264);
            this.AssociatedPartsPanel.Name = "AssociatedPartsPanel";
            this.AssociatedPartsPanel.Size = new System.Drawing.Size(664, 236);
            this.AssociatedPartsPanel.TabIndex = 33;
            // 
            // AssociatedPartsDataGrid
            // 
            this.AssociatedPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsDataGrid.Location = new System.Drawing.Point(6, 31);
            this.AssociatedPartsDataGrid.Name = "AssociatedPartsDataGrid";
            this.AssociatedPartsDataGrid.Size = new System.Drawing.Size(644, 172);
            this.AssociatedPartsDataGrid.TabIndex = 3;
            this.AssociatedPartsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataGrid_CellContentClick);
            // 
            // CandidatePartsAddButton
            // 
            this.CandidatePartsAddButton.Location = new System.Drawing.Point(598, 209);
            this.CandidatePartsAddButton.Name = "CandidatePartsAddButton";
            this.CandidatePartsAddButton.Size = new System.Drawing.Size(52, 24);
            this.CandidatePartsAddButton.TabIndex = 4;
            this.CandidatePartsAddButton.Text = "Add";
            this.CandidatePartsAddButton.UseVisualStyleBackColor = true;
            this.CandidatePartsAddButton.Click += new System.EventHandler(this.CandidatePartsAddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(935, 506);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(61, 30);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CandidatePartsPanel
            // 
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsAddButton);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsDataGrid);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsLabel);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsTextbox);
            this.CandidatePartsPanel.Controls.Add(this.CandidatePartsSearchButton);
            this.CandidatePartsPanel.Location = new System.Drawing.Point(413, 19);
            this.CandidatePartsPanel.Name = "CandidatePartsPanel";
            this.CandidatePartsPanel.Size = new System.Drawing.Size(664, 236);
            this.CandidatePartsPanel.TabIndex = 32;
            // 
            // CandidatePartsDataGrid
            // 
            this.CandidatePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatePartsDataGrid.Location = new System.Drawing.Point(6, 31);
            this.CandidatePartsDataGrid.Name = "CandidatePartsDataGrid";
            this.CandidatePartsDataGrid.Size = new System.Drawing.Size(644, 172);
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
            this.CandidatePartsTextbox.Location = new System.Drawing.Point(460, 4);
            this.CandidatePartsTextbox.Name = "CandidatePartsTextbox";
            this.CandidatePartsTextbox.Size = new System.Drawing.Size(190, 20);
            this.CandidatePartsTextbox.TabIndex = 1;
            // 
            // CandidatePartsSearchButton
            // 
            this.CandidatePartsSearchButton.Location = new System.Drawing.Point(397, 3);
            this.CandidatePartsSearchButton.Name = "CandidatePartsSearchButton";
            this.CandidatePartsSearchButton.Size = new System.Drawing.Size(57, 21);
            this.CandidatePartsSearchButton.TabIndex = 0;
            this.CandidatePartsSearchButton.Text = "Search";
            this.CandidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.CandidatePartsSearchButton.Click += new System.EventHandler(this.CandidatePartsSearchButton_Click);
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(101, 295);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(72, 20);
            this.MinTextbox.TabIndex = 31;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(229, 295);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(72, 20);
            this.MaxTextbox.TabIndex = 29;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(71, 298);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 30;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(196, 298);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 28;
            this.MaxLabel.Text = "Max";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(130, 252);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(123, 20);
            this.PriceTextbox.TabIndex = 27;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(68, 255);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 26;
            this.PriceLabel.Text = "Price";
            // 
            // InventoryTextbox
            // 
            this.InventoryTextbox.Location = new System.Drawing.Point(130, 213);
            this.InventoryTextbox.Name = "InventoryTextbox";
            this.InventoryTextbox.Size = new System.Drawing.Size(123, 20);
            this.InventoryTextbox.TabIndex = 25;
            this.InventoryTextbox.TextChanged += new System.EventHandler(this.InventoryTextbox_TextChanged);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(48, 216);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 24;
            this.InventoryLabel.Text = "Inventory";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(130, 173);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(123, 20);
            this.NameTextbox.TabIndex = 23;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Location = new System.Drawing.Point(130, 135);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(123, 20);
            this.ID_Textbox.TabIndex = 22;
            this.ID_Textbox.TextChanged += new System.EventHandler(this.ID_Textbox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 176);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Name";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(81, 138);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 20;
            this.ID_Label.Text = "ID";
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(25, 19);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(114, 20);
            this.ModifyProductLabel.TabIndex = 19;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 548);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AssociatedPartsPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CandidatePartsPanel);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InventoryTextbox);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.ID_Textbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.ModifyProductLabel);
            this.Name = "ModifyProductScreen";
            this.Text = "Products";
            this.AssociatedPartsPanel.ResumeLayout(false);
            this.AssociatedPartsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).EndInit();
            this.CandidatePartsPanel.ResumeLayout(false);
            this.CandidatePartsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AssociatedPartsDeleteButton;
        private System.Windows.Forms.Label AssociatedPartsLabel;
        private System.Windows.Forms.TextBox AssociatedPartsTextbox;
        private System.Windows.Forms.Button AssociatedPartsSearchButton;
        private System.Windows.Forms.Panel AssociatedPartsPanel;
        private System.Windows.Forms.Button CandidatePartsAddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel CandidatePartsPanel;
        private System.Windows.Forms.Label CandidatePartsLabel;
        private System.Windows.Forms.TextBox CandidatePartsTextbox;
        private System.Windows.Forms.Button CandidatePartsSearchButton;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox InventoryTextbox;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.DataGridView AssociatedPartsDataGrid;
        private System.Windows.Forms.DataGridView CandidatePartsDataGrid;
    }
}