namespace GenteFit_ByteCCMI.View
{
    partial class PanelMonitorForm
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
            button3 = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(216, 112);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 9;
            label1.Text = "PANEL DEL MONITOR";
            // 
            // button3
            // 
            button3.Location = new Point(284, 231);
            button3.Name = "button3";
            button3.Size = new Size(175, 23);
            button3.TabIndex = 7;
            button3.Text = "Consultar actividades";
            button3.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(332, 322);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(86, 23);
            logoutButton.TabIndex = 12;
            logoutButton.Text = "Cerrar sesión";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // PanelMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Controls.Add(button3);
            Name = "PanelMonitorForm";
            Text = "PanelMonitorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button logoutButton;
    }
}