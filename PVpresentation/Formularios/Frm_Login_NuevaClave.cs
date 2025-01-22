using PVpresentation.Resources;
using PVservices.Interfaces;

namespace PVpresentation.Formularios
{
    public partial class Frm_Login_NuevaClave : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUsuariosService _usuariosService;
        public Frm_Login_NuevaClave(IServiceProvider serviceProvider, IUsuariosService usuariosService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _usuariosService = usuariosService;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            #region VALIDAR CAMPOS
            if (txtClaveActual.Text != VariablesGlobales.UsuarioClave)
            {
                MessageBox.Show("La clave ingresada no coincide con la clave actual.", "Clave incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtClaveNueva.Text == string.Empty || txtClaveNuevaCompara.Text == string.Empty)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtClaveNueva.Text != txtClaveNuevaCompara.Text)
            {
                MessageBox.Show("Las claves ingresadas no coinciden.", "Claves no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region ACTUALIZAR CLAVE
            await _usuariosService.ActualizarClave(VariablesGlobales.UsuarioID, txtClaveNueva.Text);
            MessageBox.Show("Clave actualizada correctamente.", "Clave actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            #endregion
        }
    }
}
