namespace View
{
    partial class DeleteFrom
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPersonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPersonDelete
            // 
            this.btnPersonDelete.Location = new System.Drawing.Point(134, 87);
            this.btnPersonDelete.Name = "btnPersonDelete";
            this.btnPersonDelete.Size = new System.Drawing.Size(111, 23);
            this.btnPersonDelete.TabIndex = 3;
            this.btnPersonDelete.Text = "Person Delete";
            this.btnPersonDelete.UseVisualStyleBackColor = true;
            this.btnPersonDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Person Id :";
            // 
            // txtPersonDelete
            // 
            this.txtPersonDelete.Location = new System.Drawing.Point(109, 38);
            this.txtPersonDelete.Name = "txtPersonDelete";
            this.txtPersonDelete.Size = new System.Drawing.Size(165, 23);
            this.txtPersonDelete.TabIndex = 5;
            // 
            // DeleteFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(353, 162);
            this.Controls.Add(this.txtPersonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonDelete);
            this.Controls.Add(this.btnClose);
            this.Name = "DeleteFrom";
            this.Text = "DeleteFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClose;
        private Button btnPersonDelete;
        private Label label2;
        private TextBox txtPersonDelete;
    }
}