namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?
            Console.WriteLine(sayi1);
            int[] sayilar1=new int[] {10,20,30};
            int[] sayilar2=new int[] {100,200,300};
            sayilar1 = sayilar2; ;
            sayilar2[0] = 999;
            //sayilar[0]?
            Console.WriteLine(sayilar2[0]);

            // int, decimal ,float ,double ,bool = değer tiplerdir
            //array ,clas ,interface = Refarans tiplerdir
            //değer tipler stackde tanımlanır ve değeride orada bulunur
            //referans tipler tanımlanırken stackde tanımlanır ama new yazıldıktan sonra heapde alan açılır ve oraya kaydedilir
            //satir 16 da sayılar birin gösterdiği heap kısmı sayılar ikininm heap kısmını göstermeye başlar ve garbage collector sayılar1in heapını silecek 
                        
        }
    }
}