using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectPart3
{
    public class Paper
    {
        private string name;
        private string author;
        private string abst;
        private int year;

        private List<Keyword> words;

        public Paper(string p, string p_2, string p_3, int p_4)
        {
            this.name = p;
            this.author = p_2;
            this.abst = p_3;
            this.year = p_4;
        }


        public void addKeywords(List<Keyword> list)
        {
            this.words = list;
        }

        public List<Keyword> getKeywords()
        {
            return this.words;
        }

        public void addKeyword(Keyword keyword)
        {
            for(int i = 0; i < this.words.Count; i++){
                if (this.words[i].getWord() == keyword.getWord())
                {
                    return;
                }
            }
            this.words.Add(keyword);
        }
    }
}
