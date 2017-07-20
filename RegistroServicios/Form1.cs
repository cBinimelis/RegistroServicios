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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_reparacionDataSet3.TipoServicio' Puede moverla o quitarla según sea necesario.
            this.tipoServicioTableAdapter.Fill(this.bd_reparacionDataSet3.TipoServicio);
            // TODO: esta línea de código carga datos en la tabla 'bd_reparacionDataSet2.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.bd_reparacionDataSet2.Servicio);
            // TODO: esta línea de código carga datos en la tabla 'bd_reparacionDataSet1.vUsers' Puede moverla o quitarla según sea necesario.
            this.vUsersTableAdapter.Fill(this.bd_reparacionDataSet1.vUsers);
            // TODO: esta línea de código carga datos en la tabla 'bd_reparacionDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bd_reparacionDataSet.Usuario);

        }
    }
}
