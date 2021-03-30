
namespace C968___Inventory_Application
{
    partial class AddPartScreen
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
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.OutsorcedRadioButton = new System.Windows.Forms.RadioButton();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InventoryTextbox = new System.Windows.Forms.TextBox();
            this.PriceCostTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.IO_Textbox = new System.Windows.Forms.TextBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.IO_Label = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(16, 12);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(71, 20);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Checked = true;
            this.InHouseRadioButton.Location = new System.Drawing.Point(161, 15);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadioButton.TabIndex = 1;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // OutsorcedRadioButton
            // 
            this.OutsorcedRadioButton.AutoSize = true;
            this.OutsorcedRadioButton.Location = new System.Drawing.Point(269, 15);
            this.OutsorcedRadioButton.Name = "OutsorcedRadioButton";
            this.OutsorcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.OutsorcedRadioButton.TabIndex = 2;
            this.OutsorcedRadioButton.Text = "Outsourced";
            this.OutsorcedRadioButton.UseVisualStyleBackColor = true;
            this.OutsorcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsorcedRadioButton_CheckedChanged);
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.ID_Textbox.Location = new System.Drawing.Point(180, 56);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(169, 20);
            this.ID_Textbox.TabIndex = 3;
            this.ID_Textbox.TextChanged += new System.EventHandler(this.ID_Textbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextbox.Location = new System.Drawing.Point(180, 82);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(169, 20);
            this.NameTextbox.TabIndex = 4;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // InventoryTextbox
            // 
            this.InventoryTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.InventoryTextbox.Location = new System.Drawing.Point(180, 108);
            this.InventoryTextbox.Name = "InventoryTextbox";
            this.InventoryTextbox.Size = new System.Drawing.Size(169, 20);
            this.InventoryTextbox.TabIndex = 5;
            this.InventoryTextbox.TextChanged += new System.EventHandler(this.InventoryTextbox_TextChanged);
            // 
            // PriceCostTextbox
            // 
            this.PriceCostTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.PriceCostTextbox.Location = new System.Drawing.Point(180, 134);
            this.PriceCostTextbox.Name = "PriceCostTextbox";
            this.PriceCostTextbox.Size = new System.Drawing.Size(169, 20);
            this.PriceCostTextbox.TabIndex = 6;
            this.PriceCostTextbox.TextChanged += new System.EventHandler(this.PriceCostTextbox_TextChanged);
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.MaxTextbox.Location = new System.Drawing.Point(305, 160);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(87, 20);
            this.MaxTextbox.TabIndex = 7;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // MinTextbox
            // 
            this.MinTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.MinTextbox.Location = new System.Drawing.Point(161, 160);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(87, 20);
            this.MinTextbox.TabIndex = 8;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // IO_Textbox
            // 
            this.IO_Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.IO_Textbox.Location = new System.Drawing.Point(180, 186);
            this.IO_Textbox.Name = "IO_Textbox";
            this.IO_Textbox.Size = new System.Drawing.Size(169, 20);
            this.IO_Textbox.TabIndex = 9;
            this.IO_Textbox.TextChanged += new System.EventHandler(this.IO_Textbox_TextChanged);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(125, 59);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 10;
            this.ID_Label.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(108, 85);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(92, 111);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 12;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Location = new System.Drawing.Point(80, 137);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(63, 13);
            this.PriceCostLabel.TabIndex = 13;
            this.PriceCostLabel.Text = "Price / Cost";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(266, 163);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 14;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(122, 163);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 15;
            this.MinLabel.Text = "Min";
            // 
            // IO_Label
            // 
            this.IO_Label.AutoSize = true;
            this.IO_Label.Location = new System.Drawing.Point(80, 189);
            this.IO_Label.Name = "IO_Label";
            this.IO_Label.Size = new System.Drawing.Size(62, 13);
            this.IO_Label.TabIndex = 16;
            this.IO_Label.Text = "Machine ID";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(243, 225);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(67, 32);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(325, 225);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 32);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPartScreen
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
            this.Controls.Add(this.OutsorcedRadioButton);
            this.Controls.Add(this.InHouseRadioButton);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPartScreen";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
        private System.Windows.Forms.RadioButton OutsorcedRadioButton;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InventoryTextbox;
        private System.Windows.Forms.TextBox PriceCostTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.TextBox IO_Textbox;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label IO_Label;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}