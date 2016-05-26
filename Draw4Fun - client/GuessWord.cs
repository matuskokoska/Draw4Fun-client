using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client
{
    class GuessWord
    {
        private int id;
        private String word;
        private int category;

        public GuessWord(int id, String word, int category)
        {
            this.id = id;
            this.word = word;
            this.category = category;
        }

        public void setId(int id) { this.id=id; }
        public void setWord(String word) { this.word = word; }
        public void setCategory(int category) { this.category = category; }

        public int getId() { return id; }
        public String getWord() { return word; }
        public int getCategory() { return category; }

    }
}
