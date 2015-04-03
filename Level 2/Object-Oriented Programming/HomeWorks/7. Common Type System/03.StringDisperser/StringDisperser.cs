using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace _03.StringDisperser
{
    class StringDisperser:ICloneable,IComparable<StringDisperser>,IEnumerable<StringDisperser>
    {
        List<char> letters = new List<char>();
 
        public StringDisperser(params string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];
                foreach (var letter in arg)
                {
                 letters.Add(letter);   
                }
            }
        }

        public override bool Equals(object obj)
        {
            StringDisperser otherArg = obj as StringDisperser;
           
                if (this.letters.ToString().Equals(otherArg.letters.ToString()))
                {
                    return true;
                }
            
            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0}", String.Join("",this.letters.ToArray())));
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return letters.GetHashCode();
        }

        public static bool operator ==(StringDisperser element1, StringDisperser element2)
        {
            return element1.Equals(element2);
        }

        public static bool operator !=(StringDisperser element1, StringDisperser element2)
        {
            return !(element1.Equals(element2));
        }

        public object Clone()
        {
            string obj = this.ToString();
            return new StringDisperser(obj);
        }

        public int CompareTo(StringDisperser other)
        {
            return this.ToString().CompareTo(other.ToString());
        }

        public IEnumerator<StringDisperser> GetEnumerator()
        {
            for (int i = 0; i < this.letters.Count; i++)
            {
                yield return new StringDisperser(this.letters[i].ToString());
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
