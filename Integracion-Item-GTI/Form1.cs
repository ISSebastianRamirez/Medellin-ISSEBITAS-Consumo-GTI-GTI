using System;
using System.Windows.Forms;

namespace Integracion_Item_GTI
{
    public partial class Form1 : Form
    {
        public Infraestructura.CRUD.BDConsulta bd = new Infraestructura.CRUD.BDConsulta();
        public Infraestructura.Procesos.Configuraciones _Configuraciones = new Infraestructura.Procesos.Configuraciones();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var IdDoc = Convert.ToInt32(txtIdDoc.Text);
            var NomDoc = txtNomDoc.Text;
            var IdCia = Convert.ToInt32(txtIdCia.Text);
            bd.EjecutarSPIngre("sp_IngresarPropiedades",IdDoc,NomDoc,IdCia);
            _Configuraciones.Obtener();
            Dominio.Terceros.Terceros _Tercero = new Dominio.Terceros.Terceros();
            _Tercero.ActualizarTercero();
        }
    }
}
