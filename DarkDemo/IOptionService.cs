namespace DarkDemo
{
    public interface IOptionService
    {
        bool CheckDefaultPrinterIsSet();

        string GetDefaultPrinter();

        string GetDefaultPaperSize();
    }
}