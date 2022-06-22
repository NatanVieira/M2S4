using FormularioInscricao.Models;
namespace FormularioInscricao
{
    partial class FormularioInscricao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.txt_valorDoCurso = new System.Windows.Forms.TextBox();
            this.txt_valorDesconto = new System.Windows.Forms.TextBox();
            this.txt_valorDaMulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.cb_escolaridade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cursos_selecionados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(256, 14);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(195, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(256, 40);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(195, 20);
            this.txt_curso.TabIndex = 1;
            this.txt_curso.Leave += new System.EventHandler(this.txt_curso_Leave);
            // 
            // txt_valorDoCurso
            // 
            this.txt_valorDoCurso.Location = new System.Drawing.Point(256, 92);
            this.txt_valorDoCurso.Name = "txt_valorDoCurso";
            this.txt_valorDoCurso.Size = new System.Drawing.Size(195, 20);
            this.txt_valorDoCurso.TabIndex = 3;
            // 
            // txt_valorDesconto
            // 
            this.txt_valorDesconto.Location = new System.Drawing.Point(256, 118);
            this.txt_valorDesconto.Name = "txt_valorDesconto";
            this.txt_valorDesconto.Size = new System.Drawing.Size(195, 20);
            this.txt_valorDesconto.TabIndex = 4;
            // 
            // txt_valorDaMulta
            // 
            this.txt_valorDaMulta.Location = new System.Drawing.Point(256, 144);
            this.txt_valorDaMulta.Name = "txt_valorDaMulta";
            this.txt_valorDaMulta.Size = new System.Drawing.Size(195, 20);
            this.txt_valorDaMulta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Escolaridade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Desconto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Multa";
            // 
            // dtp_data_nascimento
            // 
            this.dtp_data_nascimento.AllowDrop = true;
            this.dtp_data_nascimento.CustomFormat = "";
            this.dtp_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_nascimento.Location = new System.Drawing.Point(256, 170);
            this.dtp_data_nascimento.Name = "dtp_data_nascimento";
            this.dtp_data_nascimento.Size = new System.Drawing.Size(83, 20);
            this.dtp_data_nascimento.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dt. Nascimento";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(233, 205);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(167, 23);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Idade:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(62, 238);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(13, 13);
            this.lbl_idade.TabIndex = 16;
            this.lbl_idade.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Descrição:";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(81, 251);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(0, 13);
            this.lbl_descricao.TabIndex = 18;
            // 
            // cb_escolaridade
            // 
            this.cb_escolaridade.FormattingEnabled = true;
            this.cb_escolaridade.IntegralHeight = false;
            this.cb_escolaridade.Items.AddRange(new object[] {
            "Fundamental Cursando",
            "Fundamental Completo",
            "Médio Cursando",
            "Médio Completo",
            "Técnico Cursando",
            "Técnico Completo",
            "Superior Cursando",
            "Superior Completo",
            "Pós-graduação Cursando",
            "Pós-graduação Completo",
            "Mestrado Cursando",
            "Mestrado Completo",
            "Doutorado Cursando",
            "Doutorado Completo",
            "PhD Cursando",
            "PhD Completo"});
            this.cb_escolaridade.Location = new System.Drawing.Point(256, 66);
            this.cb_escolaridade.Name = "cb_escolaridade";
            this.cb_escolaridade.Size = new System.Drawing.Size(195, 21);
            this.cb_escolaridade.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Resultado:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(81, 264);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(13, 13);
            this.lbl_resultado.TabIndex = 21;
            this.lbl_resultado.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cursos Selecionados:";
            // 
            // lbl_cursos_selecionados
            // 
            this.lbl_cursos_selecionados.AutoSize = true;
            this.lbl_cursos_selecionados.Location = new System.Drawing.Point(126, 277);
            this.lbl_cursos_selecionados.Name = "lbl_cursos_selecionados";
            this.lbl_cursos_selecionados.Size = new System.Drawing.Size(0, 13);
            this.lbl_cursos_selecionados.TabIndex = 23;
            // 
            // FormularioInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 543);
            this.Controls.Add(this.lbl_cursos_selecionados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_escolaridade);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_data_nascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valorDaMulta);
            this.Controls.Add(this.txt_valorDesconto);
            this.Controls.Add(this.txt_valorDoCurso);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.txt_nome);
            this.Name = "FormularioInscricao";
            this.Text = "Formulário de Inscrição";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.cursoSelecionado = new CursoSelecionado();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.TextBox txt_valorDoCurso;
        private System.Windows.Forms.TextBox txt_valorDesconto;
        private System.Windows.Forms.TextBox txt_valorDaMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_data_nascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.ComboBox cb_escolaridade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_resultado;
        private CursoSelecionado cursoSelecionado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cursos_selecionados;
    }
}

