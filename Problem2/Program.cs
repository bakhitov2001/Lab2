using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            using(StreamReader sr = new StreamReader(@"C:\Users\Lenovo\source\repos\Lab2\Problem2\input.txt")) {               // Открыл поток для чтения
                string stroka = sr.ReadLine();                                                                                // Записал содержимое в строку
                int[] m = Array.ConvertAll<string, int>(stroka.Split(), int.Parse);                                          // Создал массив
                int[] Prime = new int[m.Length];                                                                            // Создал массив для простых чисел
                int cnt = 0;                                                                                               // Создал счетчик для простых чисел
                
                for(int i = 0; i < m.Length; i++) {                                                                      // Пробегаюсь по всем числам в массиве 
                    bool flag = true;                                                                                   // Создал флаг, отвечающий за добавление в Prime
                    for(int j = 2; j < m[i]; j++) {                                                                    // Проверка числа на простое или сложное
                        if( m[i] % j == 0) {
                            flag = false;
                            break;
                        }

                    }
                    if(flag == true && m[i] != 1) {                                                             // Если флаг tf == true и не равняется одному, то оно добавляется Prime числа
                        Prime[cnt] = m[i];
                        cnt++;
                    }
                }
                using(StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\source\repos\Lab2\Problem2\output.txt")) {    // Открыл поток чтобы записать
                    for(int i = 0; i < cnt; i++) {
                        sw.Write(Prime[i] + " ");
                    }

                }
            }  
        }
    }
}
