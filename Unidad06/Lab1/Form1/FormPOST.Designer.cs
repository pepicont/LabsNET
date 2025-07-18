namespace Form1
{
    partial class FormPOST
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
            dgvPOST = new DataGridView();
            labelPOST = new Label();
            label1 = new Label();
            textBoxID = new TextBox();
            textBoxApellido = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            textBoxLegajo = new TextBox();
            label5 = new Label();
            buttonPOST = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPOST).BeginInit();
            SuspendLayout();
            // 
            // dgvPOST
            // 
            dgvPOST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOST.Location = new Point(61, 232);
            dgvPOST.Name = "dgvPOST";
            dgvPOST.Size = new Size(623, 102);
            dgvPOST.TabIndex = 0;
            dgvPOST.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelPOST
            // 
            labelPOST.AutoSize = true;
            labelPOST.Location = new Point(316, 204);
            labelPOST.Name = "labelPOST";
            labelPOST.Size = new Size(125, 15);
            labelPOST.TabIndex = 1;
            labelPOST.Text = "ALUMNO INGRESADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 23);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(124, 23);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(124, 52);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(100, 23);
            textBoxApellido.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 52);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(124, 81);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(124, 110);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(100, 23);
            textBoxDireccion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 113);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Dirección";
            // 
            // textBoxLegajo
            // 
            textBoxLegajo.Location = new Point(124, 139);
            textBoxLegajo.Name = "textBoxLegajo";
            textBoxLegajo.Size = new Size(100, 23);
            textBoxLegajo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 142);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Legajo";
            // 
            // buttonPOST
            // 
            buttonPOST.Location = new Point(262, 138);
            buttonPOST.Name = "buttonPOST";
            buttonPOST.Size = new Size(75, 23);
            buttonPOST.TabIndex = 12;
            buttonPOST.Text = "Cargar";
            buttonPOST.UseVisualStyleBackColor = true;
            buttonPOST.Click += buttonPOST_Click;
            // 
            // FormPOST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPOST);
            Controls.Add(textBoxLegajo);
            Controls.Add(label5);
            Controls.Add(textBoxDireccion);
            Controls.Add(label4);
            Controls.Add(textBoxNombre);
            Controls.Add(label3);
            Controls.Add(textBoxApellido);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(labelPOST);
            Controls.Add(dgvPOST);
            Name = "FormPOST";
            Text = "FormPOST";
            ((System.ComponentModel.ISupportInitialize)dgvPOST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPOST;
        private Label labelPOST;
        private Label label1;
        private TextBox textBoxID;
        private TextBox textBoxApellido;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxDireccion;
        private Label label4;
        private TextBox textBoxLegajo;
        private Label label5;
        private Button buttonPOST;
    }
}