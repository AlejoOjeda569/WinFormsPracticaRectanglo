namespace WinFormsPracticaRectanglo
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            gbxBordes = new GroupBox();
            btnOk = new Button();
            btnCancelar = new Button();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Altura";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Relleno";
            // 
            // gbxBordes
            // 
            gbxBordes.Location = new Point(272, 100);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Size = new Size(200, 150);
            gbxBordes.TabIndex = 6;
            gbxBordes.TabStop = false;
            gbxBordes.Text = "Tipo  de Borde";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(36, 146);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 43);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(88, 30);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 9;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(343, 33);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 297);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(gbxBordes);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnCancelar;
        private Button btnOk;
        private GroupBox gbxBordes;
        private TextBox txtAltura;
        private TextBox txtBase;
    }
}