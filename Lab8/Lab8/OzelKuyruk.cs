using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class OzelKuyruk
    {
        //ArrayList sayilar;
        List<int> sayilar = new List<int>();
        public static int ElemanSayisi;

        Queue kuyruk = new Queue();

        public OzelKuyruk()
        {
            Console.WriteLine("çalıştım");
            ElemanSayisi++;
        }

      

        public void Enqueue(int YeniEleman)
        {
            if(ElemanSayisi > 0)
            {
                for (int i = 0;i<ElemanSayisi;i++)
                {
                    if (i % 2 == 0)
                    {
                        sayilar.Add(YeniEleman);
                    }
                    if(i == ElemanSayisi)
                    {
                        sayilar.Add(YeniEleman);
                    }
                }
            } else
            {
                sayilar.Add(YeniEleman);
            }
            //Console.WriteLine("eklendi: " + YeniEleman);
            this.show();
            
        }

        void show()
        {
            foreach (int i in sayilar)
            {
                Console.Write("kuyruk ->: " + i + " ");
            }
            Console.WriteLine("");
        }

        public void Dequeue()
        {
            if(ElemanSayisi > 0)
            {
                if(ElemanSayisi > 3)
                {
                    Console.WriteLine("silindi: " + sayilar[ElemanSayisi]);
                    sayilar.RemoveAt(ElemanSayisi);
                }
                else
                {
                    Console.WriteLine("silindi: " + sayilar[ElemanSayisi-1]);
                    sayilar.RemoveAt(ElemanSayisi-1);
                }
            } else
            {
                throw new System.ArgumentException("Boş", "original");
            }

            this.show();
            //implemente edilecek

            //OzelKuyruk boş ise istisna fırlatacak
        }

        
    }
}
