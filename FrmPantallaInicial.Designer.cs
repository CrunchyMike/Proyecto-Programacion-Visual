namespace MAME_Proyecto_StripClubV2
{
    partial class FrmPantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaInicial));
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltas
            // 
            this.btnAltas.BackColor = System.Drawing.Color.Transparent;
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Location = new System.Drawing.Point(543, 152);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(105, 34);
            this.btnAltas.TabIndex = 0;
            this.btnAltas.Text = "ALTAS";
            this.btnAltas.UseVisualStyleBackColor = false;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // btnCambios
            // 
            this.btnCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambios.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.Location = new System.Drawing.Point(543, 204);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(105, 34);
            this.btnCambios.TabIndex = 1;
            this.btnCambios.Text = "CAMBIOS";
            this.btnCambios.UseVisualStyleBackColor = false;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.BackColor = System.Drawing.Color.Transparent;
            this.btnBajas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.Location = new System.Drawing.Point(543, 257);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(105, 34);
            this.btnBajas.TabIndex = 2;
            this.btnBajas.Text = "BAJAS";
            this.btnBajas.UseVisualStyleBackColor = false;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(543, 311);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(105, 34);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(85, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "MIKE\'S STRIP CLUB";
            // 
            // FrmPantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnAltas);
            this.Name = "FrmPantallaInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

