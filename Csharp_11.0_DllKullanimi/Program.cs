using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematikselIslemler;//using ile dll i kullanılabilir hale getirdim.
namespace Csharp_11._0_DllKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {   //MatematikselIslemler projesi class library **
            //Daha önce class Library(dll) ile oluşturmuş olduğum projede dll yazdım .
            //Bu dll i ortak bir yere ekledim daha sonra proje de referans olarka ekliyip.Using ile kullanılabilir hale getirdim .
            //Örnekleyerek dll içerisindeki metotları kullandım.


            Islemler Islem=new Islemler();//Örnekledim.


            Console.WriteLine("Toplam deger:{0}", Islem.Topla(10, 10));

            Console.WriteLine(Islem.Carp(5,5));

            Console.ReadLine();


        }
    }
}
