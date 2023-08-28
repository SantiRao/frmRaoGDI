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

        private void btnEmpezar_Click(object sender, KeyEventArgs e)
        {
        }

        private void frmArkanoidLVL2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("presiono izquierda");
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // enciende el reloj
            Reloj.Enabled = true;
            btnEmpezar.Hide();
            this.Focus();
        }
    }
}
