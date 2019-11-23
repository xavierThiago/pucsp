namespace PucSp.DesignPatterns.HtmlBuilder
{
    public interface IHtmlElement
    {
        string Tag { get; }

        IHtmlElement AddNode(IHtmlElement node);
        IHtmlElement AddAttribute(string name, string value);
        IHtmlElement RemoveAttribute(string name);

        string ToHtml();
    }
}
