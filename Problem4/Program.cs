using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            FileInfo File = new FileInfo(@"C:\Users\Lenovo\source\repos\Lab2\Problem4\BB.txt");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Lenovo\source\repos\Lab2\Problem4\Papka");
            if(!dir.Exists) {
                dir.Create();
                FileInfo NewFile = new FileInfo(dir.FullName + @"\BB2.txt");
                File.CopyTo(NewFile.FullName);
                File.Delete();
            } else {
                dir.Delete(true);
            }
        }
    }
}