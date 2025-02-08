
namespace PVpresentation.Resources
{
    public static class VariablesGlobales
    {
        public static int UsuarioID { get; set; }
        public static string UsuarioNombre { get; set; }= string.Empty;
        public static string UsuarioClave { get; set; } = string.Empty;
        public static int UsuarioIDrol { get; set; }
        public static string RolNombre { get; set; } = string.Empty;


        public static int SucursalID { get; set; }
        public static int EmpresaID { get; set; }
        public static string EmpresaNombre {get; set;}= string.Empty;
        public static string EmpresaLogo {get; set;}= string.Empty;


        public static int CajaID { get; set; }
        public static string CajaNombre { get; set; } = string.Empty;
        public static string CajaCondicion { get; set; } = string.Empty; //values: 'Abierta' / 'Cerrada'   

        public static int cajaSeleccionadaID { get; set; }
        public static int cajaSeleccionadaSaldoInicial { get; set; }


        //Instancias de Formularios Ventas
        public static int Frm_Venta01 { get; set; } //values: 0 Cerrado / 1 Abierto
        public static int Frm_Venta02 { get; set; } //values: 0 Cerrado / 1 Abierto
        public static int Frm_Venta03 { get; set; } //values: 0 Cerrado / 1 Abierto

        public static int Venta01_ClienteID {get; set;}
        public static string Venta01_ClienteNombre {get; set;}
        public static string Venta01_ClienteDomicilio {get; set;}
        public static string Venta01_ClienteCUIT {get; set;}
        public static string Venta01_ClienteCondicionIVA {get; set;}
        public static int Venta01_Tipo {get; set;}
        public static int Venta01_SubTotal {get; set;}
        public static int Venta01_DtoEfectivo {get; set;}
        public static int Venta01_Bruto {get; set;}
        public static int Venta01_DtoAdicional {get; set;}
        public static int Venta01_Monto {get; set;}

        public static int Venta02_ClienteID {get; set;}
        public static string Venta02_ClienteNombre {get; set;}
        public static string Venta02_ClienteDomicilio {get; set;}
        public static string Venta02_ClienteCUIT {get; set;}
        public static string Venta02_ClienteCondicionIVA {get; set;}
        public static int Venta02_Tipo {get; set;}
        public static int Venta02_SubTotal {get; set;}
        public static int Venta02_DtoEfectivo {get; set;}
        public static int Venta02_Bruto {get; set;}
        public static int Venta02_DtoAdicional {get; set;}
        public static int Venta02_Monto {get; set;}

        public static int Venta03_ClienteID {get; set;}
        public static string Venta03_ClienteNombre {get; set;}
        public static string Venta03_ClienteDomicilio {get; set;}
        public static string Venta03_ClienteCUIT {get; set;}
        public static string Venta03_ClienteCondicionIVA {get; set;}
        public static int Venta03_Tipo {get; set;}
        public static int Venta03_SubTotal {get; set;}
        public static int Venta03_DtoEfectivo {get; set;}
        public static int Venta03_Bruto {get; set;}
        public static int Venta03_DtoAdicional {get; set;}
        public static int Venta03_Monto {get; set;}

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
