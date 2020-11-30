namespace Cuadrilateros.Windows
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PerimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbCantidad = new System.Windows.Forms.ToolStripButton();
            this.cmnLado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.PerimetroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Lado1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 375);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripSeparator1,
            this.tsbEditar,
            this.toolStripSeparator2,
            this.tsbBorrar,
            this.toolStripSeparator3,
            this.tsbCerrar,
            this.toolStripSplitButton1,
            this.tsbOrdenar,
            this.toolStripSeparator4,
            this.tsbActualizar,
            this.toolStripSeparator5,
            this.tsbCantidad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 300);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 75);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 75);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 75);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 75);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnLado1,
            this.cmnLado2,
            this.cmnPerimetro,
            this.cmnArea,
            this.cmnTipo});
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 450);
            this.dgvDatos.TabIndex = 2;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 75);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 75);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.AutoSize = false;
            this.tsbNuevo.Image = global::Cuadrilateros.Windows.Properties.Resources.nuevoae1;
            this.tsbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(70, 72);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.AutoSize = false;
            this.tsbEditar.Image = global::Cuadrilateros.Windows.Properties.Resources.editarae;
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(70, 72);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.AutoSize = false;
            this.tsbBorrar.Image = global::Cuadrilateros.Windows.Properties.Resources.borrarae;
            this.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(70, 72);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.AutoSize = false;
            this.tsbCerrar.Image = global::Cuadrilateros.Windows.Properties.Resources.exit_24px;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(70, 72);
            this.tsbCerrar.Text = "Salir";
            this.tsbCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.AutoSize = false;
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.PerimetroToolStripMenuItem,
            this.lado2ToolStripMenuItem,
            this.Lado1ToolStripMenuItem});
            this.tsbOrdenar.Image = global::Cuadrilateros.Windows.Properties.Resources.numeric_40px;
            this.tsbOrdenar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(70, 72);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOrdenar.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbOrdenar_DropDownItemClicked);
            this.tsbOrdenar.Click += new System.EventHandler(this.tsbOrdenar_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // PerimetroToolStripMenuItem
            // 
            this.PerimetroToolStripMenuItem.Name = "PerimetroToolStripMenuItem";
            this.PerimetroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PerimetroToolStripMenuItem.Text = "Perimetro";
            // 
            // lado2ToolStripMenuItem
            // 
            this.lado2ToolStripMenuItem.Name = "lado2ToolStripMenuItem";
            this.lado2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lado2ToolStripMenuItem.Text = "Lado2";
            // 
            // Lado1ToolStripMenuItem
            // 
            this.Lado1ToolStripMenuItem.Name = "Lado1ToolStripMenuItem";
            this.Lado1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Lado1ToolStripMenuItem.Text = "Lado1";
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.Image = global::Cuadrilateros.Windows.Properties.Resources.refresh_40px;
            this.tsbActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 72);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbActualizar.Click += new System.EventHandler(this.tsbActualizar_Click);
            // 
            // tsbCantidad
            // 
            this.tsbCantidad.AutoSize = false;
            this.tsbCantidad.Image = global::Cuadrilateros.Windows.Properties.Resources.counter_40px;
            this.tsbCantidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCantidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCantidad.Name = "tsbCantidad";
            this.tsbCantidad.Size = new System.Drawing.Size(170, 72);
            this.tsbCantidad.Text = "Cantidad de elementos";
            this.tsbCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCantidad.Click += new System.EventHandler(this.tsbCantidad_Click_1);
            // 
            // cmnLado1
            // 
            this.cmnLado1.HeaderText = "Lado 1";
            this.cmnLado1.Name = "cmnLado1";
            this.cmnLado1.ReadOnly = true;
            // 
            // cmnLado2
            // 
            this.cmnLado2.HeaderText = "Lado 2";
            this.cmnLado2.Name = "cmnLado2";
            this.cmnLado2.ReadOnly = true;
            // 
            // cmnPerimetro
            // 
            this.cmnPerimetro.HeaderText = "Perimetro";
            this.cmnPerimetro.Name = "cmnPerimetro";
            this.cmnPerimetro.ReadOnly = true;
            // 
            // cmnArea
            // 
            this.cmnArea.HeaderText = "Area";
            this.cmnArea.Name = "cmnArea";
            this.cmnArea.ReadOnly = true;
            // 
            // cmnTipo
            // 
            this.cmnTipo.HeaderText = "Tipo de Cuadrilatero";
            this.cmnTipo.Name = "cmnTipo";
            this.cmnTipo.ReadOnly = true;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lado1ToolStripMenuItem1,
            this.PerimetroToolStripMenuItem1});
            this.toolStripSplitButton1.Image = global::Cuadrilateros.Windows.Properties.Resources.numeric_40px;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(70, 72);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // PerimetroToolStripMenuItem1
            // 
            this.PerimetroToolStripMenuItem1.Name = "PerimetroToolStripMenuItem1";
            this.PerimetroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.PerimetroToolStripMenuItem1.Text = "Perimetro";
            // 
            // Lado1ToolStripMenuItem1
            // 
            this.Lado1ToolStripMenuItem1.Name = "Lado1ToolStripMenuItem1";
            this.Lado1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.Lado1ToolStripMenuItem1.Text = "Lado1";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerimetroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lado2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Lado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipo;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Lado1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PerimetroToolStripMenuItem1;
    }
}

