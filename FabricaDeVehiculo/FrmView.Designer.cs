namespace FabricaDeVehiculo
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            cmbTipo = new ComboBox();
            btnEliminar = new Button();
            btnFabricar = new Button();
            pcbFabrica = new PictureBox();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 17);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(530, 409);
            lstVehiculos.TabIndex = 0;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(589, 48);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(163, 23);
            cmbTipo.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(607, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 49);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(607, 303);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(136, 49);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // pcbFabrica
            // 
            pcbFabrica.ErrorImage = (Image)resources.GetObject("pcbFabrica.ErrorImage");
            pcbFabrica.Image = Properties.Resources.icons8_vehicles_64;
            pcbFabrica.InitialImage = (Image)resources.GetObject("pcbFabrica.InitialImage");
            pcbFabrica.Location = new Point(635, 117);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(67, 82);
            pcbFabrica.TabIndex = 4;
            pcbFabrica.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(589, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(94, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo de Vehiculo";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipo);
            Controls.Add(pcbFabrica);
            Controls.Add(btnFabricar);
            Controls.Add(btnEliminar);
            Controls.Add(cmbTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            Text = "Fabrica de Vehiculos";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private ComboBox cmbTipo;
        private Button btnEliminar;
        private Button btnFabricar;
        private PictureBox pcbFabrica;
        private Label lblTipo;
    }
}