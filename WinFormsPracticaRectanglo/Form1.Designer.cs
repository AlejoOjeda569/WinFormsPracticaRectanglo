namespace WinFormsPracticaRectanglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            btnBorrar = new ToolStripButton();
            btnFiltrar = new ToolStripButton();
            btnCerrar = new ToolStripButton();
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            colBase = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colSuperficie = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, toolStripLabel1, btnBorrar, btnFiltrar, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(46, 22);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 22);
            // 
            // btnBorrar
            // 
            btnBorrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.ImageTransparentColor = Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(43, 22);
            btnBorrar.Text = "borrar";
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(41, 22);
            btnFiltrar.Text = "Filtrar";
            // 
            // btnCerrar
            // 
            btnCerrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 22);
            btnCerrar.Text = "Salir";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 425);
            panel1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colBase, colAltura, colRelleno, colBorde, colPerimetro, colSuperficie });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 425);
            dgvDatos.TabIndex = 0;
            // 
            // colBase
            // 
            colBase.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBase.HeaderText = "Base";
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            // 
            // colAltura
            // 
            colAltura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            // 
            // colRelleno
            // 
            colRelleno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRelleno.HeaderText = "Relleno";
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            // 
            // colBorde
            // 
            colBorde.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBorde.HeaderText = "Borde";
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            // 
            // colPerimetro
            // 
            colPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPerimetro.HeaderText = "Perimetro";
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            colSuperficie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSuperficie.HeaderText = "Superficie";
            colSuperficie.Name = "colSuperficie";
            colSuperficie.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnCerrar;
        private Panel panel1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colSuperficie;
    }
}