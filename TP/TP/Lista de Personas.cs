using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace TP
{
    public partial class ListadePersonas : Form
    {
        Personas EditarP;
        private bool edit = false;
        private string Sexo = "NADA";
        private List<String> gustitos = new List<string>();
        private List<Personas> ListaDePersonas = new List<Personas>();
        private BindingList<Personas> listaBindeable;
        public ListadePersonas()
        {
            InitializeComponent();
        }
        private void RefresLista()
        {
            listaBindeable.ResetBindings();
        }
        private void DeleteAlls()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            rdioFemenino.Checked = false;
            rdioMasculino.Checked = false;
            rdioOtro.Checked = false;
            ckbReggea.Checked = false;
            ckbCumbia.Checked = false;
            ckbRap.Checked = false;
            ckbPop.Checked = false;
            ckbCuarteto.Checked = false;
            ckbRock.Checked = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtmEdad_ValueChanged(object sender, EventArgs e)
        {
            string dia = dtmEdad.Value.Day.ToString();
            string mes = dtmEdad.Value.Month.ToString();
            string año = dtmEdad.Value.Year.ToString();
            TimeSpan edad = new TimeSpan();
            edad = DateTime.Now.Subtract(dtmEdad.Value.Date);
            int edadTotal = System.Convert.ToInt32((edad.TotalDays / 365));
            if(edadTotal < 0)
            {
                edadTotal = 0;
            }
            lblEdadTotal.Text = edadTotal.ToString();
        }

        private void ListarPersonas_Load(object sender, EventArgs e)
        {
            List<String> Colores = new List<string> { "Rojo", "Azul", "Amarillo", "Marron", "Verde", "Naranja", "Rosa" };
            cboColor.DataSource = Colores;
            listaBindeable = new BindingList<Personas>(ListaDePersonas);
            dgvPersonas.DataSource = listaBindeable;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gustitos.Clear();
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Nombre o Apellido vacio", "Error", MessageBoxButtons.OK);
                return;
            }
            if (rdioFemenino.Checked) this.Sexo = rdioFemenino.Text;
            if (rdioMasculino.Checked) this.Sexo = rdioMasculino.Text;
            if (rdioOtro.Checked) this.Sexo = rdioOtro.Text;
            if (this.Sexo == "NADA")
            {
                MessageBox.Show("Por favor, elija en SEXO", "Error", MessageBoxButtons.OK);
                return;
            }
            if (ckbReggea.Checked) gustitos.Add(ckbReggea.Text);
            if (ckbCumbia.Checked) gustitos.Add(ckbCumbia.Text);
            if (ckbRap.Checked) gustitos.Add(ckbRap.Text);
            if (ckbPop.Checked) gustitos.Add(ckbPop.Text);
            if (ckbCuarteto.Checked) gustitos.Add(ckbCuarteto.Text);
            if (ckbRock.Checked) gustitos.Add(ckbRock.Text);
            if (gustitos.Count == 0)
            {
                MessageBox.Show("No a seleccionado gusto musical", "Error", MessageBoxButtons.OK);
                return;
            }
            if (this.edit == true)
            {
                this.BorrarSelected();
                this.edit = false;
            }
            else
            {
                Personas Person = new Personas(gustitos, txtNombre.Text, txtApellido.Text, dtmEdad.Value.Date, this.Sexo, cboColor.SelectedItem.ToString());
                ListaDePersonas.Add(Person);
                this.RefresLista();
                this.DeleteAlls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DeleteAlls();
            this.edit = false;
        }
        private void setEdit()
        {
            txtApellido.Text = EditarP.Apellido;
            txtNombre.Text = EditarP.Nombre;
            dtmEdad.Value = EditarP.FechaNacimiento;
            if (EditarP.Sexo == "Masculino") rdioMasculino.Checked = true;
            if (EditarP.Sexo == "Femenino") rdioFemenino.Checked = true;
            if (EditarP.Sexo == "Otro") rdioOtro.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Reggea") == "Reggea") ckbReggea.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Cumbia") == "Cumbia") ckbCumbia.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Rap") == "Rap") ckbRap.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Pop") == "Pop") ckbPop.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Cuarteto") == "Cuarteto") ckbCuarteto.Checked = true;
            if (EditarP.Gustos.Find(x => x == "Rock") == "Rock") ckbRock.Checked = true;
            cboColor.SelectedItem = EditarP.Color;
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ListaDePersonas.Count == 0)
            {
                MessageBox.Show("No hay que Modificar ", "Error", MessageBoxButtons.OK);
                return;
            }
            Object Select;
            Select = dgvPersonas.CurrentRow.DataBoundItem;
            this.EditarP = (Personas)Select;
            this.setEdit();
            this.edit = true;
        }
        private void BorrarSelected()
        {
            
            ListaDePersonas.Remove(EditarP);
            this.RefresLista();
            Personas Personita = new Personas(gustitos, txtNombre.Text, txtApellido.Text, dtmEdad.Value.Date, this.Sexo, cboColor.SelectedItem.ToString());
            ListaDePersonas.Add(Personita);
            this.RefresLista();
            this.DeleteAlls();
            
        }
        private void BorrarSeleccionado()
        {
            Object Select;
            Select = dgvPersonas.CurrentRow.DataBoundItem;
            Personas Person = (Personas)Select;
            ListaDePersonas.Remove(Person);
            this.RefresLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDePersonas.Count == 0)
            {
                MessageBox.Show("No hay que Eliminar en lista", "Error", MessageBoxButtons.OK);
                return;
            }
            this.BorrarSeleccionado();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }
    }
}
