using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    internal class bomba
    {
       
        public int bomba1x, bomba1y, bomba2x, bomba2y, bomba3x, bomba3y;
        public void bomb()
        {
            oku okumacagırma = new oku();
            okumacagırma.okuma();
            ilerleme yol = new ilerleme();

            Random bomba = new Random();

            bomba1x = bomba.Next(0, 30);
            bomba1y = bomba.Next(0, 30);

            while (okumacagırma.labirent3[bomba1x, bomba1y] != 48)
            {
                bomba1x = bomba.Next(0, 30);
                bomba1y = bomba.Next(0, 30);
            }
           

            bomba2x = bomba.Next(0, 30);
            bomba2y = bomba.Next(0, 30);

            while (okumacagırma.labirent3[bomba2x, bomba2y] != 48)
            {
                bomba2x = bomba.Next(0, 30);
                bomba2y = bomba.Next(0, 30);
            }
            

            bomba3x = bomba.Next(0, 30);
            bomba3y = bomba.Next(0, 30);

            while (okumacagırma.labirent3[bomba3x, bomba3y] != 48)
            {
                bomba3x = bomba.Next(0, 30);
                bomba3y = bomba.Next(0, 30);
            }
           


        }
    }
}
