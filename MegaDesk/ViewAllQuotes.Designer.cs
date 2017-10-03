namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuoteDate,
            this.CustomerName,
            this.Depth,
            this.Width,
            this.NumberOfDrawers,
            this.SurfaceMaterial,
            this.DeliveryType,
            this.QuoteAmount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(938, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Date";
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.HeaderText = "Drawers";
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.ReadOnly = true;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.ReadOnly = true;
            // 
            // DeliveryType
            // 
            this.DeliveryType.HeaderText = "Delivery Type";
            this.DeliveryType.Name = "DeliveryType";
            this.DeliveryType.ReadOnly = true;
            // 
            // QuoteAmount
            // 
            this.QuoteAmount.HeaderText = "Quote Amount";
            this.QuoteAmount.Name = "QuoteAmount";
            this.QuoteAmount.ReadOnly = true;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 507);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteAmount;
    }
}