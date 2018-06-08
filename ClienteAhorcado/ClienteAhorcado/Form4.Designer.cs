namespace ClienteAhorcado
{
    partial class Marcador
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.layoutMarcadores = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(26, 27);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(71, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(153, 27);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(67, 20);
            this.labelTiempo.TabIndex = 1;
            this.labelTiempo.Text = "Tiempo";
            // 
            // layoutMarcadores
            // 
            this.layoutMarcadores.Location = new System.Drawing.Point(30, 55);
            this.layoutMarcadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutMarcadores.Name = "layoutMarcadores";
            this.layoutMarcadores.Size = new System.Drawing.Size(254, 350);
            this.layoutMarcadores.TabIndex = 2;
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 430);
            this.Controls.Add(this.layoutMarcadores);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelNombre);
            this.Name = "Marcador";
            this.Text = "Marcadores";
            this.Load += new System.EventHandler(this.Marcador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.FlowLayoutPanel layoutMarcadores;
    }
}