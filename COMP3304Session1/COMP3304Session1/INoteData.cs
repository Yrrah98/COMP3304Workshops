using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    interface INoteData
    {

        void AddNote(int key, String txt);

        void RemoveNote(int key);

        Image ReturnImage(int key);
    }
}
