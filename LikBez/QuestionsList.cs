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
            Questionslist.Add("4   Ref и Out");
            Questionslist.Add("18  Ссылочные преобразования as и is");

            return Questionslist;
        }
    }
}
