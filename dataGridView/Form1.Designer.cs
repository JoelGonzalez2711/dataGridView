
namespace dataGridView
{
    partial class Form1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(284, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 55);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Productos";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaCodigo,
            this.ColumnaCantidad,
            this.ColumnaPrecio,
            this.ColumnaDescripción,
            this.ColumnaTipo});
            this.dgvProductos.Location = new System.Drawing.Point(12, 77);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(776, 287);
            this.dgvProductos.TabIndex = 1;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaCodigo.HeaderText = "Código";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.ReadOnly = true;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.ReadOnly = true;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.ReadOnly = true;
            // 
            // ColumnaDescripción
            // 
            this.ColumnaDescripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaDescripción.HeaderText = "Descripción";
            this.ColumnaDescripción.Name = "ColumnaDescripción";
            this.ColumnaDescripción.ReadOnly = true;
            // 
            // ColumnaTipo
            // 
            this.ColumnaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaTipo.HeaderText = "Tipo";
            this.ColumnaTipo.Name = "ColumnaTipo";
            this.ColumnaTipo.ReadOnly = true;
            // 
            // btAñadir
            // 
            this.btAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadir.Location = new System.Drawing.Point(601, 387);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(187, 51);
            this.btAñadir.TabIndex = 2;
            this.btAñadir.Text = "Añadir Fila";
            this.btAñadir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(398, 387);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(187, 50);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar Fila";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipo;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btEditar;
    }
}

