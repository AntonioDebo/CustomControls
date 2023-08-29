namespace CustomControls
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.adButton2 = new CustomControls.ADControls.ADButton();
            this.adButton1 = new CustomControls.ADControls.ADButton();
            this.adToogleButton2 = new CustomControls.ADControls.ADToogleButton();
            this.adToogleButton1 = new CustomControls.ADControls.ADToogleButton();
            this.adButton3 = new CustomControls.ADControls.ADButton();
            this.SuspendLayout();
            // 
            // adButton2
            // 
            this.adButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adButton2.BorderRadius = 10;
            this.adButton2.BorderSize = 0;
            this.adButton2.FlatAppearance.BorderSize = 0;
            this.adButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adButton2.ForeColor = System.Drawing.Color.White;
            this.adButton2.Location = new System.Drawing.Point(341, 223);
            this.adButton2.Name = "adButton2";
            this.adButton2.Size = new System.Drawing.Size(150, 64);
            this.adButton2.TabIndex = 3;
            this.adButton2.Text = "TextButton";
            this.adButton2.TextColor = System.Drawing.Color.White;
            this.adButton2.UseVisualStyleBackColor = false;
            // 
            // adButton1
            // 
            this.adButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adButton1.BorderRadius = 10;
            this.adButton1.BorderSize = 0;
            this.adButton1.FlatAppearance.BorderSize = 0;
            this.adButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adButton1.ForeColor = System.Drawing.Color.White;
            this.adButton1.Location = new System.Drawing.Point(345, 130);
            this.adButton1.Name = "adButton1";
            this.adButton1.Size = new System.Drawing.Size(150, 59);
            this.adButton1.TabIndex = 2;
            this.adButton1.Text = "adButton1";
            this.adButton1.TextColor = System.Drawing.Color.White;
            this.adButton1.UseVisualStyleBackColor = false;
            // 
            // adToogleButton2
            // 
            this.adToogleButton2.Location = new System.Drawing.Point(40, 130);
            this.adToogleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.adToogleButton2.Name = "adToogleButton2";
            this.adToogleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.adToogleButton2.OffToogleColor = System.Drawing.Color.Gainsboro;
            this.adToogleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.adToogleButton2.OnToogleColor = System.Drawing.Color.MediumSlateBlue;
            this.adToogleButton2.Size = new System.Drawing.Size(64, 39);
            this.adToogleButton2.SolidStyle = false;
            this.adToogleButton2.TabIndex = 1;
            this.adToogleButton2.Text = "adToogleButton2";
            this.adToogleButton2.UseVisualStyleBackColor = true;
            // 
            // adToogleButton1
            // 
            this.adToogleButton1.AutoSize = true;
            this.adToogleButton1.Location = new System.Drawing.Point(40, 48);
            this.adToogleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.adToogleButton1.Name = "adToogleButton1";
            this.adToogleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.adToogleButton1.OffToogleColor = System.Drawing.Color.Gainsboro;
            this.adToogleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.adToogleButton1.OnToogleColor = System.Drawing.Color.WhiteSmoke;
            this.adToogleButton1.Size = new System.Drawing.Size(133, 22);
            this.adToogleButton1.TabIndex = 0;
            this.adToogleButton1.Text = "adToogleButton1";
            this.adToogleButton1.UseVisualStyleBackColor = true;
            // 
            // adButton3
            // 
            this.adButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.adButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adButton3.BorderRadius = 10;
            this.adButton3.BorderSize = 0;
            this.adButton3.FlatAppearance.BorderSize = 0;
            this.adButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adButton3.ForeColor = System.Drawing.Color.White;
            this.adButton3.Location = new System.Drawing.Point(89, 263);
            this.adButton3.Name = "adButton3";
            this.adButton3.Size = new System.Drawing.Size(150, 53);
            this.adButton3.TabIndex = 4;
            this.adButton3.Text = "adButton3";
            this.adButton3.TextColor = System.Drawing.Color.White;
            this.adButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 371);
            this.Controls.Add(this.adButton3);
            this.Controls.Add(this.adButton2);
            this.Controls.Add(this.adButton1);
            this.Controls.Add(this.adToogleButton2);
            this.Controls.Add(this.adToogleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADControls.ADToogleButton adToogleButton1;
        private ADControls.ADToogleButton adToogleButton2;
        private ADControls.ADButton adButton1;
        private ADControls.ADButton adButton2;
        private ADControls.ADButton adButton3;
    }
}

