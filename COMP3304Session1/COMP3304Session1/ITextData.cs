using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    interface ITextData
    {

        String Retrieve(int key);

        void Replace(int key, String replacementTxt);

    }
}
