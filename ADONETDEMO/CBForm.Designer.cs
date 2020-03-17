namespace ADONETDEMO
{
    partial class CBForm
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
            this.btnButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton1
            // 
            this.btnButton1.Location = new System.Drawing.Point(327, 119);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Size = new System.Drawing.Size(75, 23);
            this.btnButton1.TabIndex = 0;
            this.btnButton1.Text = "button1";
            this.btnButton1.UseVisualStyleBackColor = true;
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // CBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButton1);
            this.Name = "CBForm";
            this.Text = "CBForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton1;
    }
}