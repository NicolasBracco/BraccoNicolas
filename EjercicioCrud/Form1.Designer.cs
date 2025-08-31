namespace EjercicioCrud
{
    partial class Form1
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
            DGVPersonas = new DataGridView();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            BtnConexion = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVPersonas).BeginInit();
            SuspendLayout();
            // 
            // DGVPersonas
            // 
            DGVPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPersonas.Location = new Point(39, 164);
            DGVPersonas.Name = "DGVPersonas";
            DGVPersonas.RowHeadersWidth = 51;
            DGVPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPersonas.Size = new Size(709, 497);
            DGVPersonas.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(165, 75);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(102, 41);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(282, 75);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(102, 41);
            BtnModificar.TabIndex = 2;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(410, 75);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(102, 41);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnConexion
            // 
            BtnConexion.Location = new Point(529, 69);
            BtnConexion.Name = "BtnConexion";
            BtnConexion.Size = new Size(128, 52);
            BtnConexion.TabIndex = 4;
            BtnConexion.Text = "Conexion con base de datos";
            BtnConexion.UseVisualStyleBackColor = true;
            BtnConexion.Click += BtnConexion_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(47, 75);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(102, 41);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 688);
            Controls.Add(btnRefrescar);
            Controls.Add(BtnConexion);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(DGVPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVPersonas;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnConexion;
        private Button btnRefrescar;
    }
}
