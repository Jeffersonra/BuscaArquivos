using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BuscaImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            Listar();

        }
        private void LerArquivo()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\test.txt");


        }

        private void Listar()
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                                          new System.IO.StreamReader(@"c:\temp\teste.txt");
            while ((line = file.ReadLine()) != null)
            {
                DirectoryInfo Dir = new DirectoryInfo(@"C:\temp\teste");
                // Busca automaticamente todos os arquivos em todos os subdiretórios
                FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo File in Files)
                {
                    // Retira o diretório iformado inicialmente
                    string fileName = File.FullName;
                    FileInfo fi = new FileInfo(fileName);
                    var name = fi.Name;
                    var dir = fi.DirectoryName;
                    var full = fi.FullName;
                   
                    FileInfo filine = new FileInfo(line);
                    var nameline = filine.Name;
                    var dirline = filine.DirectoryName;
                    var fullline = filine.FullName;

                    if (name == nameline)
                    {

                        System.IO.File.Move(fileName, line);


                    }
                    else
                    {
                        Listar();
                    }

                }
            }
            counter++;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textDiretorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
