using System;
using CapaLogica;
using CapaLogica.Login;
using CapaSoporte;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Index : Form
    {
        readonly string error = "No pudo realizarse la operacion solicitada.\n\n Verifique los datos y vuelva a intentarlo\n\n\n\n";
        readonly string success = "Operación realizada con éxito!";
        bool create;
        public Index()
        {
            InitializeComponent();
        }

        #region BUTTONS

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("C"))
            {
                InitialState();
                CVControlsReadOnly.ReadOnly(gbData, false);
                gbData.Visible = true;
                btnSave.Visible = true;
                btnClear.Visible = true;
                btnCancel.Visible = true;
                create = true;
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("R"))
            {
                InitialState();
                panelSearch.Visible = true;
                btnClose.Visible = true;
                btnSave.Visible = false;
                btnClear.Visible = false;
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("U"))
            {
                CVControlsReadOnly.ReadOnly(gbData, false);
                btnSave.Visible = true;
                btnAddTel.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnCancel.Visible = true;
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("D"))
            {
                if (lblIDPersona.Text == string.Empty) MessageBox.Show("Seleccionar una Persona de la Grilla \n\n (Doble Click sobre la fila)");
                else
                {
                    DialogResult result = MessageBox.Show($"Eliminará el registro de manera permanente", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (new CLDelete
                            {
                                IdPersona = lblIDPersona.Text
                            }.Personas_Delete())
                            {
                                MessageBox.Show(success);
                                InitialState();
                                btnRead.PerformClick();
                                btnSearch.PerformClick();
                            }
                            else MessageBox.Show(error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(error + ex.ToString());
                        }
                    }
                }
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string parameter = txtSearch.Text;
            InitialState();
            panelSearch.Visible = true;
            try
            {
                CLRead cLRead = new CLRead
                {
                    Parameter = parameter
                };
                dgvData.DataSource = cLRead.Personas_Read();

                dgvData.Visible = true;
                dgvData.Columns["IDPERSONA"].Visible = false;
                dgvData.Columns["IDDOC"].Visible = false;
                dgvData.Columns["IDPROVINCIA"].Visible = false;
                dgvData.Columns["IDPARTIDO"].Visible = false;
                dgvData.Columns["IDLOCALIDAD"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(error + ex.ToString());
            }
            txtSearch.Text="";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (create)
            {
                try
                {
                    if (CVControlsEmpty.Empty(gbData)) MessageBox.Show("Debe completar todos los campos");
                    else
                    {
                        if (new CLRead().CMB_Verify(Convert.ToInt32(cmbLoc.SelectedValue)))
                        {
                            if (new CLCreate
                            {
                                Nombre = txtPName.Text,
                                Apellido = txtPSurname.Text,
                                IdDoc = cmbTipoDoc.SelectedValue.ToString(),
                                NumDoc = mktNumDoc.Text,
                                CUIL = mktxtPCUIL.Text.Replace("-", ""),
                                Calle = txtPAdressName.Text,
                                NumCalle = txtPAdressNum.Text,
                                Piso = txtPFloor.Text,
                                Depto = txtPDepto.Text,
                                IdLocalidad = cmbLoc.SelectedValue.ToString()
                            }.Personas_Create())
                            {
                                MessageBox.Show(success);
                                InitialState();
                                btnRead.PerformClick();
                                btnSearch.PerformClick();
                            }
                            else MessageBox.Show(error);
                        }
                        else MessageBox.Show("Provincia->Partido->Localidad\nInválidos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(error + ex.ToString());
                }
            }
            else 
            {
                try
                {
                    if (CVControlsEmpty.Empty(gbData)) MessageBox.Show("Debe completar todos los campos");
                    else
                    {
                        if (new CLRead().CMB_Verify(Convert.ToInt32(cmbLoc.SelectedValue)))
                        {
                            string idPersona = lblIDPersona.Text;
                            if (
                            new CLUpdate
                            {
                                IdPersona = idPersona,
                                Nombre = txtPName.Text,
                                Apellido = txtPSurname.Text,
                                IdDoc = cmbTipoDoc.SelectedValue.ToString(),
                                NumDoc = mktNumDoc.Text,
                                CUIL = mktxtPCUIL.Text.Replace("-", ""),
                                Calle = txtPAdressName.Text,
                                NumCalle = txtPAdressNum.Text,
                                Piso = txtPFloor.Text,
                                Depto = txtPDepto.Text,
                                IdLocalidad = cmbLoc.SelectedValue.ToString()
                            }.Personas_Update())
                            {
                                MessageBox.Show(success);
                                InitialState();
                                btnRead.PerformClick();
                                btnSearch.PerformClick();
                            }
                            else MessageBox.Show(error);
                        }
                        else MessageBox.Show("Provincia->Partido->Localidad\nInválidos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(error + ex.ToString());
                }
            }
        }

        private void BtnAddTel_Click(object sender, EventArgs e)
        {
            if (CLLoginPermissions.Permissions("U") || CLLoginPermissions.Permissions("C")
                || CLLoginPermissions.Permissions("D"))
            {
                DialogResult result = new PopUpTelephones(lblIDPersona.Text).ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvTel.DataSource = new CLRead()
                    {
                        IDPersona = lblIDPersona.Text
                    }
                    .PersTel_Read();
                }
            }
            else MessageBox.Show("No tiene permisos suficientes", "DENEGADO");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CVCleanControls.CleanGB(gbData);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            InitialState();
        }

        private void BtnDispose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            gbData.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
        }

        #endregion

        #region EVENTS

        private void Index_Load(object sender, EventArgs e)
        {
            InitialState();
            lblActiveUSer.Text = CSActiveUser.Usuario;
            CVControlsOption.CMBLoad(cmbTipoDoc, "TipoDoc", "IDDOC", "DESCRIDOC");
            CVControlsOption.CMBLoad(cmbProvincia, "Provincias", "IDPROVINCIA", "DESCRIPCIA");
            cmbLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddTel.Visible = false;
            btnSave.Visible = false;
            CVCleanControls.CleanGB(gbData);
            CVControlsReadOnly.ReadOnly(gbData, true);
            gbData.Visible = true;            

            var row = (DataGridViewRow)dgvData.Rows[e.RowIndex];
            try
            {
                CVControlsOption.CMBLoad(cmbLoc, "Localidades", "IDLOCALIDAD", "DESCRILOC");
                CVControlsOption.CMBLoad(cmbPartido, "Partidos", "IDPARTIDO", "DESCRIPART");


                lblIDPersona.Text = row.Cells["IDPERSONA"].Value.ToString();
                txtPName.Text = row.Cells["NOMBRE"].Value.ToString();
                txtPSurname.Text = row.Cells["APELLIDO"].Value.ToString();
                mktNumDoc.Text = row.Cells["NUMDOC"].Value.ToString();
                txtPAdressName.Text = row.Cells["CALLE"].Value.ToString();
                txtPAdressNum.Text = row.Cells["NUMCALLE"].Value.ToString();
                txtPFloor.Text = row.Cells["PISO"].Value.ToString();
                txtPDepto.Text = row.Cells["DEPTO"].Value.ToString();
                mktxtPCUIL.Text =  row.Cells["CUIL"].Value.ToString();
                cmbLoc.SelectedValue = Convert.ToInt32(row.Cells["IDLOCALIDAD"].Value); 
                cmbPartido.SelectedValue = Convert.ToInt32(row.Cells["IDPARTIDO"].Value);
                cmbProvincia.SelectedValue = Convert.ToInt32(row.Cells["IDPROVINCIA"].Value);
                cmbTipoDoc.SelectedValue = Convert.ToInt32(row.Cells["IDDOC"].Value);

                dgvTel.DataSource = new CLRead()
                {
                    IDPersona = lblIDPersona.Text
                }
                .PersTel_Read();

                dgvTel.Columns["IDTELEFONO"].Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(error + ex.ToString());
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            CVCleanControls.CleanGB(gbData);
        }

        private void CmbPartido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CVControlsOption.CMBLoad(cmbLoc, "Localidades", "IDLOCALIDAD", "DESCRILOC",
                "IDPARTIDO", cmbPartido.SelectedValue.ToString());

        }

        private void CmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CVControlsOption.CMBLoad(cmbPartido, "Partidos", "IDPARTIDO", "DESCRIPART",
                "IDPROVINCIA", cmbProvincia.SelectedValue.ToString());
            cmbLocalidad.DataSource = null;
        }

        private void TxtPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CVControlsKeyPressEvents.OnlyLetters(e);
        }

        private void TxtPSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            CVControlsKeyPressEvents.OnlyLetters(e);
        }

        private void TxtPAdressNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            CVControlsKeyPressEvents.OnlyNumbers(e);
        }
        #endregion

        #region METHODS

        private void InitialState()
        {
            dgvData.DataSource = null;
            dgvTel.DataSource = null;
            panelSearch.Visible = false;
            dgvData.Visible = false;
            gbData.Visible = false;
            btnAddTel.Visible = false;
            btnSave.Visible = false;
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            create = false;
            txtSearch.Text = "";
            lblIDPersona.Text = "";            
            CVDesingOptions.DgvDesing(dgvData);
            CVDesingOptions.DgvDesing(dgvTel);
            CVCleanControls.CleanGB(gbData);
            CVControlsReadOnly.ReadOnly(gbData, true);
        }

        #endregion
    }
}
