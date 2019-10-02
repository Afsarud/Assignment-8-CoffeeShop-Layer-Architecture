namespace CoffeeShopWindowsFormsApp
{
    partial class OrderUi
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
            this.components = new System.ComponentModel.Container();
            this.customerInformationgroupBox = new System.Windows.Forms.GroupBox();
            this.showTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerInformationgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInformationgroupBox
            // 
            this.customerInformationgroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerInformationgroupBox.Controls.Add(this.showTotalPriceTextBox);
            this.customerInformationgroupBox.Controls.Add(this.quantityNumericUpDown);
            this.customerInformationgroupBox.Controls.Add(this.customerNameComboBox);
            this.customerInformationgroupBox.Controls.Add(this.itemComboBox);
            this.customerInformationgroupBox.Controls.Add(this.label1);
            this.customerInformationgroupBox.Controls.Add(this.quantityLabel);
            this.customerInformationgroupBox.Controls.Add(this.addButton);
            this.customerInformationgroupBox.Controls.Add(this.orderLabel);
            this.customerInformationgroupBox.Controls.Add(this.customerNameLabel);
            this.customerInformationgroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformationgroupBox.Location = new System.Drawing.Point(254, 38);
            this.customerInformationgroupBox.Name = "customerInformationgroupBox";
            this.customerInformationgroupBox.Size = new System.Drawing.Size(341, 264);
            this.customerInformationgroupBox.TabIndex = 0;
            this.customerInformationgroupBox.TabStop = false;
            this.customerInformationgroupBox.Text = "Order Information";
            // 
            // showTotalPriceTextBox
            // 
            this.showTotalPriceTextBox.Location = new System.Drawing.Point(129, 170);
            this.showTotalPriceTextBox.Name = "showTotalPriceTextBox";
            this.showTotalPriceTextBox.Size = new System.Drawing.Size(173, 30);
            this.showTotalPriceTextBox.TabIndex = 12;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(129, 133);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(173, 30);
            this.quantityNumericUpDown.TabIndex = 9;
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Name", true));
            this.customerNameComboBox.DataSource = this.customerBindingSource;
            this.customerNameComboBox.DisplayMember = "Name";
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(129, 44);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(173, 30);
            this.customerNameComboBox.TabIndex = 8;
            this.customerNameComboBox.ValueMember = "Id";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CoffeeShop.Model.Customer);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(129, 88);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(173, 30);
            this.itemComboBox.TabIndex = 7;
            this.itemComboBox.ValueMember = "Id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(CoffeeShop.Model.Item);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(22, 135);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(87, 22);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity :";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(129, 214);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 32);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Save";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(22, 91);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(55, 22);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Item :";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(22, 52);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(91, 22);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer:";
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(6, 21);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.RowTemplate.Height = 24;
            this.showDataGridView.Size = new System.Drawing.Size(862, 210);
            this.showDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(28, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 249);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All order";
            // 
            // OrderUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(905, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerInformationgroupBox);
            this.MaximizeBox = false;
            this.Name = "OrderUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderUi_Load);
            this.customerInformationgroupBox.ResumeLayout(false);
            this.customerInformationgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInformationgroupBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox showTotalPriceTextBox;
        private System.Windows.Forms.Label label1;
    }
}

