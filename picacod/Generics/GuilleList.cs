using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacod.Generics
{
    internal class GuilleList<T>
    {
        private List<T> _list;
        public GuilleList() 
        {
            _list = new List<T>();
        }
        public void Add(T item)
        {
           
           _list.Add(item);
           
           
        }
        public string GetElements()
        {
            string content = "";
            foreach (var item in _list)
            {
                content += $"{item},";

            }
            return content;
        }

    }
}
