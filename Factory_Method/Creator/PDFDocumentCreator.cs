using Factory_Method.Product;

namespace Factory_Method.Creator
{
    public class PDFDocumentCreator : ICreator
    {
        public IDocument Creative()
        {
            return new PDFDocument();
        }

    }
}
