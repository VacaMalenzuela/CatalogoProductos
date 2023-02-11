namespace TPWinForm_Saucedo_Valenzuela
{
    partial class frmAltaArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 298);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(37, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtnombre.Location = new System.Drawing.Point(101, 65);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(218, 22);
            this.txtnombre.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.txtdescripcion.Location = new System.Drawing.Point(101, 298);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(239, 98);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.Location = new System.Drawing.Point(101, 20);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(218, 22);
            this.txtcodigo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(393, 332);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(541, 332);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(41, 118);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(48, 16);
            this.lblmarca.TabIndex = 8;
            this.lblmarca.Text = "Marca:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(20, 162);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(69, 16);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(36, 207);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(49, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.Info;
            this.txtprecio.Location = new System.Drawing.Point(101, 203);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(218, 22);
            this.txtprecio.TabIndex = 7;
            // 
            // pbxUrl
            // 
            this.pbxUrl.Location = new System.Drawing.Point(365, 20);
            this.pbxUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(303, 286);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 14;
            this.pbxUrl.TabStop = false;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(5, 255);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(85, 16);
            this.lblurl.TabIndex = 15;
            this.lblurl.Text = "URL imagen:";
            // 
            // txturl
            // 
            this.txturl.BackColor = System.Drawing.SystemColors.Info;
            this.txturl.Location = new System.Drawing.Point(101, 251);
            this.txturl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(218, 22);
            this.txturl.TabIndex = 8;
            this.txturl.Leave += new System.EventHandler(this.txturl_Leave);
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.SystemColors.Info;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(101, 114);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(218, 24);
            this.cbxMarca.TabIndex = 16;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(101, 159);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(218, 24);
            this.cbxCategoria.TabIndex = 17;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(327, 162);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(32, 21);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 398);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.pbxUrl);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(699, 445);
            this.MinimumSize = new System.Drawing.Size(699, 445);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}