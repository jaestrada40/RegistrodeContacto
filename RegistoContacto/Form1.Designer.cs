namespace RegistoContacto
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            lbListar = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(446, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(143, 76);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 115);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo Electrónico:";
            label3.Click += label3_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(143, 107);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(442, 23);
            txtCorreo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(143, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 42);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar Contacto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.OrangeRed;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(280, 139);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 42);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbListar
            // 
            lbListar.FormattingEnabled = true;
            lbListar.ItemHeight = 15;
            lbListar.Location = new Point(146, 197);
            lbListar.Name = "lbListar";
            lbListar.Size = new Size(443, 169);
            lbListar.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMensaje.Location = new Point(146, 383);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 25);
            lblMensaje.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(lbListar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtCorreo;
        private Button btnAgregar;
        private Button btnLimpiar;
        private ListBox lbListar;
        private Label lblMensaje;
    }
}
