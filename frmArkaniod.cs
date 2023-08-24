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
    public partial class frmArkaniod : Form
    {
        Pen lapiz = new Pen(Color.Red);

        Graphics Lienzo;

        public frmArkaniod()
        {
            InitializeComponent();
        }

        private void frmArkaniod_Load(object sender, EventArgs e)
        {
            Lienzo = Contenedor.CreateGraphics();

            Lienzo.DrawRectangle(lapiz, 306, 228, 150, 150);
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            btnEmpezar.Hide();
        }
    }
}
