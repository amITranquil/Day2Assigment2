namespace ThreadingDemo
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
            this.btnProcess1 = new Syncfusion.WinForms.Controls.SfButton();
            this.btnProcess2 = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // btnProcess1
            // 
            this.btnProcess1.AccessibleName = "Button";
            this.btnProcess1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnProcess1.Location = new System.Drawing.Point(58, 52);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(159, 58);
            this.btnProcess1.TabIndex = 0;
            this.btnProcess1.Text = "Process1";
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.AccessibleName = "Button";
            this.btnProcess2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnProcess2.Location = new System.Drawing.Point(260, 52);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(163, 47);
            this.btnProcess2.TabIndex = 1;
            this.btnProcess2.Text = "Process2";
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.btnProcess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnProcess1;
        private Syncfusion.WinForms.Controls.SfButton btnProcess2;
    }
}

