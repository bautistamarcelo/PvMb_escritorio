
namespace PVpresentation.Resources
{
    public static class VariablesGlobales
    {
        public static int UsuarioID { get; set; }
        public static string UsuarioNombre { get; set; }= string.Empty;
        public static string UsuarioClave { get; set; } = string.Empty;
        public static int UsuarioIDrol { get; set; }
        public static string RolNombre { get; set; } = string.Empty;

        public static int CajaID { get; set; }
        public static string CajaNombre { get; set; } = string.Empty;
        public static string CajaCondicion { get; set; } = string.Empty; //values: 'Abierta' / 'Cerrada'   
    }


    ////Ejemplo de asignación de valores a las variables desde un formulario login
    //private void LoginButton_Click(object sender, EventArgs e)
    //    {
    //        // Lógica de autenticación
    //        if (AuthenticateUser(txtUsername.Text, txtPassword.Text))
    //        {
    //            // Asignar valores a variables globales
    //            VariablesGlobales.UsuarioNombre = txtUsername.Text;
    //            VariablesGlobales.UsuarioID = GetUserId(txtUsername.Text);


    //            // Abrir el siguiente formulario
    //            MainForm mainForm = new MainForm();
    //            this.Hide();
    //            mainForm.Show();
    //        }
    //        else
    //        {
    //            MessageBox.Show("Usuario o contraseña incorrectos.");
    //        }
    //    }


    ////Ejemplo de acceso a los datos de las variables globales desde otro formulario
    //private void MainForm_Load(object sender, EventArgs e)
    //    {
    //        // Mostrar el nombre del usuario logueado
    //        lblWelcome.Text = $"Bienvenido, {VariablesGlobales.UsuarioNombre}!";
    //    }



    }
