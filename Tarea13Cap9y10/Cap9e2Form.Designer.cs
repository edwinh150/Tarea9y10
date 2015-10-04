namespace Tarea13Cap9y10
{
    partial class Cap9e2Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.NumeroCuentatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DinerotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(271, 126);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(43, 76);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(188, 20);
            this.NombretextBox.TabIndex = 6;
            // 
            // NumeroCuentatextBox
            // 
            this.NumeroCuentatextBox.Location = new System.Drawing.Point(43, 128);
            this.NumeroCuentatextBox.Name = "NumeroCuentatextBox";
            this.NumeroCuentatextBox.Size = new System.Drawing.Size(188, 20);
            this.NumeroCuentatextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cuenta de banco";
            // 
            // DinerotextBox
            // 
            this.DinerotextBox.Location = new System.Drawing.Point(43, 179);
            this.DinerotextBox.Name = "DinerotextBox";
            this.DinerotextBox.Size = new System.Drawing.Size(188, 20);
            this.DinerotextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dinero";
            // 
            // RlistBox
            // 
            this.RlistBox.FormattingEnabled = true;
            this.RlistBox.Location = new System.Drawing.Point(43, 234);
            this.RlistBox.Name = "RlistBox";
            this.RlistBox.Size = new System.Drawing.Size(188, 69);
            this.RlistBox.TabIndex = 11;
            // 
            // Cap9e2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 321);
            this.Controls.Add(this.RlistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DinerotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroCuentatextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cap9e2Form";
            this.Text = "Cap9e2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox NumeroCuentatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DinerotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox RlistBox;
    }
}