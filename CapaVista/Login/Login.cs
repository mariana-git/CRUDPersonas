using System;
using System.Windows.Forms;
using CapaLogica.Login;

namespace CapaVista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            StartPosition = FormStartPosition.CenterScreen;
            txtPass.UseSystemPasswordChar = true;
        }

        #region BUTTONS
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //antes de consultar la BD valido a nivel formulario que los textbox tengan datos
            if (txtUser.Text == string.Empty)
            {
                ErrorMessage("Ingresar Usuario");
            }
            else if (txtPass.Text == string.Empty)
            {
                ErrorMessage("Ingresar Clave");
            }
            else
            {
                //Abro este form de login en un diálogo modal desde el MAIN, si se valida el Usuario, se abre el form principal, sino se cierra toda la aplicacion
                try
                {
                    string result = new CLLoginValidate { Usuario = txtUser.Text, Clave = txtPass.Text }.Login_Validate();
                    
                    if (result == "") 
                    {
                        
                        DialogResult = DialogResult.OK;
                    }
                    else ErrorMessage(result);
                    txtPass.Text = "";
                    txtUser.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No pudo realizarse la operacion solicitada.\n\n Verifique los datos y vuelva a intentarlo\n\n\n\n" + ex.ToString());
                }
                btnLogin.Focus();
            }
        }
        #endregion

        #region METHODS
        private void ErrorMessage(string mensaje)
        {
            //muestra mensajes de error en un label de este formulario de login
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }

        #endregion

        #region EVENTS

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (lblMensajeError.Visible) lblMensajeError.Visible = false;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {

            if(lblMensajeError.Visible) lblMensajeError.Visible = false;
        }

        #endregion
    }
}
