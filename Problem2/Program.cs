using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            using(StreamReader sr = new StreamReader(@"C:\Users\Lenovo\source\repos\Lab2\Problem2\input.txt")) {
                string stroka = sr.ReadLine();
                int[] m = Array.ConvertAll<string, int>(stroka.Split(), int.Parse);
                int[] Prime = new int[m.Length];
                int cnt = 0;
                
                for(int i = 0; i < m.Length; i++) {
                    bool flag = true;
                    for(int j = 2; j < m[i]; j++) {
                        if( m[i] % j == 0) {
                            flag = false;
                            break;
                        }

                    }
                    if(flag == true && m[i] != 1) {
                        Prime[cnt] = m[i];
                        cnt++;
                    }
                }
                using(StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\source\repos\Lab2\Problem2\output.txt")) {
                    for(int i = 0; i < cnt; i++) {
                        sw.Write(Prime[i] + " ");
                    }

                }
            }  
        }
    }
}
