using System;

namespace PucSp.DesignPatterns.HtmlBuilder
{
    public class SpanElement : IHtmlElement
    {
        private readonly string _text;

        public string Tag => "span";

        public SpanElement(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this._text = text;
        }

        public IHtmlElement AddNode(IHtmlElement node)
        {
            throw new System.NotImplementedException();
        }

        public IHtmlElement AddAttribute(string name, string value)
        {
            throw new System.NotImplementedException();
        }

        public IHtmlElement RemoveAttribute(string name)
        {
            throw new NotImplementedException();
        }

        public string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
