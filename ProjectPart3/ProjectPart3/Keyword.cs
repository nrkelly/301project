using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPart3
{
   public class Keyword
    {
       private string word;

       public Keyword(string p)
       {
           this.word = p.ToLowerInvariant();
       }


        public object getWord()
       {
           return this.word;
       }
    }
}
