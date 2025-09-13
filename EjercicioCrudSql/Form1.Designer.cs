namespace EjercicioCrudSql
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
            dgvPersonas = new DataGridView();
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(30, 88);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(647, 365);
            dgvPersonas.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(274, 41);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(102, 41);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(152, 41);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(102, 41);
            BtnModificar.TabIndex = 7;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(30, 41);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(102, 41);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 493);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(dgvPersonas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersonas;
        private Button BtnEliminar;
        private Button BtnModificar;
        private Button BtnAgregar;
    }
}
