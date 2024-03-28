using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ödev1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            yaz yazmacagırma = new yaz();
            yazmacagırma.üretme();

            oku okumacagırma = new oku();
            okumacagırma.okuma();

           
            ilerleme yol = new ilerleme();

            yol.enter();

            bomba bomba = new bomba();

            if (yol.kontrol6 == false)
            {
                Console.WriteLine("Bombaları görmek için :b\nSadece labirenti görmek için :l\nÇıkış için :c");
                char secenek = Convert.ToChar(Console.ReadLine());

                while (secenek != 'c')
                {
                    switch (secenek)
                    {
                        case 'b':

                            Console.WriteLine("\n****");

                            for (int satır = 0; satır < 30; satır++)
                            {
                                Console.WriteLine(" ");
                                for (int sütun = 0; sütun < 30; sütun++)
                                {
                                    Console.Write((char)yol.bombamatris[satır, sütun]);
                                }
                            }

                            break;

                        case 'l':
                            for (int satır = 0; satır < 30; satır++)
                            {
                                Console.WriteLine(" ");
                                for (int sütun = 0; sütun < 30; sütun++)
                                {
                                    Console.Write((char)okumacagırma.labirent3[satır, sütun]);
                                }
                            }
                            break;
                    }
                    Console.WriteLine("\n\nBombaları görmek için :b\nSadece labirenti görmek için :l\nÇıkış için :c");
                    secenek = Convert.ToChar(Console.ReadLine());
                }
                
            }

            else
            {
                Console.WriteLine("\n\nYolu labirent üzerinde görmek için x\nYolu bombalarla beraber labirent üzerinde görmek için b\nSadece labirenti görmek için l\nÇıkış için c");
                char secenek = Convert.ToChar(Console.ReadLine());
                while (secenek != 'c')
                {
                    switch (secenek)
                    {
                        case 'x':
                            Console.WriteLine("\n****");
                            for (int satır = 0; satır < 30; satır++)
                            {
                                Console.WriteLine(" ");
                                for (int sütun = 0; sütun < 30; sütun++)
                                {
                                    Console.Write((char)yol.yolmatris[satır, sütun]);
                                }
                            }

                            break;
                        
                        case 'b':
                            Console.WriteLine("\n****");

                            for (int satır = 0; satır < 30; satır++)
                            {
                                Console.WriteLine(" ");
                                for (int sütun = 0; sütun < 30; sütun++)
                                {
                                    Console.Write((char)yol.yolbombamatris[satır, sütun]);
                                }
                            }

                            break;

                        case 'l':
                            for (int satır = 0; satır < 30; satır++)
                            {
                                Console.WriteLine(" ");
                                for (int sütun = 0; sütun < 30; sütun++)
                                {
                                    Console.Write((char)okumacagırma.labirent3[satır, sütun]);
                                }
                            }
                            break;
                    }
                    Console.WriteLine("\n\n*Yolu labirent üzerinde görmek için x\nYolu bombalarla beraber labirent üzerinde görmek için b\nSadece labirenti görmek için l\nÇıkış için c");
                    secenek = Convert.ToChar(Console.ReadLine());
                }
            }
           
        }
    }
}
