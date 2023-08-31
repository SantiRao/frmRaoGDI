using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRaoGDI
{
    public partial class frmArkanoidLVL2 : Form
    {
        public frmArkanoidLVL2()
        {
            InitializeComponent();
        }

        private void frmArkanoidLVL2_KeyDown(object sender, KeyEventArgs e)
        {
                
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            picPelota.Show();
            btnDerecha.Enabled = true;
            btnIzquierda.Enabled = true;
            // enciende el reloj
            Reloj.Enabled = true;
            btnEmpezar.Hide();
            EjeY = picPelota.Location.Y;
            this.Focus();
        }

        private void frmArkanoidLVL2_Load(object sender, EventArgs e)
        {
            picPelota.Hide();
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Red;
        }

        int EjeY = 0;
        int EjeX = 0;   

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            EjeX = picNave.Location.X;

            picNave.Location = new Point(EjeX - 25, picNave.Location.Y);
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        { 

            EjeX = picNave.Location.X;

            picNave.Location = new Point(EjeX + 25, picNave.Location.Y);
        }
    }
}
