using System;
using System.Collections.Generic;
using System.Text;

namespace LikBez
{
    public class Asset
    {
        public string Name;
    }

    public class Stock : Asset // унаследован от Asset
    {
        public long SharesOwned;
    }
    public class House : Asset // унаследован от Asset
    {
        public decimal Mortgage;
    }

    public class Question18
    {
        static void TestUpset()
        {
            Stock msft = new Stock();
            Asset a = msft; // Приведение вверх

            Console.WriteLine(a.Name); //Нормально
            //Console.WriteLine(а.SharesOwned); // ошибкой
        }

        static void TestDownset()
        {
            Stock msft = new Stock();
            Asset a = msft;
            Stock s = (Stock)a;
            Console.WriteLine(s.SharesOwned); // нет ошибки
            Console.WriteLine(s == a); // true
            Console.WriteLine(s == msft); // true
        }

        public static void TestAs()
        {
            //Операция as выполняет приведение вниз, которое в случае неудачи вычисляется
            //как null(вместо генерации исключения):
            Asset a = new Asset();
            Stock s = a as Stock; // s равно null; исключение не генерируется
            //Stock t = (Stock)a; // System.InvalidCastException: "Unable to cast object of type 'LikBez.Asset' to type 'LikBez.Stock'."

            //Операция as не может выполнять специальные преобразования(см.раздел
            //“Перегрузка операций” в главе 4), равно как и числовые преобразования.
            //long х = 3 as long; // не поддерживается
            long? х = 3 as long?; // Пишет что всегда будет null
            long? xх = 3L as long?; // Ошибка на этапе компиляции
        }

        public static void TestIs()
        {
            //Операция i s проверяет, будет ли преобразование ссылки успешным; другими словами,
            //является ли объект производным от указанного класса(или реализует ли какой-
            //то интерфейс). Она часто применяется при проверке перед приведением вниз
            Asset a = new Asset();
            var s = a is Stock; // s равно null; исключение не генерируется

            int t = 1;
            long tt = 2;
            object o = t;
            object oo = tt;

            var ss = (int)o;
            var cc = oo is int; // незя так
            var sss = (int)tt;
            //var ee = (int)oo; // System.InvalidCastException: "Unable to cast object of type 'System.Int64' to type 'System.Int32'."
        }
    }
}
