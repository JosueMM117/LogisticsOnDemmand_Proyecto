using FontAwesome.Sharp;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas;
using LogisticsOnDemmand_Proyecto.Utility_Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Vehiculos : Form
    {
        public CN_Vehiculos cn_vehiculos = new CN_Vehiculos();
        public CN_Rutas cn_rutas = new CN_Rutas(); 

        #region Constructor
        public frm_Vehiculos()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidvehiculo.Select();
            txtidvehiculo.Clear();
            txtidconductor.Text = "";
            txtnombrevehiculo.Clear();
            txtnombreconductor.Text = "";
            txtmarca.Clear();
            txtidentificacion.Clear();
            nupcargamaxima.Value = 1;
            nupcargaminima.Value = 1;
            nuphoraiodisponibilidad.Value = 1;
            cbohabilidad.SelectedIndex = -1;
            cboestado.SelectedIndex = -1;
        }
        public async void CargarDatos()
        {
            try
            {
                //Habilidades
                List<CM_Habilidades> listahabilidades = await cn_vehiculos.Listar_Habilidades();
                foreach (CM_Habilidades item in listahabilidades)
                {
                    cbohabilidad.Items.Add(new OpcionCombo() { IdPos = item.IdHabilidad, Texto = item.Descripcion });
                }
                cbohabilidad.DisplayMember = "Texto";
                cbohabilidad.ValueMember = "Valor";
                cbohabilidad.SelectedIndex = 0;

                //Estado
                List<OpcionCombo> listaestado = new List<OpcionCombo>
                {
                    new OpcionCombo() { IdPos = 0, Texto = "Activo" },
                    new OpcionCombo() { IdPos = 1, Texto = "Inactivo" }
                };
                foreach (OpcionCombo estados in listaestado)
                {
                    cboestado.Items.Add(new OpcionCombo() { IdPos = estados.IdPos, Texto = estados.Texto });
                }
                cboestado.DisplayMember = "Texto";
                cboestado.ValueMember = "IdPos";
                cboestado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        #endregion

        #region Eventos

        //Load 
        private void frm_Vehiculos_Load(object sender, EventArgs e)
        {
            txtidvehiculo.Select();
            btnguardar.Enabled = false;
            btnbuscarconductor.Enabled = false;
            CargarDatos();
        }

        #region Click
        private async void btnhabilidad_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["frm_Habilidades"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new frm_Habilidades();
                open.ShowDialog();
                if (open.DialogResult == DialogResult.OK)
                {
                    //Volver a llenar el combo al momento de cerrar el frm_Habilidades, en caso de que se haya creado una nueva.
                    cbohabilidad.Items.Clear();
                    List<CM_Habilidades> listahabilidades = await cn_vehiculos.Listar_Habilidades();
                    foreach (CM_Habilidades item in listahabilidades)
                    {
                        cbohabilidad.Items.Add(new OpcionCombo() { IdPos = item.IdHabilidad, Texto = item.Descripcion });
                    }
                    cbohabilidad.DisplayMember = "Texto";
                    cbohabilidad.ValueMember = "Valor";
                    cbohabilidad.SelectedIndex = 0;
                }
            }
        }
        private void btnbuscarconductor_Click(object sender, EventArgs e)
        {
            try
            {
                using (var new_modal = new frm_BuscarUsuarios())
                {
                    var resultado = new_modal.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        if (new_modal._Usuarios.Rol != "Conductor")
                            MessageBox.Show("El usuario que sea asignar debe ser un conductor.","Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (new_modal._Usuarios.Estado == "Inactivo")
                            MessageBox.Show("El conductor se encuentra inactivo.", "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else      
                        {
                             txtidconductor.Text = new_modal._Usuarios.IdUsuario.ToString();
                             txtnombreconductor.Text = new_modal._Usuarios.NombreCompleto;
                        }        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnadicionar.IconChar == IconChar.Ban)
                {
                    btnadicionar.IconChar = IconChar.FileCirclePlus;
                    btnadicionar.Text = "Adicionar";
                    btnguardar.Enabled = false;
                    btneditar.Enabled = true;
                    btnbuscar.Enabled = true;
                    btnborrar.Enabled = true;
                    txtidvehiculo.Enabled = true;
                    btnbuscarconductor.Enabled = false;
                    txtidvehiculo.BackColor = Color.White;
                    Limpiar();
                }
                else
                {
                    btnadicionar.IconChar = IconChar.Ban;
                    btnadicionar.Text = "Cancelar";
                    btneditar.Enabled = false;
                    btnbuscar.Enabled = false;
                    btnborrar.Enabled = false;
                    txtidvehiculo.Enabled = false;
                    cboestado.Enabled = false;
                    btnbuscarconductor.Enabled = true;
                    Limpiar();
                    List<CM_Vehiculos> BuscarDatos = await cn_vehiculos.Listar_Vehículos();
                    int cant_registros = BuscarDatos.Select(b => b.IdVehiculo).Count();
                    int idgenerado;

                    if (cant_registros == 0)
                        idgenerado = 1;
                    else
                    {
                        cant_registros = BuscarDatos.Select(b => b.IdVehiculo).Max();
                        idgenerado = cant_registros + 1;
                    }
                    txtidvehiculo.Text = string.Format("{0:0000}", idgenerado);
                    txtidvehiculo.BackColor = Color.LightGreen;
                    btnguardar.Enabled = true;
                    txtidconductor.Text = "0";
                    cboestado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                if (nuphoraiodisponibilidad.Value < 0 || nuphoraiodisponibilidad.Value > 24)
                {
                    MessageBox.Show("La cantidad de horas de disponibilidad no puede ser mayor a 24 horas o menor a 1 hora.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var objvehiculo = new CM_Vehiculos()
                {
                    IdVehiculo = Convert.ToInt32(txtidvehiculo.Text),
                    NombreVehiculo = txtnombrevehiculo.Text.ToString(),
                    Marca = txtmarca.Text.ToString(),
                    CargaMaxima = Convert.ToInt32(nupcargamaxima.Value),
                    CargaMinima = Convert.ToInt32(nupcargaminima.Value),
                    Identificacion = txtidentificacion.Text.ToString(),
                    HorarioDisponibilidad = Convert.ToInt32(nuphoraiodisponibilidad.Value),
                    Conductor = new CM_Usuarios
                    {
                        IdUsuario = Convert.ToInt32(txtidconductor.Text),
                        NombreCompleto = txtnombreconductor.Text.ToString()
                    },
                    Habilidades = new CM_Habilidades
                    {
                        IdHabilidad = Convert.ToInt32(((OpcionCombo)cbohabilidad.SelectedItem).IdPos.ToString()),
                        Descripcion = ((OpcionCombo)cbohabilidad.SelectedItem).Texto.ToLower()
                    },
                    Estado = cboestado.GetItemText(cboestado.SelectedItem),
                    FechaRegistro = Convert.ToDateTime(DateTime.Now.Date.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };

                if (txtidvehiculo.BackColor == Color.LightGreen)
                {
                    bool respuesta = cn_vehiculos.Registrar_Vehiculo(objvehiculo, out mensaje);
                    if (respuesta == true)
                    {
                        btnadicionar.IconChar = IconChar.FileCirclePlus;
                        btnadicionar.Text = "Adicionar";
                        btneditar.IconChar = IconChar.FilePen;
                        btneditar.Text = "Editar";
                        btnguardar.Enabled = false;
                        btneditar.Enabled = true;
                        btnborrar.Enabled = true;
                        btnadicionar.Enabled = true;
                        btnbuscar.Enabled = true;
                        txtidvehiculo.Enabled = true;
                        cboestado.Enabled = true;
                        btnbuscarconductor.Enabled = false;
                        txtidvehiculo.BackColor = Color.White;
                    }
                    else
                        MessageBox.Show(mensaje, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool respuesta = await cn_vehiculos.Actualizar_InformacionVehiculos(objvehiculo);
                    if (respuesta == true)
                    {
                        btnadicionar.IconChar = IconChar.FileCirclePlus;
                        btnadicionar.Text = "Adicionar";
                        btneditar.IconChar = IconChar.FilePen;
                        btneditar.Text = "Editar";
                        btnguardar.Enabled = false;
                        btneditar.Enabled = true;
                        btnborrar.Enabled = true;
                        btnadicionar.Enabled = true;
                        btnbuscar.Enabled = true;
                        txtidvehiculo.Enabled = true;
                        cboestado.Enabled = true;
                        btnbuscarconductor.Enabled = false;
                        txtidvehiculo.BackColor = Color.White;
                    }
                    else
                        MessageBox.Show("No se pudieron actualizar las informaciones.\n \n Proceso Candelado.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidvehiculo.Text))
                {
                    MessageBox.Show("Debe seleccionar un vehículo.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                List<CM_Vehiculos> BuscarDatos = await cn_vehiculos.Listar_Vehículos();
                var validar = BuscarDatos.Where(b => b.IdVehiculo == Convert.ToInt32(txtidvehiculo.Text)).FirstOrDefault();
                if (btneditar.IconChar == IconChar.Ban)
                {
                    btneditar.IconChar = IconChar.FilePen;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    btnborrar.Enabled = true;
                    txtidvehiculo.Enabled = true;
                    cboestado.Enabled = false;
                    txtidvehiculo.BackColor = Color.White;
                    btnbuscarconductor.Enabled = false;

                    txtnombrevehiculo.ReadOnly = true;
                    txtmarca.ReadOnly = true;
                    txtidentificacion.ReadOnly = true;
                    nupcargamaxima.ReadOnly = true;
                    nupcargaminima.ReadOnly = true;
                    nuphoraiodisponibilidad.ReadOnly = true;

                    #region Cargar_Datos_IdSelecciado
                    txtidvehiculo.Text = string.Format("{0:000}", Convert.ToInt32(txtidvehiculo.Text));
                    txtnombrevehiculo.Text = validar.NombreVehiculo;
                    txtidconductor.Text = validar.Conductor.IdUsuario.ToString();
                    txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                    txtmarca.Text = validar.Marca;
                    txtidentificacion.Text = validar.Identificacion;
                    nupcargamaxima.Value = validar.CargaMaxima;
                    nupcargaminima.Value = validar.CargaMinima;
                    nuphoraiodisponibilidad.Value = Convert.ToInt32(validar.HorarioDisponibilidad);
                    foreach (OpcionCombo oc in cbohabilidad.Items)
                    {
                        if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(validar.Habilidades.IdHabilidad))
                        {
                            int indice_combo = cbohabilidad.Items.IndexOf(oc);
                            cbohabilidad.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (oc.Texto == validar.Estado)
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    #endregion
                }
                else
                {
                    if (validar != null)
                    {
                        btneditar.IconChar = IconChar.Ban;
                        btneditar.Text = "Cancelar";
                        btnguardar.Enabled = true;
                        btnadicionar.Enabled = false;
                        btnborrar.Enabled = false;
                        btnbuscar.Enabled = false;
                        txtidvehiculo.Enabled = false;
                        cboestado.Enabled = true;
                        btnbuscarconductor.Enabled = true;
                        txtidvehiculo.BackColor = Color.Khaki;

                        txtnombrevehiculo.ReadOnly = false;
                        txtmarca.ReadOnly = false;
                        txtidentificacion.ReadOnly = false;
                        nupcargamaxima.ReadOnly = false;
                        nupcargaminima.ReadOnly = false;
                        nuphoraiodisponibilidad.ReadOnly = false;

                        #region Cargar_Datos_IdSeleccionado
                        txtidvehiculo.Text = string.Format("{0:000}", Convert.ToInt32(txtidvehiculo.Text));
                        txtnombrevehiculo.Text = validar.NombreVehiculo;
                        txtidconductor.Text = validar.Conductor.IdUsuario.ToString();
                        txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                        txtmarca.Text = validar.Marca;
                        txtidentificacion.Text = validar.Identificacion;
                        nupcargamaxima.Value = validar.CargaMaxima;
                        nupcargaminima.Value = validar.CargaMinima;
                        nuphoraiodisponibilidad.Value = Convert.ToInt32(validar.HorarioDisponibilidad);
                        foreach (OpcionCombo oc in cbohabilidad.Items)
                        {
                            if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(validar.Habilidades.IdHabilidad))
                            {
                                int indice_combo = cbohabilidad.Items.IndexOf(oc);
                                cbohabilidad.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        #endregion
                    }
                    else
                        MessageBox.Show("Debe seleccionar el vehículo que desea editar", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidvehiculo.Text))
                {
                    MessageBox.Show("Debe seleccionar un vehículo.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var objvehiculo = new CM_Vehiculos
                {
                    IdVehiculo = Convert.ToInt32(txtidvehiculo.Text)
                };

                if (MessageBox.Show("¿Seguro que desea borrar el vehículo?", "Vehículos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = await cn_vehiculos.Borrar_Vehiculos(objvehiculo);
                    if (respuesta == true)
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new frm_BuscarVehiculos())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtidvehiculo.Text = string.Format("{0:000}", modal._Vehiculos.IdVehiculo);
                        txtnombrevehiculo.Text = modal._Vehiculos.NombreVehiculo;
                        txtidconductor.Text = modal._Vehiculos.Conductor.IdUsuario.ToString();
                        txtnombreconductor.Text = modal._Vehiculos.Conductor.NombreCompleto;
                        txtmarca.Text = modal._Vehiculos.Marca;
                        txtidentificacion.Text = modal._Vehiculos.Identificacion;
                        nupcargamaxima.Value = modal._Vehiculos.CargaMaxima;
                        nupcargaminima.Value = modal._Vehiculos.CargaMinima;
                        nuphoraiodisponibilidad.Value = Convert.ToInt32(modal._Vehiculos.HorarioDisponibilidad);

                        foreach (OpcionCombo oc in cbohabilidad.Items)
                        {
                            if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(modal._Vehiculos.Habilidades.IdHabilidad))
                            {
                                int indice_combo = cbohabilidad.Items.IndexOf(oc);
                                cbohabilidad.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == modal._Vehiculos.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        cboestado.Enabled = false;
                        dgv_rutasvehiculo.Rows.Clear();

                        txtnombrevehiculo.ReadOnly = true;
                        txtmarca.ReadOnly = true;
                        txtidentificacion.ReadOnly = true;
                        nupcargamaxima.ReadOnly = true;
                        nupcargaminima.ReadOnly = true;
                        nuphoraiodisponibilidad.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btncargarrutavehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidvehiculo.Text))
                {
                    MessageBox.Show("Debe indicar el Id del vehículo.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int codigo = int.Parse(txtidvehiculo.Text);
                List<CM_DetalleRuta> DetalleRutas = await cn_rutas.Listar_DetalleRutas();
                var buscar_rutavehiculo = DetalleRutas.Where(b => b.IdVehiculo == codigo);
                if (buscar_rutavehiculo != null)
                {
                    List<CM_Rutas> Rutas = await cn_rutas.Listar_Rutas();
                    var rutas = buscar_rutavehiculo.Where(b => b.IdVehiculo == codigo).FirstOrDefault();
                    //var cargarruta = Rutas.Where(b => b.IdRuta.Equals(rutas.IdRuta));
                    foreach (var item in Rutas)
                    {
                        if (item.IdRuta == rutas.IdRuta)
                        {
                            dgv_rutasvehiculo.Rows.Add(new object[]
                            {
                                string.Format("{0:0000}",item.IdRuta),
                                item.Titulo,
                                item.Concepto,
                                string.Format("{0:dd-MMM-yyy}",item.Fecha_Entrega),
                                item.Tiempo_Ruta,
                                item.Cargas,
                                item.Comentarios,
                                item.Prioridad,
                                item.Estado,
                                string.Format("{0:dd-MMM-yyy}",item.FechaRegistro)
                            });
                        }
                    }
                }
                else
                    MessageBox.Show("Este vehículo no tiene rutas asignadas.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        //KeyPress
        private void txtidvehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private async void txtidvehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    if (string.IsNullOrEmpty(txtidvehiculo.Text))
                    {
                        MessageBox.Show("Debe indicar el Id del vehículo.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int codigo = int.Parse(txtidvehiculo.Text);
                    List<CM_Vehiculos> BuscarDatos = await cn_vehiculos.Listar_Vehículos();
                    var validar = BuscarDatos.Where(b => b.IdVehiculo == codigo).FirstOrDefault();
                    if (validar != null)
                    {
                        e.SuppressKeyPress = true;
                        txtidvehiculo.Text = string.Format("{0:000}", codigo);
                        txtnombrevehiculo.Text = validar.NombreVehiculo;
                        txtidconductor.Text = validar.Conductor.IdUsuario.ToString();
                        txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                        txtmarca.Text = validar.Marca;
                        txtidentificacion.Text = validar.Identificacion;
                        nupcargamaxima.Value = validar.CargaMaxima;
                        nupcargaminima.Value = validar.CargaMinima;
                        nuphoraiodisponibilidad.Value = Convert.ToInt32(validar.HorarioDisponibilidad);
                        foreach (OpcionCombo oc in cbohabilidad.Items)
                        {
                            if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(validar.Habilidades.IdHabilidad))
                            {
                                int indice_combo = cbohabilidad.Items.IndexOf(oc);
                                cbohabilidad.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        txtidvehiculo.SelectionStart = txtidvehiculo.MaxLength;
                        dgv_rutasvehiculo.Rows.Clear();

                        txtnombrevehiculo.ReadOnly = true;
                        txtmarca.ReadOnly = true;
                        txtidentificacion.ReadOnly = true;
                        nupcargamaxima.ReadOnly = true;
                        nupcargaminima.ReadOnly = true;
                        nuphoraiodisponibilidad.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("La vehículo no existe", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidvehiculo.SelectAll();
                        dgv_rutasvehiculo.Rows.Clear();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion   
    }
}
