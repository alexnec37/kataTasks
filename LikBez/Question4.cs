using System;
using System.Collections.Generic;
using System.Text;

namespace LikBez
{
    class Question4
    {
        // например для метода swap
        void Foo(ref int p)
        {
            p = 6;
        }

        //Аргумент out похож на аргумент ref за исключением следующих аспектов:
        //  • он не нуждается в присваивании значения перед входом в функцию;
        //  • ему должно быть присвоено значение перед выходом из функции.
        //Модификатор out чаще всего применяется для получения из метода нескольких
        //возвращаемых значений.
        void Bar(out int p)
        {
            p = 6;
        }

        void Testing()
        {
            int p = 0;
            this.Foo(ref p); // p = 6

            int o;
            this.Bar(out o);
            this.Bar(out int r);
            this.Bar(out _);
        }
    }
}
