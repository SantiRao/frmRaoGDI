namespace frmRaoGDI
{
    partial class frmArkaniod
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
            this.Contenedor = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(2, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(612, 456);
            this.Contenedor.TabIndex = 0;
            this.Contenedor.TabStop = false;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(262, 421);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 1;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // frmArkaniod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 464);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.Contenedor);
            this.Name = "frmArkaniod";
            this.Text = "frmArkaniod";
            this.Load += new System.EventHandler(this.frmArkaniod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Contenedor;
        private System.Windows.Forms.Button btnEmpezar;
    }
}