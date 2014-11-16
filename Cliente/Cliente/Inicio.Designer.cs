namespace Cliente
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bc = new System.Windows.Forms.Button();
            this.Bcuentas = new System.Windows.Forms.Button();
            this.Be = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.MediumOrchid;
            this.bc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bc.Location = new System.Drawing.Point(120, 54);
            this.bc.Margin = new System.Windows.Forms.Padding(4);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(240, 35);
            this.bc.TabIndex = 0;
            this.bc.Text = "Clientes";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bcuentas
            // 
            this.Bcuentas.BackColor = System.Drawing.Color.MediumOrchid;
            this.Bcuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bcuentas.Location = new System.Drawing.Point(120, 117);
            this.Bcuentas.Margin = new System.Windows.Forms.Padding(4);
            this.Bcuentas.Name = "Bcuentas";
            this.Bcuentas.Size = new System.Drawing.Size(240, 35);
            this.Bcuentas.TabIndex = 1;
            this.Bcuentas.Text = "Cuentas";
            this.Bcuentas.UseVisualStyleBackColor = false;
            this.Bcuentas.Click += new System.EventHandler(this.Bcuentas_Click);
            // 
            // Be
            // 
            this.Be.BackColor = System.Drawing.Color.MediumOrchid;
            this.Be.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Be.Location = new System.Drawing.Point(120, 184);
            this.Be.Margin = new System.Windows.Forms.Padding(4);
            this.Be.Name = "Be";
            this.Be.Size = new System.Drawing.Size(240, 35);
            this.Be.TabIndex = 2;
            this.Be.Text = "Estadisticas";
            this.Be.UseVisualStyleBackColor = false;
            this.Be.Click += new System.EventHandler(this.button2_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::Cliente.Properties.Resources.perro1;
            this.Logo.Location = new System.Drawing.Point(405, 82);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(101, 98);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(537, 288);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Be);
            this.Controls.Add(this.Bcuentas);
            this.Controls.Add(this.bc);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button Bcuentas;
        private System.Windows.Forms.Button Be;
        private System.Windows.Forms.PictureBox Logo;
    }
}

