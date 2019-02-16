using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1 {
    class Program {
        static void Main(string[] args) {
            string s;
            StreamReader sr = new StreamReader(@"C:\Users\Lenovo\source\repos\Lab2\Problem 1\GG.txt");{
             s = sr.ReadLine();
                bool polindrome = true;
                for(int i = 0; i < s.Length / 2; i++) {
                    if(s[i] != s[s.Length - 1 - i]) {
                        polindrome = false;
                        break;
                    }
                } 
             if(polindrome == true) {
                    Console.WriteLine("Yes");
                } else {
                    Console.WriteLine("NO");
                }

            }
            

        }
    }
}
