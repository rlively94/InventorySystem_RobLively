
namespace InventorySystem_RobLively
{
    partial class UpdateProducts
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
            this.addpartButton = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.invtextBox = new System.Windows.Forms.TextBox();
            this.instockLabel = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.mintextBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.updateproductsLabel = new System.Windows.Forms.Label();
            this.partssearchButton = new System.Windows.Forms.Button();
            this.partssearchtextBox = new System.Windows.Forms.TextBox();
            this.availpartsLabel = new System.Windows.Forms.Label();
            this.partsDGV = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.assocpartsLabel = new System.Windows.Forms.Label();
            this.assocpartsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteassocpartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocpartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addpartButton
            // 
            this.addpartButton.Location = new System.Drawing.Point(552, 233);
            this.addpartButton.Name = "addpartButton";
            this.addpartButton.Size = new System.Drawing.Size(54, 29);
            this.addpartButton.TabIndex = 36;
            this.addpartButton.Text = "Add";
            this.addpartButton.UseVisualStyleBackColor = true;
            this.addpartButton.Click += new System.EventHandler(this.addpartButton_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(100, 67);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 34;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 70);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "ID";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(100, 102);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 32;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Name";
            // 
            // invtextBox
            // 
            this.invtextBox.Location = new System.Drawing.Point(100, 135);
            this.invtextBox.Name = "invtextBox";
            this.invtextBox.Size = new System.Drawing.Size(100, 20);
            this.invtextBox.TabIndex = 30;
            this.invtextBox.TextChanged += new System.EventHandler(this.invtextBox_TextChanged);
            // 
            // instockLabel
            // 
            this.instockLabel.AutoSize = true;
            this.instockLabel.Location = new System.Drawing.Point(12, 138);
            this.instockLabel.Name = "instockLabel";
            this.instockLabel.Size = new System.Drawing.Size(51, 13);
            this.instockLabel.TabIndex = 29;
            this.instockLabel.Text = "Inventory";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(100, 168);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 20);
            this.pricetextBox.TabIndex = 28;
            this.pricetextBox.TextChanged += new System.EventHandler(this.pricetextBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 171);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(106, 212);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 26;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(12, 212);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 25;
            this.minLabel.Text = "Min";
            // 
            // mintextBox
            // 
            this.mintextBox.Location = new System.Drawing.Point(42, 205);
            this.mintextBox.Name = "mintextBox";
            this.mintextBox.Size = new System.Drawing.Size(47, 20);
            this.mintextBox.TabIndex = 24;
            this.mintextBox.TextChanged += new System.EventHandler(this.mintextBox_TextChanged);
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(154, 205);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.Size = new System.Drawing.Size(47, 20);
            this.maxtextBox.TabIndex = 23;
            this.maxtextBox.TextChanged += new System.EventHandler(this.maxtextBox_TextChanged);
            // 
            // updateproductsLabel
            // 
            this.updateproductsLabel.AutoSize = true;
            this.updateproductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateproductsLabel.Location = new System.Drawing.Point(12, 9);
            this.updateproductsLabel.Name = "updateproductsLabel";
            this.updateproductsLabel.Size = new System.Drawing.Size(147, 20);
            this.updateproductsLabel.TabIndex = 37;
            this.updateproductsLabel.Text = "Add/Modify Product";
            // 
            // partssearchButton
            // 
            this.partssearchButton.Location = new System.Drawing.Point(449, 12);
            this.partssearchButton.Name = "partssearchButton";
            this.partssearchButton.Size = new System.Drawing.Size(51, 20);
            this.partssearchButton.TabIndex = 41;
            this.partssearchButton.Text = "Search";
            this.partssearchButton.UseVisualStyleBackColor = true;
            this.partssearchButton.Click += new System.EventHandler(this.partssearchButton_Click);
            // 
            // partssearchtextBox
            // 
            this.partssearchtextBox.Location = new System.Drawing.Point(506, 12);
            this.partssearchtextBox.Name = "partssearchtextBox";
            this.partssearchtextBox.Size = new System.Drawing.Size(100, 20);
            this.partssearchtextBox.TabIndex = 40;
            this.partssearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.partssearchtextBox_KeyDown);
            // 
            // availpartsLabel
            // 
            this.availpartsLabel.AutoSize = true;
            this.availpartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.availpartsLabel.Location = new System.Drawing.Point(239, 18);
            this.availpartsLabel.Name = "availpartsLabel";
            this.availpartsLabel.Size = new System.Drawing.Size(102, 17);
            this.availpartsLabel.TabIndex = 39;
            this.availpartsLabel.Text = "Available Parts";
            // 
            // partsDGV
            // 
            this.partsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.partsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.partsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.PartName,
            this.InStock,
            this.Price,
            this.Min,
            this.Max});
            this.partsDGV.Location = new System.Drawing.Point(242, 38);
            this.partsDGV.Name = "partsDGV";
            this.partsDGV.RowHeadersWidth = 4;
            this.partsDGV.Size = new System.Drawing.Size(364, 189);
            this.partsDGV.TabIndex = 38;
            this.partsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDGV_CellClick);
            // 
            // PartId
            // 
            this.PartId.DataPropertyName = "PartId";
            this.PartId.HeaderText = "Part ID";
            this.PartId.Name = "PartId";
            this.PartId.Width = 65;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "Name";
            this.PartName.HeaderText = "Name";
            this.PartName.Name = "PartName";
            this.PartName.Width = 60;
            // 
            // InStock
            // 
            this.InStock.DataPropertyName = "InStock";
            this.InStock.HeaderText = "Inventory";
            this.InStock.Name = "InStock";
            this.InStock.Width = 76;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 56;
            // 
            // Min
            // 
            this.Min.DataPropertyName = "Min";
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.Width = 49;
            // 
            // Max
            // 
            this.Max.DataPropertyName = "Max";
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.Width = 52;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(16, 479);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(54, 29);
            this.saveButton.TabIndex = 45;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(100, 479);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(54, 29);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // assocpartsLabel
            // 
            this.assocpartsLabel.AutoSize = true;
            this.assocpartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.assocpartsLabel.Location = new System.Drawing.Point(239, 264);
            this.assocpartsLabel.Name = "assocpartsLabel";
            this.assocpartsLabel.Size = new System.Drawing.Size(114, 17);
            this.assocpartsLabel.TabIndex = 48;
            this.assocpartsLabel.Text = "Associated Parts";
            // 
            // assocpartsDGV
            // 
            this.assocpartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.assocpartsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.assocpartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assocpartsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.assocpartsDGV.Location = new System.Drawing.Point(242, 284);
            this.assocpartsDGV.Name = "assocpartsDGV";
            this.assocpartsDGV.RowHeadersWidth = 4;
            this.assocpartsDGV.Size = new System.Drawing.Size(364, 189);
            this.assocpartsDGV.TabIndex = 47;
            this.assocpartsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assocpartsDGV_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InStock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 56;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Min";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 49;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Max";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 52;
            // 
            // deleteassocpartButton
            // 
            this.deleteassocpartButton.Location = new System.Drawing.Point(552, 479);
            this.deleteassocpartButton.Name = "deleteassocpartButton";
            this.deleteassocpartButton.Size = new System.Drawing.Size(54, 29);
            this.deleteassocpartButton.TabIndex = 46;
            this.deleteassocpartButton.Text = "Delete";
            this.deleteassocpartButton.UseVisualStyleBackColor = true;
            this.deleteassocpartButton.Click += new System.EventHandler(this.deleteassocpartButton_Click);
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 520);
            this.Controls.Add(this.assocpartsLabel);
            this.Controls.Add(this.assocpartsDGV);
            this.Controls.Add(this.deleteassocpartButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.partssearchButton);
            this.Controls.Add(this.partssearchtextBox);
            this.Controls.Add(this.availpartsLabel);
            this.Controls.Add(this.partsDGV);
            this.Controls.Add(this.updateproductsLabel);
            this.Controls.Add(this.addpartButton);
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
            this.Name = "UpdateProducts";
            this.Text = "UpdateProducts";
            this.Load += new System.EventHandler(this.UpdateProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocpartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addpartButton;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox invtextBox;
        private System.Windows.Forms.Label instockLabel;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox mintextBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.Label updateproductsLabel;
        private System.Windows.Forms.Button partssearchButton;
        private System.Windows.Forms.TextBox partssearchtextBox;
        private System.Windows.Forms.Label availpartsLabel;
        private System.Windows.Forms.DataGridView partsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label assocpartsLabel;
        private System.Windows.Forms.DataGridView assocpartsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button deleteassocpartButton;
    }
}