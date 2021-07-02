
namespace RareBookApp.Winform
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
            this.customerServiceBtn = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerServiceBtn
            // 
            this.customerServiceBtn.Location = new System.Drawing.Point(303, 89);
            this.customerServiceBtn.Name = "customerServiceBtn";
            this.customerServiceBtn.Size = new System.Drawing.Size(125, 23);
            this.customerServiceBtn.TabIndex = 0;
            this.customerServiceBtn.Text = "Customer Service";
            this.customerServiceBtn.UseVisualStyleBackColor = true;
            this.customerServiceBtn.Click += new System.EventHandler(this.customerServiceBtn_Click);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(68, 168);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.RowTemplate.Height = 25;
            this.customerDataGrid.Size = new System.Drawing.Size(717, 360);
            this.customerDataGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 666);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.customerServiceBtn);
            this.Name = "Form1";
            this.Text = "Rare Book Store";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerServiceBtn;
        private System.Windows.Forms.DataGridView customerDataGrid;
    }
}

