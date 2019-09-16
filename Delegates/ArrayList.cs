using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class ArrayList
    {
        public virtual int Add(object value)
        {
            int i = 0;
            ArrayList[] continuedArray = new ArrayList[i];
            i = (continuedArray.Length + 1);
            for (int o = 0; o < continuedArray.Length; o++)
            {
                continuedArray[o] = continuedArray[o];
                int arrayEnd = (continuedArray.Length - 1);
                value = continuedArray[arrayEnd];
                i++;
            }

            return i;
        }
        public virtual void Clear()
        {

        }
        public virtual object this[int index]
        {
            set
            {
                
            }
        }
    }
}
