namespace View
{
    partial class MainPage
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
            this.btnPersonMain = new System.Windows.Forms.Button();
            this.btnProductMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonMain
            // 
            this.btnPersonMain.Location = new System.Drawing.Point(66, 43);
            this.btnPersonMain.Name = "btnPersonMain";
            this.btnPersonMain.Size = new System.Drawing.Size(75, 68);
            this.btnPersonMain.TabIndex = 0;
            this.btnPersonMain.Text = "Person Page";
            this.btnPersonMain.UseVisualStyleBackColor = true;
            this.btnPersonMain.Click += new System.EventHandler(this.btnPersonMain_Click);
            // 
            // btnProductMain
            // 
            this.btnProductMain.Location = new System.Drawing.Point(221, 43);
            this.btnProductMain.Name = "btnProductMain";
            this.btnProductMain.Size = new System.Drawing.Size(75, 68);
            this.btnProductMain.TabIndex = 1;
            this.btnProductMain.Text = "Product Page";
            this.btnProductMain.UseVisualStyleBackColor = true;
            this.btnProductMain.Click += new System.EventHandler(this.btnProductMain_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 157);
            this.Controls.Add(this.btnProductMain);
            this.Controls.Add(this.btnPersonMain);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPersonMain;
        private Button btnProductMain;
    }
}