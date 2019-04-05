using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class TP1WinFormAPP : Form
    {
        public TP1WinFormAPP()
        {
            InitializeComponent();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPersonas personas = new ListarPersonas();
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Name == personas.Name)
                {
                    abierto = true;
                    f.Show();
                }
            }
            if(!abierto)
            {
                personas.MdiParent = this;
                personas.Show();
            }
        }



        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("¿Está seguro de salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (salida == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
