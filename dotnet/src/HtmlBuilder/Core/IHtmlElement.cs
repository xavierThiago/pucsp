namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public interface IHtmlElement
    {
        string Tag { get; }

        IHtmlElement AddNode(IHtmlElement node);
        IHtmlElement AddAttribute(string name, string value);
        IHtmlElement AddAttribute(HtmlAttribute attribute);
        IHtmlElement RemoveAttribute(string name);

        string ToHtml();
    }
}
