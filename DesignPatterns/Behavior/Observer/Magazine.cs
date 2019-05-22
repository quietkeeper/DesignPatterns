using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Observer
{
    public class Magazine
    {
        private string content;

        private string id;
        public string Content { get { return content; } }

        public Magazine(string id, string content)
        {
            this.id = id;
            this.content = content;
        }

        public Magazine Clone()
        {
            return new Magazine(this.id, Content);
        }
    }
}
