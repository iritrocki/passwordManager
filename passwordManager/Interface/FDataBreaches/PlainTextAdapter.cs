using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManagerLogic.FDataBreaches
{
    public class PlainTextAdapter : IDataBreachesAdapter
    {
        public PlainTextAdapter(){}

        public PlainTextAdapter(string data){
            this.PlainText = data;
        }


        public string PlainText { get; set; }


        public List<string> AdaptData()
        {
            List<string> adapted = this.PlainText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            return adapted;
        }
    }
}