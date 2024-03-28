using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ödev1
{
    internal class oku
    {
        StreamReader sr = new StreamReader("C:\\Users\\User\\Desktop\\maze1.txt");
        public int[,] labirent1 = new int[30, 30]; //çözüm için
        public int[,] labirent2 = new int[30, 30];//yolu yazdırabilmek için
        public int[,] labirent3 = new int[30, 30];//orijinal hali için
        

        public string text2;
        public void okuma()
        {
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + "";
            }
            sr.Close();

            text2 = text.Replace(",", "");
            text2 = text2.Replace("{", "");
            text2 = text2.Replace("}", "");
            text2 = text2.Replace(" ", "");

            int i = 0;

            for (int satır = 0; satır < 30; satır++)
            {
                for (int sütun = 0; sütun < 30; sütun++)
                {
                    labirent1[satır, sütun] = Convert.ToChar(text2.Substring(i, 1));
                    labirent2[satır, sütun] = Convert.ToChar(text2.Substring(i, 1));
                    labirent3[satır, sütun] = Convert.ToChar(text2.Substring(i, 1));
                    

                    i++;
                }
            }
        }
    }
}
