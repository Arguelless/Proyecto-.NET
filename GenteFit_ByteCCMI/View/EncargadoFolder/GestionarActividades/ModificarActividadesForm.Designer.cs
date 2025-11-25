namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarActividades
{
    partial class ModificarActividadesForm
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
            guardarButton = new Button();
            cancelarButton = new Button();
            duracionSpinner = new NumericUpDown();
            label4 = new Label();
            descripcionTextBox = new RichTextBox();
            nombreTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)duracionSpinner).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(270, 29);
            label1.Name = "label1";
            label1.Size = new Size(306, 46);
            label1.TabIndex = 18;
            label1.Text = "Modificar actividad";
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(501, 394);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(75, 23);
            guardarButton.TabIndex = 16;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(251, 394);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 15;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // duracionSpinner
            // 
            duracionSpinner.Location = new Point(363, 279);
            duracionSpinner.Name = "duracionSpinner";
            duracionSpinner.Size = new Size(120, 23);
            duracionSpinner.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 281);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 23;
            label4.Text = "Duración";
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(363, 187);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(198, 68);
            descripcionTextBox.TabIndex = 22;
            descripcionTextBox.Text = "";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(363, 148);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(200, 23);
            nombreTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 187);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 20;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 148);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // ModificarActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(duracionSpinner);
            Controls.Add(label4);
            Controls.Add(descripcionTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guardarButton);
            Controls.Add(cancelarButton);
            Name = "ModificarActividadesForm";
            Text = "ModificarActividadesForm";
            Load += ModificarActividadesForm_Load;
            ((System.ComponentModel.ISupportInitialize)duracionSpinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button guardarButton;
        private Button cancelarButton;
        private NumericUpDown duracionSpinner;
        private Label label4;
        private RichTextBox descripcionTextBox;
        private TextBox nombreTextBox;
        private Label label3;
        private Label label2;
    }
}