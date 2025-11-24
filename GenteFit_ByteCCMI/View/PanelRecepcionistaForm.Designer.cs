namespace GenteFit_ByteCCMI.View
{
    partial class PanelRecepcionistaForm
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(208, 115);
            label1.Name = "label1";
            label1.Size = new Size(366, 46);
            label1.TabIndex = 9;
            label1.Text = "PANEL RECEPCIONISTA";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(146, 313);
            button4.Name = "button4";
            button4.Size = new Size(175, 23);
            button4.TabIndex = 8;
            button4.Text = "Modificar cliente";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(146, 227);
            button3.Name = "button3";
            button3.Size = new Size(175, 23);
            button3.TabIndex = 7;
            button3.Text = "Registrar cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(479, 313);
            button2.Name = "button2";
            button2.Size = new Size(175, 23);
            button2.TabIndex = 6;
            button2.Text = "Consultar clientes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(479, 227);
            button1.Name = "button1";
            button1.Size = new Size(175, 23);
            button1.TabIndex = 5;
            button1.Text = "Dar de baja cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(350, 374);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(95, 23);
            logoutButton.TabIndex = 12;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // PanelRecepcionistaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PanelRecepcionistaForm";
            Text = "PanelRecepcionistaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button logoutButton;
    }
}