namespace MAME_Proyecto_StripClubV2
{
    partial class FrmPantallaConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaConsultas));
            this.btnConsultasRegresar = new System.Windows.Forms.Button();
            this.gbxConsultaProductos = new System.Windows.Forms.GroupBox();
            this.lstConsultaProductos = new System.Windows.Forms.ListBox();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.gbxConsultaArtistas = new System.Windows.Forms.GroupBox();
            this.lstConsultaArtistas = new System.Windows.Forms.ListBox();
            this.btnConsultarArtistas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxConsultaProductos.SuspendLayout();
            this.gbxConsultaArtistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultasRegresar
            // 
            this.btnConsultasRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultasRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultasRegresar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasRegresar.Location = new System.Drawing.Point(12, 481);
            this.btnConsultasRegresar.Name = "btnConsultasRegresar";
            this.btnConsultasRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultasRegresar.TabIndex = 0;
            this.btnConsultasRegresar.Text = "REGRESAR";
            this.btnConsultasRegresar.UseVisualStyleBackColor = false;
            this.btnConsultasRegresar.Click += new System.EventHandler(this.btnConsultasRegresar_Click);
            // 
            // gbxConsultaProductos
            // 
            this.gbxConsultaProductos.BackColor = System.Drawing.Color.Transparent;
            this.gbxConsultaProductos.Controls.Add(this.lstConsultaProductos);
            this.gbxConsultaProductos.Controls.Add(this.btnConsultarProductos);
            this.gbxConsultaProductos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConsultaProductos.ForeColor = System.Drawing.Color.Yellow;
            this.gbxConsultaProductos.Location = new System.Drawing.Point(12, 48);
            this.gbxConsultaProductos.Name = "gbxConsultaProductos";
            this.gbxConsultaProductos.Size = new System.Drawing.Size(415, 415);
            this.gbxConsultaProductos.TabIndex = 1;
            this.gbxConsultaProductos.TabStop = false;
            this.gbxConsultaProductos.Text = "PRODUCTOS";
            // 
            // lstConsultaProductos
            // 
            this.lstConsultaProductos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsultaProductos.FormattingEnabled = true;
            this.lstConsultaProductos.ItemHeight = 17;
            this.lstConsultaProductos.Location = new System.Drawing.Point(10, 26);
            this.lstConsultaProductos.Name = "lstConsultaProductos";
            this.lstConsultaProductos.Size = new System.Drawing.Size(392, 327);
            this.lstConsultaProductos.TabIndex = 1;
            this.lstConsultaProductos.Visible = false;
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarProductos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarProductos.Location = new System.Drawing.Point(135, 370);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(154, 23);
            this.btnConsultarProductos.TabIndex = 0;
            this.btnConsultarProductos.Text = "CONSULTAR RODUCTOS";
            this.btnConsultarProductos.UseVisualStyleBackColor = false;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // gbxConsultaArtistas
            // 
            this.gbxConsultaArtistas.BackColor = System.Drawing.Color.Transparent;
            this.gbxConsultaArtistas.Controls.Add(this.lstConsultaArtistas);
            this.gbxConsultaArtistas.Controls.Add(this.btnConsultarArtistas);
            this.gbxConsultaArtistas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConsultaArtistas.ForeColor = System.Drawing.Color.Yellow;
            this.gbxConsultaArtistas.Location = new System.Drawing.Point(442, 48);
            this.gbxConsultaArtistas.Name = "gbxConsultaArtistas";
            this.gbxConsultaArtistas.Size = new System.Drawing.Size(415, 415);
            this.gbxConsultaArtistas.TabIndex = 2;
            this.gbxConsultaArtistas.TabStop = false;
            this.gbxConsultaArtistas.Text = "ARTISTAS";
            // 
            // lstConsultaArtistas
            // 
            this.lstConsultaArtistas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsultaArtistas.FormattingEnabled = true;
            this.lstConsultaArtistas.ItemHeight = 17;
            this.lstConsultaArtistas.Location = new System.Drawing.Point(17, 26);
            this.lstConsultaArtistas.Name = "lstConsultaArtistas";
            this.lstConsultaArtistas.Size = new System.Drawing.Size(392, 327);
            this.lstConsultaArtistas.TabIndex = 2;
            this.lstConsultaArtistas.Visible = false;
            // 
            // btnConsultarArtistas
            // 
            this.btnConsultarArtistas.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarArtistas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarArtistas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarArtistas.Location = new System.Drawing.Point(143, 370);
            this.btnConsultarArtistas.Name = "btnConsultarArtistas";
            this.btnConsultarArtistas.Size = new System.Drawing.Size(151, 23);
            this.btnConsultarArtistas.TabIndex = 0;
            this.btnConsultarArtistas.Text = "CONSULTAR ARTISTAS";
            this.btnConsultarArtistas.UseVisualStyleBackColor = false;
            this.btnConsultarArtistas.Click += new System.EventHandler(this.btnConsultarArtistas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTAR REGISTROS";
            // 
            // FrmPantallaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxConsultaArtistas);
            this.Controls.Add(this.gbxConsultaProductos);
            this.Controls.Add(this.btnConsultasRegresar);
            this.Name = "FrmPantallaConsultas";
            this.Text = "FrmPantallaConsultas";
            this.gbxConsultaProductos.ResumeLayout(false);
            this.gbxConsultaArtistas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultasRegresar;
        private System.Windows.Forms.GroupBox gbxConsultaProductos;
        private System.Windows.Forms.GroupBox gbxConsultaArtistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Button btnConsultarArtistas;
        private System.Windows.Forms.ListBox lstConsultaProductos;
        private System.Windows.Forms.ListBox lstConsultaArtistas;
    }
}