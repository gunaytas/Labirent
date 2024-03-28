using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ödev1
{
    internal class yaz
    {
        StreamWriter sw = new StreamWriter("C:\\Users\\User\\Desktop\\maze1.txt");
        public int[,] üretilenmatris = new int[30, 30];
        public void üretme()
        {
            int x = 5, y = 0;
            üretilenmatris[x, y] = 'x';

            for (int j = 0; j < 30 && y < 29; j++)
            {
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    x++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    x++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    y++;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    x--;
                    üretilenmatris[x, y] = 'x';
                }
                if (y != 29)
                {
                    x--;
                    üretilenmatris[x, y] = 'x';
                }

            }



            Random random = new Random();
            int a =0;
            for (int satır = 0; satır < 30; satır++)
            {
                for (int sütun = 0; sütun < 30; sütun++)
                {
                    if (üretilenmatris[satır, sütun] != 'x')
                    {
                        a = random.Next(1,3);
                        if (a == 1)
                        {
                            üretilenmatris[satır, sütun] = '0';
                        }
                        else if (a == 2)
                        {
                            üretilenmatris[satır, sütun] = '1';
                        }
                    }
                }
            }

            for (int satır = 0; satır < 30; satır++)
            {
                for (int sütun = 0; sütun < 30; sütun++)
                {
                    if (üretilenmatris[satır, sütun] == 'x')
                    {
                        üretilenmatris[satır, sütun] = '0';
                    }

                    }
                }
                    yazma();

        }

        public void yazma()
        {
            for (int satır = 0; satır < 30; satır++)
            {
                sw.WriteLine();
                for (int sütun = 0; sütun < 30; sütun++)
                {
                    sw.Write((char)üretilenmatris[satır,sütun]);
                }
            }
                        
            sw.Close();
            return;
        }
    }
}
