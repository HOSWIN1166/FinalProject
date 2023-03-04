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
            this.txtProductDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPersonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonDelete = new System.Windows.Forms.TextBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductDelete
            // 
            this.txtProductDelete.Location = new System.Drawing.Point(425, 38);
            this.txtProductDelete.Name = "txtProductDelete";
            this.txtProductDelete.Size = new System.Drawing.Size(165, 23);
            this.txtProductDelete.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id :";
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
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(458, 87);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(110, 23);
            this.btnProductDelete.TabIndex = 6;
            this.btnProductDelete.Text = "Product Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // DeleteFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(634, 162);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.txtPersonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductDelete);
            this.Name = "DeleteFrom";
            this.Text = "DeleteFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtProductDelete;
        private Label label1;
        private Button btnClose;
        private Button btnPersonDelete;
        private Label label2;
        private TextBox txtPersonDelete;
        private Button btnProductDelete;
    }
}