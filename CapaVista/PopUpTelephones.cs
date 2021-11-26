using System;
using CapaLogica;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class PopUpTelephones : Form
    {
        bool create;
        string idPersona;
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
            InitialState();
            btnCreate.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            CVControlsOption.ReadOnly(gbData, false);
            create = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtTelNumber.Text == "" || cmbTel.SelectedIndex == -1) MessageBox.Show("Debe seleccionar un Tipo de Teléfono y consignar un Número");
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
                            Telefono = txtTelNumber.Text,
                            Referencia = txtTelRef.Text

                        }.PersTel_Create())
                        {
                            MessageBox.Show(success);
                            InitialState();
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
                            Telefono = txtTelNumber.Text,
                            Referencia = txtTelRef.Text
                        }.PersTel_Update())
                        {
                            MessageBox.Show(success);
                            InitialState();
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

        #endregion

        #region METHODS
        private void ReLoadTels()
        {
            dgvTel.DataSource = new CLRead()
            {
                IDPersona = idPersona
            }
                .PersTel_Read();
        }

        private void InitialState()
        {
            btnCreate.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            create = false;
            CVControlsOption.ReadOnly(gbData, true);
            CVCleanControls.CleanGB(gbData);
            ReLoadTels();
        }

        #endregion

    }
}
