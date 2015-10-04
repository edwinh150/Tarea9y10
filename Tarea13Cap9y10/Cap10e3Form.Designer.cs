namespace Tarea13Cap9y10
{
    partial class Cap10e3Form
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
            this.NtextBox = new System.Windows.Forms.TextBox();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.Mbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NtextBox
            // 
            this.NtextBox.Location = new System.Drawing.Point(75, 100);
            this.NtextBox.Name = "NtextBox";
            this.NtextBox.Size = new System.Drawing.Size(100, 20);
            this.NtextBox.TabIndex = 0;
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(75, 226);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(100, 20);
            this.RtextBox.TabIndex = 0;
            // 
            // Mbutton
            // 
            this.Mbutton.Location = new System.Drawing.Point(252, 154);
            this.Mbutton.Name = "Mbutton";
            this.Mbutton.Size = new System.Drawing.Size(75, 23);
            this.Mbutton.TabIndex = 1;
            this.Mbutton.Text = "button1";
            this.Mbutton.UseVisualStyleBackColor = true;
            this.Mbutton.Click += new System.EventHandler(this.Mbutton_Click);
            // 
            // Cap10e3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 350);
            this.Controls.Add(this.Mbutton);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.NtextBox);
            this.Name = "Cap10e3Form";
            this.Text = "Cap10e3Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NtextBox;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.Button Mbutton;
    }
}