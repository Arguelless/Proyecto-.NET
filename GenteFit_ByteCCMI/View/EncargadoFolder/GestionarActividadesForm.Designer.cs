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
            button3 = new Button();
            consultarButton = new Button();
            actividadesList = new ListBox();
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
            // 
            // button3
            // 
            button3.Location = new Point(550, 239);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
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
            // 
            // GestionarActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actividadesList);
            Controls.Add(consultarButton);
            Controls.Add(button3);
            Controls.Add(modificarButton);
            Controls.Add(crearButton);
            Name = "GestionarActividadesForm";
            Text = "GestionarActividadesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button crearButton;
        private Button modificarButton;
        private Button button3;
        private Button consultarButton;
        private ListBox actividadesList;
    }
}