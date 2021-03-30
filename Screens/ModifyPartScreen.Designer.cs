
namespace C968___Inventory_Application
{
    partial class ModifyPartScreen
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.IO_Label = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.IO_Textbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.PriceCostTextbox = new System.Windows.Forms.TextBox();
            this.InventoryTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(326, 226);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 32);
            this.CancelButton.TabIndex = 37;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(244, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(67, 32);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IO_Label
            // 
            this.IO_Label.AutoSize = true;
            this.IO_Label.Location = new System.Drawing.Point(81, 190);
            this.IO_Label.Name = "IO_Label";
            this.IO_Label.Size = new System.Drawing.Size(62, 13);
            this.IO_Label.TabIndex = 35;
            this.IO_Label.Text = "Machine ID";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(104, 164);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 34;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(251, 164);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 33;
            this.MaxLabel.Text = "Max";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Location = new System.Drawing.Point(81, 138);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(63, 13);
            this.PriceCostLabel.TabIndex = 32;
            this.PriceCostLabel.Text = "Price / Cost";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(93, 112);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 31;
            this.InventoryLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(109, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Name";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(126, 60);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 29;
            this.ID_Label.Text = "ID";
            // 
            // IO_Textbox
            // 
            this.IO_Textbox.Location = new System.Drawing.Point(181, 187);
            this.IO_Textbox.Name = "IO_Textbox";
            this.IO_Textbox.Size = new System.Drawing.Size(169, 20);
            this.IO_Textbox.TabIndex = 28;
            this.IO_Textbox.TextChanged += new System.EventHandler(this.IO_Textbox_TextChanged);
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(143, 161);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(87, 20);
            this.MinTextbox.TabIndex = 27;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(306, 161);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(99, 20);
            this.MaxTextbox.TabIndex = 26;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // PriceCostTextbox
            // 
            this.PriceCostTextbox.Location = new System.Drawing.Point(181, 135);
            this.PriceCostTextbox.Name = "PriceCostTextbox";
            this.PriceCostTextbox.Size = new System.Drawing.Size(169, 20);
            this.PriceCostTextbox.TabIndex = 25;
            this.PriceCostTextbox.TextChanged += new System.EventHandler(this.PriceCostTextbox_TextChanged);
            // 
            // InventoryTextbox
            // 
            this.InventoryTextbox.Location = new System.Drawing.Point(181, 109);
            this.InventoryTextbox.Name = "InventoryTextbox";
            this.InventoryTextbox.Size = new System.Drawing.Size(169, 20);
            this.InventoryTextbox.TabIndex = 24;
            this.InventoryTextbox.TextChanged += new System.EventHandler(this.InventoryTextbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(181, 83);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(169, 20);
            this.NameTextbox.TabIndex = 23;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Location = new System.Drawing.Point(181, 57);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(169, 20);
            this.ID_Textbox.TabIndex = 22;
            this.ID_Textbox.TextChanged += new System.EventHandler(this.ID_Textbox_TextChanged);
            // 
            // OutsourcedRadioButton
            // 
            this.OutsourcedRadioButton.AutoSize = true;
            this.OutsourcedRadioButton.Location = new System.Drawing.Point(270, 16);
            this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            this.OutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadioButton.TabIndex = 21;
            this.OutsourcedRadioButton.Text = "Outsourced";
            this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.OutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Checked = true;
            this.InHouseRadioButton.Location = new System.Drawing.Point(162, 16);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadioButton.TabIndex = 20;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(17, 13);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(88, 20);
            this.ModifyPartLabel.TabIndex = 19;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.IO_Label);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceCostLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.IO_Textbox);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.PriceCostTextbox);
            this.Controls.Add(this.InventoryTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.ID_Textbox);
            this.Controls.Add(this.OutsourcedRadioButton);
            this.Controls.Add(this.InHouseRadioButton);
            this.Controls.Add(this.ModifyPartLabel);
            this.Name = "ModifyPartScreen";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label IO_Label;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox IO_Textbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.TextBox PriceCostTextbox;
        private System.Windows.Forms.TextBox InventoryTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.RadioButton OutsourcedRadioButton;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
        private System.Windows.Forms.Label ModifyPartLabel;
    }
}