﻿namespace frmRaoGDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArkaniod));
            this.Contenedor = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picNave = new System.Windows.Forms.PictureBox();
            this.picPelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(250, 380);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 33);
            this.picNave.TabIndex = 2;
            this.picNave.TabStop = false;
            // 
            // picPelota
            // 
            this.picPelota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPelota.BackgroundImage")));
            this.picPelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPelota.Location = new System.Drawing.Point(285, 328);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(29, 29);
            this.picPelota.TabIndex = 3;
            this.picPelota.TabStop = false;
            // 
            // frmArkaniod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 464);
            this.Controls.Add(this.picPelota);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.Contenedor);
            this.Name = "frmArkaniod";
            this.Text = "frmArkaniod";
            this.Load += new System.EventHandler(this.frmArkaniod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Contenedor;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox picPelota;
    }
}