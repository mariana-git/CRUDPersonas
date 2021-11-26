using System;
using CapaLogica;
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
        private void BtnDispose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            InitialState();
            CVControlsOption.ReadOnly(gbData, false);
            gbData.Visible = true;
            btnSave.Visible = true;
            btnClear.Visible = true;
            btnAddTel.Visible = true;
            btnClose.Visible = true;
            create = true;
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            InitialState();
            pnlSearch.Visible = true;
            panelButtonsFLP.Visible = true;
            btnClose.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CVControlsOption.ReadOnly(gbData, false);
            btnSave.Visible = true;
            btnAddTel.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(lblIDPersona.Text == string.Empty) MessageBox.Show("Seleccionar una Persona de la Grilla \n\n (Doble Click sobre la fila)");
            else
            {
                DialogResult result = MessageBox.Show($"Eliminará el registro de manera permanente","ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CLRead cLRead = new CLRead();
            try
            {
                cLRead.Parameter = txtSearch.Text;
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
            if (CVControlsOption.Empty(gbData)) MessageBox.Show("Debe completar todos los campos");
            else
            {
                
                try
                {
                    if (create)
                    {
                        if(new CLCreate
                        {
                            Nombre = txtPName.Text,
                            Apellido = txtPSurname.Text,
                            IdDoc = cmbTipoDoc.SelectedValue.ToString(),
                            NumDoc = txtPDoc.Text,
                            CUIL = mktxtPCUIL.Text.Replace("-", ""),
                            Calle = txtPAdressName.Text,
                            NumCalle = txtPAdressNum.Text,
                            Piso = txtPFloor.Text,
                            Depto = txtPDepto.Text,
                            IdLocalidad = cmbLocalidad.SelectedValue.ToString()
                        }.Personas_Create())
                        {
                            MessageBox.Show(success);
                            InitialState();
                            btnRead.PerformClick();
                            btnSearch.PerformClick();
                        }
                        else MessageBox.Show(error);
                    }
                    else
                    {
                        string idPersona = lblIDPersona.Text;
                        if (
                        new CLUpdate
                        {
                            IdPersona = idPersona,
                            Nombre = txtPName.Text,
                            Apellido = txtPSurname.Text,
                            IdDoc = cmbTipoDoc.SelectedValue.ToString(),
                            NumDoc = txtPDoc.Text,
                            CUIL = mktxtPCUIL.Text.Replace("-", ""),
                            Calle = txtPAdressName.Text,
                            NumCalle = txtPAdressNum.Text,
                            Piso = txtPFloor.Text,
                            Depto = txtPDepto.Text,
                            IdLocalidad = cmbLocalidad.SelectedValue.ToString()
                        }.Personas_Update())
                        {
                            MessageBox.Show(success);
                            InitialState();
                            btnRead.PerformClick();
                            btnSearch.PerformClick();
                        }
                        else MessageBox.Show(error);
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
            
            DialogResult result = new PopUpTelephones(lblIDPersona.Text).ShowDialog();
            if(result == DialogResult.OK)
            {
                dgvTel.DataSource = new CLRead()
                {
                    IDPersona = lblIDPersona.Text
                }
                .PersTel_Read();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CVCleanControls.CleanGB(gbData);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            InitialState();
        }
        #endregion

        #region EVENTS

        private void Index_Load(object sender, EventArgs e)
        {
            InitialState();
            lblActiveUSer.Text = CSActiveUser.Usuario;
            CVControlsOption.CMBLoad(cmbTipoDoc, "TipoDoc", "IDDOC", "DESCRIDOC");
            CVControlsOption.CMBLoad(cmbLocalidad, "Localidades", "IDLOCALIDAD", "DESCRILOC");
            CVControlsOption.CMBLoad(cmbPartido, "Partidos", "IDPARTIDO", "DESCRIPART");
            CVControlsOption.CMBLoad(cmbProvincia, "Provincias", "IDPROVINCIA", "DESCRIPCIA");
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddTel.Visible = false;
            CVCleanControls.CleanGB(gbData);
            gbData.Visible = true;
            CVControlsOption.ReadOnly(gbData,true);

            var row = (DataGridViewRow)dgvData.Rows[e.RowIndex];
            try
            {
                lblIDPersona.Text = row.Cells["IDPERSONA"].Value.ToString();
                txtPName.Text = row.Cells["NOMBRE"].Value.ToString();
                txtPSurname.Text = row.Cells["APELLIDO"].Value.ToString();
                txtPDoc.Text = row.Cells["NUMDOC"].Value.ToString();
                txtPAdressName.Text = row.Cells["CALLE"].Value.ToString();
                txtPAdressNum.Text = row.Cells["NUMCALLE"].Value.ToString();
                txtPFloor.Text = row.Cells["PISO"].Value.ToString();
                txtPDepto.Text = row.Cells["DEPTO"].Value.ToString();
                mktxtPCUIL.Text =  row.Cells["CUIL"].Value.ToString();
                cmbLocalidad.SelectedValue = Convert.ToInt32(row.Cells["IDLOCALIDAD"].Value); 
                cmbPartido.SelectedValue = Convert.ToInt32(row.Cells["IDPARTIDO"].Value);
                cmbProvincia.SelectedValue = Convert.ToInt32(row.Cells["IDPROVINCIA"].Value);
                cmbTipoDoc.SelectedValue = Convert.ToInt32(row.Cells["IDDOC"].Value);

                dgvTel.DataSource = new CLRead()
                {
                    IDPersona = lblIDPersona.Text
                }
                .PersTel_Read();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

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

        #endregion

        #region METHODS

        private void InitialState()
        {
            dgvData.DataSource = null;
            dgvTel.DataSource = null;
            pnlSearch.Visible = false;
            dgvData.Visible = false;
            gbData.Visible = false;
            btnAddTel.Visible = false;
            btnSave.Visible = false;
            btnClear.Visible = false;
            btnClose.Visible = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            create = false;
            txtSearch.Text = "";
            lblIDPersona.Text = "";            
            CVDesingOptions.DgvDesing(dgvData);
            CVDesingOptions.DgvDesing(dgvTel);
            CVCleanControls.CleanGB(gbData);
            CVControlsOption.ReadOnly(gbData, true);
        }

        #endregion


    }
}
