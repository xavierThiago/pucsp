using System;

namespace PucSp.DesignPatterns.HtmlBuilder
{
    public class EmphasisElement : IHtmlElement
    {
        private readonly string _text;

        public string Tag => "em";

        public EmphasisElement(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this._text = text;
        }

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
