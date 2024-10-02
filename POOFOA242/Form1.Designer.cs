namespace POOFOA242
{
    partial class frmPrincipal
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
            lblNome = new Label();
            btnCliqueMe = new Button();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(402, 123);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // btnCliqueMe
            // 
            btnCliqueMe.Enabled = false;
            btnCliqueMe.Location = new Point(499, 300);
            btnCliqueMe.Name = "btnCliqueMe";
            btnCliqueMe.Size = new Size(94, 29);
            btnCliqueMe.TabIndex = 1;
            btnCliqueMe.Text = "Clique-me";
            btnCliqueMe.UseVisualStyleBackColor = true;
            btnCliqueMe.Click += btnCliqueMe_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(523, 116);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 500);
            Controls.Add(txtNome);
            Controls.Add(btnCliqueMe);
            Controls.Add(lblNome);
            Name = "frmPrincipal";
            Text = "Formulário Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnCliqueMe;
        private TextBox txtNome;
    }
}
