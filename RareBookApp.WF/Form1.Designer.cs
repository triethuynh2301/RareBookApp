
namespace RareBookApp.WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.filterSalesByComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortSalesByComboBox = new System.Windows.Forms.ComboBox();
            this.displaySalesDataBtn = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.filterValueTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter sales by:";
            // 
            // filterSalesByComboBox
            // 
            this.filterSalesByComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.filterSalesByComboBox.FormattingEnabled = true;
            this.filterSalesByComboBox.Items.AddRange(new object[] {
            "Sale Id",
            "Customer Number",
            "Sale Total Amount",
            "Sale Date"});
            this.filterSalesByComboBox.Location = new System.Drawing.Point(225, 17);
            this.filterSalesByComboBox.Name = "filterSalesByComboBox";
            this.filterSalesByComboBox.Size = new System.Drawing.Size(151, 28);
            this.filterSalesByComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort sales by:";
            // 
            // sortSalesByComboBox
            // 
            this.sortSalesByComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.sortSalesByComboBox.FormattingEnabled = true;
            this.sortSalesByComboBox.Items.AddRange(new object[] {
            "Sale Id",
            "Customer Number",
            "Sale Total Amount",
            "Sale Date"});
            this.sortSalesByComboBox.Location = new System.Drawing.Point(225, 62);
            this.sortSalesByComboBox.Name = "sortSalesByComboBox";
            this.sortSalesByComboBox.Size = new System.Drawing.Size(151, 28);
            this.sortSalesByComboBox.TabIndex = 3;
            // 
            // displaySalesDataBtn
            // 
            this.displaySalesDataBtn.AutoSize = true;
            this.displaySalesDataBtn.Location = new System.Drawing.Point(53, 160);
            this.displaySalesDataBtn.Name = "displaySalesDataBtn";
            this.displaySalesDataBtn.Size = new System.Drawing.Size(138, 30);
            this.displaySalesDataBtn.TabIndex = 4;
            this.displaySalesDataBtn.Text = "Display sales data";
            this.displaySalesDataBtn.UseVisualStyleBackColor = true;
            this.displaySalesDataBtn.Click += new System.EventHandler(this.displaySalesDataBtn_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.salesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(15, 206);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 29;
            this.salesDataGridView.Size = new System.Drawing.Size(897, 551);
            this.salesDataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter value";
            // 
            // filterValueTextBox
            // 
            this.filterValueTextBox.Location = new System.Drawing.Point(225, 115);
            this.filterValueTextBox.Name = "filterValueTextBox";
            this.filterValueTextBox.Size = new System.Drawing.Size(151, 27);
            this.filterValueTextBox.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 762);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.filterValueTextBox);
            this.tabPage1.Controls.Add(this.salesDataGridView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.filterSalesByComboBox);
            this.tabPage1.Controls.Add(this.sortSalesByComboBox);
            this.tabPage1.Controls.Add(this.displaySalesDataBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 729);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 786);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterSalesByComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortSalesByComboBox;
        private System.Windows.Forms.Button displaySalesDataBtn;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterValueTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

