using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCodingExercise
{
    public static class ListExtension
    {
        public static List<int> TakeEverySecond(this List<int> list)
        {
            if(list == null)
            {
                throw new Exception("List is null");
            }
            if(list.Count == 0)
            {
                return list;
            }
            var newList = new List<int>();
            for(int i = 0; i < list.Count; i++)
            {
                newList.Add(list[i++]);
            }
            return newList;
        }
    }
}
