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

namespace GenSQLScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGEN_Click(object sender, EventArgs e)
        {
            var alterStr = new List<long>(){ 5586530, 5586531, 5586529, 5863972, 5586528, 5756290 };



            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(@"C:\CT_Script.txt"))
            {
                foreach (var item in alterStr)
                {
                    var pattern = $@"INSERT INTO Dbf2SqlCA([Retries], [Sql2Dbf], [Dtin], [Secsin], [dtout], [secsout], [totaltime], [processed], [server], [user], [command], [response], [webservice], [priority], [origin], [comment], [system], [Ip], NetwotkUser)
VALUES(0, 1, GETDATE(), 00000.000, NULL, NULL, 0, 0, '', 'CHINH', 'UpdateProduction(''CHINH'',{item},.F.,.F.)', '', '', 1, 'CAL', '', '', '', '')";
                    writer.WriteLine(pattern);
                }
            }

            // Read a file  
            string readText = File.ReadAllText(@"C:\CT_Script.txt");
            Console.WriteLine(readText);
        }
    }
}
