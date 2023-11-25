using Factory_Method.Product;

namespace Factory_Method.Creator
{
    public class WordDocumentCreator : ICreator
    {
        public IDocument Creative()
        {
            return new WordDocument();
        }
    }
}
