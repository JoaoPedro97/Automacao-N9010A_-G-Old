using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheusProductions.AutomacaoN9010A;

namespace Automacao_N9010A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Ensaio_Largura_de_faixa_a_6_dB(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Largura_6dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }
        }

        public void Ensaio_Largura_de_faixa_a_26_dB(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue; ;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Largura_26dB(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }
        }

        public void Ensaio_pico_da_densidade_de_potência(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Pico_da_densidade_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }
        }

        public void Ensaio_Valor_Medio_Densidade_Espectral(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Valor_médio_da_densidade_espectral_de_potência(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }

        }

        public void Ensaio_Potencia_de_Pico_Maxima(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Potência_de_pico_máxima(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }

        }

        public void Ensaio_Valor_médio_da_potência_máxima_de_saída(string valFreq, string ip)
        {
            AutomacaoN9010A radical;
            radical = new AutomacaoN9010A();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                switch (checkedListBox1.CheckedItems[i])
                {
                    case "802.11a":
                        MessageBox.Show("Iniciando o Ensaio do 802.11a, configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11b":
                        MessageBox.Show("Iniciando o Ensaio do 802.11b, configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (20), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11n (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (40), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11n (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11n (80), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ac (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (20), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ac (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (40), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ac (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ac (80), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (20)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (20), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "20");
                        continue;
                    case "802.11ax (40)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (40), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "40");
                        continue;
                    case "802.11ax (80)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (80), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "80");
                        continue;
                    case "802.11ax (160)":
                        MessageBox.Show("Iniciando o Ensaio do 802.11ax (160), configure o aparelho");
                        radical.Valor_médio_da_potência_máxima_de_saída(valFreq, ip, checkedListBox1.CheckedItems[i] + valFreq, "160");
                        continue;
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                switch (checkedListBox2.CheckedItems[i])
                {
                    case "Largura de faixa a 6 dB":
                        MessageBox.Show("Iniciando o Ensaio Largura de Faixa a 6 dB");
                        Ensaio_Largura_de_faixa_a_6_dB(textBox1.Text, textBox2.Text);
                        MessageBox.Show("valores Salvos na pasta");
                        continue;
                    case "Largura de faixa a 26 dB":
                        MessageBox.Show("Iniciando o Ensaio Largura de Faixa a 26 dB");
                        Ensaio_Largura_de_faixa_a_26_dB(textBox1.Text, textBox2.Text);
                        MessageBox.Show(@"valores Salvos na Pasta");
                        continue;
                    case "Potência de pico máxima":
                        MessageBox.Show("Iniciando o Ensaio Potência de Pico Máxima, Utilizando o Método de ensaio de Integração do Item 9.1.8 da norma 6506");
                        Ensaio_Potencia_de_Pico_Maxima(textBox1.Text, textBox2.Text);
                        MessageBox.Show(@"valores Salvos na Pasta");
                        continue;
                    case "Valor médio da potência máxima de saída":
                        MessageBox.Show("Iniciando o Ensaio Valor Médio da Potência Máxima de Saída, Utilizando o Método de ensaio de Integração do Item 9.1.8 da norma 6506");
                        Ensaio_Valor_médio_da_potência_máxima_de_saída(textBox1.Text, textBox2.Text);
                        MessageBox.Show(@"valores Salvos na Pasta");
                        continue;
                    case "Pico da densidade de potência":
                        MessageBox.Show("Iniciando o Ensaio Pico da Densidade de Potência");
                        Ensaio_pico_da_densidade_de_potência(textBox1.Text, textBox2.Text);
                        MessageBox.Show(@"valores Salvos na pasta");
                        continue;
                    case "Valor médio da densidade espectral de potência":
                        MessageBox.Show("Iniciando o Ensaio Valor Médio da Densidade Espectral de Potência");
                        Ensaio_Valor_Medio_Densidade_Espectral(textBox1.Text, textBox2.Text);
                        MessageBox.Show(@"valores Salvos na pasta");
                        continue;
                    case "Emissão fora da faixa":

                        continue;
                }
            }
            for (int i = 0; i < checkedListBox3.CheckedItems.Count; i++)
            {
                switch (checkedListBox3.CheckedItems[i])
                {
                    case "Potência de saída":

                    case "Densidade espectral de potência":

                    case "Emissão fora da faixa":

                        continue;
                }
            }



        }
    }
}
