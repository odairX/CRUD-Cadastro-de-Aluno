using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Aluno
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void preencheGrid()
        {
            try
            {
                dgvAlunos.DataSource = AcessoFB.fb_GetDados().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        //
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            aluno.Matricula = Convert.ToInt32(txtMT.Text);
            aluno.Nome = txtNome.Text;
            aluno.Email = txtEmail.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Endereco = txtEndereco.Text;

            try
            {
                AcessoFB.fb_InserirDados(aluno);
                preencheGrid();
                MessageBox.Show("Aluno inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        //

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(dgvAlunos.Rows[e.RowIndex].Cells[0].Value);
            Alunos aluno = new Alunos();
            try
            {
                aluno = AcessoFB.fb_ProcuraDados(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
            preencheDados(aluno);
        }


       private void btnProcurar_Click(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(txtMT.Text);
        Alunos aluno = new Alunos();
        try
        {
            aluno = AcessoFB.fb_ProcuraDados(codigo);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
        }
        preencheDados(aluno);
    }

        //
        private void preencheDados(Alunos alu)
        {
            txtMT.Text = alu.Matricula.ToString(); 
            txtNome.Text = alu.Nome;
            txtEmail.Text = alu.Email;
            txtTelefone.Text = alu.Telefone;
            txtEndereco.Text = alu.Endereco;
        }

        //
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            foreach (Control myControl in groupBox1.Controls)
            {
                if (myControl as TextBox == null)
                { }
                else
                {
                    ((TextBox)myControl).Text = "";
                }
            }
            txtMT.Focus();
        }
        //

        //
        private void btnExclui_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtMT.Text);
            try
            {
                AcessoFB.fb_ExcluirDados(codigo);
                preencheGrid();
                MessageBox.Show("Aluno excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {

            Alunos aluno= new Alunos();
            aluno.Matricula = Convert.ToInt32(txtMT.Text);
            aluno.Nome = txtNome.Text;
            aluno.Email = txtEmail.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
                        
            try
            {
                AcessoFB.fb_AlterarDados(aluno);
                preencheGrid();
                MessageBox.Show("Aluno alterado com sucesso !", "Alterar", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
