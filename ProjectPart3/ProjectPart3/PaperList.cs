using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPart3
{
    public class PaperList
    {
        private List<Paper> list;

        public PaperList(List<Paper> list)
        {
            this.list = list;
        }

        public PaperList()
        {
            this.list = null;
        }

        public PaperList(Paper paper)
        {
            this.list = new List<Paper> { paper };
        }

        public List<Paper> getList()
        {
            return this.list;
        }


        public void addPaper(Paper paper)
        {
            if (String.IsNullOrEmpty(paper.getName()))
            {
                return;
            }
            if (this.list == null)
            {
                this.list = new List<Paper>() { paper };
            }
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].getName().Equals(paper.getName()))
                {
                    return;
                }
            }
            this.list.Add(paper);
        }

        public Paper getPaper(String name)
        {
            for(int i = 0; i < this.list.Count; i++){
                if (this.list[i].getName().Equals(name))
                {
                    return this.list[i];
                }
            }
            return null;
        }

        public int searchRelationFrequency(string p, string p_2)
        {
            if (String.IsNullOrEmpty(p) || String.IsNullOrEmpty(p_2))
            {
                return -1;
            }
            if (p.Equals(p_2))
            {
                return -1;
            }
            Paper[] array = new Paper[this.list.Count];

            int bothCount = 0;
            this.list.CopyTo(array);
            for (int i = 0; i < array.Length; i++)
            {
                List<Keyword> words = array[i].getKeywords();
                if ((words.Contains(new Keyword(p))) && (words.Contains(new Keyword(p_2))))
                {
                    bothCount++;
                }
            }
                return bothCount;
                
        }
    }
}
