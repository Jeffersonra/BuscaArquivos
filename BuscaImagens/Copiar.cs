using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaImagens
{
    class Copiar
    {
        public void Copia(string valor)
        {
            try
            {
                string nomeArquivo = @"C:\Users\mt15160\Source\Repos\RoboCopia\Log\log" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

                string line;

                FormPrincipal frm = new FormPrincipal(); //new FormPrincipal();


                System.IO.StreamReader file = new System.IO.StreamReader(valor);

                StreamWriter writer = new StreamWriter(nomeArquivo);
                writer.WriteLine("Inicio do processamento: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

                while ((line = file.ReadLine()) != null)
                {

                    string[] arrLines = line.Split(';');
                    frm.label1.Visible = true;
                    frm.label1.Text = arrLines[1];
                    FileInfo fileInfo = new FileInfo(arrLines[0]);
                    if (System.IO.File.Exists(arrLines[1] + fileInfo.Name)) // verifica se o arquivo copia existe 
                    {
                        writer.WriteLine(arrLines[1] + ";Data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Arquivo ja existente");
                    }
                    else if (System.IO.File.Exists(arrLines[0]) == false)// verifica se o arquivo para copiar existe
                    {
                        writer.WriteLine(arrLines[0] + ";Data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Arquivo Origem não encontrado");
                    }
                    else if (System.IO.Directory.Exists(arrLines[1]) == false) // verifica se a pasta para receber acopia existe
                    {
                        writer.WriteLine(arrLines[0] + ";Data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Pasta final não encontrado");
                    }
                    else if (System.IO.File.Exists(arrLines[0]) && System.IO.Directory.Exists(arrLines[1])) // valida se o arquivo origem e o diretorio final existe e realiza a copia
                    {
                        frm.label1.Text = arrLines[0];

                        System.IO.File.Copy(arrLines[0], (arrLines[1]) + fileInfo.Name);
                        writer.WriteLine("Origem: " + arrLines[0] + ";Destino: " + (arrLines[1]) + ";Data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Copia realizada com sucesso!");
                    }
                    else
                    {

                    }

                    //    (System.IO.File.Exists(arrLines[0]) && System.IO.Directory.Exists(arrLines[1]) )
                    //{
                    //    frm.label1.Text = arrLines[0];
                    //    System.IO.File.Copy(arrLines[0], (arrLines[1]));
                    //    writer.WriteLine("Origem: " + arrLines[0] + ";Destino: " + (arrLines[1]) + ";Data " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Copia realizada com sucesso!");
                    //}
                    //else
                    //{

                    //}

                }
                writer.WriteLine("Final do processamento: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                writer.Close();
                MessageBox.Show("Processo finalizado!");
            }
            catch
            {
                MessageBox.Show( DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";Erro no metodo copiar");
            }
            
        }
    }
}
