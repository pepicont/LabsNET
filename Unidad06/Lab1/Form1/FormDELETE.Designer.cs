namespace Form1
{
    partial class FormDELETE
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
            botonDELETE = new Button();
            labelGET = new Label();
            textBoxDELETE = new TextBox();
            dgvDELETE = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDELETE).BeginInit();
            SuspendLayout();
            // 
            // botonDELETE
            // 
            botonDELETE.Location = new Point(461, 12);
            botonDELETE.Name = "botonDELETE";
            botonDELETE.Size = new Size(75, 23);
            botonDELETE.TabIndex = 5;
            botonDELETE.Text = "Borrar";
            botonDELETE.UseVisualStyleBackColor = true;
            botonDELETE.Click += botonDELETE_Click;
            // 
            // labelGET
            // 
            labelGET.AutoSize = true;
            labelGET.Location = new Point(284, 15);
            labelGET.Name = "labelGET";
            labelGET.Size = new Size(18, 15);
            labelGET.TabIndex = 4;
            labelGET.Text = "ID";
            // 
            // textBoxDELETE
            // 
            textBoxDELETE.Location = new Point(339, 12);
            textBoxDELETE.Name = "textBoxDELETE";
            textBoxDELETE.Size = new Size(100, 23);
            textBoxDELETE.TabIndex = 3;
            // 
            // dgvDELETE
            // 
            dgvDELETE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDELETE.Location = new Point(184, 75);
            dgvDELETE.Name = "dgvDELETE";
            dgvDELETE.Size = new Size(439, 75);
            dgvDELETE.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 7;
            label1.Text = "ALUMNO BORRADO";
            label1.Click += label1_Click;
            // 
            // FormDELETE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvDELETE);
            Controls.Add(botonDELETE);
            Controls.Add(labelGET);
            Controls.Add(textBoxDELETE);
            Name = "FormDELETE";
            Text = "FormDELETE";
            ((System.ComponentModel.ISupportInitialize)dgvDELETE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonDELETE;
        private Label labelGET;
        private TextBox textBoxDELETE;
        private DataGridView dgvDELETE;
        private Label label1;
    }
}