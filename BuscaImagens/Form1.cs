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


        private void Listar()
        {
            label3.Visible = true;

            string nomeArquivo = @"C:\Users\mt15160\Documents\Dev\EncontrarArquivos\BuscaImagens\BuscaImagens\log\log" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            string line;

            System.IO.StreamReader file =
                                          new System.IO.StreamReader(@txtdestino.Text);

            StreamWriter writer = new StreamWriter(nomeArquivo);
            while ((line = file.ReadLine()) != null)
            {

                string[] arrLines = line.Split(';');
                label1.Visible = true;
                label1.Text = arrLines[1];
                if (System.IO.File.Exists(arrLines[1]))
                {
                    MessageBox.Show("Arquivo ja existente");
                    writer.WriteLine(arrLines[1] + "Arquivo ja existente ");

                }

                else if (System.IO.File.Exists(arrLines[0]))
                {

                    System.IO.File.Copy(arrLines[0], (arrLines[1]));

                    writer.WriteLine(arrLines[0] + " Arquivo copiado para " + (arrLines[1]) + " na data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

                }
                else
                {
                    MessageBox.Show("Arquivo Não encontrado");
                    writer.WriteLine(arrLines[0] + " Arquivo Não encontrado na data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                }

            }
            writer.Close();
            MessageBox.Show("Processo finalizado");
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

        private void txtdestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label1.Visible = false;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}