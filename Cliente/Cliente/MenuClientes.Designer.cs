namespace Cliente
{
    partial class MenuClientes
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
            this.Bver = new System.Windows.Forms.Button();
            this.Bcrear = new System.Windows.Forms.Button();
            this.Beditar = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bver
            // 
            this.Bver.BackColor = System.Drawing.Color.MediumOrchid;
            this.Bver.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bver.Location = new System.Drawing.Point(96, 35);
            this.Bver.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Bver.Name = "Bver";
            this.Bver.Size = new System.Drawing.Size(219, 46);
            this.Bver.TabIndex = 1;
            this.Bver.Text = "Ver  Cliente";
            this.Bver.UseVisualStyleBackColor = false;
            this.Bver.Click += new System.EventHandler(this.bc_Click);
            // 
            // Bcrear
            // 
            this.Bcrear.BackColor = System.Drawing.Color.MediumOrchid;
            this.Bcrear.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcrear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bcrear.Location = new System.Drawing.Point(96, 112);
            this.Bcrear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Bcrear.Name = "Bcrear";
            this.Bcrear.Size = new System.Drawing.Size(219, 44);
            this.Bcrear.TabIndex = 2;
            this.Bcrear.Text = "Crear  Cliente";
            this.Bcrear.UseVisualStyleBackColor = false;
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.Color.MediumOrchid;
            this.Beditar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Beditar.Location = new System.Drawing.Point(96, 183);
            this.Beditar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Beditar.Name = "Beditar";
            this.Beditar.Size = new System.Drawing.Size(219, 44);
            this.Beditar.TabIndex = 3;
            this.Beditar.Text = "Editar  Cliente";
            this.Beditar.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Cliente.Properties.Resources.perro11;
            this.Home.Location = new System.Drawing.Point(12, 221);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 53);
            this.Home.TabIndex = 5;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(372, 286);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.Bcrear);
            this.Controls.Add(this.Bver);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuClientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bver;
        private System.Windows.Forms.Button Bcrear;
        private System.Windows.Forms.Button Beditar;
        private System.Windows.Forms.Button Home;
    }
}