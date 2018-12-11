using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntro
{
    //DEFINITION
    public delegate bool FilterDelgate(int i);
    public delegate bool OtherFilterDelegate(int i);

    public static class FilterExtensions
    {
        //1. Filtering according to IFilterRule interface
        /*public static IEnumerable<int> Filter(IEnumerable<int> list,IFilterRule rule)
        {
            foreach (var item in list)
            {
                if (rule.IsValid(item))
                    yield return item;
            }
        }*/

        //2. Filtering according to Deletgate
        public static IEnumerable<int> Filter(IEnumerable<int> list, FilterDelgate filter)
        {
            foreach (var item in list)
            {
                if (filter(item))
                    yield return item;
            }
        }
        //3. Using pre-define Delegate
        public static IEnumerable<int> Filter3(IEnumerable<int> list, Func<int,bool> strategy)
        {
            foreach (var item in list)
            {
                if (strategy(item))
                    yield return item;
            }
        }

    }
    
}
