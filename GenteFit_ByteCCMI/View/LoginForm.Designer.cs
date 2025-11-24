namespace GenteFit_ByteCCMI.View
{
    partial class LoginForm
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
            emailTextField = new TextBox();
            label2 = new Label();
            pwdTextField = new TextBox();
            accederButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 117);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // emailTextField
            // 
            emailTextField.Location = new Point(51, 135);
            emailTextField.Name = "emailTextField";
            emailTextField.Size = new Size(162, 23);
            emailTextField.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 177);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // pwdTextField
            // 
            pwdTextField.Location = new Point(51, 195);
            pwdTextField.Name = "pwdTextField";
            pwdTextField.Size = new Size(162, 23);
            pwdTextField.TabIndex = 3;
            // 
            // accederButton
            // 
            accederButton.Location = new Point(51, 263);
            accederButton.Name = "accederButton";
            accederButton.Size = new Size(162, 29);
            accederButton.TabIndex = 4;
            accederButton.Text = "Acceder";
            accederButton.UseVisualStyleBackColor = true;
            accederButton.Click += accederButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(73, 29);
            label3.Name = "label3";
            label3.Size = new Size(118, 46);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            label3.Click += label3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 347);
            Controls.Add(label3);
            Controls.Add(accederButton);
            Controls.Add(pwdTextField);
            Controls.Add(label2);
            Controls.Add(emailTextField);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTextField;
        private Label label2;
        private TextBox pwdTextField;
        private Button accederButton;
        private Label label3;
    }
}