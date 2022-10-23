using System;
using System.Collections.Generic;

namespace VrQuizPrac
{
    class Program
    {
        List<Tuple<string, string>> tList = new List<Tuple<string, string>>();

        public Program() {
            Console.WriteLine(new newclass().randomnumber);

            newclass n = new newclass();

            n.randomnumber = "wwwww";
            Console.WriteLine(n.randomnumber);

        }

        void name() {
            Console.WriteLine("Write 5 names");
            for (int i = 0; i < 5; i++)
            {
                String name = Console.ReadLine();
                String[] namesplit = name.Split(" ");
                tList.Add(new Tuple<string, string>(namesplit[0], namesplit[1]));
            }
            tList.ForEach(Console.WriteLine);
        }

        void dictionary(List<Tuple<string, string>> a) {
            Dictionary<int, string> tDict = new Dictionary<int, string>();
            for (int i = 0; i < a.Count; i++) {
                tDict.Add(i, a[i].Item1);
            }

            foreach (KeyValuePair<int, string> i in tDict) {
                Console.Write(i + " ");
            }

        }

        static void Main(String[] args) {
            new Program();
        }

    }

    class newclass{

        public string RandNum = "5";
        public string randomnumber { 
            get {
                //int r = new random().next(1, 6);
                //string s = "random number is ";
                //if (r == 1)
                //    s += "one";
                //if (r == 2)
                //    s += "two";
                //if (r == 3)
                //    s += "three";
                //if (r == 4)
                //    s += "four";
                //if (r == 5)
                //    s += "five";
                //return s;
                return RandNum;
            }
            
            set {
                RandNum = value;
            }

        }

    }

}