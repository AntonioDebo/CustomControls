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
            this.adToogleButton2 = new CustomControls.ADControls.ADToogleButton();
            this.adToogleButton1 = new CustomControls.ADControls.ADToogleButton();
            this.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

