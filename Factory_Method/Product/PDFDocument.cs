

namespace Factory_Method.Product
{ 
    public class PDFDocument : IDocument
    {
    public void Open()
    {
        Console.WriteLine(" this PDFDocument was opened");
    }
    public void Save()
    {
        Console.WriteLine(" this PDFDocument was saved");
    }
    }
}