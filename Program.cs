using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SearchMistakesInText
{
    static class Program
    {
        public static List<string> wordslist = new List<string>();

        private static void CheckFile()
        {
           
            StreamReader reader = new StreamReader(@"..\..\zdf-win.txt", System.Text.Encoding.Default);

            try
            {
                while (!reader.EndOfStream)
                    wordslist.Add((reader.ReadLine()).Trim());
            }

            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                reader.Close();
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
