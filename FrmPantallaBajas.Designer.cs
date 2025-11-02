namespace MAME_Proyecto_StripClubV2
{
    partial class FrmPantallaBajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaBajas));
            this.btnBajasRegresar = new System.Windows.Forms.Button();
            this.lstBajaProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBajaProductos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBajaProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.gbxBajaArtistas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdBajaArtista = new System.Windows.Forms.TextBox();
            this.btnEliminarArtista = new System.Windows.Forms.Button();
            this.lstBajaArtistas = new System.Windows.Forms.ListBox();
            this.gbxBajaProductos.SuspendLayout();
            this.gbxBajaArtistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBajasRegresar
            // 
            this.btnBajasRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBajasRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajasRegresar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajasRegresar.Location = new System.Drawing.Point(9, 468);
            this.btnBajasRegresar.Name = "btnBajasRegresar";
            this.btnBajasRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnBajasRegresar.TabIndex = 0;
            this.btnBajasRegresar.Text = "REGRESAR";
            this.btnBajasRegresar.UseVisualStyleBackColor = false;
            this.btnBajasRegresar.Click += new System.EventHandler(this.btnBajasRegresar_Click);
            // 
            // lstBajaProductos
            // 
            this.lstBajaProductos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBajaProductos.FormattingEnabled = true;
            this.lstBajaProductos.ItemHeight = 17;
            this.lstBajaProductos.Location = new System.Drawing.Point(6, 19);
            this.lstBajaProductos.Name = "lstBajaProductos";
            this.lstBajaProductos.Size = new System.Drawing.Size(410, 276);
            this.lstBajaProductos.TabIndex = 1;
            this.lstBajaProductos.SelectedIndexChanged += new System.EventHandler(this.LstBajaProductos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(163, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONA LA INFORMACION QUE QUIERAS DAR DE BAJA";
            // 
            // gbxBajaProductos
            // 
            this.gbxBajaProductos.BackColor = System.Drawing.Color.Transparent;
            this.gbxBajaProductos.Controls.Add(this.label2);
            this.gbxBajaProductos.Controls.Add(this.txtIdBajaProducto);
            this.gbxBajaProductos.Controls.Add(this.btnEliminarProducto);
            this.gbxBajaProductos.Controls.Add(this.lstBajaProductos);
            this.gbxBajaProductos.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBajaProductos.ForeColor = System.Drawing.Color.Yellow;
            this.gbxBajaProductos.Location = new System.Drawing.Point(9, 34);
            this.gbxBajaProductos.Name = "gbxBajaProductos";
            this.gbxBajaProductos.Size = new System.Drawing.Size(422, 414);
            this.gbxBajaProductos.TabIndex = 3;
            this.gbxBajaProductos.TabStop = false;
            this.gbxBajaProductos.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "INGRESA EL ID DEL PRODUCTO A ELIMINAR:";
            // 
            // txtIdBajaProducto
            // 
            this.txtIdBajaProducto.Location = new System.Drawing.Point(239, 326);
            this.txtIdBajaProducto.Name = "txtIdBajaProducto";
            this.txtIdBajaProducto.Size = new System.Drawing.Size(36, 23);
            this.txtIdBajaProducto.TabIndex = 3;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProducto.Location = new System.Drawing.Point(131, 378);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(144, 23);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // gbxBajaArtistas
            // 
            this.gbxBajaArtistas.BackColor = System.Drawing.Color.Transparent;
            this.gbxBajaArtistas.Controls.Add(this.label3);
            this.gbxBajaArtistas.Controls.Add(this.txtIdBajaArtista);
            this.gbxBajaArtistas.Controls.Add(this.btnEliminarArtista);
            this.gbxBajaArtistas.Controls.Add(this.lstBajaArtistas);
            this.gbxBajaArtistas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBajaArtistas.ForeColor = System.Drawing.Color.Yellow;
            this.gbxBajaArtistas.Location = new System.Drawing.Point(437, 34);
            this.gbxBajaArtistas.Name = "gbxBajaArtistas";
            this.gbxBajaArtistas.Size = new System.Drawing.Size(422, 414);
            this.gbxBajaArtistas.TabIndex = 4;
            this.gbxBajaArtistas.TabStop = false;
            this.gbxBajaArtistas.Text = "ARTISTAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESA EL ID DEL ARTISTA A ELIMINAR:";
            // 
            // txtIdBajaArtista
            // 
            this.txtIdBajaArtista.Location = new System.Drawing.Point(225, 329);
            this.txtIdBajaArtista.Name = "txtIdBajaArtista";
            this.txtIdBajaArtista.Size = new System.Drawing.Size(38, 23);
            this.txtIdBajaArtista.TabIndex = 3;
            // 
            // btnEliminarArtista
            // 
            this.btnEliminarArtista.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarArtista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarArtista.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArtista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarArtista.Location = new System.Drawing.Point(145, 378);
            this.btnEliminarArtista.Name = "btnEliminarArtista";
            this.btnEliminarArtista.Size = new System.Drawing.Size(132, 23);
            this.btnEliminarArtista.TabIndex = 2;
            this.btnEliminarArtista.Text = "ELIMINAR ARTISTA";
            this.btnEliminarArtista.UseVisualStyleBackColor = false;
            this.btnEliminarArtista.Click += new System.EventHandler(this.btnEliminarArtista_Click);
            // 
            // lstBajaArtistas
            // 
            this.lstBajaArtistas.BackColor = System.Drawing.SystemColors.Window;
            this.lstBajaArtistas.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBajaArtistas.FormattingEnabled = true;
            this.lstBajaArtistas.ItemHeight = 17;
            this.lstBajaArtistas.Location = new System.Drawing.Point(6, 19);
            this.lstBajaArtistas.Name = "lstBajaArtistas";
            this.lstBajaArtistas.Size = new System.Drawing.Size(410, 276);
            this.lstBajaArtistas.TabIndex = 1;
            this.lstBajaArtistas.SelectedIndexChanged += new System.EventHandler(this.LstBajaArtistas_SelectedIndexChanged);
            // 
            // FrmPantallaBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 503);
            this.Controls.Add(this.gbxBajaArtistas);
            this.Controls.Add(this.gbxBajaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBajasRegresar);
            this.Name = "FrmPantallaBajas";
            this.Text = "FrmPantallaBajas";
            this.Load += new System.EventHandler(this.FrmPantallaBajas_Load);
            this.gbxBajaProductos.ResumeLayout(false);
            this.gbxBajaProductos.PerformLayout();
            this.gbxBajaArtistas.ResumeLayout(false);
            this.gbxBajaArtistas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBajasRegresar;
        private System.Windows.Forms.ListBox lstBajaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxBajaProductos;
        private System.Windows.Forms.GroupBox gbxBajaArtistas;
        private System.Windows.Forms.ListBox lstBajaArtistas;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnEliminarArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBajaProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdBajaArtista;
    }
}