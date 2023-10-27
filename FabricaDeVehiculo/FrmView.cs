using Entidades2023;
namespace FabricaDeVehiculo
{
    public partial class FrmView : Form
    {
        Fabrica fabrica;

        public FrmView()
        {
            InitializeComponent();

        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = new string[] { "Automovil", "Camioneta", "Moto" };
        }

        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(10);

        }

        private Vehiculo CrearVehiculo()
        {
            foreach (var item in this.cmbTipo.Items)
            {
                if (item.ToString() == "Automovil")
                {
                    return new Automovil();
                }
                if (item.ToString() == "Camioneta")
                {
                    return new Camioneta(EPropulsion.Electrica, true);
                }
            }

            return new Moto(EPropulsion.Electrica);
        }

        private void Refrescar()
        {
            this.lstVehiculos.Items.Add(fabrica.Vehiculos);
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            fabrica += this.CrearVehiculo();
        }
    }
}