using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

/*
 * API Connect
 * Save to DB
 * Read from DB
 * Calculate 
 * Clean looking form
 */

namespace Zad2
{
    static class Program
    {
        [STAThread]
        static async Task Main()
        {
            var json = File.ReadAllText("st_list.json");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            foreach (var s in students)
                Console.WriteLine(s.studentId + ":\t" + s.studentName);
        }
    }
}
