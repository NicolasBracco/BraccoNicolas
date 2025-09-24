namespace ado_multiplestablas
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
            btnRefrescar = new Button();
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnAgregar = new Button();
            DGVPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(28, 17);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(89, 31);
            btnRefrescar.TabIndex = 11;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(346, 17);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(89, 31);
            BtnEliminar.TabIndex = 9;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(234, 17);
            BtnModificar.Margin = new Padding(3, 2, 3, 2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(89, 31);
            BtnModificar.TabIndex = 8;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(131, 17);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(89, 31);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // DGVPersonas
            // 
            DGVPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPersonas.Location = new Point(21, 84);
            DGVPersonas.Margin = new Padding(3, 2, 3, 2);
            DGVPersonas.Name = "DGVPersonas";
            DGVPersonas.RowHeadersWidth = 51;
            DGVPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPersonas.Size = new Size(783, 407);
            DGVPersonas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 502);
            Controls.Add(btnRefrescar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(DGVPersonas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGVPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefrescar;
        private Button BtnEliminar;
        private Button BtnModificar;
        private Button BtnAgregar;
        private DataGridView DGVPersonas;
    }
}
