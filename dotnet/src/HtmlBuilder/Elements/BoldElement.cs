using System;
using System.Collections.Generic;

namespace PucSp.DesignPatterns.HtmlBuilder
{
    public class BoldElement : Node, IHtmlElement
    {
        private readonly string _text;

        public string Tag => "strong";

        public BoldElement(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this._text = text;
            this.attributes = new HashSet<KeyValuePair<string, string>>();
        }

        public IHtmlElement AddNode(IHtmlElement node)
        {
            throw new System.NotImplementedException();
        }

        public IHtmlElement AddAttribute(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            base.attributes.Add(new KeyValuePair<string, string>(name, value));

            return this;
        }

        public IHtmlElement RemoveAttribute(string name)
        {
            base.attributes.RemoveWhere(x => x.Key == name);

            return this;
        }

        public string ToHtml()
        {
            throw new System.NotImplementedException();
        }

        protected override string AsTagString()
        {
            throw new NotImplementedException();
        }
    }
}
