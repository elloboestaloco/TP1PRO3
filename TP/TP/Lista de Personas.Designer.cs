namespace TP
{
    partial class ListadePersonas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lnlNacimiento = new System.Windows.Forms.Label();
            this.dtmEdad = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.rdioOtro = new System.Windows.Forms.RadioButton();
            this.rdioFemenino = new System.Windows.Forms.RadioButton();
            this.rdioMasculino = new System.Windows.Forms.RadioButton();
            this.gpMusica = new System.Windows.Forms.GroupBox();
            this.ckbReggea = new System.Windows.Forms.CheckBox();
            this.ckbCuarteto = new System.Windows.Forms.CheckBox();
            this.ckbRap = new System.Windows.Forms.CheckBox();
            this.ckbCumbia = new System.Windows.Forms.CheckBox();
            this.ckbPop = new System.Windows.Forms.CheckBox();
            this.ckbRock = new System.Windows.Forms.CheckBox();
            this.lblEdadTotal = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpSexo.SuspendLayout();
            this.gpMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 51);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(70, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lnlNacimiento
            // 
            this.lnlNacimiento.AutoSize = true;
            this.lnlNacimiento.Location = new System.Drawing.Point(6, 80);
            this.lnlNacimiento.Name = "lnlNacimiento";
            this.lnlNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lnlNacimiento.TabIndex = 4;
            this.lnlNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtmEdad
            // 
            this.dtmEdad.Location = new System.Drawing.Point(8, 111);
            this.dtmEdad.Name = "dtmEdad";
            this.dtmEdad.Size = new System.Drawing.Size(200, 20);
            this.dtmEdad.TabIndex = 5;
            this.dtmEdad.ValueChanged += new System.EventHandler(this.dtmEdad_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(211, 89);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad:";
            // 
            // gpSexo
            // 
            this.gpSexo.Controls.Add(this.rdioOtro);
            this.gpSexo.Controls.Add(this.rdioFemenino);
            this.gpSexo.Controls.Add(this.rdioMasculino);
            this.gpSexo.Location = new System.Drawing.Point(129, 154);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(102, 145);
            this.gpSexo.TabIndex = 7;
            this.gpSexo.TabStop = false;
            this.gpSexo.Text = "Sexo";
            this.gpSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdioOtro
            // 
            this.rdioOtro.AutoSize = true;
            this.rdioOtro.Location = new System.Drawing.Point(12, 83);
            this.rdioOtro.Name = "rdioOtro";
            this.rdioOtro.Size = new System.Drawing.Size(45, 17);
            this.rdioOtro.TabIndex = 2;
            this.rdioOtro.TabStop = true;
            this.rdioOtro.Text = "Otro";
            this.rdioOtro.UseVisualStyleBackColor = true;
            // 
            // rdioFemenino
            // 
            this.rdioFemenino.AutoSize = true;
            this.rdioFemenino.Location = new System.Drawing.Point(12, 51);
            this.rdioFemenino.Name = "rdioFemenino";
            this.rdioFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdioFemenino.TabIndex = 1;
            this.rdioFemenino.TabStop = true;
            this.rdioFemenino.Text = "Femenino";
            this.rdioFemenino.UseVisualStyleBackColor = true;
            // 
            // rdioMasculino
            // 
            this.rdioMasculino.AutoSize = true;
            this.rdioMasculino.Location = new System.Drawing.Point(12, 19);
            this.rdioMasculino.Name = "rdioMasculino";
            this.rdioMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdioMasculino.TabIndex = 0;
            this.rdioMasculino.TabStop = true;
            this.rdioMasculino.Text = "Masculino";
            this.rdioMasculino.UseVisualStyleBackColor = true;
            // 
            // gpMusica
            // 
            this.gpMusica.Controls.Add(this.ckbReggea);
            this.gpMusica.Controls.Add(this.ckbCuarteto);
            this.gpMusica.Controls.Add(this.ckbRap);
            this.gpMusica.Controls.Add(this.ckbCumbia);
            this.gpMusica.Controls.Add(this.ckbPop);
            this.gpMusica.Controls.Add(this.ckbRock);
            this.gpMusica.Location = new System.Drawing.Point(12, 154);
            this.gpMusica.Name = "gpMusica";
            this.gpMusica.Size = new System.Drawing.Size(111, 209);
            this.gpMusica.TabIndex = 8;
            this.gpMusica.TabStop = false;
            this.gpMusica.Text = "Estilos Musicales";
            // 
            // ckbReggea
            // 
            this.ckbReggea.AutoSize = true;
            this.ckbReggea.Location = new System.Drawing.Point(12, 176);
            this.ckbReggea.Name = "ckbReggea";
            this.ckbReggea.Size = new System.Drawing.Size(64, 17);
            this.ckbReggea.TabIndex = 5;
            this.ckbReggea.Text = "Reggea";
            this.ckbReggea.UseVisualStyleBackColor = true;
            // 
            // ckbCuarteto
            // 
            this.ckbCuarteto.AutoSize = true;
            this.ckbCuarteto.Location = new System.Drawing.Point(12, 115);
            this.ckbCuarteto.Name = "ckbCuarteto";
            this.ckbCuarteto.Size = new System.Drawing.Size(66, 17);
            this.ckbCuarteto.TabIndex = 4;
            this.ckbCuarteto.Text = "Cuarteto";
            this.ckbCuarteto.UseVisualStyleBackColor = true;
            // 
            // ckbRap
            // 
            this.ckbRap.AutoSize = true;
            this.ckbRap.Location = new System.Drawing.Point(12, 51);
            this.ckbRap.Name = "ckbRap";
            this.ckbRap.Size = new System.Drawing.Size(46, 17);
            this.ckbRap.TabIndex = 3;
            this.ckbRap.Text = "Rap";
            this.ckbRap.UseVisualStyleBackColor = true;
            // 
            // ckbCumbia
            // 
            this.ckbCumbia.AutoSize = true;
            this.ckbCumbia.Location = new System.Drawing.Point(12, 144);
            this.ckbCumbia.Name = "ckbCumbia";
            this.ckbCumbia.Size = new System.Drawing.Size(61, 17);
            this.ckbCumbia.TabIndex = 2;
            this.ckbCumbia.Text = "Cumbia";
            this.ckbCumbia.UseVisualStyleBackColor = true;
            // 
            // ckbPop
            // 
            this.ckbPop.AutoSize = true;
            this.ckbPop.Location = new System.Drawing.Point(12, 83);
            this.ckbPop.Name = "ckbPop";
            this.ckbPop.Size = new System.Drawing.Size(45, 17);
            this.ckbPop.TabIndex = 1;
            this.ckbPop.Text = "Pop";
            this.ckbPop.UseVisualStyleBackColor = true;
            // 
            // ckbRock
            // 
            this.ckbRock.AutoSize = true;
            this.ckbRock.Location = new System.Drawing.Point(12, 19);
            this.ckbRock.Name = "ckbRock";
            this.ckbRock.Size = new System.Drawing.Size(52, 17);
            this.ckbRock.TabIndex = 0;
            this.ckbRock.Text = "Rock";
            this.ckbRock.UseVisualStyleBackColor = true;
            // 
            // lblEdadTotal
            // 
            this.lblEdadTotal.AutoSize = true;
            this.lblEdadTotal.Location = new System.Drawing.Point(231, 111);
            this.lblEdadTotal.Name = "lblEdadTotal";
            this.lblEdadTotal.Size = new System.Drawing.Size(0, 13);
            this.lblEdadTotal.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(136, 302);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color Favorito";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(139, 330);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(92, 21);
            this.cboColor.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(61, 384);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(266, 22);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(418, 311);
            this.dgvPersonas.TabIndex = 14;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(387, 340);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 15;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(468, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListadePersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblEdadTotal);
            this.Controls.Add(this.gpMusica);
            this.Controls.Add(this.gpSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtmEdad);
            this.Controls.Add(this.lnlNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "ListadePersonas";
            this.Text = "Lista de Personas";
            this.Load += new System.EventHandler(this.ListarPersonas_Load);
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.gpMusica.ResumeLayout(false);
            this.gpMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lnlNacimiento;
        private System.Windows.Forms.DateTimePicker dtmEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gpSexo;
        private System.Windows.Forms.RadioButton rdioOtro;
        private System.Windows.Forms.RadioButton rdioFemenino;
        private System.Windows.Forms.RadioButton rdioMasculino;
        private System.Windows.Forms.GroupBox gpMusica;
        private System.Windows.Forms.Label lblEdadTotal;
        private System.Windows.Forms.CheckBox ckbReggea;
        private System.Windows.Forms.CheckBox ckbCuarteto;
        private System.Windows.Forms.CheckBox ckbRap;
        private System.Windows.Forms.CheckBox ckbCumbia;
        private System.Windows.Forms.CheckBox ckbPop;
        private System.Windows.Forms.CheckBox ckbRock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}