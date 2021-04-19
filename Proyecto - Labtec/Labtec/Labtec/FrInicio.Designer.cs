namespace Labtec
{
    partial class FrInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pboxInicio = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblContraOl = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.ttlpMensajes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIDUsuario.Location = new System.Drawing.Point(96, 120);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtIDUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtClave.Location = new System.Drawing.Point(96, 164);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(152, 20);
            this.txtClave.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 23);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "INICIO DE SESIÓN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Labtec.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(51, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Labtec.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(51, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxCerrar
            // 
            this.pBoxCerrar.Image = global::Labtec.Properties.Resources.Cerrar;
            this.pBoxCerrar.Location = new System.Drawing.Point(273, 6);
            this.pBoxCerrar.Name = "pBoxCerrar";
            this.pBoxCerrar.Size = new System.Drawing.Size(61, 40);
            this.pBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCerrar.TabIndex = 7;
            this.pBoxCerrar.TabStop = false;
            this.pBoxCerrar.Click += new System.EventHandler(this.pBoxCerrar_Click);
            // 
            // pboxInicio
            // 
            this.pboxInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboxInicio.Image = global::Labtec.Properties.Resources.user1;
            this.pboxInicio.Location = new System.Drawing.Point(0, 0);
            this.pboxInicio.Name = "pboxInicio";
            this.pboxInicio.Size = new System.Drawing.Size(340, 76);
            this.pboxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxInicio.TabIndex = 6;
            this.pboxInicio.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.BackgroundImage = global::Labtec.Properties.Resources.panelTec2;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.Silver;
            this.btnAceptar.Location = new System.Drawing.Point(34, 237);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(270, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblContraOl
            // 
            this.lblContraOl.AutoSize = true;
            this.lblContraOl.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.lblContraOl.ForeColor = System.Drawing.Color.Black;
            this.lblContraOl.Location = new System.Drawing.Point(68, 201);
            this.lblContraOl.Name = "lblContraOl";
            this.lblContraOl.Size = new System.Drawing.Size(211, 23);
            this.lblContraOl.TabIndex = 33;
            this.lblContraOl.Text = "¿Olvidaste tu contraseña?";
            this.lblContraOl.Click += new System.EventHandler(this.lblContraOl_Click);
            this.lblContraOl.MouseLeave += new System.EventHandler(this.lblContraOl_MouseLeave);
            this.lblContraOl.MouseHover += new System.EventHandler(this.lblContraOl_MouseHover);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.pictureBox2);
            this.pnlControl.Controls.Add(this.lblTitulo);
            this.pnlControl.Controls.Add(this.pictureBox1);
            this.pnlControl.Controls.Add(this.lblContraOl);
            this.pnlControl.Controls.Add(this.txtClave);
            this.pnlControl.Controls.Add(this.btnAceptar);
            this.pnlControl.Controls.Add(this.txtIDUsuario);
            this.pnlControl.Controls.Add(this.pBoxCerrar);
            this.pnlControl.Controls.Add(this.pboxInicio);
            this.pnlControl.Location = new System.Drawing.Point(5, 11);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(340, 295);
            this.pnlControl.TabIndex = 34;
            // 
            // ttlpMensajes
            // 
            this.ttlpMensajes.IsBalloon = true;
            // 
            // FrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 315);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pboxInicio;
        private System.Windows.Forms.PictureBox pBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContraOl;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.ToolTip ttlpMensajes;
    }
}

