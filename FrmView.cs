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
        }
        public void InicializarFabrica()
        {
            fabrica=new Fabrica(10);
            Camioneta item = new Camioneta(EPropulsion.Electrica, true);
            fabrica = fabrica + item;
    }
}