namespace TextFinder
{
    partial class fmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbout));
            this.bnOK = new System.Windows.Forms.Button();
            this.lbSearchedText = new System.Windows.Forms.Label();
            this.lbWordsSearched = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bnOK
            // 
            this.bnOK.Location = new System.Drawing.Point(73, 371);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(100, 23);
            this.bnOK.TabIndex = 13;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // lbSearchedText
            // 
            this.lbSearchedText.AutoSize = true;
            this.lbSearchedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchedText.Location = new System.Drawing.Point(166, 314);
            this.lbSearchedText.Name = "lbSearchedText";
            this.lbSearchedText.Size = new System.Drawing.Size(18, 20);
            this.lbSearchedText.TabIndex = 12;
            this.lbSearchedText.Text = "0";
            // 
            // lbWordsSearched
            // 
            this.lbWordsSearched.AutoSize = true;
            this.lbWordsSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordsSearched.Location = new System.Drawing.Point(28, 314);
            this.lbWordsSearched.Name = "lbWordsSearched";
            this.lbWordsSearched.Size = new System.Drawing.Size(132, 20);
            this.lbWordsSearched.TabIndex = 11;
            this.lbWordsSearched.Text = "Words Searched:";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(28, 271);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(93, 20);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "Version: 1.0";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(28, 228);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(179, 20);
            this.lbAuthor.TabIndex = 9;
            this.lbAuthor.Text = "Author: John Velazquez";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(26, 178);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(197, 31);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Text Searcher";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.InitialImage = null;
            this.pbSearch.Location = new System.Drawing.Point(55, 23);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(138, 130);
            this.pbSearch.TabIndex = 7;
            this.pbSearch.TabStop = false;
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 418);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.lbSearchedText);
            this.Controls.Add(this.lbWordsSearched);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbSearch);
            this.Name = "fmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.fmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Label lbSearchedText;
        private System.Windows.Forms.Label lbWordsSearched;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}