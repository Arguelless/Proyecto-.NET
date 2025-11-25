namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarSesiones
{
    partial class CrearSesionForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tipoActividadCombo = new ComboBox();
            monitorCombo = new ComboBox();
            salaCombo = new ComboBox();
            horaInicioPicker = new DateTimePicker();
            horaFinPicker = new DateTimePicker();
            guardarButton = new Button();
            cancelarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(273, 28);
            label1.Name = "label1";
            label1.Size = new Size(202, 46);
            label1.TabIndex = 4;
            label1.Text = "Crear sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 119);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo de actividad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 161);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Monitor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 205);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "Sala";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 254);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Hora inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 304);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 9;
            label6.Text = "Hora fin";
            // 
            // tipoActividadCombo
            // 
            tipoActividadCombo.FormattingEnabled = true;
            tipoActividadCombo.Location = new Point(368, 116);
            tipoActividadCombo.Name = "tipoActividadCombo";
            tipoActividadCombo.Size = new Size(200, 23);
            tipoActividadCombo.TabIndex = 10;
            // 
            // monitorCombo
            // 
            monitorCombo.FormattingEnabled = true;
            monitorCombo.Location = new Point(368, 158);
            monitorCombo.Name = "monitorCombo";
            monitorCombo.Size = new Size(200, 23);
            monitorCombo.TabIndex = 11;
            // 
            // salaCombo
            // 
            salaCombo.FormattingEnabled = true;
            salaCombo.Location = new Point(368, 205);
            salaCombo.Name = "salaCombo";
            salaCombo.Size = new Size(200, 23);
            salaCombo.TabIndex = 12;
            // 
            // horaInicioPicker
            // 
            horaInicioPicker.Location = new Point(368, 254);
            horaInicioPicker.Name = "horaInicioPicker";
            horaInicioPicker.Size = new Size(200, 23);
            horaInicioPicker.TabIndex = 13;
            // 
            // horaFinPicker
            // 
            horaFinPicker.Location = new Point(368, 298);
            horaFinPicker.Name = "horaFinPicker";
            horaFinPicker.Size = new Size(200, 23);
            horaFinPicker.TabIndex = 14;
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(472, 387);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(75, 23);
            guardarButton.TabIndex = 16;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(222, 387);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 15;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // CrearSesionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarButton);
            Controls.Add(cancelarButton);
            Controls.Add(horaFinPicker);
            Controls.Add(horaInicioPicker);
            Controls.Add(salaCombo);
            Controls.Add(monitorCombo);
            Controls.Add(tipoActividadCombo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearSesionForm";
            Text = "CrearSesionForm";
            Load += CrearSesionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox tipoActividadCombo;
        private ComboBox monitorCombo;
        private ComboBox salaCombo;
        private DateTimePicker horaInicioPicker;
        private DateTimePicker horaFinPicker;
        private Button guardarButton;
        private Button cancelarButton;
    }
}