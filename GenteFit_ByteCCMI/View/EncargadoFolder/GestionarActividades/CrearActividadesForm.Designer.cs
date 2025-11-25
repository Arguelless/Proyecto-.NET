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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombreTextBox = new TextBox();
            descripcionTextBox = new RichTextBox();
            label4 = new Label();
            duracionSpinner = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)duracionSpinner).BeginInit();
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
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(324, 108);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(200, 23);
            nombreTextBox.TabIndex = 13;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(324, 147);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(198, 68);
            descripcionTextBox.TabIndex = 14;
            descripcionTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 241);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Duración";
            // 
            // duracionSpinner
            // 
            duracionSpinner.Location = new Point(324, 239);
            duracionSpinner.Name = "duracionSpinner";
            duracionSpinner.Size = new Size(120, 23);
            duracionSpinner.TabIndex = 16;
            // 
            // CrearActividadesForm
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
            Name = "CrearActividadesForm";
            Text = "CrearActividadesForm";
            Load += CrearActividadesForm_Load;
            ((System.ComponentModel.ISupportInitialize)duracionSpinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarButton;
        private Button guardarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombreTextBox;
        private RichTextBox descripcionTextBox;
        private Label label4;
        private NumericUpDown duracionSpinner;
    }
}