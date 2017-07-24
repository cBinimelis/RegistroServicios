using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroServicios
{
    public partial class AgregarCliente : Form
    {
        conexion con = new conexion();
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_reparacionDataSet4.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.bd_reparacionDataSet4.Ciudad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text.Equals("") || txt_apellido.Text.Equals("") || txt_telefono.Text.Equals(""))
                {
                    MessageBox.Show("No puedes dejar campos vacios");
                }
                else
                {
                    int ingresar = con.ejecutar("INSERT INTO Usuario (Nombres, Apellidos, Telefono, idCiudad) VALUES ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_telefono.Text + "','" + combo_ciudad.SelectedValue + "')");
                    if (ingresar > 0)
                    {
                        MessageBox.Show("Usuario ingresado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un problema ingresando al usuario");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
