using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi //Bazı özellikler atıyoruz
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Yazdır() //Base sınıfının ad soya yazdırma metodu
        {
            Console.WriteLine("ADINIZ: " + Ad + "SOYADINIZ: " + Soyad);
        }

    }

    public class Student : BaseKisi //BasePerson'a ait özellikleri Student'a inheritance özellliği ile aktarıyoruz
    {
        public int studentNumber { get; set; }

        public void studentInfo ()
        {
            Console.WriteLine("ÖĞRENCİ NUMARANIZ: " + studentNumber);
        }

    }

    public class Teacher : BaseKisi
    {
        public string Profession { get; set; }

        public void teacherInfo ()
        {
            Console.WriteLine("UZMANLIK ALANINIZ: " + teacherInfo);
        }
    }


}
