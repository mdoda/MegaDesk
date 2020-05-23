namespace MegaDesk_Porter
{
    partial class DisplayQuote
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
            this.LblDelivery = new System.Windows.Forms.Label();
            this.LblSurfaceMaterial = new System.Windows.Forms.Label();
            this.LblDrawers = new System.Windows.Forms.Label();
            this.NumDrawers = new System.Windows.Forms.NumericUpDown();
            this.DimensionBox = new System.Windows.Forms.GroupBox();
            this.LblDepth = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.NumDepth = new System.Windows.Forms.NumericUpDown();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblYourQuote = new System.Windows.Forms.Label();
            this.Grpbx = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtSurfaceMaterial = new System.Windows.Forms.TextBox();
            this.TxtDelivery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).BeginInit();
            this.DimensionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            this.Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDelivery
            // 
            this.LblDelivery.AutoSize = true;
            this.LblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDelivery.Location = new System.Drawing.Point(405, 269);
            this.LblDelivery.Name = "LblDelivery";
            this.LblDelivery.Size = new System.Drawing.Size(68, 20);
            this.LblDelivery.TabIndex = 22;
            this.LblDelivery.Text = "Delivery:";
            this.LblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSurfaceMaterial
            // 
            this.LblSurfaceMaterial.AutoSize = true;
            this.LblSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurfaceMaterial.Location = new System.Drawing.Point(344, 245);
            this.LblSurfaceMaterial.Name = "LblSurfaceMaterial";
            this.LblSurfaceMaterial.Size = new System.Drawing.Size(129, 20);
            this.LblSurfaceMaterial.TabIndex = 20;
            this.LblSurfaceMaterial.Text = "Surface Material:";
            this.LblSurfaceMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDrawers
            // 
            this.LblDrawers.AutoSize = true;
            this.LblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawers.Location = new System.Drawing.Point(323, 219);
            this.LblDrawers.Name = "LblDrawers";
            this.LblDrawers.Size = new System.Drawing.Size(150, 20);
            this.LblDrawers.TabIndex = 19;
            this.LblDrawers.Text = "Number of Drawers:";
            this.LblDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumDrawers
            // 
            this.NumDrawers.Enabled = false;
            this.NumDrawers.Location = new System.Drawing.Point(479, 219);
            this.NumDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.ReadOnly = true;
            this.NumDrawers.Size = new System.Drawing.Size(40, 20);
            this.NumDrawers.TabIndex = 18;
            this.NumDrawers.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DimensionBox
            // 
            this.DimensionBox.Controls.Add(this.LblDepth);
            this.DimensionBox.Controls.Add(this.LblWidth);
            this.DimensionBox.Controls.Add(this.NumDepth);
            this.DimensionBox.Controls.Add(this.NumWidth);
            this.DimensionBox.Location = new System.Drawing.Point(73, 192);
            this.DimensionBox.Name = "DimensionBox";
            this.DimensionBox.Size = new System.Drawing.Size(214, 90);
            this.DimensionBox.TabIndex = 17;
            this.DimensionBox.TabStop = false;
            this.DimensionBox.Text = "Desk Size";
            // 
            // LblDepth
            // 
            this.LblDepth.AutoSize = true;
            this.LblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepth.Location = new System.Drawing.Point(18, 56);
            this.LblDepth.Name = "LblDepth";
            this.LblDepth.Size = new System.Drawing.Size(57, 20);
            this.LblDepth.TabIndex = 5;
            this.LblDepth.Text = "Depth:";
            this.LblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWidth.Location = new System.Drawing.Point(18, 27);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(54, 20);
            this.LblWidth.TabIndex = 4;
            this.LblWidth.Text = "Width:";
            this.LblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumDepth
            // 
            this.NumDepth.Enabled = false;
            this.NumDepth.Location = new System.Drawing.Point(84, 56);
            this.NumDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.NumDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumDepth.Name = "NumDepth";
            this.NumDepth.ReadOnly = true;
            this.NumDepth.Size = new System.Drawing.Size(120, 20);
            this.NumDepth.TabIndex = 1;
            this.NumDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // NumWidth
            // 
            this.NumWidth.Enabled = false;
            this.NumWidth.Location = new System.Drawing.Point(84, 27);
            this.NumWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.NumWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumWidth.Name = "NumWidth";
            this.NumWidth.ReadOnly = true;
            this.NumWidth.Size = new System.Drawing.Size(120, 20);
            this.NumWidth.TabIndex = 0;
            this.NumWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(215, 136);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.ReadOnly = true;
            this.TxtCustomerName.Size = new System.Drawing.Size(274, 20);
            this.TxtCustomerName.TabIndex = 16;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(81, 136);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(128, 20);
            this.LblCustomerName.TabIndex = 15;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // LblYourQuote
            // 
            this.LblYourQuote.AutoSize = true;
            this.LblYourQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYourQuote.Location = new System.Drawing.Point(253, 54);
            this.LblYourQuote.Name = "LblYourQuote";
            this.LblYourQuote.Size = new System.Drawing.Size(184, 38);
            this.LblYourQuote.TabIndex = 14;
            this.LblYourQuote.Text = "Your Quote";
            // 
            // Grpbx
            // 
            this.Grpbx.Controls.Add(this.label1);
            this.Grpbx.Controls.Add(this.TxtTotal);
            this.Grpbx.Location = new System.Drawing.Point(250, 310);
            this.Grpbx.Name = "Grpbx";
            this.Grpbx.Size = new System.Drawing.Size(200, 56);
            this.Grpbx.TabIndex = 24;
            this.Grpbx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(77, 19);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(278, 384);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(149, 40);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtSurfaceMaterial
            // 
            this.TxtSurfaceMaterial.Location = new System.Drawing.Point(479, 245);
            this.TxtSurfaceMaterial.Name = "TxtSurfaceMaterial";
            this.TxtSurfaceMaterial.ReadOnly = true;
            this.TxtSurfaceMaterial.Size = new System.Drawing.Size(130, 20);
            this.TxtSurfaceMaterial.TabIndex = 26;
            // 
            // TxtDelivery
            // 
            this.TxtDelivery.Location = new System.Drawing.Point(479, 271);
            this.TxtDelivery.Name = "TxtDelivery";
            this.TxtDelivery.ReadOnly = true;
            this.TxtDelivery.Size = new System.Drawing.Size(130, 20);
            this.TxtDelivery.TabIndex = 27;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.TxtDelivery);
            this.Controls.Add(this.TxtSurfaceMaterial);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Grpbx);
            this.Controls.Add(this.LblDelivery);
            this.Controls.Add(this.LblSurfaceMaterial);
            this.Controls.Add(this.LblDrawers);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.DimensionBox);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.LblYourQuote);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayQuote_FormClosing);
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).EndInit();
            this.DimensionBox.ResumeLayout(false);
            this.DimensionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            this.Grpbx.ResumeLayout(false);
            this.Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDelivery;
        private System.Windows.Forms.Label LblSurfaceMaterial;
        private System.Windows.Forms.Label LblDrawers;
        private System.Windows.Forms.NumericUpDown NumDrawers;
        private System.Windows.Forms.GroupBox DimensionBox;
        private System.Windows.Forms.Label LblDepth;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.NumericUpDown NumDepth;
        private System.Windows.Forms.NumericUpDown NumWidth;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblYourQuote;
        private System.Windows.Forms.GroupBox Grpbx;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSurfaceMaterial;
        private System.Windows.Forms.TextBox TxtDelivery;
    }
}