namespace datagridview_ejem1
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
            btn_agregar = new Button();
            btn_eliminar = new Button();
            btn_limpiar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_nombre = new TextBox();
            txt_email = new TextBox();
            dgv_datos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_datos).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Sitka Heading", 10F);
            btn_agregar.ForeColor = SystemColors.ActiveCaptionText;
            btn_agregar.Location = new Point(608, 61);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 42);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Sitka Heading", 10F);
            btn_eliminar.ForeColor = SystemColors.ActiveCaptionText;
            btn_eliminar.Location = new Point(608, 113);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 42);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Sitka Heading", 10F);
            btn_limpiar.ForeColor = SystemColors.ActiveCaptionText;
            btn_limpiar.Location = new Point(608, 170);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 42);
            btn_limpiar.TabIndex = 2;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Sitka Heading", 10F);
            btn_salir.ForeColor = SystemColors.ActiveCaptionText;
            btn_salir.Location = new Point(608, 230);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 42);
            btn_salir.TabIndex = 3;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(56, 66);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(56, 136);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(150, 72);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(300, 31);
            txt_nombre.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(150, 136);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(300, 31);
            txt_email.TabIndex = 7;
            // 
            // dgv_datos
            // 
            dgv_datos.AllowUserToAddRows = false;
            dgv_datos.AllowUserToDeleteRows = false;
            dgv_datos.BackgroundColor = SystemColors.ScrollBar;
            dgv_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_datos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Email });
            dgv_datos.GridColor = SystemColors.Control;
            dgv_datos.Location = new Point(39, 213);
            dgv_datos.Name = "dgv_datos";
            dgv_datos.ReadOnly = true;
            dgv_datos.RowHeadersWidth = 62;
            dgv_datos.Size = new Size(498, 225);
            dgv_datos.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Email
            // 
            Email.HeaderText = "email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 250;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(746, 450);
            Controls.Add(dgv_datos);
            Controls.Add(txt_email);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Button btn_eliminar;
        private Button btn_limpiar;
        private Button btn_salir;
        private Label label1;
        private Label label2;
        private TextBox txt_nombre;
        private TextBox txt_email;
        private DataGridView dgv_datos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
    }
}
