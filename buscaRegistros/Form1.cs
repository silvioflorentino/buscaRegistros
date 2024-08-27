using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscaRegistros
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> temporadasEpisodios;

        public Form1()
        {
            InitializeComponent();
            // Inicializa os dados no dicionário
            InicializarDados();
            // Popula o ComboBox de temporadas
            comboBoxTemporadas.Items.AddRange(temporadasEpisodios.Keys.ToArray());
        }

        private void InicializarDados()
        {
            // Inicializa o dicionário com temporadas e seus episódios
            temporadasEpisodios = new Dictionary<string, List<string>>
            {
                { "Temporada 1", new List<string> { "Episódio 1", "Episódio 2", "Episódio 3" } },
                { "Temporada 2", new List<string> { "Episódio 21", "Episódio 22", "Episódio 23" } },
                { "Temporada 3", new List<string> { "Episódio 31", "Episódio 32", "Episódio 33" } }
            };
        }

        private void comboBoxTemporadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa o ComboBox de episódios sempre que uma nova temporada for selecionada
            comboBoxEpisodios.Items.Clear();
            comboBoxEpisodios.Text = "";

            // Obtém a temporada selecionada
            string temporadaSelecionada = comboBoxTemporadas.SelectedItem.ToString();

            // Verifica se a temporada selecionada existe no dicionário e preenche o ComboBox de episódios
            if (temporadasEpisodios.ContainsKey(temporadaSelecionada))
            {
                comboBoxEpisodios.Items.AddRange(temporadasEpisodios[temporadaSelecionada].ToArray());
            }
        }
    }
}
