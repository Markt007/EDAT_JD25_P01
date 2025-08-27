namespace UI.NumerosAleatorios
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
            btnGuardarDatos = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            BoxSueldo = new TextBox();
            BoxGrupo = new TextBox();
            checkBoxSeguro = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            Femenino = new RadioButton();
            Masculino = new RadioButton();
            dateTime = new DateTimePicker();
            label3 = new Label();
            BoxNombre = new TextBox();
            label2 = new Label();
            BoxNumero = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(146, 496);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(283, 34);
            btnGuardarDatos.TabIndex = 0;
            btnGuardarDatos.Text = "Guardar datos aleatorios";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BoxSueldo);
            groupBox1.Controls.Add(BoxGrupo);
            groupBox1.Controls.Add(checkBoxSeguro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Femenino);
            groupBox1.Controls.Add(Masculino);
            groupBox1.Controls.Add(dateTime);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BoxNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BoxNumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 439);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // BoxSueldo
            // 
            BoxSueldo.Location = new Point(107, 342);
            BoxSueldo.Name = "BoxSueldo";
            BoxSueldo.Size = new Size(95, 31);
            BoxSueldo.TabIndex = 12;
            // 
            // BoxGrupo
            // 
            BoxGrupo.Location = new Point(107, 295);
            BoxGrupo.Name = "BoxGrupo";
            BoxGrupo.Size = new Size(95, 31);
            BoxGrupo.TabIndex = 11;
            // 
            // checkBoxSeguro
            // 
            checkBoxSeguro.AutoSize = true;
            checkBoxSeguro.Location = new Point(172, 377);
            checkBoxSeguro.Name = "checkBoxSeguro";
            checkBoxSeguro.Size = new Size(159, 29);
            checkBoxSeguro.TabIndex = 10;
            checkBoxSeguro.Text = "Seguro médico";
            checkBoxSeguro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 342);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 9;
            label5.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 298);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "Grupo";
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(107, 252);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(115, 29);
            Femenino.TabIndex = 7;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(107, 207);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(117, 29);
            Masculino.TabIndex = 6;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(172, 143);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(327, 31);
            dateTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 143);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha Nacimiento";
            // 
            // BoxNombre
            // 
            BoxNombre.Location = new Point(107, 89);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(275, 31);
            BoxNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // BoxNumero
            // 
            BoxNumero.Location = new Point(107, 45);
            BoxNumero.Name = "BoxNumero";
            BoxNumero.Size = new Size(95, 31);
            BoxNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 574);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarDatos);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardarDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox BoxNumero;
        private Label label3;
        private TextBox BoxNombre;
        private Label label2;
        private DateTimePicker dateTime;
        private RadioButton Femenino;
        private RadioButton Masculino;
        private CheckBox checkBoxSeguro;
        private Label label5;
        private Label label4;
        private TextBox BoxSueldo;
        private TextBox BoxGrupo;
    }
}
