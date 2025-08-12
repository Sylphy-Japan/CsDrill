using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDrill
{
    internal class QClass
    {

        public void Q01()
        {
            //xが10以上なら"OK"と表示するif文
            int x = 0;
            if (x >= 10)
            {
                Console.WriteLine("OK");
            }
        }

        public void Q02()
        {
            //scoreが60以上なら"Pass"、それ以外は"Fail"を表示
            int score = 60;
            if (score >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public void Q03()
        {
            int n = 0;
            switch (n)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }

        public void Q04()
        {
            //0〜4を表示するfor文
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Q05()
        {
            //5〜1をカウントダウン表示するfor文
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void Q06()
        {
            //0〜9を表示するwhile文
            int i = 0;

            while (i <= 9)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void Q07()
        {
            //配列fruitsを"apple","banana","grape"で初期化
            string[] fruits = { "apple", "banana", "grape" };
        }

        public void Q08()
        {
            
        }
    }
}
