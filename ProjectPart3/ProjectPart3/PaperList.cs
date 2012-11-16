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

        public Paper getPaper(int i)
        {
            if (this.list.Count > i)
            {
                return this.list[i];
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

            bool hasP = false;
            bool hasP2 = false;
            int bothCount = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                List<Keyword> words = this.getPaper(i).getKeywords();
                for(int j = 0; j < words.Count; j++){
                    if(words[j].getWord().Equals(p.ToLowerInvariant().Trim())){
                        hasP = true;
                    }
                    else if(words[j].getWord().Equals(p_2.ToLowerInvariant().Trim())){
                        hasP2 = true;
                    }
                }
                if(hasP && hasP2){
                    bothCount++;
                }
            }
                return bothCount;
                
        }
    }
}
