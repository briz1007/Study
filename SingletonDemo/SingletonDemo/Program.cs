using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(
            //    () => EmployeeMethod(),
            //    () => Studentmethod()
            //    );
            //Console.ReadLine();
            //string s = "Brajesh is working"; // aabbcd
            string s = "aabbcd"; // aabbcd
            SortedDictionary<char, int> count = new SortedDictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                {
                    int temp = count[s[i]];
                    count.Remove(s[i]);
                    count.Add(s[i], temp + 1);
                }
                else
                {
                    count.Add(s[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> mapElement in count)
            {
                //string mapElementKey = null;
                if (mapElement.Value > 1)
                    Console.WriteLine(mapElement + "count=" + mapElement.Value);
            }

            Console.ReadLine();
        }

        private static void Studentmethod()
        {
            SingleTon fromStudent = SingleTon.GetInstances;
            fromStudent.PrintDetails("from student");
        }

        private static void EmployeeMethod()
        {
            SingleTon fromEmployee = SingleTon.GetInstances;
            fromEmployee.PrintDetails("from employee");
        }
    }
}
