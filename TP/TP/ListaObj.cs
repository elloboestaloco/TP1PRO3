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
    public partial class ListaObj : Form
    {

        public ListaObj()
        {
            InitializeComponent();
            ActualizaContador();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text == "")
            {
                MessageBox.Show("Sin Objeto", "Error", MessageBoxButtons.OK );
                return;
            }
            ListViewItem item = new ListViewItem(txtObjeto.Text);
            ListViewItem item1 = primeLIV.FindItemWithText(txtObjeto.Text);
            if (item1 != null)
            {
                if (item1.Text == txtObjeto.Text)
                {
                    MessageBox.Show("Ya esta en lista este objeto", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    primeLIV.Items.Add(item);
                }
            }
            else
            {
                primeLIV.Items.Add(item);
            }
            txtObjeto.Text = "";
            ActualizaContador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in primeLIV.Items)
            {
                ListViewItem repetido = segLIV.FindItemWithText(item.Text);
                if (repetido != null)
                {
                    if (repetido.Text == item.Text)
                    {
                        primeLIV.Items.Remove(item);
                        MessageBox.Show("Ya que existe", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        primeLIV.Items.Remove(item);
                        segLIV.Items.Add(item);
                    }
                }
                else
                {
                    primeLIV.Items.Remove(item);
                    segLIV.Items.Add(item);
                }
            }
            ActualizaContador();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in primeLIV.SelectedItems)
            {
                ListViewItem repetido = segLIV.FindItemWithText(item.Text);
                if (repetido != null)
                {
                    if (repetido.Text == item.Text)
                    {
                        primeLIV.Items.Remove(item);
                        MessageBox.Show("Ya que existe", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        primeLIV.Items.Remove(item);
                        segLIV.Items.Add(item);
                    }
                }
                else
                {
                    primeLIV.Items.Remove(item);
                    segLIV.Items.Add(item);
                }
            }
            ActualizaContador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in segLIV.SelectedItems)
            {
                ListViewItem repetido = primeLIV.FindItemWithText(item.Text);
                if (repetido != null)
                {
                    if (repetido.Text == item.Text)
                    {
                        segLIV.Items.Remove(item);
                        MessageBox.Show("Ya que existe", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        segLIV.Items.Remove(item);
                        primeLIV.Items.Add(item);
                    }
                }
                else
                {
                    segLIV.Items.Remove(item);
                    primeLIV.Items.Add(item);
                }
            }
            ActualizaContador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in segLIV.SelectedItems)
            {
                segLIV.Items.Remove(item);
            }
            ActualizaContador();
        }

        private void ActualizaContador()
        {
            lblReg1.Text = primeLIV.Items.Count.ToString();
            lblReg2.Text = segLIV.Items.Count.ToString();
        }
    }
}
