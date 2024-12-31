using PVpresentation.ViewModels;
using PVservices.Interfaces;
using PVpresentation.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using PVrepository.Entities;
using PVservices.Implementation;

namespace PVpresentation.Formularios
{
    public partial class FrmUsuarios : FrmModelo
    {
        #region Funcionalidades y Constructor del formulario

        private readonly IUsuariosService _usuariosService;
        private readonly IRolService _rolService;
        public FrmUsuarios(IUsuariosService usuariosService, IRolService rolService)
        {
        InitializeComponent();
            _usuariosService = usuariosService;
            _rolService = rolService;
        }

        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabListado, tabNuevo, tabEditar };
            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }

            }
        }

        private async Task MostrarUsuarios(string Buscar = "")
        {
            var listaUsuarios = await _usuariosService.Lista(Buscar);
            var VMlistaUsuarios = listaUsuarios.Select(item => new UsuariosVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG

            {
                IDUsuario = item.IDUsuario,
                nombre = item.nombre,
                correo = item.correo,
                telefono = item.telefono,
                IDRol = item.IDRol.IDRol,
                nombreRol = item.IDRol.descripcion,
                urlFoto = item.urlFoto,
                nombreFoto = item.nombreFoto,
                clave = item.clave,
                esActivo = item.esActivo,
                Situacion = item.esActivo == 1 ? "Activo" : "Suspendido",
                fechaRegistro = item.fechaRegistro
            }).ToList();
            dgvListado.DataSource = VMlistaUsuarios; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["IDRol"].Visible = false;
            dgvListado.Columns["fechaRegistro"].Visible = false;
            dgvListado.Columns["esActivo"].Visible = false;
        }

        #endregion

        #region CRUD y Navegación del formulario
        private async void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarUsuarios();

            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsSituacion = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Activo",Valor=1},
                new OpcionesComboBox{Texto="Suspendido",Valor=2}
            };
            cmbEsActivoNuevo.InsertarItems(itemsSituacion);
            cmbEsActivoEditar.InsertarItems(itemsSituacion);

            var ListaRol = await _rolService.Lista();
            var items = ListaRol.Select(item => new OpcionesComboBox { Texto = item.descripcion, Valor = item.IDRol }).ToArray();

            cmbRolNuevo.InsertarItems(items);
            cmbRolEditar.InsertarItems(items);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios(txtBuscar.Text.Trim());
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var UsuarioSeleccionado = (UsuariosVM)dgvListado.CurrentRow.DataBoundItem;
                txtIDEditar.Text = UsuarioSeleccionado.IDUsuario.ToString();
                txtNombreEditar.Text = UsuarioSeleccionado.nombre.ToString();
                txtCorreoEditar.Text = UsuarioSeleccionado.correo.ToString();
                txtTelefonoEditar.Text = UsuarioSeleccionado.telefono.ToString();
                cmbRolEditar.EstablecerValor(UsuarioSeleccionado.IDRol);
                txtUrlFotoEditar.Text = UsuarioSeleccionado.urlFoto.ToString();
                txtNombreFotoEditar.Text = UsuarioSeleccionado.nombreFoto.ToString();
                txtClaveEditar.Text = UsuarioSeleccionado.clave.ToString();

                cmbEsActivoEditar.EstablecerValor(UsuarioSeleccionado.esActivo);
                txtFechaEditar.Text = UsuarioSeleccionado.fechaRegistro.ToString();

                //txtIDEditar.Visible = true; //Desabilitar cuando compruebe funcionamiento
                MostrarTabs(tabEditar.Name);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIDnuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtCorreoNuevo.Text = "";
            txtTelefonoNuevo.Text = "";
            cmbRolNuevo.SelectedIndex = 0;
            txtUrlFotoNuevo.Text = "";
            txtNombreFotoNuevo.Text = "";
            txtClaveNuevo.Text = "";
            cmbEsActivoNuevo.SelectedIndex = 0;
            txtFechaNuevo.Text = "";
            MostrarTabs(tabNuevo.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabNuevo.Name];
            txtNombreNuevo.Select();
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        private async void btnGrabarNuevo_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no se encuentren vacíos
            if (txtNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Usuario es obligatorio");
                return;
            }
            if (txtTelefonoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Teléfono del Usuario es obligatorio");
                return;
            }
            if (txtClaveNuevo.Text.Trim() == "")
            {
                MessageBox.Show("La clave del Usuario es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemRol = (OpcionesComboBox)cmbRolNuevo.SelectedItem!;
            var itemActivo = (OpcionesComboBox)cmbEsActivoNuevo.SelectedItem!;

            //Cargo los datos en el objeto Cliente para guardarlo después
            var objeTo = new Usuarios
            {
                nombre = txtNombreNuevo.Text.Trim(),
                correo = txtCorreoNuevo.Text.Trim(),
                telefono = txtTelefonoNuevo.Text.Trim(),
                IDRol = new Rol { IDRol = itemRol.Valor },
                urlFoto = txtUrlFotoNuevo.Text.Trim(),
                nombreFoto = txtNombreFotoNuevo.Text.Trim(),
                clave = txtClaveNuevo.Text.Trim(),
                esActivo = itemActivo.Valor,
                fechaRegistro = DateTime.Now
            };

            var respuesta = await _usuariosService.crear(objeTo);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTabs(tabListado.Name);
            }
        }

        private async void btnGrabarEditar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no se encuentren vacíos
            if (txtNombreEditar.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Usuario es obligatorio");
                return;
            }
            if (txtTelefonoEditar.Text.Trim() == "")
            {
                MessageBox.Show("El Teléfono del Usuario es obligatorio");
                return;
            }
            if (txtClaveEditar.Text.Trim() == "")
            {
                MessageBox.Show("La clave del Usuario es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemRol = (OpcionesComboBox)cmbRolEditar.SelectedItem!;
            var itemActivo = (OpcionesComboBox)cmbEsActivoEditar.SelectedItem!;

            //Cargo los datos en el objeto Usuario para guardarlo después
            var objeTo = new Usuarios
            {
                IDUsuario= Convert.ToInt32(txtIDEditar.Text.Trim()),
                nombre = txtNombreEditar.Text.Trim(),
                correo = txtCorreoEditar.Text.Trim(),
                telefono = txtTelefonoEditar.Text.Trim(),
                IDRol = new Rol { IDRol = itemRol.Valor },
                urlFoto = txtUrlFotoEditar.Text.Trim(),
                nombreFoto = txtNombreFotoEditar.Text.Trim(),
                clave = txtClaveEditar.Text.Trim(),
                esActivo = itemActivo.Valor,
                //fechaRegistro = DateTime.Now
            };

            var respuesta = await _usuariosService.editar(objeTo);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTabs(tabListado.Name);
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        #endregion

        #region Formatos de Foco

        private void txtNombreNuevo_Enter(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoFoco();
        }

        private void txtNombreNuevo_Leave(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoNormal();
        }

        private void txtCorreoNuevo_Enter(object sender, EventArgs e)
        {
            txtCorreoNuevo.ColorFondoFoco();
        }

        private void txtCorreoNuevo_Leave(object sender, EventArgs e)
        {
            txtCorreoNuevo.ColorFondoNormal();
        }

        private void txtTelefonoNuevo_Enter(object sender, EventArgs e)
        {
            txtTelefonoNuevo.ColorFondoFoco();
        }

        private void txtTelefonoNuevo_Leave(object sender, EventArgs e)
        {
            txtTelefonoNuevo.ColorFondoNormal();
        }

        private void txtClaveNuevo_Enter(object sender, EventArgs e)
        {
            txtClaveNuevo.ColorFondoFoco();
        }

        private void txtClaveNuevo_Leave(object sender, EventArgs e)
        {
            txtClaveNuevo.ColorFondoNormal();
        }

        private void txtUrlFotoNuevo_Enter(object sender, EventArgs e)
        {
            txtUrlFotoNuevo.ColorFondoFoco();
        }

        private void txtUrlFotoNuevo_Leave(object sender, EventArgs e)
        {
            txtUrlFotoNuevo.ColorFondoNormal();
        }

        private void txtNombreFotoNuevo_Enter(object sender, EventArgs e)
        {
            txtNombreFotoNuevo.ColorFondoFoco();
        }

        private void txtNombreFotoNuevo_Leave(object sender, EventArgs e)
        {
            txtNombreFotoNuevo.ColorFondoNormal();
        }

        private void cmbEsActivoNuevo_Enter(object sender, EventArgs e)
        {
            cmbEsActivoNuevo.ColorCmbFoco();
        }

        private void cmbEsActivoNuevo_Leave(object sender, EventArgs e)
        {
            cmbEsActivoNuevo.ColorCmbNormal();
        }

        private void cmbRolNuevo_Enter(object sender, EventArgs e)
        {
            cmbRolNuevo.ColorCmbFoco();
        }

        private void cmbRolNuevo_Leave(object sender, EventArgs e)
        {
            cmbRolNuevo.ColorCmbNormal();
        }

        private void txtNombreEditar_Enter(object sender, EventArgs e)
        {
            txtNombreEditar.ColorFondoFoco();
        }

        private void txtNombreEditar_Leave(object sender, EventArgs e)
        {
            txtNombreEditar.ColorFondoNormal();
        }

        private void txtCorreoEditar_Enter(object sender, EventArgs e)
        {
            txtCorreoEditar.ColorFondoFoco();
        }

        private void txtCorreoEditar_Leave(object sender, EventArgs e)
        {
            txtCorreoEditar.ColorFondoNormal();
        }

        private void txtTelefonoEditar_Enter(object sender, EventArgs e)
        {
            txtTelefonoEditar.ColorFondoFoco();
        }

        private void txtTelefonoEditar_Leave(object sender, EventArgs e)
        {
            txtTelefonoEditar.ColorFondoNormal();
        }

        private void txtClaveEditar_Enter(object sender, EventArgs e)
        {
            txtClaveEditar.ColorFondoFoco();
        }

        private void txtClaveEditar_Leave(object sender, EventArgs e)
        {
            txtClaveEditar.ColorFondoNormal();
        }

        private void txtUrlFotoEditar_Enter(object sender, EventArgs e)
        {
            txtUrlFotoEditar.ColorFondoFoco();
        }

        private void txtUrlFotoEditar_Leave(object sender, EventArgs e)
        {
            txtUrlFotoEditar.ColorFondoNormal();
        }

        private void txtNombreFotoEditar_Enter(object sender, EventArgs e)
        {
            txtNombreFotoEditar.ColorFondoFoco();
        }

        private void txtNombreFotoEditar_Leave(object sender, EventArgs e)
        {
            txtNombreFotoEditar.ColorFondoNormal();
        }

        private void cmbEsActivoEditar_Enter(object sender, EventArgs e)
        {
            cmbEsActivoEditar.ColorCmbFoco();
        }

        private void cmbEsActivoEditar_Leave(object sender, EventArgs e)
        {
            cmbEsActivoEditar.ColorCmbNormal();
        }

        private void cmbRolEditar_Enter(object sender, EventArgs e)
        {
            cmbRolEditar.ColorCmbFoco();
        }

        private void cmbRolEditar_Leave(object sender, EventArgs e)
        {
            cmbRolEditar.ColorCmbNormal();
        }

        #endregion
    }
}
