namespace APIWForms
{
    partial class Form1
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
            System.Windows.Forms.Button btnapi;
            System.Windows.Forms.Button btninformacion;
            System.Windows.Forms.Button btnreiniciar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblojos = new System.Windows.Forms.Label();
            this.txtojos = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            btnapi = new System.Windows.Forms.Button();
            btninformacion = new System.Windows.Forms.Button();
            btnreiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnapi
            // 
            btnapi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnapi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnapi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnapi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnapi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnapi.ForeColor = System.Drawing.Color.Black;
            btnapi.Location = new System.Drawing.Point(242, 137);
            btnapi.Name = "btnapi";
            btnapi.Size = new System.Drawing.Size(185, 57);
            btnapi.TabIndex = 0;
            btnapi.Text = "LLAMADA API";
            btnapi.UseVisualStyleBackColor = false;
            btnapi.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // btninformacion
            // 
            btninformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btninformacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btninformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btninformacion.ForeColor = System.Drawing.Color.Black;
            btninformacion.Location = new System.Drawing.Point(242, 195);
            btninformacion.Name = "btninformacion";
            btninformacion.Size = new System.Drawing.Size(185, 57);
            btninformacion.TabIndex = 9;
            btninformacion.Text = "¿QUIEN ES?";
            btninformacion.UseVisualStyleBackColor = false;
            btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtname.Location = new System.Drawing.Point(91, 155);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(110, 35);
            this.txtname.TabIndex = 1;
            this.txtname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtaltura.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtaltura.Location = new System.Drawing.Point(91, 213);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(110, 35);
            this.txtaltura.TabIndex = 3;
            this.txtaltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblaltura
            // 
            this.lblaltura.BackColor = System.Drawing.Color.Transparent;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblaltura.Location = new System.Drawing.Point(23, 213);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(62, 35);
            this.lblaltura.TabIndex = 4;
            this.lblaltura.Text = "Altura";
            // 
            // lblojos
            // 
            this.lblojos.BackColor = System.Drawing.Color.Transparent;
            this.lblojos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblojos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblojos.Location = new System.Drawing.Point(23, 271);
            this.lblojos.Name = "lblojos";
            this.lblojos.Size = new System.Drawing.Size(62, 35);
            this.lblojos.TabIndex = 5;
            this.lblojos.Text = "Ojos";
            // 
            // txtojos
            // 
            this.txtojos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtojos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtojos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtojos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtojos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtojos.Location = new System.Drawing.Point(91, 271);
            this.txtojos.Name = "txtojos";
            this.txtojos.Size = new System.Drawing.Size(110, 35);
            this.txtojos.TabIndex = 6;
            this.txtojos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxid
            // 
            this.txtboxid.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtboxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxid.Location = new System.Drawing.Point(91, 67);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(110, 21);
            this.txtboxid.TabIndex = 7;
            this.txtboxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblid
            // 
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblid.Location = new System.Drawing.Point(111, 42);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(90, 22);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "Ingrese ID";
            // 
            // btnreiniciar
            // 
            btnreiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnreiniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnreiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnreiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnreiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnreiniciar.ForeColor = System.Drawing.Color.Black;
            btnreiniciar.Location = new System.Drawing.Point(242, 253);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new System.Drawing.Size(185, 57);
            btnreiniciar.TabIndex = 10;
            btnreiniciar.Text = "REINICIAR";
            btnreiniciar.UseVisualStyleBackColor = false;
            btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 340);
            this.Controls.Add(btnreiniciar);
            this.Controls.Add(btninformacion);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.txtojos);
            this.Controls.Add(this.lblojos);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(btnapi);
            this.Name = "Form1";
            this.Text = "Star Wars API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtaltura;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblojos;
        private System.Windows.Forms.Label txtojos;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label lblid;
    }
}

