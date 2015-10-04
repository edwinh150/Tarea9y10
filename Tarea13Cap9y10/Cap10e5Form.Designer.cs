namespace Tarea13Cap9y10
{
    partial class Cap10e5Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Mbutton = new System.Windows.Forms.Button();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.NtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clase Poligono y el metodo to String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese lados";
            // 
            // Mbutton
            // 
            this.Mbutton.Location = new System.Drawing.Point(280, 153);
            this.Mbutton.Name = "Mbutton";
            this.Mbutton.Size = new System.Drawing.Size(75, 23);
            this.Mbutton.TabIndex = 6;
            this.Mbutton.Text = "Mostrar";
            this.Mbutton.UseVisualStyleBackColor = true;
            this.Mbutton.Click += new System.EventHandler(this.Mbutton_Click);
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(52, 209);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(221, 20);
            this.RtextBox.TabIndex = 4;
            // 
            // NtextBox
            // 
            this.NtextBox.Location = new System.Drawing.Point(52, 111);
            this.NtextBox.Name = "NtextBox";
            this.NtextBox.Size = new System.Drawing.Size(221, 20);
            this.NtextBox.TabIndex = 5;
            // 
            // Cap10e5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mbutton);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.NtextBox);
            this.Name = "Cap10e5Form";
            this.Text = "Cap10e5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mbutton;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.TextBox NtextBox;
    }
}