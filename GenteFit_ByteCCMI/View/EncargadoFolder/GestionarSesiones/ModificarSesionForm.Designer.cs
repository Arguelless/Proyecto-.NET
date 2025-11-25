namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarSesiones
{
    partial class ModificarSesionForm
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
            guardarButton = new Button();
            cancelarButton = new Button();
            horaFinPicker = new DateTimePicker();
            horaInicioPicker = new DateTimePicker();
            salaCombo = new ComboBox();
            monitorCombo = new ComboBox();
            tipoActividadCombo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(483, 393);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(75, 23);
            guardarButton.TabIndex = 29;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(233, 393);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 28;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // horaFinPicker
            // 
            horaFinPicker.Location = new Point(379, 304);
            horaFinPicker.Name = "horaFinPicker";
            horaFinPicker.Size = new Size(200, 23);
            horaFinPicker.TabIndex = 27;
            // 
            // horaInicioPicker
            // 
            horaInicioPicker.Location = new Point(379, 260);
            horaInicioPicker.Name = "horaInicioPicker";
            horaInicioPicker.Size = new Size(200, 23);
            horaInicioPicker.TabIndex = 26;
            // 
            // salaCombo
            // 
            salaCombo.FormattingEnabled = true;
            salaCombo.Location = new Point(379, 211);
            salaCombo.Name = "salaCombo";
            salaCombo.Size = new Size(200, 23);
            salaCombo.TabIndex = 25;
            // 
            // monitorCombo
            // 
            monitorCombo.FormattingEnabled = true;
            monitorCombo.Location = new Point(379, 164);
            monitorCombo.Name = "monitorCombo";
            monitorCombo.Size = new Size(200, 23);
            monitorCombo.TabIndex = 24;
            // 
            // tipoActividadCombo
            // 
            tipoActividadCombo.FormattingEnabled = true;
            tipoActividadCombo.Location = new Point(379, 122);
            tipoActividadCombo.Name = "tipoActividadCombo";
            tipoActividadCombo.Size = new Size(200, 23);
            tipoActividadCombo.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 310);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 22;
            label6.Text = "Hora fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 260);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 21;
            label5.Text = "Hora inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 211);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 20;
            label4.Text = "Sala";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 167);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 19;
            label3.Text = "Monitor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 18;
            label2.Text = "Tipo de actividad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(284, 34);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 17;
            label1.Text = "Modificar sesión";
            // 
            // ModificarSesionForm
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
            Name = "ModificarSesionForm";
            Text = "ModificarSesionForm";
            Load += ModificarSesionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarButton;
        private Button cancelarButton;
        private DateTimePicker horaFinPicker;
        private DateTimePicker horaInicioPicker;
        private ComboBox salaCombo;
        private ComboBox monitorCombo;
        private ComboBox tipoActividadCombo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}