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
           if(String.IsNullOrEmpty(p)){
               this.word = null;
               return;
           }
           else this.word = p.ToLowerInvariant().Trim();
       }


        public string getWord()
       {
           return this.word;
       }
    }
}
