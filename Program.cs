using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace k.t.g_10_sayı_stack_e_doldur_queue_aktr
{
    //kullanıcı tarafından gırılen 10 adet sayıyı Queue ye doldurup Stacke aktar
    //metod olusturarak aktarma ıslemı yapıldı
    class Program
    {
        static Queue StQueAktr(Stack s)
        {
            Queue q1 = new Queue();
            while (s.Count > 0)
                q1.Enqueue(s.Pop());
            return q1;
        }
        static void yaz( Queue q)
        {
            foreach (object o in q)
                Console.Write(o + " ");
        }
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int tut = Convert.ToInt32(Console.ReadLine());
                dizi[i] = tut;
                s1.Push(dizi[i]);
            }
            Console.WriteLine();
            foreach (int i in dizi)
                Console.Write(i + " ");
            Console.WriteLine();
            Queue q1 = StQueAktr(s1);
            yaz(q1);
        }
    }
}
