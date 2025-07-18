
namespace Form1
{
    partial class FormPUT
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
            buttonPUT = new Button();
            textBoxLegajo = new TextBox();
            label5 = new Label();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxApellido = new TextBox();
            label2 = new Label();
            textBoxID = new TextBox();
            label1 = new Label();
            labelPOST = new Label();
            dgvPUT = new DataGridView();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPUT).BeginInit();
            SuspendLayout();
            // 
            // buttonPUT
            // 
            buttonPUT.Location = new Point(267, 143);
            buttonPUT.Name = "buttonPUT";
            buttonPUT.Size = new Size(75, 23);
            buttonPUT.TabIndex = 25;
            buttonPUT.Text = "Modificar";
            buttonPUT.UseVisualStyleBackColor = true;
            buttonPUT.Click += buttonPUT_Click;
            // 
            // textBoxLegajo
            // 
            textBoxLegajo.Location = new Point(129, 144);
            textBoxLegajo.Name = "textBoxLegajo";
            textBoxLegajo.Size = new Size(100, 23);
            textBoxLegajo.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 147);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 23;
            label5.Text = "Legajo";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(129, 115);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(100, 23);
            textBoxDireccion.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 118);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Dirección";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(129, 86);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 19;
            label3.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(129, 57);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(100, 23);
            textBoxApellido.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 57);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Apellido";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(129, 28);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // labelPOST
            // 
            labelPOST.AutoSize = true;
            labelPOST.Location = new Point(321, 209);
            labelPOST.Name = "labelPOST";
            labelPOST.Size = new Size(140, 15);
            labelPOST.TabIndex = 14;
            labelPOST.Text = "ALUMNO ACTUALIZADO";
            labelPOST.Click += labelPOST_Click;
            // 
            // dgvPUT
            // 
            dgvPUT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPUT.Location = new Point(66, 237);
            dgvPUT.Name = "dgvPUT";
            dgvPUT.Size = new Size(623, 102);
            dgvPUT.TabIndex = 13;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(591, 27);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(98, 23);
            buttonBuscar.TabIndex = 28;
            buttonBuscar.Text = "Buscar por ID";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += button1_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(453, 28);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(100, 23);
            textBoxBuscar.TabIndex = 27;
            textBoxBuscar.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 31);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 26;
            label6.Text = "ID";
            label6.Click += label6_Click;
            // 
            // FormPUT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label6);
            Controls.Add(buttonPUT);
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
            Controls.Add(dgvPUT);
            Name = "FormPUT";
            Text = "FormPUT";
            ((System.ComponentModel.ISupportInitialize)dgvPUT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private Button buttonPUT;
        private TextBox textBoxLegajo;
        private Label label5;
        private TextBox textBoxDireccion;
        private Label label4;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label2;
        private TextBox textBoxID;
        private Label label1;
        private Label labelPOST;
        private DataGridView dgvPUT;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label label6;
    }
}