
namespace CapaVista
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.panelLogin.Controls.Add(this.lblMensajeError);
            this.panelLogin.Controls.Add(this.btnClose);
            this.panelLogin.Controls.Add(this.panel3);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lblSegundo);
            this.panelLogin.Controls.Add(this.lblPrimero);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogin.Location = new System.Drawing.Point(174, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(278, 329);
            this.panelLogin.TabIndex = 3;
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensajeError.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblMensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lblMensajeError.Image")));
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(38, 209);
            this.lblMensajeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(154, 18);
            this.lblMensajeError.TabIndex = 8;
            this.lblMensajeError.Text = "      Mensaje de Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeError.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(226, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.panel3.Location = new System.Drawing.Point(60, 176);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(59, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 1);
            this.panel2.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnLogin.Location = new System.Drawing.Point(59, 249);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Tempus Sans ITC", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.lblSegundo.Location = new System.Drawing.Point(58, 131);
            this.lblSegundo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(111, 23);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Constraseña";
            // 
            // lblPrimero
            // 
            this.lblPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Font = new System.Drawing.Font("Tempus Sans ITC", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.lblPrimero.Location = new System.Drawing.Point(58, 72);
            this.lblPrimero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(76, 23);
            this.lblPrimero.TabIndex = 2;
            this.lblPrimero.Text = "Usuario";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(60, 153);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(126, 17);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Arial", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(61, 92);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(126, 17);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(26, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}