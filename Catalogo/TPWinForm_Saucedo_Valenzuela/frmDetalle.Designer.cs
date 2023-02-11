
namespace TPWinForm_Saucedo_Valenzuela
{
    partial class frmDetalle
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
            this.txtDetalleCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.ptbDetalle = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetalleCodigo
            // 
            this.txtDetalleCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtDetalleCodigo.Location = new System.Drawing.Point(60, 17);
            this.txtDetalleCodigo.Name = "txtDetalleCodigo";
            this.txtDetalleCodigo.ReadOnly = true;
            this.txtDetalleCodigo.Size = new System.Drawing.Size(177, 20);
            this.txtDetalleCodigo.TabIndex = 5;
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreDetalle.Location = new System.Drawing.Point(60, 58);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(177, 20);
            this.txtNombreDetalle.TabIndex = 6;
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecioDetalle.Location = new System.Drawing.Point(60, 97);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioDetalle.TabIndex = 7;
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(11, 20);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoDetalle.TabIndex = 8;
            this.lblCodigoDetalle.Text = "Codigo:";
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.Location = new System.Drawing.Point(11, 58);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDetalle.TabIndex = 9;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(11, 97);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioDetalle.TabIndex = 10;
            this.lblPrecioDetalle.Text = "Precio:";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(11, 132);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionDetalle.TabIndex = 11;
            this.lblDescripcionDetalle.Text = "Descripcion:";
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(14, 158);
            this.txtDescripcionDetalle.Multiline = true;
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(225, 69);
            this.txtDescripcionDetalle.TabIndex = 12;
            // 
            // ptbDetalle
            // 
            this.ptbDetalle.Location = new System.Drawing.Point(272, 9);
            this.ptbDetalle.Name = "ptbDetalle";
            this.ptbDetalle.Size = new System.Drawing.Size(238, 266);
            this.ptbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDetalle.TabIndex = 13;
            this.ptbDetalle.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(93, 245);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 32);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 286);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbDetalle);
            this.Controls.Add(this.txtDescripcionDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblCodigoDetalle);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.txtNombreDetalle);
            this.Controls.Add(this.txtDetalleCodigo);
            this.MaximumSize = new System.Drawing.Size(540, 325);
            this.MinimumSize = new System.Drawing.Size(540, 325);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalleCodigo;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.PictureBox ptbDetalle;
        private System.Windows.Forms.Button btnOk;
    }
}