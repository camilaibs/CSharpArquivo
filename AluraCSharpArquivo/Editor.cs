using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraCSharpArquivo
{
    public partial class Editor : Form
    {
        private string arquivo = "arquivo.txt";

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {
                using (FileStream entrada = new FileStream(arquivo, FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    texto.Text = leitor.ReadToEnd();
                }
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            using (FileStream saida = new FileStream(arquivo, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(texto.Text);
            }
        }
    }
}
