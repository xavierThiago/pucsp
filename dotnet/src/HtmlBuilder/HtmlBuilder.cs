using System.Text;

namespace PucSp.DesignPatterns.HtmlBuilder
{
    public abstract class HtmlBuilder : IHtmlElement
    {
        private readonly StringBuilder _builder;

        protected HtmlBuilder() => this._builder = new StringBuilder();

        public string Tag => throw new System.NotImplementedException();

        public IHtmlElement AddAttribute(string name, string value)
        {
            throw new System.NotImplementedException();
        }

        public IHtmlElement AddNode(IHtmlElement node)
        {
            throw new System.NotImplementedException();
        }

        public string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
