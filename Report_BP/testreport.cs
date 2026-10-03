using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class InvoiceReport : IDocument
{
    public object Model { get; }
    public InvoiceReport(object model) => Model = model;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(50);
            page.MarginTop(5);
            
            page.Background("#FF8800");
            page.Header().Image("");
            page.Header().Text("Company Report").Bold().FontSize(20).AlignCenter().Underline();
            page.Content().PaddingVertical(10).Text("Report content goes here...");
            page.Footer().AlignCenter().Text(x => x.CurrentPageNumber());
        });
    }
}