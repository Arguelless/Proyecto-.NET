namespace GenteFit_ByteCCMI.View
{
    partial class PanelEncargadoForm
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
            asignarMonitoresButton = new Button();
            listaEsperaButton = new Button();
            gestionarActividadesButton = new Button();
            estadoReservasButton = new Button();
            label1 = new Label();
            logoutButton = new Button();
            gestionarSesionesButton = new Button();
            SuspendLayout();
            // 
            // asignarMonitoresButton
            // 
            asignarMonitoresButton.Location = new Point(454, 165);
            asignarMonitoresButton.Name = "asignarMonitoresButton";
            asignarMonitoresButton.Size = new Size(175, 23);
            asignarMonitoresButton.TabIndex = 0;
            asignarMonitoresButton.Text = "Asignar monitores";
            asignarMonitoresButton.UseVisualStyleBackColor = true;
            asignarMonitoresButton.Click += asignarMonitoresButton_Click;
            // 
            // listaEsperaButton
            // 
            listaEsperaButton.Location = new Point(454, 249);
            listaEsperaButton.Name = "listaEsperaButton";
            listaEsperaButton.Size = new Size(175, 23);
            listaEsperaButton.TabIndex = 1;
            listaEsperaButton.Text = "Lista espera";
            listaEsperaButton.UseVisualStyleBackColor = true;
            // 
            // gestionarActividadesButton
            // 
            gestionarActividadesButton.Location = new Point(121, 165);
            gestionarActividadesButton.Name = "gestionarActividadesButton";
            gestionarActividadesButton.Size = new Size(175, 23);
            gestionarActividadesButton.TabIndex = 2;
            gestionarActividadesButton.Text = "Gestionar actividades";
            gestionarActividadesButton.UseVisualStyleBackColor = true;
            gestionarActividadesButton.Click += gestionarActividadesButton_Click;
            // 
            // estadoReservasButton
            // 
            estadoReservasButton.Location = new Point(121, 249);
            estadoReservasButton.Name = "estadoReservasButton";
            estadoReservasButton.Size = new Size(175, 23);
            estadoReservasButton.TabIndex = 3;
            estadoReservasButton.Text = "Estado de reservas";
            estadoReservasButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(173, 53);
            label1.Name = "label1";
            label1.Size = new Size(392, 46);
            label1.TabIndex = 4;
            label1.Text = "PANEL DEL ENCARGADO";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(332, 374);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(83, 23);
            logoutButton.TabIndex = 12;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // gestionarSesionesButton
            // 
            gestionarSesionesButton.Location = new Point(121, 324);
            gestionarSesionesButton.Name = "gestionarSesionesButton";
            gestionarSesionesButton.Size = new Size(175, 23);
            gestionarSesionesButton.TabIndex = 13;
            gestionarSesionesButton.Text = "Gestionar sesiones";
            gestionarSesionesButton.UseVisualStyleBackColor = true;
            gestionarSesionesButton.Click += gestionarSesionesButton_Click;
            // 
            // PanelEncargadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gestionarSesionesButton);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Controls.Add(estadoReservasButton);
            Controls.Add(gestionarActividadesButton);
            Controls.Add(listaEsperaButton);
            Controls.Add(asignarMonitoresButton);
            Name = "PanelEncargadoForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button asignarMonitoresButton;
        private Button listaEsperaButton;
        private Button gestionarActividadesButton;
        private Button estadoReservasButton;
        private Label label1;
        private Button logoutButton;
        private Button gestionarSesionesButton;
    }
}