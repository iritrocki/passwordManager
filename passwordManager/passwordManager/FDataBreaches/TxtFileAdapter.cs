using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager.FDataBreaches
{
    public class TxtFileAdapter : IDataBreachesAdapter
    { 
        public string Path { get; set; }
        public TxtFileAdapter(string path)
        {
            this.Path = path;
        }

        public List<string> AdaptData()
        {
            string entireText = System.IO.File.ReadAllText(this.Path);
            List<string> adaptedText = entireText.Split('\t').ToList();
            return adaptedText;
        }
    }
}
