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
            this.gpxcadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbFuncaoCad2 = new System.Windows.Forms.TextBox();
            this.txbSetorCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbFuncaoCad = new System.Windows.Forms.Label();
            this.txbSetor = new System.Windows.Forms.Label();
            this.txbtelefone = new System.Windows.Forms.Label();
            this.txbtelCad = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.Label();
            this.gpxEditar = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbFuncaoEd = new System.Windows.Forms.TextBox();
            this.txbSetorEd = new System.Windows.Forms.TextBox();
            this.txbEmailEd = new System.Windows.Forms.TextBox();
            this.txbNomeEd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTelEd = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpxcadastro.SuspendLayout();
            this.gpxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(173, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Funcionários :: Listar";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(39, 64);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(661, 191);
            this.dgvFuncionarios.TabIndex = 1;
            this.dgvFuncionarios.SelectionChanged += new System.EventHandler(this.dgvFuncionarios_SelectionChanged);
            // 
            // gpxcadastro
            // 
            this.gpxcadastro.Controls.Add(this.btnCadastrar);
            this.gpxcadastro.Controls.Add(this.txbFuncaoCad2);
            this.gpxcadastro.Controls.Add(this.txbSetorCad);
            this.gpxcadastro.Controls.Add(this.txbEmailCad);
            this.gpxcadastro.Controls.Add(this.txbNomeCad);
            this.gpxcadastro.Controls.Add(this.txbFuncaoCad);
            this.gpxcadastro.Controls.Add(this.txbSetor);
            this.gpxcadastro.Controls.Add(this.txbtelefone);
            this.gpxcadastro.Controls.Add(this.txbtelCad);
            this.gpxcadastro.Controls.Add(this.txbEmail);
            this.gpxcadastro.Controls.Add(this.txbNome);
            this.gpxcadastro.Location = new System.Drawing.Point(39, 273);
            this.gpxcadastro.Name = "gpxcadastro";
            this.gpxcadastro.Size = new System.Drawing.Size(328, 240);
            this.gpxcadastro.TabIndex = 2;
            this.gpxcadastro.TabStop = false;
            this.gpxcadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(16, 174);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(298, 36);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbFuncaoCad2
            // 
            this.txbFuncaoCad2.Location = new System.Drawing.Point(114, 148);
            this.txbFuncaoCad2.Name = "txbFuncaoCad2";
            this.txbFuncaoCad2.Size = new System.Drawing.Size(194, 20);
            this.txbFuncaoCad2.TabIndex = 9;
            // 
            // txbSetorCad
            // 
            this.txbSetorCad.Location = new System.Drawing.Point(114, 113);
            this.txbSetorCad.Name = "txbSetorCad";
            this.txbSetorCad.Size = new System.Drawing.Size(194, 20);
            this.txbSetorCad.TabIndex = 8;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(114, 51);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(194, 20);
            this.txbEmailCad.TabIndex = 7;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(114, 20);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(194, 20);
            this.txbNomeCad.TabIndex = 6;
            // 
            // txbFuncaoCad
            // 
            this.txbFuncaoCad.AutoSize = true;
            this.txbFuncaoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFuncaoCad.Location = new System.Drawing.Point(13, 148);
            this.txbFuncaoCad.Name = "txbFuncaoCad";
            this.txbFuncaoCad.Size = new System.Drawing.Size(63, 16);
            this.txbFuncaoCad.TabIndex = 5;
            this.txbFuncaoCad.Text = "Função:";
            // 
            // txbSetor
            // 
            this.txbSetor.AutoSize = true;
            this.txbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSetor.Location = new System.Drawing.Point(10, 113);
            this.txbSetor.Name = "txbSetor";
            this.txbSetor.Size = new System.Drawing.Size(49, 16);
            this.txbSetor.TabIndex = 4;
            this.txbSetor.Text = "Setor:";
            // 
            // txbtelefone
            // 
            this.txbtelefone.AutoSize = true;
            this.txbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefone.Location = new System.Drawing.Point(10, 80);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(74, 16);
            this.txbtelefone.TabIndex = 3;
            this.txbtelefone.Text = "Telefone:";
            // 
            // txbtelCad
            // 
            this.txbtelCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelCad.Location = new System.Drawing.Point(114, 80);
            this.txbtelCad.Mask = "(99) 00000-0000";
            this.txbtelCad.Name = "txbtelCad";
            this.txbtelCad.Size = new System.Drawing.Size(194, 22);
            this.txbtelCad.TabIndex = 2;
            // 
            // txbEmail
            // 
            this.txbEmail.AutoSize = true;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(10, 51);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(51, 16);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.Text = "Email:";
            // 
            // txbNome
            // 
            this.txbNome.AutoSize = true;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(7, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(53, 16);
            this.txbNome.TabIndex = 0;
            this.txbNome.Text = "Nome:";
            // 
            // gpxEditar
            // 
            this.gpxEditar.Controls.Add(this.btnExcluir);
            this.gpxEditar.Controls.Add(this.btnEditar);
            this.gpxEditar.Controls.Add(this.txbFuncaoEd);
            this.gpxEditar.Controls.Add(this.txbSetorEd);
            this.gpxEditar.Controls.Add(this.txbEmailEd);
            this.gpxEditar.Controls.Add(this.txbNomeEd);
            this.gpxEditar.Controls.Add(this.label1);
            this.gpxEditar.Controls.Add(this.label2);
            this.gpxEditar.Controls.Add(this.label3);
            this.gpxEditar.Controls.Add(this.txbTelEd);
            this.gpxEditar.Controls.Add(this.label4);
            this.gpxEditar.Controls.Add(this.label5);
            this.gpxEditar.Location = new System.Drawing.Point(373, 273);
            this.gpxEditar.Name = "gpxEditar";
            this.gpxEditar.Size = new System.Drawing.Size(327, 240);
            this.gpxEditar.TabIndex = 3;
            this.gpxEditar.TabStop = false;
            this.gpxEditar.Text = "Editar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(19, 179);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 36);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Blue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(134, 179);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 36);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbFuncaoEd
            // 
            this.txbFuncaoEd.Location = new System.Drawing.Point(117, 153);
            this.txbFuncaoEd.Name = "txbFuncaoEd";
            this.txbFuncaoEd.Size = new System.Drawing.Size(194, 20);
            this.txbFuncaoEd.TabIndex = 20;
            // 
            // txbSetorEd
            // 
            this.txbSetorEd.Location = new System.Drawing.Point(117, 118);
            this.txbSetorEd.Name = "txbSetorEd";
            this.txbSetorEd.Size = new System.Drawing.Size(194, 20);
            this.txbSetorEd.TabIndex = 19;
            // 
            // txbEmailEd
            // 
            this.txbEmailEd.Location = new System.Drawing.Point(117, 56);
            this.txbEmailEd.Name = "txbEmailEd";
            this.txbEmailEd.Size = new System.Drawing.Size(194, 20);
            this.txbEmailEd.TabIndex = 18;
            // 
            // txbNomeEd
            // 
            this.txbNomeEd.BackColor = System.Drawing.Color.MintCream;
            this.txbNomeEd.Location = new System.Drawing.Point(117, 25);
            this.txbNomeEd.Name = "txbNomeEd";
            this.txbNomeEd.Size = new System.Drawing.Size(194, 20);
            this.txbNomeEd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Função:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefone:";
            // 
            // txbTelEd
            // 
            this.txbTelEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelEd.Location = new System.Drawing.Point(117, 85);
            this.txbTelEd.Mask = "(99) 00000-0000";
            this.txbTelEd.Name = "txbTelEd";
            this.txbTelEd.Size = new System.Drawing.Size(194, 22);
            this.txbTelEd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome:";
            // 
            // WinFuncListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 525);
            this.Controls.Add(this.gpxEditar);
            this.Controls.Add(this.gpxcadastro);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "WinFuncListar";
            this.Text = "Funcionários :: Listar";
            this.Load += new System.EventHandler(this.WinFuncListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gpxcadastro.ResumeLayout(false);
            this.gpxcadastro.PerformLayout();
            this.gpxEditar.ResumeLayout(false);
            this.gpxEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox gpxcadastro;
        private System.Windows.Forms.TextBox txbFuncaoCad2;
        private System.Windows.Forms.TextBox txbSetorCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label txbFuncaoCad;
        private System.Windows.Forms.Label txbSetor;
        private System.Windows.Forms.Label txbtelefone;
        private System.Windows.Forms.MaskedTextBox txbtelCad;
        private System.Windows.Forms.Label txbEmail;
        private System.Windows.Forms.Label txbNome;
        private System.Windows.Forms.GroupBox gpxEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbFuncaoEd;
        private System.Windows.Forms.TextBox txbSetorEd;
        private System.Windows.Forms.TextBox txbEmailEd;
        private System.Windows.Forms.TextBox txbNomeEd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txbTelEd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}