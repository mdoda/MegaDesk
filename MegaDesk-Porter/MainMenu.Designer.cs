namespace MegaDesk_Porter
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BtnNewQuote = new System.Windows.Forms.Button();
            this.BtnViewQuotes = new System.Windows.Forms.Button();
            this.BtnSearchQuotes = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewQuote
            // 
            this.BtnNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewQuote.Location = new System.Drawing.Point(55, 38);
            this.BtnNewQuote.Name = "BtnNewQuote";
            this.BtnNewQuote.Size = new System.Drawing.Size(169, 77);
            this.BtnNewQuote.TabIndex = 0;
            this.BtnNewQuote.Text = "Add New Quote";
            this.BtnNewQuote.UseVisualStyleBackColor = true;
            this.BtnNewQuote.Click += new System.EventHandler(this.BtnNewQuote_Click);
            // 
            // BtnViewQuotes
            // 
            this.BtnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewQuotes.Location = new System.Drawing.Point(55, 132);
            this.BtnViewQuotes.Name = "BtnViewQuotes";
            this.BtnViewQuotes.Size = new System.Drawing.Size(169, 77);
            this.BtnViewQuotes.TabIndex = 1;
            this.BtnViewQuotes.Text = "View Quotes";
            this.BtnViewQuotes.UseVisualStyleBackColor = true;
            this.BtnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes_Click);
            // 
            // BtnSearchQuotes
            // 
            this.BtnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchQuotes.Location = new System.Drawing.Point(55, 224);
            this.BtnSearchQuotes.Name = "BtnSearchQuotes";
            this.BtnSearchQuotes.Size = new System.Drawing.Size(169, 77);
            this.BtnSearchQuotes.TabIndex = 2;
            this.BtnSearchQuotes.Text = "Search Quotes";
            this.BtnSearchQuotes.UseVisualStyleBackColor = true;
            this.BtnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(55, 320);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(169, 77);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 275);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSearchQuotes);
            this.Controls.Add(this.BtnViewQuotes);
            this.Controls.Add(this.BtnNewQuote);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewQuote;
        private System.Windows.Forms.Button BtnViewQuotes;
        private System.Windows.Forms.Button BtnSearchQuotes;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}