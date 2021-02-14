
namespace InventorySystem_RobLively
{
    partial class UpdateParts
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
            this.updatepartsLabel = new System.Windows.Forms.Label();
            this.inhouseradioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedradioButton = new System.Windows.Forms.RadioButton();
            this.variableLabel = new System.Windows.Forms.Label();
            this.variabletextBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.mintextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.invtextBox = new System.Windows.Forms.TextBox();
            this.instockLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatepartsLabel
            // 
            this.updatepartsLabel.AutoSize = true;
            this.updatepartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updatepartsLabel.Location = new System.Drawing.Point(12, 9);
            this.updatepartsLabel.Name = "updatepartsLabel";
            this.updatepartsLabel.Size = new System.Drawing.Size(121, 20);
            this.updatepartsLabel.TabIndex = 0;
            this.updatepartsLabel.Text = "Add/Modify Part";
            // 
            // inhouseradioButton
            // 
            this.inhouseradioButton.AutoSize = true;
            this.inhouseradioButton.Checked = true;
            this.inhouseradioButton.Location = new System.Drawing.Point(140, 9);
            this.inhouseradioButton.Name = "inhouseradioButton";
            this.inhouseradioButton.Size = new System.Drawing.Size(68, 17);
            this.inhouseradioButton.TabIndex = 1;
            this.inhouseradioButton.TabStop = true;
            this.inhouseradioButton.Text = "In-House";
            this.inhouseradioButton.UseVisualStyleBackColor = true;
            this.inhouseradioButton.CheckedChanged += new System.EventHandler(this.inhouseradioButton_CheckedChanged);
            // 
            // outsourcedradioButton
            // 
            this.outsourcedradioButton.AutoSize = true;
            this.outsourcedradioButton.Location = new System.Drawing.Point(213, 9);
            this.outsourcedradioButton.Name = "outsourcedradioButton";
            this.outsourcedradioButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedradioButton.TabIndex = 2;
            this.outsourcedradioButton.TabStop = true;
            this.outsourcedradioButton.Text = "Outsourced";
            this.outsourcedradioButton.UseVisualStyleBackColor = true;
            this.outsourcedradioButton.CheckedChanged += new System.EventHandler(this.outsourcedradioButton_CheckedChanged);
            // 
            // variableLabel
            // 
            this.variableLabel.AutoSize = true;
            this.variableLabel.Location = new System.Drawing.Point(19, 255);
            this.variableLabel.Name = "variableLabel";
            this.variableLabel.Size = new System.Drawing.Size(62, 13);
            this.variableLabel.TabIndex = 3;
            this.variableLabel.Text = "Machine ID";
            // 
            // variabletextBox
            // 
            this.variabletextBox.Location = new System.Drawing.Point(107, 252);
            this.variabletextBox.Name = "variabletextBox";
            this.variabletextBox.Size = new System.Drawing.Size(100, 20);
            this.variabletextBox.TabIndex = 4;
            this.variabletextBox.TextChanged += new System.EventHandler(this.variabletextBox_TextChanged);
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(161, 209);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.Size = new System.Drawing.Size(47, 20);
            this.maxtextBox.TabIndex = 5;
            this.maxtextBox.TextChanged += new System.EventHandler(this.maxtextBox_TextChanged);
            // 
            // mintextBox
            // 
            this.mintextBox.Location = new System.Drawing.Point(49, 209);
            this.mintextBox.Name = "mintextBox";
            this.mintextBox.Size = new System.Drawing.Size(47, 20);
            this.mintextBox.TabIndex = 6;
            this.mintextBox.TextChanged += new System.EventHandler(this.mintextBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(19, 216);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(113, 216);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(107, 172);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 20);
            this.pricetextBox.TabIndex = 12;
            this.pricetextBox.TextChanged += new System.EventHandler(this.pricetextBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(19, 175);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // invtextBox
            // 
            this.invtextBox.Location = new System.Drawing.Point(107, 139);
            this.invtextBox.Name = "invtextBox";
            this.invtextBox.Size = new System.Drawing.Size(100, 20);
            this.invtextBox.TabIndex = 14;
            this.invtextBox.TextChanged += new System.EventHandler(this.invtextBox_TextChanged);
            // 
            // instockLabel
            // 
            this.instockLabel.AutoSize = true;
            this.instockLabel.Location = new System.Drawing.Point(19, 142);
            this.instockLabel.Name = "instockLabel";
            this.instockLabel.Size = new System.Drawing.Size(51, 13);
            this.instockLabel.TabIndex = 13;
            this.instockLabel.Text = "Inventory";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(107, 106);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 16;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(107, 71);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 18;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(19, 74);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "ID";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(54, 29);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(239, 200);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(54, 29);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // UpdateParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.invtextBox);
            this.Controls.Add(this.instockLabel);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.mintextBox);
            this.Controls.Add(this.maxtextBox);
            this.Controls.Add(this.variabletextBox);
            this.Controls.Add(this.variableLabel);
            this.Controls.Add(this.outsourcedradioButton);
            this.Controls.Add(this.inhouseradioButton);
            this.Controls.Add(this.updatepartsLabel);
            this.Name = "UpdateParts";
            this.Text = "UpdateParts";
            this.Load += new System.EventHandler(this.UpdateParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updatepartsLabel;
        private System.Windows.Forms.RadioButton inhouseradioButton;
        private System.Windows.Forms.RadioButton outsourcedradioButton;
        private System.Windows.Forms.Label variableLabel;
        private System.Windows.Forms.TextBox variabletextBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.TextBox mintextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox invtextBox;
        private System.Windows.Forms.Label instockLabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}