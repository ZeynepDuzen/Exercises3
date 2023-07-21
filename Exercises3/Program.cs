using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kısının tc numarası, yası ve mezuniyetine göre emekli olma durumunu hesaplayan kod blogunu yazın

            git:
            Console.WriteLine("lütfen tc numaranızı girin : ");
            int tc = Convert.ToInt32(Console.ReadLine());

            if (tc == 12345)
            {
                Console.WriteLine("Lütfen yasinizi girin : ");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen egitim durumunuzu girin :");
                string mezuniyet = Console.ReadLine();

                if (yas >= 65 && mezuniyet == "lisans")
                {
                    Console.WriteLine("Emekli olabilirsiniz");
                }
                else
                {
                    Console.WriteLine("Emekli olamazsınız");
                }
            }
            else
            {
                Console.WriteLine("Tc no hatalı girildi");
                Console.WriteLine("Tekrar denemek ister misiniz ? <e/h>");
                char cevap = Convert.ToChar(Console.ReadLine());

                if (cevap == 'e' || cevap == 'E')
                {
                    Console.Clear();
                    goto git;
                }
            }

            Console.Read();
        }
    }
}
