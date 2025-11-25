namespace GenteFit_ByteCCMI.View.EncargadoFolder
{
    partial class EstadoReservasForm
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
            clientesReservaListBox = new ListBox();
            listaEsperaListbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // sesionesListBox
            // 
            sesionesListBox.FormattingEnabled = true;
            sesionesListBox.ItemHeight = 15;
            sesionesListBox.Location = new Point(30, 81);
            sesionesListBox.Name = "sesionesListBox";
            sesionesListBox.Size = new Size(228, 289);
            sesionesListBox.TabIndex = 0;
            sesionesListBox.SelectedIndexChanged += sesionesListBox_SelectedIndexChanged;
            // 
            // clientesReservaListBox
            // 
            clientesReservaListBox.FormattingEnabled = true;
            clientesReservaListBox.ItemHeight = 15;
            clientesReservaListBox.Location = new Point(294, 81);
            clientesReservaListBox.Name = "clientesReservaListBox";
            clientesReservaListBox.Size = new Size(226, 289);
            clientesReservaListBox.TabIndex = 1;
            clientesReservaListBox.SelectedIndexChanged += clientesReservaListBox_SelectedIndexChanged;
            // 
            // listaEsperaListbox
            // 
            listaEsperaListbox.FormattingEnabled = true;
            listaEsperaListbox.ItemHeight = 15;
            listaEsperaListbox.Location = new Point(551, 81);
            listaEsperaListbox.Name = "listaEsperaListbox";
            listaEsperaListbox.Size = new Size(217, 289);
            listaEsperaListbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 63);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 3;
            label1.Text = "Listado de Actividades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 63);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Clientes con reserva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 63);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Lista de espera";
            // 
            // EstadoReservasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listaEsperaListbox);
            Controls.Add(clientesReservaListBox);
            Controls.Add(sesionesListBox);
            Name = "EstadoReservasForm";
            Text = "EstadoReservasForm";
            Load += EstadoReservasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox sesionesListBox;
        private ListBox clientesReservaListBox;
        private ListBox listaEsperaListbox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}