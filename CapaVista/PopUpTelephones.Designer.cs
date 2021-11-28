
namespace CapaVista
{
    partial class PopUpTelephones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpTelephones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelRef = new System.Windows.Forms.TextBox();
            this.gbTel = new System.Windows.Forms.GroupBox();
            this.dgvTel = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mktNumTel = new System.Windows.Forms.MaskedTextBox();
            this.gbTel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTel)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 151;
            this.label4.Text = "Tipo De Teléfono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTel
            // 
            this.cmbTel.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbTel.ForeColor = System.Drawing.Color.Black;
            this.cmbTel.FormattingEnabled = true;
            this.cmbTel.Location = new System.Drawing.Point(180, 41);
            this.cmbTel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cmbTel.Name = "cmbTel";
            this.cmbTel.Size = new System.Drawing.Size(158, 24);
            this.cmbTel.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 152;
            this.label1.Text = "Número De Teléfono";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCreate.Location = new System.Drawing.Point(2, 2);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 153;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(351, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 57);
            this.btnClose.TabIndex = 154;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnDelete.Location = new System.Drawing.Point(284, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 158;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(75, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 160;
            this.label2.Text = "Referencia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelRef
            // 
            this.txtTelRef.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTelRef.ForeColor = System.Drawing.Color.Black;
            this.txtTelRef.Location = new System.Drawing.Point(180, 122);
            this.txtTelRef.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtTelRef.Name = "txtTelRef";
            this.txtTelRef.Size = new System.Drawing.Size(158, 23);
            this.txtTelRef.TabIndex = 159;
            this.txtTelRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTel
            // 
            this.gbTel.Controls.Add(this.mktNumTel);
            this.gbTel.Controls.Add(this.txtTelRef);
            this.gbTel.Controls.Add(this.label2);
            this.gbTel.Controls.Add(this.cmbTel);
            this.gbTel.Controls.Add(this.label4);
            this.gbTel.Controls.Add(this.label1);
            this.gbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbTel.ForeColor = System.Drawing.Color.Black;
            this.gbTel.Location = new System.Drawing.Point(2, 53);
            this.gbTel.Margin = new System.Windows.Forms.Padding(2);
            this.gbTel.Name = "gbTel";
            this.gbTel.Padding = new System.Windows.Forms.Padding(2);
            this.gbTel.Size = new System.Drawing.Size(381, 182);
            this.gbTel.TabIndex = 161;
            this.gbTel.TabStop = false;
            // 
            // dgvTel
            // 
            this.dgvTel.AllowUserToAddRows = false;
            this.dgvTel.AllowUserToDeleteRows = false;
            this.dgvTel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTel.Location = new System.Drawing.Point(2, 239);
            this.dgvTel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTel.Name = "dgvTel";
            this.dgvTel.ReadOnly = true;
            this.dgvTel.RowHeadersWidth = 51;
            this.dgvTel.RowTemplate.Height = 24;
            this.dgvTel.Size = new System.Drawing.Size(381, 182);
            this.dgvTel.TabIndex = 156;
            this.dgvTel.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTel_CellMouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSave.Location = new System.Drawing.Point(96, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCancel.Location = new System.Drawing.Point(190, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.gbTel);
            this.flowLayoutPanel3.Controls.Add(this.dgvTel);
            this.flowLayoutPanel3.Controls.Add(this.lblInfo);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(9, 73);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(389, 465);
            this.flowLayoutPanel3.TabIndex = 166;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCreate);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 47);
            this.flowLayoutPanel2.TabIndex = 167;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpdate.Location = new System.Drawing.Point(2, 40);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 34);
            this.btnUpdate.TabIndex = 164;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblInfo.Location = new System.Drawing.Point(3, 430);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(379, 28);
            this.lblInfo.TabIndex = 168;
            this.lblInfo.Text = "(Doble click para Seleccionar)";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mktNumTel
            // 
            this.mktNumTel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mktNumTel.Font = new System.Drawing.Font("Arial", 10F);
            this.mktNumTel.Location = new System.Drawing.Point(180, 85);
            this.mktNumTel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.mktNumTel.Mask = "000000000";
            this.mktNumTel.Name = "mktNumTel";
            this.mktNumTel.RejectInputOnFirstFailure = true;
            this.mktNumTel.Size = new System.Drawing.Size(158, 23);
            this.mktNumTel.TabIndex = 161;
            this.mktNumTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PopUpTelephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(408, 566);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopUpTelephones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentanaPopUp";
            this.Load += new System.EventHandler(this.PopUpTelephones_Load);
            this.gbTel.ResumeLayout(false);
            this.gbTel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTel)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelRef;
        private System.Windows.Forms.GroupBox gbTel;
        private System.Windows.Forms.DataGridView dgvTel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MaskedTextBox mktNumTel;
    }
}