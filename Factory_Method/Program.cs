using Factory_Method.Creator;
using Factory_Method.Product;

ICreator pdf = new PDFDocumentCreator();
IDocument pdfDocument = pdf.Creative();
ICreator word = new WordDocumentCreator();
IDocument word_Document = word.Creative();
pdfDocument.Open();
pdfDocument.Save();
word_Document.Open();
word_Document.Save();
