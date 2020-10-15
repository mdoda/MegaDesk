namespace MegaDesk_Porter
{
    partial class SearchQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.com1SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.CmbDelivery = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surface Material";
            // 
            // com1SurfaceMaterial
            // 
            this.com1SurfaceMaterial.FormattingEnabled = true;
            this.com1SurfaceMaterial.Location = new System.Drawing.Point(182, 64);
            this.com1SurfaceMaterial.Name = "com1SurfaceMaterial";
            this.com1SurfaceMaterial.Size = new System.Drawing.Size(183, 24);
            this.com1SurfaceMaterial.TabIndex = 2;
            this.com1SurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.com1SurfaceMaterial_SelectedIndexChanged);
            // 
            // CmbDelivery
            // 
            this.CmbDelivery.FormattingEnabled = true;
            this.CmbDelivery.Location = new System.Drawing.Point(617, 64);
            this.CmbDelivery.Name = "CmbDelivery";
            this.CmbDelivery.Size = new System.Drawing.Size(183, 24);
            this.CmbDelivery.TabIndex = 3;
            this.CmbDelivery.SelectedIndexChanged += new System.EventHandler(this.CmbDelivery_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(490, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delivery Type";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbDelivery);
            this.Controls.Add(this.com1SurfaceMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com1SurfaceMaterial;
        private System.Windows.Forms.ComboBox CmbDelivery;
        private System.Windows.Forms.Label label2;
    }
}