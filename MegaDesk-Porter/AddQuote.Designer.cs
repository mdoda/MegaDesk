namespace MegaDesk_Porter
{
    partial class AddQuote
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
            this.LblAddNewQuote = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.DimensionBox = new System.Windows.Forms.GroupBox();
            this.LblDepth = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.NumDepth = new System.Windows.Forms.NumericUpDown();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.NumDrawers = new System.Windows.Forms.NumericUpDown();
            this.LblDrawers = new System.Windows.Forms.Label();
            this.LblSurfaceMaterial = new System.Windows.Forms.Label();
            this.CmbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.LblDelivery = new System.Windows.Forms.Label();
            this.CmbDelivery = new System.Windows.Forms.ComboBox();
            this.BtnGetQuote = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DimensionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddNewQuote
            // 
            this.LblAddNewQuote.AutoSize = true;
            this.LblAddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNewQuote.Location = new System.Drawing.Point(291, 23);
            this.LblAddNewQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddNewQuote.Name = "LblAddNewQuote";
            this.LblAddNewQuote.Size = new System.Drawing.Size(313, 48);
            this.LblAddNewQuote.TabIndex = 0;
            this.LblAddNewQuote.Text = "Add New Quote";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(93, 127);
            this.LblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(160, 25);
            this.LblCustomerName.TabIndex = 1;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(272, 127);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(364, 22);
            this.TxtCustomerName.TabIndex = 2;
            // 
            // DimensionBox
            // 
            this.DimensionBox.Controls.Add(this.LblDepth);
            this.DimensionBox.Controls.Add(this.LblWidth);
            this.DimensionBox.Controls.Add(this.NumDepth);
            this.DimensionBox.Controls.Add(this.NumWidth);
            this.DimensionBox.Location = new System.Drawing.Point(83, 196);
            this.DimensionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionBox.Name = "DimensionBox";
            this.DimensionBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionBox.Size = new System.Drawing.Size(285, 111);
            this.DimensionBox.TabIndex = 3;
            this.DimensionBox.TabStop = false;
            this.DimensionBox.Text = "Desk Size";
            // 
            // LblDepth
            // 
            this.LblDepth.AutoSize = true;
            this.LblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepth.Location = new System.Drawing.Point(24, 69);
            this.LblDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDepth.Name = "LblDepth";
            this.LblDepth.Size = new System.Drawing.Size(70, 25);
            this.LblDepth.TabIndex = 5;
            this.LblDepth.Text = "Depth:";
            this.LblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWidth.Location = new System.Drawing.Point(24, 33);
            this.LblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(69, 25);
            this.LblWidth.TabIndex = 4;
            this.LblWidth.Text = "Width:";
            this.LblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumDepth
            // 
            this.NumDepth.Location = new System.Drawing.Point(112, 69);
            this.NumDepth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NumDepth.Size = new System.Drawing.Size(160, 22);
            this.NumDepth.TabIndex = 1;
            this.NumDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // NumWidth
            // 
            this.NumWidth.Location = new System.Drawing.Point(112, 33);
            this.NumWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NumWidth.Size = new System.Drawing.Size(160, 22);
            this.NumWidth.TabIndex = 0;
            this.NumWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // NumDrawers
            // 
            this.NumDrawers.Location = new System.Drawing.Point(624, 229);
            this.NumDrawers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.Size = new System.Drawing.Size(53, 22);
            this.NumDrawers.TabIndex = 6;
            this.NumDrawers.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LblDrawers
            // 
            this.LblDrawers.AutoSize = true;
            this.LblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawers.Location = new System.Drawing.Point(416, 229);
            this.LblDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDrawers.Name = "LblDrawers";
            this.LblDrawers.Size = new System.Drawing.Size(185, 25);
            this.LblDrawers.TabIndex = 7;
            this.LblDrawers.Text = "Number of Drawers:";
            this.LblDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSurfaceMaterial
            // 
            this.LblSurfaceMaterial.AutoSize = true;
            this.LblSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurfaceMaterial.Location = new System.Drawing.Point(444, 261);
            this.LblSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurfaceMaterial.Name = "LblSurfaceMaterial";
            this.LblSurfaceMaterial.Size = new System.Drawing.Size(160, 25);
            this.LblSurfaceMaterial.TabIndex = 8;
            this.LblSurfaceMaterial.Text = "Surface Material:";
            this.LblSurfaceMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbSurfaceMaterial
            // 
            this.CmbSurfaceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSurfaceMaterial.FormattingEnabled = true;
            this.CmbSurfaceMaterial.Location = new System.Drawing.Point(624, 260);
            this.CmbSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbSurfaceMaterial.Name = "CmbSurfaceMaterial";
            this.CmbSurfaceMaterial.Size = new System.Drawing.Size(192, 24);
            this.CmbSurfaceMaterial.TabIndex = 9;
            // 
            // LblDelivery
            // 
            this.LblDelivery.AutoSize = true;
            this.LblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDelivery.Location = new System.Drawing.Point(525, 290);
            this.LblDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDelivery.Name = "LblDelivery";
            this.LblDelivery.Size = new System.Drawing.Size(88, 25);
            this.LblDelivery.TabIndex = 10;
            this.LblDelivery.Text = "Delivery:";
            this.LblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbDelivery
            // 
            this.CmbDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDelivery.FormattingEnabled = true;
            this.CmbDelivery.Items.AddRange(new object[] {
            "3-Day Rush",
            "5-Day Rush",
            "7-Day Rush",
            "No Rush (~14 days)"});
            this.CmbDelivery.Location = new System.Drawing.Point(624, 293);
            this.CmbDelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbDelivery.Name = "CmbDelivery";
            this.CmbDelivery.Size = new System.Drawing.Size(192, 24);
            this.CmbDelivery.TabIndex = 11;
            // 
            // BtnGetQuote
            // 
            this.BtnGetQuote.Location = new System.Drawing.Point(225, 362);
            this.BtnGetQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGetQuote.Name = "BtnGetQuote";
            this.BtnGetQuote.Size = new System.Drawing.Size(172, 53);
            this.BtnGetQuote.TabIndex = 12;
            this.BtnGetQuote.Text = "Get Quote";
            this.BtnGetQuote.UseVisualStyleBackColor = true;
            this.BtnGetQuote.Click += new System.EventHandler(this.BtnGetQuote_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(487, 362);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(172, 53);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 475);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnGetQuote);
            this.Controls.Add(this.CmbDelivery);
            this.Controls.Add(this.LblDelivery);
            this.Controls.Add(this.CmbSurfaceMaterial);
            this.Controls.Add(this.LblSurfaceMaterial);
            this.Controls.Add(this.LblDrawers);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.DimensionBox);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.LblAddNewQuote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddQuote";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.DimensionBox.ResumeLayout(false);
            this.DimensionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddNewQuote;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.GroupBox DimensionBox;
        private System.Windows.Forms.Label LblDepth;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.NumericUpDown NumDepth;
        private System.Windows.Forms.NumericUpDown NumWidth;
        private System.Windows.Forms.NumericUpDown NumDrawers;
        private System.Windows.Forms.Label LblDrawers;
        private System.Windows.Forms.Label LblSurfaceMaterial;
        private System.Windows.Forms.ComboBox CmbSurfaceMaterial;
        private System.Windows.Forms.Label LblDelivery;
        private System.Windows.Forms.ComboBox CmbDelivery;
        private System.Windows.Forms.Button BtnGetQuote;
        private System.Windows.Forms.Button BtnCancel;
    }
}

