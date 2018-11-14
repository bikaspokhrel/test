namespace App1
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
            this.Sub_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sub_Button
            // 
            this.Sub_Button.Location = new System.Drawing.Point(270, 268);
            this.Sub_Button.Name = "Sub_Button";
            this.Sub_Button.Size = new System.Drawing.Size(75, 23);
            this.Sub_Button.TabIndex = 0;
            this.Sub_Button.Text = "Submit";
            this.Sub_Button.UseVisualStyleBackColor = true;
            this.Sub_Button.Click += new System.EventHandler(this.Submit_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sub_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sub_Button;
    }
}

