using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    internal class ilerleme
    {
        bomba bomba = new bomba();

        public int[,] bombamatris = new int[30, 30];
        public int[,] yolbombamatris = new int[30, 30];
        public int[,] yolmatris = new int[30, 30];
        oku okumacagırma = new oku();
        public bool kontrol1 = true, kontrol2 = true, kontrol3 = true, kontrol5= true,kontrol6= true,bombakontrol=true;
        int x = 0, y = 0;
        int kontrol4;

        public void enter()
        {
            
            if (kontrol1 == true)
            {
                okumacagırma.okuma();
                Console.WriteLine("\n*****Çözülmeye başlanıyor!******\n");
                kontrol1 = false;
            }

            if (bombakontrol == true)
            {
                bombacalıstır();
                bombakontrol = false;
            }

            for (x = 0; (x < 30); x++)
            {
                if (okumacagırma.labirent1[x, y] == 48)//giriş
                {
                    okumacagırma.labirent1[x, y] = 'x';
                    right();

                }
            }
            if (kontrol6 == true)
            {
                cıkısyaz();
            }
            return;
        }

        public void right()
        {
            if (kontrol6==true && (bombamatris[x,y]=='B' ))
            {
                Console.Beep();
                Console.WriteLine("Bomba patladı,çıkış bulunamadı!");
                Console.WriteLine("Bombaların koordinatları => ({0},{1}) ({2},{3}) ({4},{5})",bomba.bomba1x,bomba.bomba1y,bomba.bomba2x,bomba.bomba2y,bomba.bomba3x,bomba.bomba3y);
                kontrol2 = false;
                kontrol6 = false;//bomba patlarsa cıkısyaz fonksiyonunun çalışmaması için
            }

             if (y == 29 && kontrol2 == true)
            {
                Console.WriteLine("Çıkış bulundu");
                kontrol2 = false;
            }

            else if ((y != 29) && okumacagırma.labirent1[x, y + 1] == 48)//sağdaki 0 kontrol     
            {
                y++;
                okumacagırma.labirent1[x, y] = 'x';
            }


            else if ((x != 29) && okumacagırma.labirent1[x + 1, y] == 48)//asağı kontrol   
            {
                x++;
                okumacagırma.labirent1[x, y] = 'x';

            }

            else if ((x != 0) && okumacagırma.labirent1[x - 1, y] == 48)//yukarı kontrol     
            {
                x--;
                okumacagırma.labirent1[x, y] = 'x';
            }

            else if ((y != 0) && okumacagırma.labirent1[x, y - 1] == 48)//sol 0 kontrol      
            {
                y--;
                okumacagırma.labirent1[x, y] = 'x';
            }

            else if ((y == 0) && (x != 0) && (okumacagırma.labirent1[x, y + 1] == 49) && (okumacagırma.labirent1[x + 1, y] == 49) && (okumacagırma.labirent1[x - 1, y] == 49))
            {//sol kenarda kalırsa sonraki yolları denemesi için
                okumacagırma.labirent1[x, y] = '1';
                enter();
            }

            else if ((y == 0) && (x == 0) && (okumacagırma.labirent1[x, y + 1] == 49) && (okumacagırma.labirent1[x + 1, y] == 49) )
            {//sol üst köşede kalırsa sonraki yolları denemesi için
                okumacagırma.labirent1[x, y] = '1';
                enter();
            }

            else if (((y != 29) && okumacagırma.labirent1[x, y + 1] == 'x') || ((x != 29) && okumacagırma.labirent1[x + 1, y] == 'x') || ((x != 0) && okumacagırma.labirent1[x - 1, y] == 'x') || ((y != 0) && okumacagırma.labirent1[x, y - 1] == 'x'))
            {//etrafında hiç 0 yoksa ve x varsa x'ten devam etmesi için

                okumacagırma.labirent1[x, y] = '1';

                if ((y != 29) && okumacagırma.labirent1[x, y + 1] == 'x')
                {
                    y++;
                }
                else if ((x != 29) && okumacagırma.labirent1[x + 1, y] == 'x')
                {
                    x++;
                }
                else if ((x != 0) && okumacagırma.labirent1[x - 1, y] == 'x')
                {
                    x--;
                }
                else if ((y != 0) && okumacagırma.labirent1[x, y - 1] == 'x')
                {
                    y--;
                }
            }


            else if (((y != 29) && okumacagırma.labirent1[x, y + 1] == 49) && ((x != 29) && okumacagırma.labirent1[x + 1, y] == 49) && ((x != 0) && okumacagırma.labirent1[x - 1, y] == 49) && ((y != 0) && okumacagırma.labirent1[x, y - 1] == 49))
            {//etrafında sadece 1 varsa
                x = 0;
                y = 0;
                enter();
            }


            for (int i = 0; i < 30 && (kontrol2 == true); i++)
            {
                right();
            }
        }


        
        public void cıkısyaz()
        {
            y = 0;
            for (int a = 29; (a >= 0) && kontrol3 == true; a--)
            {
                if (okumacagırma.labirent1[a, 0] == 'x')
                {
                    Console.Write("\n******({0},0)* ", a);
                    x = a;
                    okumacagırma.labirent2[x, y] = 'x';
                    


                    kontrol3 = false;
                }
            }


            for (int i = 0; i < 900 && kontrol5==true; i++)
            {
                if (y == 29)
                {
                    for (int satır = 0; satır < 30; satır++)
                    {
                        for (int sütun = 0; sütun < 30; sütun++)
                        {
                            yolmatris[satır, sütun] = okumacagırma.labirent2[satır, sütun];
                            yolbombamatris[satır, sütun] = okumacagırma.labirent2[satır, sütun];

                        }
                    }
                    

                    yolbombamatris[bomba.bomba1x, bomba.bomba1y] = 'B';
                    yolbombamatris[bomba.bomba2x, bomba.bomba2y] = 'B';
                    yolbombamatris[bomba.bomba3x, bomba.bomba3y] = 'B';

                    kontrol5 = false;
                }

                else if ((kontrol4 != 4) && (y != 29) && okumacagırma.labirent1[x, y + 1] == 'x')//sağdaki yol kontrol
                {
                    y++;
                    kontrol4 = 1;
                    Console.Write("*({0},{1})* ", x, y);
                    okumacagırma.labirent2[x, y] = 'x';
                    

                }

                else if ((kontrol4 != 3) && (x != 29) && okumacagırma.labirent1[x + 1, y] == 'x')//asağıdaki yol kontrol
                {
                    x++;
                    kontrol4 = 2;
                    Console.Write("*({0},{1})* ", x, y);
                    okumacagırma.labirent2[x, y] = 'x';
                    

                }

                else if ((kontrol4 != 2) && (x != 0) && okumacagırma.labirent1[x - 1, y] == 'x')//yukarıdaki yol kontrol
                {
                    x--;
                    kontrol4 = 3;
                    Console.Write("*({0},{1})* ", x, y);
                    okumacagırma.labirent2[x, y] = 'x';
                    

                }
                else if ((kontrol4 != 1) && (y != 0) && okumacagırma.labirent1[x, y - 1] == 'x')//soldaki yol kontrol
                {
                    y--;
                    kontrol4 = 4;
                    Console.Write("*({0},{1})* ", x, y);
                    okumacagırma.labirent2[x, y] = 'x';
                    

                }
                
            }
            
        }
        public void bombacalıstır()
        {
            bomba.bomb();
            for (int satır = 0; satır < 30; satır++)
            {
                for (int sütun = 0; sütun < 30; sütun++)
                {
                    bombamatris[satır, sütun] = okumacagırma.labirent3[satır, sütun];
                    
                }
            }

            bombamatris[bomba.bomba1x, bomba.bomba1y] = 'B';
            bombamatris[bomba.bomba2x, bomba.bomba2y] = 'B';
            bombamatris[bomba.bomba3x, bomba.bomba3y] = 'B';


        }
    }
}

