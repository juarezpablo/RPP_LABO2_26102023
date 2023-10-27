namespace Parcial
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
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnFabricar = new Button();
            cmbTipo = new ComboBox();
            lstVehiculos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(606, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 132);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(621, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(652, 341);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(75, 23);
            btnFabricar.TabIndex = 2;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(606, 51);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 3;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(46, 53);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(433, 349);
            lstVehiculos.TabIndex = 4;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstVehiculos);
            Controls.Add(cmbTipo);
            Controls.Add(btnFabricar);
            Controls.Add(btnEliminar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            Text = "Fabrica de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnFabricar;
        private ComboBox cmbTipo;
        private ListBox lstVehiculos;
    }
}