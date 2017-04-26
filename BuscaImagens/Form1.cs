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

        private void Form1_Load(object sender, EventArgs e)
        {
            txtProcessando.Visible = false;
            label1.Visible = false;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            if (txtdestino.Text != "")
            {
                txtProcessando.Visible = true;
                Copiar();
            }
            else
            {
                MessageBox.Show("Selecione um Arquivo!");
            }
            
        }


        private void Copiar()
        {
            
            string nomeArquivo = @"C:\Users\jeffe\Source\Repos\BuscaArquivos\Log\log" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@txtdestino.Text);

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
                    label1.Text = arrLines[0];
                    System.IO.File.Copy(arrLines[0], (arrLines[1]));

                    writer.WriteLine("Origem: " + arrLines[0] + ";Destino: " + (arrLines[1]) + ";Copia realizada com sucesso!;data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

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


        #region LabelEntreoutros

        public void textDiretorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #endregion LabelEntreoutros

        private void selectPath_Click(object sender, EventArgs e)
        {
            openFile.Multiselect = false;
            openFile.InitialDirectory = @"c:\";
            openFile.Filter = "Arquivos de texto (*.txt)|*.txt";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            openFile.ReadOnlyChecked = true;
            openFile.ShowReadOnly = true;
            openFile.Title = "Selecione o Arquivo";

            DialogResult dr = openFile.ShowDialog();
            if (openFile.FileName == "openFile")
            {
                txtdestino.Text = "";
            }
            else
            {
                txtdestino.Text = openFile.FileName;
            }
            
        }
    }
}