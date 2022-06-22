using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using FormularioInscricao.Models;
using FormularioInscricao.Utils;

namespace FormularioInscricao
{
    public partial class FormularioInscricao : Form
    {
        public FormularioInscricao()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            FichaInscricao fc = new FichaInscricao(this.txt_nome.Text, this.txt_curso.Text,
                                                   this.cb_escolaridade.SelectedItem.ToString(), this.dtp_data_nascimento.Value,
                                                   Double.Parse(this.txt_valorDoCurso.Text), double.Parse(this.txt_valorDesconto.Text),
                                                   double.Parse(this.txt_valorDaMulta.Text));
            CobrarCurso cc = new CobrarCurso(fc.valorDoCurso, fc.valorDaMulta, fc.valorDeDesconto);
            cc.CalcularResultado();
            this.lbl_idade.Text = fc.idade.ToString();
            this.lbl_descricao.Text = FormatacaoTexto.formataTexto(fc);
            this.lbl_resultado.Text = cc.Resultado.ToString("c");
        }

        private void txt_curso_Leave(object sender, EventArgs e)
        {
            try
            {
                this.cursoSelecionado.AdicionaCurso(this.txt_curso.Text);
                this.lbl_cursos_selecionados.Text = "";
                this.lbl_cursos_selecionados.Text = this.cursoSelecionado.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
