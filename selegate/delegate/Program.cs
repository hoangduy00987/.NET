namespace selegate
{
    internal class Program
    {
        public delegate void mydel(int x , int y);
        public static void  Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void sub(int x, int y) {
           Console.WriteLine(x - y);

        }
        public static void tinhtoan(int x , int y, mydel d)
        {
            d(x, y);
        }
        static void Main(string[] args)
        {

            /* mydel d = new mydel(Add);
             /// xxem d nhu phuong thuc
             int z = d(3, 4);
             Console.WriteLine(z);
             //xexm d nhu doi tuong
             int t = d.Invoke(3, 4);
             Console.WriteLine(t);
             // xem nhu d la mot tham so cau ham

             int z1 = tinhtoan(4, 3, sub);
             Console.WriteLine(z1);*/
            mydel d = new mydel(Add);
            d += new mydel(sub);
            d+= new mydel(sub);
            d -= new mydel(sub);
            d(3, 4);
        }
    }
}