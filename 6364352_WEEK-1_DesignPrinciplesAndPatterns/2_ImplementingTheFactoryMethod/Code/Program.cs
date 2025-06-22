class Program
{
    static void Main()
    {
        var wordFactory = new WordDocumentFactory();
        var pdfFactory = new PdfDocumentFactory();
        var excelFactory = new ExcelDocumentFactory();
        
        Console.WriteLine("Creating Word Document:");
        wordFactory.ProcessDocument();
        
        Console.WriteLine("\nCreating PDF Document:");
        pdfFactory.ProcessDocument();
        
        Console.WriteLine("\nCreating Excel Document:");
        excelFactory.ProcessDocument();
    }
}
