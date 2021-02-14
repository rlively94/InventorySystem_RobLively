
namespace InventorySystem_RobLively
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
            this.partsDGV = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partssearchtextBox = new System.Windows.Forms.TextBox();
            this.partssearchButton = new System.Windows.Forms.Button();
            this.partsdeleteButton = new System.Windows.Forms.Button();
            this.partsmodifyButton = new System.Windows.Forms.Button();
            this.partsaddButton = new System.Windows.Forms.Button();
            this.productsaddButton = new System.Windows.Forms.Button();
            this.productsmodifyButton = new System.Windows.Forms.Button();
            this.productsdeleteButton = new System.Windows.Forms.Button();
            this.productssearchButton = new System.Windows.Forms.Button();
            this.productssearchtextBox = new System.Windows.Forms.TextBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appexitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.partsDGV.Location = new System.Drawing.Point(12, 103);
            this.partsDGV.Name = "partsDGV";
            this.partsDGV.RowHeadersWidth = 4;
            this.partsDGV.Size = new System.Drawing.Size(364, 189);
            this.partsDGV.TabIndex = 0;
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(229, 20);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partsLabel.Location = new System.Drawing.Point(13, 67);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(41, 17);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts";
            // 
            // partssearchtextBox
            // 
            this.partssearchtextBox.Location = new System.Drawing.Point(276, 64);
            this.partssearchtextBox.Name = "partssearchtextBox";
            this.partssearchtextBox.Size = new System.Drawing.Size(100, 20);
            this.partssearchtextBox.TabIndex = 3;
            this.partssearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.partssearchtextBox_KeyDown);
            // 
            // partssearchButton
            // 
            this.partssearchButton.Location = new System.Drawing.Point(219, 64);
            this.partssearchButton.Name = "partssearchButton";
            this.partssearchButton.Size = new System.Drawing.Size(51, 20);
            this.partssearchButton.TabIndex = 4;
            this.partssearchButton.Text = "Search";
            this.partssearchButton.UseVisualStyleBackColor = true;
            this.partssearchButton.Click += new System.EventHandler(this.partssearchButton_Click);
            // 
            // partsdeleteButton
            // 
            this.partsdeleteButton.Location = new System.Drawing.Point(328, 298);
            this.partsdeleteButton.Name = "partsdeleteButton";
            this.partsdeleteButton.Size = new System.Drawing.Size(46, 21);
            this.partsdeleteButton.TabIndex = 5;
            this.partsdeleteButton.Text = "Delete";
            this.partsdeleteButton.UseVisualStyleBackColor = true;
            this.partsdeleteButton.Click += new System.EventHandler(this.partsdeleteButton_Click);
            // 
            // partsmodifyButton
            // 
            this.partsmodifyButton.Location = new System.Drawing.Point(276, 298);
            this.partsmodifyButton.Name = "partsmodifyButton";
            this.partsmodifyButton.Size = new System.Drawing.Size(46, 21);
            this.partsmodifyButton.TabIndex = 6;
            this.partsmodifyButton.Text = "Modify";
            this.partsmodifyButton.UseVisualStyleBackColor = true;
            this.partsmodifyButton.Click += new System.EventHandler(this.partsmodifyButton_Click);
            // 
            // partsaddButton
            // 
            this.partsaddButton.Location = new System.Drawing.Point(224, 298);
            this.partsaddButton.Name = "partsaddButton";
            this.partsaddButton.Size = new System.Drawing.Size(46, 21);
            this.partsaddButton.TabIndex = 7;
            this.partsaddButton.Text = "Add";
            this.partsaddButton.UseVisualStyleBackColor = true;
            this.partsaddButton.Click += new System.EventHandler(this.partsaddButton_Click);
            // 
            // productsaddButton
            // 
            this.productsaddButton.Location = new System.Drawing.Point(636, 298);
            this.productsaddButton.Name = "productsaddButton";
            this.productsaddButton.Size = new System.Drawing.Size(46, 21);
            this.productsaddButton.TabIndex = 14;
            this.productsaddButton.Text = "Add";
            this.productsaddButton.UseVisualStyleBackColor = true;
            this.productsaddButton.Click += new System.EventHandler(this.productsaddButton_Click);
            // 
            // productsmodifyButton
            // 
            this.productsmodifyButton.Location = new System.Drawing.Point(688, 298);
            this.productsmodifyButton.Name = "productsmodifyButton";
            this.productsmodifyButton.Size = new System.Drawing.Size(46, 21);
            this.productsmodifyButton.TabIndex = 13;
            this.productsmodifyButton.Text = "Modify";
            this.productsmodifyButton.UseVisualStyleBackColor = true;
            this.productsmodifyButton.Click += new System.EventHandler(this.productsmodifyButton_Click);
            // 
            // productsdeleteButton
            // 
            this.productsdeleteButton.Location = new System.Drawing.Point(740, 298);
            this.productsdeleteButton.Name = "productsdeleteButton";
            this.productsdeleteButton.Size = new System.Drawing.Size(46, 21);
            this.productsdeleteButton.TabIndex = 12;
            this.productsdeleteButton.Text = "Delete";
            this.productsdeleteButton.UseVisualStyleBackColor = true;
            this.productsdeleteButton.Click += new System.EventHandler(this.productsdeleteButton_Click);
            // 
            // productssearchButton
            // 
            this.productssearchButton.Location = new System.Drawing.Point(631, 64);
            this.productssearchButton.Name = "productssearchButton";
            this.productssearchButton.Size = new System.Drawing.Size(51, 20);
            this.productssearchButton.TabIndex = 11;
            this.productssearchButton.Text = "Search";
            this.productssearchButton.UseVisualStyleBackColor = true;
            this.productssearchButton.Click += new System.EventHandler(this.productssearchButton_Click);
            // 
            // productssearchtextBox
            // 
            this.productssearchtextBox.Location = new System.Drawing.Point(688, 64);
            this.productssearchtextBox.Name = "productssearchtextBox";
            this.productssearchtextBox.Size = new System.Drawing.Size(100, 20);
            this.productssearchtextBox.TabIndex = 10;
            this.productssearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productssearchtextBox_KeyDown);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productsLabel.Location = new System.Drawing.Point(425, 67);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(64, 17);
            this.productsLabel.TabIndex = 9;
            this.productsLabel.Text = "Products";
            // 
            // productsDGV
            // 
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productsDGV.Location = new System.Drawing.Point(406, 103);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.RowHeadersWidth = 4;
            this.productsDGV.Size = new System.Drawing.Size(382, 189);
            this.productsDGV.TabIndex = 8;
            this.productsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 83;
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
            // appexitButton
            // 
            this.appexitButton.Location = new System.Drawing.Point(742, 345);
            this.appexitButton.Name = "appexitButton";
            this.appexitButton.Size = new System.Drawing.Size(46, 21);
            this.appexitButton.TabIndex = 15;
            this.appexitButton.Text = "Exit";
            this.appexitButton.UseVisualStyleBackColor = true;
            this.appexitButton.Click += new System.EventHandler(this.appexitButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.appexitButton);
            this.Controls.Add(this.productsaddButton);
            this.Controls.Add(this.productsmodifyButton);
            this.Controls.Add(this.productsdeleteButton);
            this.Controls.Add(this.productssearchButton);
            this.Controls.Add(this.productssearchtextBox);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.partsaddButton);
            this.Controls.Add(this.partsmodifyButton);
            this.Controls.Add(this.partsdeleteButton);
            this.Controls.Add(this.partssearchButton);
            this.Controls.Add(this.partssearchtextBox);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.partsDGV);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox partssearchtextBox;
        private System.Windows.Forms.Button partssearchButton;
        private System.Windows.Forms.Button partsdeleteButton;
        private System.Windows.Forms.Button partsmodifyButton;
        private System.Windows.Forms.Button partsaddButton;
        private System.Windows.Forms.Button productsaddButton;
        private System.Windows.Forms.Button productsmodifyButton;
        private System.Windows.Forms.Button productsdeleteButton;
        private System.Windows.Forms.Button productssearchButton;
        private System.Windows.Forms.TextBox productssearchtextBox;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button appexitButton;
    }
}