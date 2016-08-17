namespace AsyncExample1
{
    partial class Form1
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
            this.btnTestAsync = new System.Windows.Forms.Button();
            this.txtMessageFirst = new System.Windows.Forms.TextBox();
            this.txtMessageLast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestAsync
            // 
            this.btnTestAsync.Location = new System.Drawing.Point(60, 186);
            this.btnTestAsync.Name = "btnTestAsync";
            this.btnTestAsync.Size = new System.Drawing.Size(160, 40);
            this.btnTestAsync.TabIndex = 0;
            this.btnTestAsync.Text = "TestAsync";
            this.btnTestAsync.UseVisualStyleBackColor = true;
            this.btnTestAsync.Click += new System.EventHandler(this.btnTestAsync_Click);
            // 
            // txtMessageFirst
            // 
            this.txtMessageFirst.Location = new System.Drawing.Point(31, 34);
            this.txtMessageFirst.Name = "txtMessageFirst";
            this.txtMessageFirst.Size = new System.Drawing.Size(545, 22);
            this.txtMessageFirst.TabIndex = 1;
            // 
            // txtMessageLast
            // 
            this.txtMessageLast.Location = new System.Drawing.Point(31, 107);
            this.txtMessageLast.Name = "txtMessageLast";
            this.txtMessageLast.Size = new System.Drawing.Size(545, 22);
            this.txtMessageLast.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 253);
            this.Controls.Add(this.txtMessageLast);
            this.Controls.Add(this.txtMessageFirst);
            this.Controls.Add(this.btnTestAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestAsync;
        private System.Windows.Forms.TextBox txtMessageFirst;
        private System.Windows.Forms.TextBox txtMessageLast;
    }
}

