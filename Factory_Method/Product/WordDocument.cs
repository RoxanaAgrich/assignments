using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory_Method.Product
{
    public class WordDocument: IDocument
    {
        public void Open()
        {
            Console.WriteLine(" this WordDocument was opened");
        }
        public void Save()
        {
            Console.WriteLine(" this WordDocument was saved");
        }
    }
}
