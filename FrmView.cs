using Entidades;
namespace Parcial
{
    public partial class FrmView : Form
    {
        Fabrica fabrica;
        public FrmView()
        {
            InitializeComponent();
            
            InicializarFabrica();
            Refrescar();
        }
        public void InicializarFabrica()
        {
            fabrica = new Fabrica(10);
            Camioneta item = new Camioneta(EPropulsion.Electrica, true);
            fabrica = fabrica + item;
        }
        public void Refrescar()
        {
            lstVehiculos.Items.Clear();
            lstVehiculos.DataSource = null;
            lstVehiculos.DataSource = fabrica.Vehiculos;

        }
    }
}