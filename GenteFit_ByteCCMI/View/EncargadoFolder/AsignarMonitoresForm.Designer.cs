namespace GenteFit_ByteCCMI.View.EncargadoFolder
{
    partial class AsignarMonitoresForm
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
            lstMonitores = new ListBox();
            lstAsignadas = new ListBox();
            lstNoAsignadas = new ListBox();
            btnAsignar = new Button();
            btnQuitar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstMonitores
            // 
            lstMonitores.FormattingEnabled = true;
            lstMonitores.ItemHeight = 15;
            lstMonitores.Location = new Point(43, 78);
            lstMonitores.Name = "lstMonitores";
            lstMonitores.Size = new Size(217, 319);
            lstMonitores.TabIndex = 0;
            // 
            // lstAsignadas
            // 
            lstAsignadas.FormattingEnabled = true;
            lstAsignadas.ItemHeight = 15;
            lstAsignadas.Location = new Point(291, 78);
            lstAsignadas.Name = "lstAsignadas";
            lstAsignadas.Size = new Size(188, 319);
            lstAsignadas.TabIndex = 1;
            // 
            // lstNoAsignadas
            // 
            lstNoAsignadas.FormattingEnabled = true;
            lstNoAsignadas.ItemHeight = 15;
            lstNoAsignadas.Location = new Point(585, 78);
            lstNoAsignadas.Name = "lstNoAsignadas";
            lstNoAsignadas.Size = new Size(186, 319);
            lstNoAsignadas.TabIndex = 2;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(494, 167);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(75, 23);
            btnAsignar.TabIndex = 3;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(494, 252);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 60);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 5;
            label1.Text = "Listado de monitores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 6;
            label2.Text = "Actividades asignadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 60);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 7;
            label3.Text = "Actividades realizables";
            // 
            // AsignarMonitoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnQuitar);
            Controls.Add(btnAsignar);
            Controls.Add(lstNoAsignadas);
            Controls.Add(lstAsignadas);
            Controls.Add(lstMonitores);
            Name = "AsignarMonitoresForm";
            Text = "AsignarMonitoresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonitores;
        private ListBox lstAsignadas;
        private ListBox lstNoAsignadas;
        private Button btnAsignar;
        private Button btnQuitar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}