namespace PucSp.DesignPatterns.HtmlBuilder
{
    public interface IHtmlElement
    {
        string Tag { get; }

        IHtmlElement AddAttribute(string name, string value);
        IHtmlElement AddNode(IHtmlElement node);

        string ToHtml();
    }
}
