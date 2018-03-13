namespace FibingerMikulicOdabirForme
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
            this.btnDruga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDruga
            // 
            this.btnDruga.Location = new System.Drawing.Point(70, 106);
            this.btnDruga.Name = "btnDruga";
            this.btnDruga.Size = new System.Drawing.Size(140, 23);
            this.btnDruga.TabIndex = 0;
            this.btnDruga.Text = "Druga forma";
            this.btnDruga.UseVisualStyleBackColor = true;
            this.btnDruga.Click += new System.EventHandler(this.btnDruga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDruga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDruga;
    }
}

