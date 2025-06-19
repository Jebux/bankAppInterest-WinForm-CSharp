namespace Banco2
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
            Label1 = new Label();
            label2 = new Label();
            cuadrousuario = new DataGridView();
            btnDepositar = new Button();
            btnRetirar = new Button();
            btnCrearcuenta = new Button();
            textBoxNombre = new TextBox();
            inputdinero = new NumericUpDown();
            label3 = new Label();
            inputInteres = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cuadrousuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputdinero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputInteres).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(30, 36);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 211);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // cuadrousuario
            // 
            cuadrousuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cuadrousuario.Location = new Point(259, 33);
            cuadrousuario.Margin = new Padding(3, 2, 3, 2);
            cuadrousuario.Name = "cuadrousuario";
            cuadrousuario.RowHeadersWidth = 51;
            cuadrousuario.Size = new Size(372, 158);
            cuadrousuario.TabIndex = 2;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(259, 209);
            btnDepositar.Margin = new Padding(3, 2, 3, 2);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(85, 22);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(516, 211);
            btnRetirar.Margin = new Padding(3, 2, 3, 2);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(115, 22);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnCrearcuenta
            // 
            btnCrearcuenta.Location = new Point(97, 110);
            btnCrearcuenta.Margin = new Padding(3, 2, 3, 2);
            btnCrearcuenta.Name = "btnCrearcuenta";
            btnCrearcuenta.Size = new Size(82, 22);
            btnCrearcuenta.TabIndex = 5;
            btnCrearcuenta.Text = "Crear Cuenta";
            btnCrearcuenta.UseVisualStyleBackColor = true;
            btnCrearcuenta.Click += btnCrearcuenta_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(97, 33);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(139, 23);
            textBoxNombre.TabIndex = 6;
            // 
            // inputdinero
            // 
            inputdinero.Location = new Point(97, 209);
            inputdinero.Margin = new Padding(3, 2, 3, 2);
            inputdinero.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            inputdinero.Name = "inputdinero";
            inputdinero.Size = new Size(139, 23);
            inputdinero.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 75);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Interes";
            // 
            // inputInteres
            // 
            inputInteres.Location = new Point(97, 73);
            inputInteres.Margin = new Padding(3, 2, 3, 2);
            inputInteres.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            inputInteres.Name = "inputInteres";
            inputInteres.Size = new Size(139, 23);
            inputInteres.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(649, 290);
            Controls.Add(inputInteres);
            Controls.Add(label3);
            Controls.Add(inputdinero);
            Controls.Add(textBoxNombre);
            Controls.Add(btnCrearcuenta);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(cuadrousuario);
            Controls.Add(label2);
            Controls.Add(Label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cuadrousuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputdinero).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputInteres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Label label2;
        private DataGridView cuadrousuario;
        private Button btnDepositar;
        private Button btnRetirar;
        private Button btnCrearcuenta;
        private TextBox textBoxNombre;
        private NumericUpDown inputdinero;
        private Label label3;
        private NumericUpDown inputInteres;
    }
}
