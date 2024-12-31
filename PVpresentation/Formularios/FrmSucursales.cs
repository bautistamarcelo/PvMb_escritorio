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

using System.Windows.Forms;

namespace PVpresentation.Formularios
{
    public partial class FrmSucursales : FrmModelo
    {
        #region Funcionalidades y Constructor del formulario
        private readonly IEmpresaService _empresaService;
        private readonly ISucursalesService _sucursalesService;

        public FrmSucursales(ISucursalesService sucursalesService, IEmpresaService empresaService)
        {
            InitializeComponent();
            _sucursalesService = sucursalesService;
            _empresaService = empresaService;
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

        private async Task MostrarSucursales(string Buscar = "")
        {
            var listaSucursales = await _sucursalesService.Lista(Buscar);
            var VMListaSucursales = listaSucursales.Select(item => new SucursalesVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Direccion = item.Direccion,
                Telefono = item.Telefono,
                Email = item.Email,
                EmpresaID = item.EmpresaID.ID,
                EmpresaNombre = item.EmpresaID.Nombre,
            }).ToList();
            dgvListado.DataSource = VMListaSucursales; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["EmpresaID"].Visible = false;
        }
        #endregion

        #region CRUD y Navegación del formulario
        private async void FrmSucursales_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarSucursales();

            //Completo los datos de los comboBox no enlazados con otras tablas

            var listaEmpresas = await _empresaService.Lista();
            var items = listaEmpresas.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbEmpresaEditar.InsertarItems(items);
            cmbEmpresaNuevo.InsertarItems(items);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarSucursales(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreNuevo.Text = "";
            txtDireccionNuevo.Text = "";
            txtTelefonoNuevo.Text = "";
            txtEmailNuevo.Text = "";
            txtIDnuevo.Text = "";
            cmbEmpresaNuevo.SelectedIndex = 0;

            MostrarTabs(tabNuevo.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabNuevo.Name];
            txtNombreNuevo.Select();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var SucursalSeleccionada = (SucursalesVM)dgvListado.CurrentRow.DataBoundItem;
                txtNombreEditar.Text = SucursalSeleccionada.Nombre.ToString();
                txtDireccionEditar.Text = SucursalSeleccionada.Direccion.ToString();
                txtEmailEditar.Text = SucursalSeleccionada.Email.ToString();
                txtTelefonoEditar.Text = SucursalSeleccionada.Telefono.ToString();
                txtIDEditar.Text = SucursalSeleccionada.ID.ToString();
                cmbEmpresaEditar.EstablecerValor(SucursalSeleccionada.EmpresaID);
                txtIDEditar.Visible = true; //Desabilitar cuando compruebe funcionamiento
                MostrarTabs(tabEditar.Name);

            }
        }

        private async void btnGrabarNuevo_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no se encuentren vacíos
            if (txtNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre de la sucursal es obligatorio");
                return;
            }
            if (txtDireccionNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio de la sucursal es obligatorio");
                return;
            }
            if (cmbEmpresaNuevo.SelectedIndex == 0)
            {
                MessageBox.Show("La selección de la empresa es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemEmpresas = (OpcionesComboBox)cmbEmpresaNuevo.SelectedItem!;

            //Cargo los datos en el objeto Empresa para guardarlo después
            var objeTo = new Sucursales
            {
                Nombre = txtNombreNuevo.Text.Trim(),
                Direccion = txtDireccionNuevo.Text.Trim(),
                Telefono = txtTelefonoNuevo.Text.Trim(),
                Email = txtEmailNuevo.Text.Trim(),
                EmpresaID = new Empresa { ID = itemEmpresas.Valor }
            };

            var respuesta = await _sucursalesService.crear(objeTo);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarSucursales();
                MostrarTabs(tabListado.Name);
            }
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        private async void btnGrabarEditar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no se encuentren vacíos
            if (txtNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre de la sucursal es obligatorio");
                return;
            }
            if (txtDireccionNuevo.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio de la sucursal es obligatorio");
                return;
            }
            if (cmbEmpresaNuevo.SelectedIndex == 0)
            {
                MessageBox.Show("La selección de la empresa es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemEmpresas = (OpcionesComboBox)cmbEmpresaEditar.SelectedItem!;

            //Cargo los datos en el objeto Empresa para guardarlo después
            var objeTo = new Sucursales
            {
                ID = Convert.ToInt32(txtIDEditar.Text.Trim()),
                Nombre = txtNombreEditar.Text.Trim(),
                Direccion = txtDireccionEditar.Text.Trim(),
                Telefono = txtTelefonoEditar.Text.Trim(),
                Email = txtEmailEditar.Text.Trim(),
                EmpresaID = new Empresa { ID = itemEmpresas.Valor }
            };

            var respuesta = await _sucursalesService.editar(objeTo);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarSucursales();
                MostrarTabs(tabListado.Name);
            }

        }
        #endregion

        #region Formatos de Foco
        private void txtNombreEditar_Enter(object sender, EventArgs e)
        {
            txtNombreEditar.ColorFondoFoco();
        }

        private void txtNombreEditar_Leave(object sender, EventArgs e)
        {
            txtNombreEditar.ColorFondoNormal();
        }

        private void txtDireccionEditar_Enter(object sender, EventArgs e)
        {
            txtDireccionEditar.ColorFondoFoco();
        }

        private void txtDireccionEditar_Leave(object sender, EventArgs e)
        {
            txtDireccionEditar.ColorFondoNormal();
        }

        private void txtTelefonoEditar_Enter(object sender, EventArgs e)
        {
            txtTelefonoEditar.ColorFondoFoco();
        }

        private void txtTelefonoEditar_Leave(object sender, EventArgs e)
        {
            txtTelefonoEditar.ColorFondoNormal();
        }

        private void txtEmailEditar_Enter(object sender, EventArgs e)
        {
            txtEmailEditar.ColorFondoFoco();
        }

        private void txtEmailEditar_Leave(object sender, EventArgs e)
        {
            txtEmailEditar.ColorFondoNormal();
        }

        private void cmbEmpresaEditar_Enter(object sender, EventArgs e)
        {
            cmbEmpresaEditar.ColorCmbFoco();
        }

        private void cmbEmpresaEditar_Leave(object sender, EventArgs e)
        {
            cmbEmpresaEditar.ColorCmbNormal();
        }

        private void txtNombreNuevo_Enter(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoFoco();
        }

        private void txtNombreNuevo_Leave(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoNormal();
        }

        private void txtDireccionNuevo_Enter(object sender, EventArgs e)
        {
            txtDireccionNuevo.ColorFondoFoco();
        }

        private void txtDireccionNuevo_Leave(object sender, EventArgs e)
        {
            txtDireccionNuevo.ColorFondoNormal();
        }

        private void txtTelefonoNuevo_Enter(object sender, EventArgs e)
        {
            txtTelefonoNuevo.ColorFondoFoco();
        }

        private void txtTelefonoNuevo_Leave(object sender, EventArgs e)
        {
            txtTelefonoNuevo.ColorFondoNormal();
        }

        private void txtEmailNuevo_Enter(object sender, EventArgs e)
        {
            txtEmailNuevo.ColorFondoFoco();
        }

        private void txtEmailNuevo_Leave(object sender, EventArgs e)
        {
            txtEmailNuevo.ColorFondoNormal();
        }

        private void cmbEmpresaNuevo_Enter(object sender, EventArgs e)
        {
            cmbEmpresaNuevo.ColorCmbFoco();
        }

        private void cmbEmpresaNuevo_Leave(object sender, EventArgs e)
        {
            cmbEmpresaNuevo.ColorCmbNormal();
        }
        #endregion
    }
}
