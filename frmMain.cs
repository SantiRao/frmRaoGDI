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
    public partial class frmMain : Form
    {
        //lienzo con picturebox
        PictureBox basePapel = new PictureBox();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //espacio GDI para dibujar 
            Graphics papel;

            papel = basePapel.CreateGraphics();
            Pen lapiz = new Pen(Color.White);

            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            basePapel.BackColor = Color.Black;
            basePapel.Location = new Point(150, 150);
            basePapel.Size = new Size(300, 300);

            Controls.Add(basePapel);
        }
    }
}
