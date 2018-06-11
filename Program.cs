using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace argsconsol
{
    class Program
    {
        private static ConsoleKeyInfo hdf;
        private static ProcessStartInfo kajs;
        [STAThread]
        static void Main(string[] args)
        {
            string ffl = "c:/bin/spkconsol.exe";
            Console.WriteLine("openfiledialog  : y :");
            hdf = Console.ReadKey();
            if (hdf.Key == ConsoleKey.Y)
            {
                OpenFileDialog ajd = new OpenFileDialog();
                DialogResult lak = new DialogResult();

                lak = ajd.ShowDialog();

                if (lak == DialogResult.OK)
                {
                    ffl = ajd.FileName;

                }
            }else
            {
                Console.WriteLine("ENTER PATH FILENAME OR EMPTY TO PLAINCONSOL---->>");

                var shd = Console.ReadLine();

                if(shd != string.Empty)
                {
                    ffl = shd.ToString();
                    Console.WriteLine("found");

                }
                else
                {
                    Console.WriteLine("spk consol");
                }

            }
              

                Console.WriteLine("ENTER ARGUMENT PROSSINFO");


                var sgd = Console.ReadLine();


            if (sgd != string.Empty)
            {
                kajs = new ProcessStartInfo(ffl);
                kajs.Arguments = sgd;
            }
            else
            {
                kajs = new ProcessStartInfo(ffl);
            }
            Process pklo =  Process.Start(kajs);
            pklo.WaitForExit();
            Console.WriteLine("wait to exit : "+ffl);

           


         
         


        }
    }
}
