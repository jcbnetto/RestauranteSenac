namespace RestauranteSenac
{
    partial class WinFuncListar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.gpxCadastro = new System.Windows.Forms.GroupBox();
            this.gpxEditar = new System.Windows.Forms.GroupBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblTelCad = new System.Windows.Forms.Label();
            this.txbTelCad = new System.Windows.Forms.MaskedTextBox();
            this.lblSetorCad = new System.Windows.Forms.Label();
            this.txbSetorCad = new System.Windows.Forms.TextBox();
            this.txbFuncaoCad = new System.Windows.Forms.TextBox();
            this.lblFuncaoCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Funcionários :: Listar";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToResizeColumns = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(22, 61);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(718, 206);
            this.dgvFuncionarios.TabIndex = 1;
            // 
            // gpxCadastro
            // 
            this.gpxCadastro.Controls.Add(this.btnCadastrar);
            this.gpxCadastro.Controls.Add(this.txbFuncaoCad);
            this.gpxCadastro.Controls.Add(this.lblFuncaoCad);
            this.gpxCadastro.Controls.Add(this.txbSetorCad);
            this.gpxCadastro.Controls.Add(this.lblSetorCad);
            this.gpxCadastro.Controls.Add(this.txbTelCad);
            this.gpxCadastro.Controls.Add(this.lblTelCad);
            this.gpxCadastro.Controls.Add(this.txbEmailCad);
            this.gpxCadastro.Controls.Add(this.lblEmailCad);
            this.gpxCadastro.Controls.Add(this.txbNomeCad);
            this.gpxCadastro.Controls.Add(this.lblNomeCad);
            this.gpxCadastro.Location = new System.Drawing.Point(22, 273);
            this.gpxCadastro.Name = "gpxCadastro";
            this.gpxCadastro.Size = new System.Drawing.Size(309, 198);
            this.gpxCadastro.TabIndex = 2;
            this.gpxCadastro.TabStop = false;
            this.gpxCadastro.Text = "Cadastro";
            // 
            // gpxEditar
            // 
            this.gpxEditar.Location = new System.Drawing.Point(454, 273);
            this.gpxEditar.Name = "gpxEditar";
            this.gpxEditar.Size = new System.Drawing.Size(286, 198);
            this.gpxEditar.TabIndex = 3;
            this.gpxEditar.TabStop = false;
            this.gpxEditar.Text = "Editar";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 25);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(60, 22);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(233, 20);
            this.txbNomeCad.TabIndex = 1;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(60, 48);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(233, 20);
            this.txbEmailCad.TabIndex = 3;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 51);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblTelCad
            // 
            this.lblTelCad.AutoSize = true;
            this.lblTelCad.Location = new System.Drawing.Point(6, 77);
            this.lblTelCad.Name = "lblTelCad";
            this.lblTelCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelCad.TabIndex = 4;
            this.lblTelCad.Text = "Telefone:";
            // 
            // txbTelCad
            // 
            this.txbTelCad.Location = new System.Drawing.Point(60, 74);
            this.txbTelCad.Mask = "(99) 00000-0000";
            this.txbTelCad.Name = "txbTelCad";
            this.txbTelCad.Size = new System.Drawing.Size(233, 20);
            this.txbTelCad.TabIndex = 5;
            // 
            // lblSetorCad
            // 
            this.lblSetorCad.AutoSize = true;
            this.lblSetorCad.Location = new System.Drawing.Point(6, 103);
            this.lblSetorCad.Name = "lblSetorCad";
            this.lblSetorCad.Size = new System.Drawing.Size(35, 13);
            this.lblSetorCad.TabIndex = 6;
            this.lblSetorCad.Text = "Setor:";
            // 
            // txbSetorCad
            // 
            this.txbSetorCad.Location = new System.Drawing.Point(60, 100);
            this.txbSetorCad.Name = "txbSetorCad";
            this.txbSetorCad.Size = new System.Drawing.Size(233, 20);
            this.txbSetorCad.TabIndex = 7;
            // 
            // txbFuncaoCad
            // 
            this.txbFuncaoCad.Location = new System.Drawing.Point(60, 126);
            this.txbFuncaoCad.Name = "txbFuncaoCad";
            this.txbFuncaoCad.Size = new System.Drawing.Size(233, 20);
            this.txbFuncaoCad.TabIndex = 9;
            // 
            // lblFuncaoCad
            // 
            this.lblFuncaoCad.AutoSize = true;
            this.lblFuncaoCad.Location = new System.Drawing.Point(6, 129);
            this.lblFuncaoCad.Name = "lblFuncaoCad";
            this.lblFuncaoCad.Size = new System.Drawing.Size(46, 13);
            this.lblFuncaoCad.TabIndex = 8;
            this.lblFuncaoCad.Text = "Função:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(284, 40);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // WinFuncListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 483);
            this.Controls.Add(this.gpxEditar);
            this.Controls.Add(this.gpxCadastro);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "WinFuncListar";
            this.Text = "Funcionários :: Listar";
            this.Load += new System.EventHandler(this.WinFuncListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gpxCadastro.ResumeLayout(false);
            this.gpxCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox gpxCadastro;
        private System.Windows.Forms.MaskedTextBox txbTelCad;
        private System.Windows.Forms.Label lblTelCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox gpxEditar;
        private System.Windows.Forms.TextBox txbSetorCad;
        private System.Windows.Forms.Label lblSetorCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbFuncaoCad;
        private System.Windows.Forms.Label lblFuncaoCad;
    }
}