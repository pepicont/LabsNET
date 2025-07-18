namespace Form1
{
    partial class Form2
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
            textBoxGET = new TextBox();
            labelGET = new Label();
            botonGET = new Button();
            dgvGET = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGET).BeginInit();
            SuspendLayout();
            // 
            // textBoxGET
            // 
            textBoxGET.Location = new Point(290, 12);
            textBoxGET.Name = "textBoxGET";
            textBoxGET.Size = new Size(100, 23);
            textBoxGET.TabIndex = 0;
            // 
            // labelGET
            // 
            labelGET.AutoSize = true;
            labelGET.Location = new Point(235, 15);
            labelGET.Name = "labelGET";
            labelGET.Size = new Size(18, 15);
            labelGET.TabIndex = 1;
            labelGET.Text = "ID";
            // 
            // botonGET
            // 
            botonGET.Location = new Point(412, 12);
            botonGET.Name = "botonGET";
            botonGET.Size = new Size(75, 23);
            botonGET.TabIndex = 2;
            botonGET.Text = "Buscar";
            botonGET.UseVisualStyleBackColor = true;
            botonGET.Click += botonGET_Click;
            // 
            // dgvGET
            // 
            dgvGET.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGET.Location = new Point(147, 60);
            dgvGET.Name = "dgvGET";
            dgvGET.Size = new Size(439, 150);
            dgvGET.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGET);
            Controls.Add(botonGET);
            Controls.Add(labelGET);
            Controls.Add(textBoxGET);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGET).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // Agrega este método al archivo para definir el controlador de evento Form2_Load
        private void Form2_Load(object sender, EventArgs e)
        {
            // Inicialización necesaria al cargar el formulario
        }

        #endregion

        private TextBox textBoxGET;
        private Label labelGET;
        private Button botonGET;
        private DataGridView dgvGET;
    }
}