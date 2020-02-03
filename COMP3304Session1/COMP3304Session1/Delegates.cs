using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public class Delegates
    {

        public delegate void RemoveNote(Form args, int key);

        public delegate String RetrieveNote(int key);

        public delegate void ReplaceNote(String args, int key);

        public Delegates()
        {

        }

    }
}
