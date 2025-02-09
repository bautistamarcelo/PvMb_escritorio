namespace PVpresentation.Formularios.Modelos
{
    public partial class FrmModeloTransaccion : Form
    {
       

        public FrmModeloTransaccion()
        {
            InitializeComponent();
            
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
        }

       
    }
}
