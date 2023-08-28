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
            // enciende el reloj
            timer1.Enabled = true;
            btnEmpezar.Hide();
        }

        Random aleatorio = new Random();
        int ejeX = 0;
        int ejeY = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ejeX = aleatorio.Next(0, 612);
            ejeY = aleatorio.Next(0,456);
            picNave.Location = new Point(ejeX, 380);
            picPelota.Location = new Point(285, ejeY);
        }
    }   

}
