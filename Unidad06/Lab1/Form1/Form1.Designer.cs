namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Alumnos = new DataGridView();
            botonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)Alumnos).BeginInit();
            SuspendLayout();
            // 
            // Alumnos
            // 
            Alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Alumnos.Location = new Point(12, 12);
            Alumnos.Name = "Alumnos";
            Alumnos.Size = new Size(728, 289);
            Alumnos.TabIndex = 0;
            // 
            // botonActualizar
            // 
            botonActualizar.Location = new Point(12, 320);
            botonActualizar.Name = "botonActualizar";
            botonActualizar.Size = new Size(728, 23);
            botonActualizar.TabIndex = 1;
            botonActualizar.Text = "Actualizar";
            botonActualizar.UseVisualStyleBackColor = true;
            botonActualizar.Click += botonActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonActualizar);
            Controls.Add(Alumnos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Alumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Alumnos;
        private Button botonActualizar;
    }
}
