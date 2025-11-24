namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarActividades
{
    partial class CrearActividadesForm
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
            cancelarButton = new Button();
            guardarButton = new Button();
            comboMonitor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboSala = new ComboBox();
            horaFinDatetime = new DateTimePicker();
            horaInicioDatetime = new DateTimePicker();
            nombreTextBox = new TextBox();
            descripcionTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(226, 387);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 0;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(476, 387);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(75, 23);
            guardarButton.TabIndex = 1;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // comboMonitor
            // 
            comboMonitor.FormattingEnabled = true;
            comboMonitor.Location = new Point(324, 278);
            comboMonitor.Name = "comboMonitor";
            comboMonitor.Size = new Size(200, 23);
            comboMonitor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(308, 27);
            label1.Name = "label1";
            label1.Size = new Size(243, 46);
            label1.TabIndex = 3;
            label1.Text = "Crear actividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 108);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 147);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 193);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Hora Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 235);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Hora Fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 281);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 8;
            label6.Text = "Monitor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 313);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 9;
            label7.Text = "Sala";
            // 
            // comboSala
            // 
            comboSala.FormattingEnabled = true;
            comboSala.Location = new Point(324, 313);
            comboSala.Name = "comboSala";
            comboSala.Size = new Size(200, 23);
            comboSala.TabIndex = 10;
            // 
            // horaFinDatetime
            // 
            horaFinDatetime.Location = new Point(324, 235);
            horaFinDatetime.Name = "horaFinDatetime";
            horaFinDatetime.Size = new Size(200, 23);
            horaFinDatetime.TabIndex = 11;
            // 
            // horaInicioDatetime
            // 
            horaInicioDatetime.Location = new Point(324, 193);
            horaInicioDatetime.Name = "horaInicioDatetime";
            horaInicioDatetime.Size = new Size(200, 23);
            horaInicioDatetime.TabIndex = 12;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(324, 108);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(200, 23);
            nombreTextBox.TabIndex = 13;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(326, 147);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(198, 40);
            descripcionTextBox.TabIndex = 14;
            descripcionTextBox.Text = "";
            // 
            // CrearActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descripcionTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(horaInicioDatetime);
            Controls.Add(horaFinDatetime);
            Controls.Add(comboSala);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboMonitor);
            Controls.Add(guardarButton);
            Controls.Add(cancelarButton);
            Name = "CrearActividadesForm";
            Text = "CrearActividadesForm";
            Load += CrearActividadesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarButton;
        private Button guardarButton;
        private ComboBox comboMonitor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboSala;
        private DateTimePicker horaFinDatetime;
        private DateTimePicker horaInicioDatetime;
        private TextBox nombreTextBox;
        private RichTextBox descripcionTextBox;
    }
}