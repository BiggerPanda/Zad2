using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

<<<<<<< HEAD
/*
 * API Connect
 * Save to DB
 * Read from DB
 * Calculate 
 * Clean looking form
 */

=======
>>>>>>> d904640b314029f7bc09a97241a47123ae438a47
namespace Zad2
{
    static class Program
    {
        [STAThread]
        static async Task Main()
        {
<<<<<<< HEAD
            var json = File.ReadAllText("st_list.json");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            foreach (var s in students)
                Console.WriteLine(s.studentId + ":\t" + s.studentName);
=======
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DataTaker taker = new DataTaker();
        
>>>>>>> d904640b314029f7bc09a97241a47123ae438a47
        }
    }
}
