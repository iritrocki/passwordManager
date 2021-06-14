using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public class TxtFileAdapter : IDataBreachesAdapter
    { 
        public string dataBreach { get; set; }

        public TxtFileAdapter() { }
        public TxtFileAdapter(string path)
        {
            GetFileData(path);
        }

        private void GetFileData(string path)
        {
            try
            {
                this.dataBreach = System.IO.File.ReadAllText(path);
            }
            catch (Exception e)
            {
                throw new InvalidPathException();
            }
        }

        public List<string> AdaptData()
        {
            List<string> adaptedText = this.dataBreach.Split('\t').ToList();
            return adaptedText;
        }
    }
}
