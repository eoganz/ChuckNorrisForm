namespace ChuckNorrisForm
{
    partial class MainFrm
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
            this.NewJokeBtn = new System.Windows.Forms.Button();
            this.CategoryCmb = new System.Windows.Forms.ComboBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NewJokeBtn
            // 
            this.NewJokeBtn.Location = new System.Drawing.Point(12, 12);
            this.NewJokeBtn.Name = "NewJokeBtn";
            this.NewJokeBtn.Size = new System.Drawing.Size(303, 139);
            this.NewJokeBtn.TabIndex = 0;
            this.NewJokeBtn.Text = "Get Random Joke";
            this.NewJokeBtn.UseVisualStyleBackColor = true;
            this.NewJokeBtn.Click += new System.EventHandler(this.NewJokeBtn_ClickAsync);
            // 
            // CategoryCmb
            // 
            this.CategoryCmb.FormattingEnabled = true;
            this.CategoryCmb.Location = new System.Drawing.Point(12, 167);
            this.CategoryCmb.Name = "CategoryCmb";
            this.CategoryCmb.Size = new System.Drawing.Size(301, 21);
            this.CategoryCmb.TabIndex = 3;
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(12, 203);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(301, 196);
            this.rtbResults.TabIndex = 4;
            this.rtbResults.Text = "";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 411);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.CategoryCmb);
            this.Controls.Add(this.NewJokeBtn);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewJokeBtn;
        private System.Windows.Forms.ComboBox CategoryCmb;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}

