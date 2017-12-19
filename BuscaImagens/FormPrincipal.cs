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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
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
                Copiar copia = new Copiar();
                copia.Copia(txtdestino.Text);

                btnProcurar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione um Arquivo!");
            }
            
        }
      
        #region LabelEntreoutros

        public void textDiretorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void txtdestino_TextChanged(object sender, EventArgs e)
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

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        #endregion LabelEntreoutros

        // OpenFileDialog para Selecionar o arquivo -  Somente txt
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
            openFile.Title = "Selecione o Arquivo: ";
           
            DialogResult dr = openFile.ShowDialog();

            txtdestino.Text = openFile.FileName;
        }
        
        private string RetornaListaDiretorios()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\_Sinf\SINF\0.Enterprise\Main\WindowsDesktop");

            var lista = "";
            foreach (DirectoryInfo file in dir.GetDirectories())
            {

                lista = lista + file.FullName.ToString() + "\r\n";

            }
            lista = lista.Replace("\"","/");
            return lista;
        }

    }
}
