
using System;

namespace BasicInterfaces
{

     
    public class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;
        public bool NeedsSave { get; set; }
        public Document(string s)
        {
            name = s;
           Console.WriteLine("Created a document with name '{0}'", s);
        }

        

         public void Load()
        {
            Console.WriteLine("Loading the Document");
        }

          public void Save()
        {
            Console.WriteLine("Saving the Document");
        }
    }
}