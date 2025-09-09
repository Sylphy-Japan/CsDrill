namespace CsDrill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var q = new QClass();

            q.Q011();
            var p = new Q023Person("Eran",24);

             
            /*try-finallyでリソース解放保証
            var res = new Resouce();
            try{
                res.use();
            }finally{
                res.Dispose();
            }
            */



        }
    }
}
