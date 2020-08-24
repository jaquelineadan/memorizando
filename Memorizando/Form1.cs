using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorizando {
    public partial class Form1 : Form {
        string escolhaAlfabeto, escolhaModulo;
        int posicaoAlfabeto = 0;
        string[] hiragana = { "あ", "い", "う", "え", "お",
            "か", "き", "く", "け", "こ",
            "さ", "し", "す", "せ", "そ",
            "た", "ち", "つ", "て", "と",
            "な", "に", "ぬ", "ね", "の"};
        string[] romanjiHiragana = { "a", "i", "u", "e", "o",
            "ka", "ki", "ku", "ke", "ko",
            "sa", "shi", "su", "se", "so",
            "ta", "chi", "tsu", "te", "to",
            "na", "ni", "nu", "ne", "no" };
        int[] acertosHiragana = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] errosHiragana = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Form1() {
            InitializeComponent();
        }

        public void geraHiragana() {
            Random aleatorio = new Random();
            switch (escolhaModulo)
            {
                case "A-O":
                    posicaoAlfabeto = aleatorio.Next(0, 5);
                    break;
                case "KA-KO":
                    posicaoAlfabeto = aleatorio.Next(5, 10);
                    break;
                case "SA-SO":
                    posicaoAlfabeto = aleatorio.Next(10, 15);
                    break;
                case "TA-TO":
                    posicaoAlfabeto = aleatorio.Next(15, 20);
                    break;
                case "NA-NO":
                    posicaoAlfabeto = aleatorio.Next(20, 25);
                    break;
                default:
                    posicaoAlfabeto = aleatorio.Next(0, 25);
                    break;
            }
            letra.Text = hiragana[posicaoAlfabeto];
        }

        public async void corrigeHiragana() {
            if (tentativa.Text == romanjiHiragana[posicaoAlfabeto]) {
                this.BackColor = Color.Green;
                acertosHiragana[posicaoAlfabeto] += 1;
            } else {
                this.BackColor = Color.Red;
                errosHiragana[posicaoAlfabeto] += 1;
            }
            relatorio.Items[posicaoAlfabeto] = hiragana[posicaoAlfabeto] + " " +
                acertosHiragana[posicaoAlfabeto].ToString() + " acertos" + " e " +
                errosHiragana[posicaoAlfabeto].ToString() + " erros";
            await limpaCorrecao();
        }

        async Task limpaCorrecao() {
            tentativa.Enabled = false;
            btnResposta.Enabled = false;
            fimMemorizacao.Enabled = false;
            await Task.Delay(1000);
            tentativa.Text = "";
            this.BackColor = Color.Snow;
            geraHiragana();
            tentativa.Enabled = true;
            btnResposta.Enabled = true;
            fimMemorizacao.Enabled = true;
        }

        private void alfabeto_SelectedValueChanged(object sender, EventArgs e)
        {
            modulo.Enabled = true;
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            if (escolhaAlfabeto == "Hiragana") {
                corrigeHiragana();
            }
        }

        private void fimMemorizacao_Click(object sender, EventArgs e)
        {
            fimMemorizacao.Visible = false;
            painelRelatorio.Visible = true;
            modulo.Enabled = false;
        }

        private void memorizarMais_Click(object sender, EventArgs e)
        {
            modulo.Enabled = true;
            fimMemorizacao.Visible = true;
            painelRelatorio.Visible = false;
            Form1 novoAprendizado = new Form1();
            novoAprendizado.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void modulo_SelectedValueChanged(object sender, EventArgs e)
        {
            escolhaAlfabeto = alfabeto.SelectedItem.ToString();
            escolhaModulo = modulo.SelectedItem.ToString();
            tentativa.Enabled = true;
            btnResposta.Enabled = true;
            alfabeto.Enabled = false;
            geraHiragana();
        }
    }
}
