using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDrill
{
    internal class QClass
    {

        public void Q001()
        {
            //xが10以上なら"OK"と表示するif文
            int x = 0;
            if (x >= 10)
            {
                Console.WriteLine("OK");
            }
        }

        public void Q002()
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

        public void Q003()
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

        public void Q004()
        {
            //0〜4を表示するfor文
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Q005()
        {
            //5〜1をカウントダウン表示するfor文
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void Q006()
        {
            //0〜9を表示するwhile文
            int i = 0;

            while (i <= 9)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void Q007()
        {
            //配列fruitsを"apple","banana","grape"で初期化
            string[] fruits = { "apple", "banana", "grape" };
        }

        public void Q008()
        {
            //fruitsの全要素をforeachで表示
            string[] fruits = { "apple", "banana", "grape" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }

        public void Q009()
        {
            //List<int> numbersを1,2,3で初期化
            List<int> numbers = new List<int> { 1, 2, 3 };
        }

        public void Q010()
        {
            //numbersの末尾に４を追加
            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Add(4);
        }

        public void Q011()
        {
            //a=3,b=5の合計を表示
            int a = 3, b = 5;
            Console.WriteLine(a + b);
        }

        public void Q012()
        {
            //x=10を2倍にして表示（複合代入）
            int x = 10;
            x *= 2;
            Console.WriteLine(x);
        }

        public void Q013()
        {
            //文字列"123"をintに変換して表示
            string S = "１２３";
            int num = int.Parse(S);
            Console.WriteLine(num);
        }

        public void Q014()
        {
            //変換失敗時に"変換失敗"を表示するtry-catch
            try
            {
                string S = "１２３";
                int num = int.Parse(S);
            }
            catch (FormatException)
            {
                Console.WriteLine("変換失敗");
            }
        }

        public void Q015()
        {
            //"Hello"を表示するメソッドHelloを定義
            Console.WriteLine("Hello");
        }

        public int Q016(int a, int b)
        {
            return a + b;
        }

        public void Q017()
        {
            //定数PIを3.14で宣言
            const double PI = 3.14;
        }

        readonly int id = 100;
        public void Q018()
        {
            //readonlyフィールドidを100で宣言（クラス内）
            Console.WriteLine(id);
        }

        public void Q019()
        {
            //三項演算子: x==0なら"Zero"、それ以外は"Non-zero"
            int x = 0;
            Console.WriteLine(x == 0 ? "Zero" : "Non-zero");
        }

        public void Q020()
        {
            //配列numsの要素数を表示
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums.Length);
        }

        public void Q021()
        {
            //List<int> numbersの要素数を表示
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Count);
        }

        public void Q022()
        {
            //文字列strの長さを表示
            string str = "Hello, World!";
            Console.WriteLine(str.Length);
        }

        public void Q024()
        {
            //
            try
            {
                int x = int.Parse("abc"); // 変換失敗
            }
            catch (FormatException ex)
            {
                // 修正: 例外メッセージを表示
                Console.WriteLine($"変換失敗: {ex.Message}");
            }

        }

        // 修正: クラス宣言からパラメータリストを削除し、通常のクラス宣言にする
        class Q023Person
        {
            //Personクラスを定義しName(string), Age(int)プロパティを持たせる
            public string Name { get; set; }
            public int Age { get; set; }

            // 修正: コンストラクターを1つだけ定義
            public Q023Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }

        //CalculatorクラスにAdd(int,int)を定義（式形式）
        class Q025Calculator { public int Add(int a, int b) => a + b; }

    }
}
