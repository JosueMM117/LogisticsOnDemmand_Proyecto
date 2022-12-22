using FontAwesome.Sharp;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas;
using LogisticsOnDemmand_Proyecto.Utility_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Clientes : Form
    {
        #region Constructor
        public frm_Clientes()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            foreach (Control controls in plncontenedordatos.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                    txtidcliente.Clear();
                    txtidcliente.Select();
                    cboestado.SelectedIndex = -1;
                }
            } 
        }
        public async void CargarDatos()
        {
            try
            { 
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

                txtidcliente.ReadOnly = false;
                txtnombrecliente.ReadOnly = false;
                txtemailcliente.ReadOnly = false;
                txtdireccioncliente.ReadOnly = false;
                txttelefonocliente.ReadOnly = false;
                txttelefonocliente.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        #region Click
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
                    txtidcliente.Enabled = true;
                    txtidcliente.BackColor = Color.White;
                    txtidcliente.ReadOnly = true;
                    txtnombrecliente.ReadOnly = true;
                    txtemailcliente.ReadOnly = true;
                    txtdireccioncliente.ReadOnly = true;
                    txttelefonocliente.ReadOnly = true;
                    txttelefonocliente.ReadOnly = true;
                    Limpiar();
                }
                else
                {
                    btnadicionar.IconChar = IconChar.Ban;
                    btnadicionar.Text = "Cancelar";
                    btneditar.Enabled = false;
                    btnbuscar.Enabled = false;
                    btnborrar.Enabled = false;
                    txtidcliente.Enabled = false;
                    cboestado.Enabled = false;
                    Limpiar();
                    List<CM_Clientes> BuscarDatos = await new CN_Clientes().Listar_Clientes();
                    int cant_registros = BuscarDatos.Select(b => b.IdCliente).Count();
                    int idgenerado;

                    if (cant_registros == 0)
                        idgenerado = 1;
                    else
                    {
                        cant_registros = BuscarDatos.Select(b => b.IdCliente).Max();
                        idgenerado = cant_registros + 1;
                    }
                    txtidcliente.Text = string.Format("{0:0000}", idgenerado);
                    txtidcliente.BackColor = Color.LightGreen;
                    btnguardar.Enabled = true;
                    cboestado.SelectedIndex = 0;

                    txtidcliente.ReadOnly = false;
                    txtnombrecliente.ReadOnly = false;
                    txtemailcliente.ReadOnly = false;
                    txtdireccioncliente.ReadOnly = false;
                    txttelefonocliente.ReadOnly = false;
                    txttelefonocliente.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                var objcliente = new CM_Clientes()
                {
                    IdCliente = Convert.ToInt32(txtidcliente.Text),
                    NombreCompleto = txtnombrecliente.Text,
                    Email = txtemailcliente.Text.ToString(),
                    Telefono = txttelefonocliente.Text,
                    Telefono2 = txttelefono2cliente.Text,
                    Direccion = txtdireccioncliente.Text,
                    Estado = cboestado.GetItemText(cboestado.SelectedItem),
                    FechaRegistro = Convert.ToString(DateTime.Now.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };

                if (txtidcliente.BackColor == Color.LightGreen)
                {
                    bool respuesta = new CN_Clientes().Registrar_Clientes(objcliente, out mensaje);
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
                        txtidcliente.Enabled = true;
                        cboestado.Enabled = true;
                        txtidcliente.BackColor = Color.White;

                        txtidcliente.ReadOnly = true;
                        txtnombrecliente.ReadOnly = true;
                        txtemailcliente.ReadOnly = true;
                        txtdireccioncliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                    }
                    else
                        MessageBox.Show(mensaje, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool respuesta = await new CN_Clientes().Actualizar_InformacionCliente(objcliente);
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
                        txtidcliente.Enabled = true;
                        cboestado.Enabled = true;
                        txtidcliente.BackColor = Color.White;

                        txtidcliente.ReadOnly = true;
                        txtnombrecliente.ReadOnly = true;
                        txtemailcliente.ReadOnly = true;
                        txtdireccioncliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("No se pudieron actualizar las informaciones.\n \n Proceso Candelado.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidcliente.Text))
                {
                    MessageBox.Show("Debe seleccionar un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidcliente.Select();
                    return;
                }
                List<CM_Clientes> BuscarDatos = await new CN_Clientes().Listar_Clientes();
                var validar = BuscarDatos.Where(b => b.IdCliente == Convert.ToInt32(txtidcliente.Text)).FirstOrDefault();
                if (btneditar.IconChar == IconChar.Ban)
                {
                    btneditar.IconChar = IconChar.FilePen;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    btnborrar.Enabled = true;
                    txtidcliente.Enabled = true;
                    cboestado.Enabled = false;
                    txtidcliente.BackColor = Color.White;

                    txtidcliente.ReadOnly = true;
                    txtnombrecliente.ReadOnly = true;
                    txtemailcliente.ReadOnly = true;
                    txtdireccioncliente.ReadOnly = true;
                    txttelefonocliente.ReadOnly = true;
                    txttelefonocliente.ReadOnly = true;

                    #region Cargar_Datos_IdSelecciado
                    txtidcliente.Text = string.Format("{0:0000}", Convert.ToInt32(txtidcliente.Text));
                    txtnombrecliente.Text = validar.NombreCompleto;
                    txtemailcliente.Text = validar.Email;
                    txtdireccioncliente.Text = validar.Direccion;
                    txttelefonocliente.Text = validar.Telefono;
                    txttelefonocliente.Text = validar.Telefono2;
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
                        txtidcliente.Enabled = false;
                        cboestado.Enabled = true;
                        txtidcliente.BackColor = Color.Khaki;

                        txtidcliente.ReadOnly = false;
                        txtnombrecliente.ReadOnly = false;
                        txtemailcliente.ReadOnly = false;
                        txtdireccioncliente.ReadOnly = false;
                        txttelefonocliente.ReadOnly = false;
                        txttelefonocliente.ReadOnly = false;

                        #region Cargar_Datos_IdSeleccionado
                        txtidcliente.Text = string.Format("{0:0000}", Convert.ToInt32(txtidcliente.Text));
                        txtnombrecliente.Text = validar.NombreCompleto;
                        txtemailcliente.Text = validar.Email;
                        txtdireccioncliente.Text = validar.Direccion;
                        txttelefonocliente.Text = validar.Telefono;
                        txttelefonocliente.Text = validar.Telefono2;
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
                if (string.IsNullOrEmpty(txtidcliente.Text))
                {
                    MessageBox.Show("Debe seleccionar un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidcliente.Select();
                    return;
                }

                var objcliente = new CM_Clientes()
                {
                    IdCliente = Convert.ToInt32(txtidcliente.Text)
                };

                if (MessageBox.Show("¿Seguro que desea borrar el cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = await new CN_Clientes().Borrar_Clientes(objcliente);
                    if (respuesta == true)
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new frm_BuscarClientes())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtidcliente.Text = string.Format("{0:0000}", modal._Clientes.IdCliente);
                        txtnombrecliente.Text = modal._Clientes.NombreCompleto;
                        txtemailcliente.Text = modal._Clientes.Email;
                        txtdireccioncliente.Text = modal._Clientes.Direccion;
                        txttelefonocliente.Text = modal._Clientes.Telefono;
                        txttelefono2cliente.Text = modal._Clientes.Telefono2;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == modal._Clientes.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        cboestado.Enabled = false;
                        dgv_rutascliente.Rows.Clear();

                        txtidcliente.ReadOnly = true;
                        txtnombrecliente.ReadOnly = true;
                        txtemailcliente.ReadOnly = true;
                        txtdireccioncliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btncargarrutacliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidcliente.Text))
                {
                    MessageBox.Show("Debe indicar el Id del cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidcliente.Select();
                    return;
                }
                int codigo = int.Parse(txtidcliente.Text);
                List<CM_DetalleRuta> DetalleRutas = await new CN_Rutas().Listar_DetalleRutas();
                var buscar_rutacliente = DetalleRutas.Where(b => b.IdCliente == codigo).FirstOrDefault();
                if (buscar_rutacliente != null)
                {
                    List<CM_Rutas> Rutas = await new CN_Rutas().Listar_Rutas();
                    foreach (var item in Rutas)
                    {
                        if (item.IdRuta == buscar_rutacliente.IdRuta)
                        {
                            dgv_rutascliente.Rows.Add(new object[]
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
                    MessageBox.Show("Este Cliente no tiene rutas registradas.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //KeyPress
        private void txttelefonocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private void txtidcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private async void txtidcliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    if (string.IsNullOrEmpty(txtidcliente.Text))
                    {
                        MessageBox.Show("Debe indicar el Id del cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int codigo = int.Parse(txtidcliente.Text);
                    List<CM_Clientes> BuscarDatos = await new CN_Clientes().Listar_Clientes();
                    var validar = BuscarDatos.Where(b => b.IdCliente == codigo).FirstOrDefault();
                    if (validar != null)
                    {
                        e.SuppressKeyPress = true;
                        txtidcliente.Text = string.Format("{0:0000}", codigo);
                        txtnombrecliente.Text = validar.NombreCompleto;
                        txtemailcliente.Text = validar.Email;
                        txtdireccioncliente.Text = validar.Direccion;
                        txttelefonocliente.Text = validar.Telefono;
                        txttelefono2cliente.Text = validar.Telefono2;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        txtidcliente.SelectionStart = txtidcliente.MaxLength;
                        dgv_rutascliente.Rows.Clear();

                        txtidcliente.ReadOnly = true;
                        txtnombrecliente.ReadOnly = true;
                        txtemailcliente.ReadOnly = true;
                        txtdireccioncliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                        txttelefonocliente.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("La cliente no existe", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidcliente.SelectAll();
                        dgv_rutascliente.Rows.Clear();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion
    }
}
