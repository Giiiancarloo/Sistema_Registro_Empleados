namespace Sistema_Registro_Empleados
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
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(51, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(95, 144);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(95, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 147);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "N° Hijos:";
            label5.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 0;
            label4.Text = "Estado Civil:";
            label4.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellidos:";
            label3.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            label2.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cedula:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(51, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 186);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Contacto";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(95, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 23);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(95, 56);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 23);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 88);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 0;
            label8.Text = "Email:";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 59);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 0;
            label9.Text = "Dirección:";
            label9.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(95, 27);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 23);
            textBox6.TabIndex = 1;
            textBox6.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 30);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "Teléfono:";
            label10.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 487);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 538);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private Button button1;
    }
}
