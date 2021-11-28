using System;
using CapaLogica;
using CapaLogica.Login;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class PopUpTelephones : Form
    {
        bool create;
        readonly string idPersona;
        readonly string error = "No pudo realizarse la operacion solicitada.\n\n Verifique los datos y vuelva a intentarlo\n\n\n\n";
        readonly string success = "Operación realizada con éxito!";

        public PopUpTelephones(string idpersona)
        {
            InitializeComponent();
            idPersona = idpersona;
        }

        #region BUTTONS

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("C"))
            {
                InitialState();
                dgvTel.Visible = false;
                lblInfo.Visible = false;
                btnCreate.Visible = false;
                btnCancel.Visible = true;
                btnSave.Visible = true;
                gbTel.Visible = true;
                CVControlsReadOnly.ReadOnly(gbTel, false);
                create = true;
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("U"))
            {
                CVControlsReadOnly.ReadOnly(gbTel, false);
                btnUpdate.Visible = false;
                btnSave.Visible = true;
            }               
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("D"))
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el registro de manera permanente?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (new CLDelete
                        {
                            IdPersona = idPersona,
                            IdTelefono = dgvTel.CurrentRow.Cells["IDTELEFONO"].Value.ToString()
                        }.PersTel_Delete())
                        {
                            MessageBox.Show(success);
                        }
                        else MessageBox.Show(error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(error + ex.ToString());
                    }
                }
                InitialState();
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (mktNumTel.Text == "" || cmbTel.SelectedIndex == -1) MessageBox.Show("Debe seleccionar un Tipo de Teléfono y consignar un Número");
            else
            {
                try
                {
                    if (create)
                    {
                        if (new CLCreate
                        {
                            IdPersona = idPersona,
                            IdTelefono = cmbTel.SelectedValue.ToString(),
                            Telefono = mktNumTel.Text,
                            Referencia = txtTelRef.Text

                        }.PersTel_Create())
                        {
                            MessageBox.Show(success);
                        }
                        else MessageBox.Show(error);
                    }
                    else
                    {
                        if (
                        new CLUpdate
                        {
                            IdPersona = idPersona,
                            IdTelefono = cmbTel.SelectedValue.ToString(),
                            Telefono = mktNumTel.Text,
                            Referencia = txtTelRef.Text
                        }.PersTel_Update())
                        {
                            MessageBox.Show(success);
                        }
                        else MessageBox.Show(error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(error + ex.ToString());
                }
                InitialState();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            InitialState();
        }
        #endregion

        #region EVENTS

        private void PopUpTelephones_Load(object sender, EventArgs e)
        {

            CVDesingOptions.DgvDesing(dgvTel);
            CVControlsOption.CMBLoad(cmbTel, "Telefonos", "IDTELEFONO", "DESCRITEL");
            InitialState();
        }

        private void DgvTel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCreate.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            gbTel.Visible = true;
            var row = (DataGridViewRow)dgvTel.Rows[e.RowIndex];
            mktNumTel.Text = row.Cells["TELEFONO"].Value.ToString();
            txtTelRef.Text = row.Cells["REFERENCIA"].Value.ToString();
            cmbTel.SelectedValue = Convert.ToInt32(row.Cells["IDTELEFONO"].Value);
            dgvTel.Visible = false;
            lblInfo.Visible = false;
        }

        #endregion

        #region METHODS

        private void ReLoadTels()
        {
            dgvTel.DataSource = new CLRead()
            {
                IDPersona = idPersona
            }
                .PersTel_Read();
            dgvTel.Columns["IDTELEFONO"].Visible = false;
        }

        private void InitialState()
        {
            btnCreate.Visible = true;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            gbTel.Visible = false;
            dgvTel.Visible = true;
            create = false;
            lblInfo.Visible = true;
            CVControlsReadOnly.ReadOnly(gbTel, true);
            CVCleanControls.CleanGB(gbTel);
            ReLoadTels();
        }

        #endregion
    }
}
