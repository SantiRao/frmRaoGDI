namespace frmRaoGDI
{
    partial class frmArkanoidLVL2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArkanoidLVL2));
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.picPelota = new System.Windows.Forms.PictureBox();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Interval = 200;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // picPelota
            // 
            this.picPelota.BackColor = System.Drawing.Color.Transparent;
            this.picPelota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPelota.BackgroundImage")));
            this.picPelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPelota.Location = new System.Drawing.Point(281, 264);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(29, 29);
            this.picPelota.TabIndex = 7;
            this.picPelota.TabStop = false;
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(246, 299);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 33);
            this.picNave.TabIndex = 6;
            this.picNave.TabStop = false;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Lime;
            this.Contenedor.Location = new System.Drawing.Point(0, 1);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(612, 456);
            this.Contenedor.TabIndex = 4;
            this.Contenedor.TabStop = false;
            this.Contenedor.Click += new System.EventHandler(this.Contenedor_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(260, 422);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Enabled = false;
            this.btnDerecha.Location = new System.Drawing.Point(298, 393);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Text = ">>";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Enabled = false;
            this.btnIzquierda.Location = new System.Drawing.Point(217, 393);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 11;
            this.btnIzquierda.Text = "<<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // frmArkanoidLVL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.picPelota);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.Contenedor);
            this.KeyPreview = true;
            this.Name = "frmArkanoidLVL2";
            this.Text = "frmArkanoidLVL2";
            this.Load += new System.EventHandler(this.frmArkanoidLVL2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArkanoidLVL2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.PictureBox picPelota;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox Contenedor;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
    }
}