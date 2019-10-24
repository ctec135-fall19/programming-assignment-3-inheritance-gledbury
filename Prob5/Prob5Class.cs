using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    // Create a class with two fields, one a string and the other an int. 
    // The class implements the IComparable interface.
    class Prob5Class : IComparable
    {
        // fields
        private string pcStr;
        private int pcInt;
        
        // properties to access private members
        public string PcStr
        {
            get { return pcStr; }
            set { pcStr = value; }
        }

        public int PcInt
        {
            get { return pcInt; }
            set { pcInt = value; }
        }

        // constructor
        public Prob5Class(string str, int x)
        {
            this.pcInt = x;
            this.pcStr = str;
        }

        // interface method
        // Objects in the class should be ordered in the following manner:
        //    * primary sort order is alphabetical according to the text field
        //    * secondary sort order is largest first according to the int field
        // int IComparable.CompareTo(object obj)

        public int CompareTo(object obj)
        {
            // cast obj to Prob5Class type
            Prob5Class pc = obj as Prob5Class;

            // if cast is successful make comparisons
            if (pc != null)
            {
                // return value corresponding to comparison
                if (String.Compare(this.PcStr, pc.PcStr) < 0) return -1;
                if (String.Compare(this.PcStr, pc.PcStr) > 0) return 1;
                else // strings are the same..compare ints
                {
                    if (this.PcInt < pc.PcInt) return -1;
                    if (this.PcInt > pc.PcInt) return 1;
                    else return 0;
                }
            }
            else
                throw new ArgumentException("Parameter is not a Prob5Class object ");
        }
        // override ToString so can print object
        public override string ToString()
        {
            return $"{PcStr}, {PcInt}";
        }

    }
}
