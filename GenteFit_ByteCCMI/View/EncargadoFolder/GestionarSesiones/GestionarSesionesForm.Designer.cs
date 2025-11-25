namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarSesiones
{
    partial class GestionarSesionesForm
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
            sesionesListBox = new ListBox();
            label1 = new Label();
            consultarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            crearButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // sesionesListBox
            // 
            sesionesListBox.FormattingEnabled = true;
            sesionesListBox.ItemHeight = 15;
            sesionesListBox.Location = new Point(77, 90);
            sesionesListBox.Name = "sesionesListBox";
            sesionesListBox.Size = new Size(289, 289);
            sesionesListBox.TabIndex = 0;
            sesionesListBox.SelectedIndexChanged += sesionesListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 72);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Sesiones";
            // 
            // consultarButton
            // 
            consultarButton.Location = new Point(525, 308);
            consultarButton.Name = "consultarButton";
            consultarButton.Size = new Size(75, 23);
            consultarButton.TabIndex = 7;
            consultarButton.Text = "Consultar";
            consultarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(525, 244);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 6;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(525, 182);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 5;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // crearButton
            // 
            crearButton.Location = new Point(525, 120);
            crearButton.Name = "crearButton";
            crearButton.Size = new Size(75, 23);
            crearButton.TabIndex = 4;
            crearButton.Text = "Crear";
            crearButton.UseVisualStyleBackColor = true;
            crearButton.Click += crearButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(362, 401);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 8;
            backButton.Text = "Atrás";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // GestionarSesionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(consultarButton);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(crearButton);
            Controls.Add(label1);
            Controls.Add(sesionesListBox);
            Name = "GestionarSesionesForm";
            Text = "GestionarSesionesForm";
            Load += GestionarSesionesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox sesionesListBox;
        private Label label1;
        private Button consultarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Button crearButton;
        private Button backButton;
    }
}