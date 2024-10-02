namespace ControleFinanceiro
{
    partial class frmCliente
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
            txtNome = new TextBox();
            lblNome = new Label();
            lblCpf = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            txtCpf = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(258, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(156, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(156, 112);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            lblCpf.Click += label2_Click;
            // 
            // btnInserir
            // 
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(156, 181);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(279, 181);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(156, 233);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(227, 104);
            lstClientes.TabIndex = 5;
            lstClientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(258, 112);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 27);
            txtCpf.TabIndex = 6;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCpf);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "frmCliente";
            Text = "Controle de Clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblCpf;
        private Button btnInserir;
        private Button btnExcluir;
        private ListBox lstClientes;
        private TextBox txtCpf;
    }
}
