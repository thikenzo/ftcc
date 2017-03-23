﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class InstruCad : Form
    {
        public InstruCad()
        {
            InitializeComponent();
        }

        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kenzo\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }
           
        }

        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexao = new SqlConnection(strCn);


        public string classificacao { get; set; }
        //public Cliente ClieteAtual { get; set; }
        public Instrum InstrumAtual { get; set; }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void InstruCad_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnAdicionar.Enabled = true;
        }

        void limpar()
        {
            txtNomeEquip.Clear();
            txtValor.Clear();

        }


        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotipo.Text = "";
        }

        private void combotipo_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            combotipo.DataSource = val.listanivel1();
            combotipo.DisplayMember = "Tipos";
        }

        private void radionacional_CheckedChanged(object sender, EventArgs e)
        {
            classificacao = "Nacional";

        }

        private void radiointernacional_CheckedChanged(object sender, EventArgs e)
        {
            classificacao = "Internacional";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeEquip.Text == "" || classificacao == "" || combotipo.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                Instrum Instrum = new Instrum();
                Instrum.NomeEquip = txtNomeEquip.Text;
                Instrum.Classificacao = classificacao;
                Instrum.Tipo = combotipo.Text;
                Instrum.valor = txtValor.Text;



                int resultado = InstrumFunc.Adicionar(Instrum);

                if (resultado > 0)
                {
                    MessageBox.Show("Dados Guardados! ");
                    limpar();
                    combotipo.Text = "";
                    classificacao = "";

                }

                else
                {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Instrum pInstrum = new Instrum();
            pInstrum.NomeEquip = txtNomeEquip.Text;
            pInstrum.Classificacao = classificacao;
            pInstrum.Tipo = combotipo.Text;
            pInstrum.valor = txtValor.Text;



            int resultado = InstrumFunc.Editar(pInstrum);

            if (resultado > 0)
            {

                MessageBox.Show("Alterado dados Instrumento Concluído!");
                limpar();
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
                btnAdicionar.Enabled = true;
            }

            else
            {
                MessageBox.Show("Não se pode editar o Instrumento, Erro!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
    }