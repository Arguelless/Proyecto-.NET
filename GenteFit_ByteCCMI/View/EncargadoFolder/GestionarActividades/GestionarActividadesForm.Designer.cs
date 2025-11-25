namespace GenteFit_ByteCCMI.View
{
    partial class GestionarActividadesForm
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
            crearButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            consultarButton = new Button();
            actividadesList = new ListBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // crearButton
            // 
            crearButton.Location = new Point(550, 115);
            crearButton.Name = "crearButton";
            crearButton.Size = new Size(75, 23);
            crearButton.TabIndex = 0;
            crearButton.Text = "Crear";
            crearButton.UseVisualStyleBackColor = true;
            crearButton.Click += crearButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(550, 177);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 1;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(550, 239);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // consultarButton
            // 
            consultarButton.Location = new Point(550, 303);
            consultarButton.Name = "consultarButton";
            consultarButton.Size = new Size(75, 23);
            consultarButton.TabIndex = 3;
            consultarButton.Text = "Consultar";
            consultarButton.UseVisualStyleBackColor = true;
            // 
            // actividadesList
            // 
            actividadesList.FormattingEnabled = true;
            actividadesList.ItemHeight = 15;
            actividadesList.Location = new Point(118, 85);
            actividadesList.Name = "actividadesList";
            actividadesList.Size = new Size(341, 274);
            actividadesList.TabIndex = 4;
            actividadesList.SelectedIndexChanged += actividadesList_SelectedIndexChanged;
            // 
            // backButton
            // 
            backButton.Location = new Point(365, 388);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 9;
            backButton.Text = "Atrás";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += this.backButton_Click;
            // 
            // GestionarActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(actividadesList);
            Controls.Add(consultarButton);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(crearButton);
            Name = "GestionarActividadesForm";
            Text = "GestionarActividadesForm";
            Load += GestionarActividadesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button crearButton;
        private Button modificarButton;
        private Button eliminarButton;
        private Button consultarButton;
        private ListBox actividadesList;
        private Button backButton;
    }
}