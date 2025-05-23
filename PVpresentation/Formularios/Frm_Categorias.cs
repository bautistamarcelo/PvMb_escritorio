﻿using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Categorias : FrmModeloCRUD
    {
        #region Funcionalidades y Constructor del formulario
        private readonly ICategoriaService _categoriasService;
        public Frm_Categorias(ICategoriaService categoriaService)
        {
            InitializeComponent();
            _categoriasService = categoriaService;
            
        }

        private Frm_Productos ObtenerFormularioAbierto()
        {
            foreach (Form formPadre in Application.OpenForms)
            {
                if (formPadre is Frm_Productos)
                {
                    return (Frm_Productos)formPadre;
                }
            }
            return null; // No se encontró un formulario abierto de tipo Frm_Productos
        }

        public void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;

        }

        private async Task MostrarCategorias(string Buscar = "")
        {

            var listaCategorias = await _categoriasService.Lista(Buscar);
            var VMListaCategorias = listaCategorias.Select(item => new Categorias //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
            }).ToList();
            dgvListado.DataSource = VMListaCategorias; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
        }

        #endregion

        private async void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            await MostrarCategorias();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarCategorias(txtBuscar.Text.Trim()!);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            txtNombre.Enabled = true;
            txtNombre.Select();
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var CategoriaSeleccionada = (Categorias)dgvListado.CurrentRow.DataBoundItem;
                txtNombre.Text = CategoriaSeleccionada.Nombre.ToString();
                txtID.Text = CategoriaSeleccionada.ID.ToString();
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                txtNombre.Enabled = true;
                txtNombre.ReadOnly = false;
                txtNombre.Select();
                btnGrabar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //var CategoriaSeleccionada = (Categorias)dgvListado.CurrentRow.DataBoundItem;
            //txtNombre.Text = CategoriaSeleccionada.Nombre.ToString();
            //txtID.Text = CategoriaSeleccionada.ID.ToString();
            //txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
            //txtNombre.Enabled = true;
            //txtNombre.ReadOnly = false;
            //txtNombre.Select();
            //btnGrabar.Enabled = true;
            //btnCancelar.Enabled = true;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            await MostrarCategorias();
        }

        public async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre de la categoria es obligatorio");
                return;
            }

            //Cargo los datos en el objeto Empresa para guardarlo después
            var miID = 0;
            if (txtID.Text.Trim() == "")
            {
                miID = 0;
            }
            else
            {
                miID = Convert.ToInt32(txtID.Text.Trim()!);
            }

            var objeTo = new Categorias
            {
                ID = miID,
                Nombre = txtNombre.Text.Trim()
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _categoriasService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _categoriasService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategorias();
                MostrarTabs(tabListado.Name);

                Frm_Productos fProd = ObtenerFormularioAbierto();
                if (fProd != null)
                {
                    fProd.CambiarVisibilidadControles();

                    await fProd.agregarCategoriaComboBox(txtNombre.Text.Trim());
                    fProd.cmbCategoria.Sorted = true;
                    fProd.cmbCategoria.Select();
                }
                LimpiarMantenimiento();
            }
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {

        }


    }
}
