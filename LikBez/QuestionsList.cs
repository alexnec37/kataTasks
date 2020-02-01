using System;
using System.Collections.Generic;
using System.Text;

namespace LikBez
{
    class QuestionsList
    {
        public IList<string> InitList()
        {
            IList<string> Questionslist = new List<string>();
            Questionslist.Add("2   Double и Decimal");
            Questionslist.Add("4   Ref и Out");
            Questionslist.Add("13  Сжатие до выражения с№ 7");
            Questionslist.Add("14  Индексаторы");
            Questionslist.Add("18  Ссылочные преобразования as и is");

            return Questionslist;
        }
    }
}
