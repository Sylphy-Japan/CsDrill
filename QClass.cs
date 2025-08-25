using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Q034 System名前空間をusingでインポート
//using System; 

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


        public void Q026()
        {
            //CalculatorのAdd(3,5)を呼び出して表示
            var c = new Q025Calculator();
            Console.WriteLine(c.Add(3, 5));
        }

        static void SayHello()
        //staticでSayHelloメソッドを定義し"Hello!"を表示
        {
            Console.WriteLine("Hello!");
        }

        public void Q035()
        {
            //Q035 現在日時を表示
            Console.WriteLine(DateTime.Now);
        }

        public void Q036()
        {
            //Q036 現在日時をyyyy-MM-dd形式で表示
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        }

    }

    // 修正: クラス宣言からパラメータリストを削除し、通常のクラス宣言にする
    class Q023Person
    {
        //Personクラスを定義しName(string), Age(int)プロパティを持たせる
        public string Name { get; set; }
        private int age { get; set; }
        //Q033 Ageに0未満が入ったら0に矯正するsetを実装
        public int Age
        {
            get { return Age; }
            set { Age = value < 0 ? 0 : value; }
        }

        // 修正: コンストラクターを1つだけ定義
        public Q023Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //PersonのToString()を"Name:○○, Age:○○"にする
        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }

    //CalculatorクラスにAdd(int,int)を定義（式形式）
    class Q025Calculator
    {
        public int Add(int a, int b) => a + b;
        //Q31 オーバーロード: Add(double,double)も定義
        public double Add(double a, double b) => a + b;
    }

    class Q027Animal
    {
        //AnimalクラスにSpeak()で"Animal sound"を表示
        public virtual void Speak()
        {
            //virtualとは？
            //virtualキーワードは、メソッドが派生クラスでオーバーライド可能であることを示します。
            Console.WriteLine("Animal sound");
        }
    }

    class Q028Dog : Q027Animal
    {
        //DogクラスはAnimalを継承し、Speak()をオーバーライドして"Woof"を表示
        public override void Speak()
        {
            //overrideとは？
            //overrideキーワードは、基底クラスのvirtualメソッドを派生クラスで再定義するために使用されます。
            Console.WriteLine("Woof");
        }
    }
    //抽象クラスShapeに抽象メソッドGetArea()
    abstract class Q029Shape { public abstract double GetArea(); }

    //RectangleがShapeを継承し幅×高さを返す
    class Q30Rectangle : Q029Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Width * Height;
    }

    //IMovableインターフェースにMove()を定義
    interface Q31Imovable
    {
        void Move();
    }

    class Car : Q31Imovable
    {
        public void Move() => Console.WriteLine("Car moves");
    }

    public class Perason
    {
        private int age;
        public int Age
        {
            get => age;
            set => age = (value < 0) ? 0 : value;
        }

    }

}

//Q033 名前空間MyApp.Modelsを定義
namespace MyApp.Models
{
    class Perason()
    {

    }
}
