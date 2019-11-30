using System;
using System.Collections.Generic;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
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
            this.attributes = new HashSet<HtmlAttribute>();
        }

        public IHtmlElement AddNode(IHtmlElement node)
        {
            throw new NotImplementedException();
        }

        public IHtmlElement AddAttribute(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name.Length == 0)
            {
                throw new ArgumentException("Attribute name can not be empty.", nameof(name));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return this.AddAttribute(new HtmlAttribute(name, value));
        }

        public IHtmlElement AddAttribute(HtmlAttribute attribute)
        {
            if (attribute == null)
            {
                throw new ArgumentNullException(nameof(attribute));
            }

            base.attributes.Add(attribute);

            return this;
        }

        public IHtmlElement RemoveAttribute(string name)
        {
            base.attributes.RemoveWhere(x => x.Name == name);

            return this;
        }

        public string ToHtml()
        {
            throw new NotImplementedException();
        }

        protected override string AsTagString()
        {
            throw new NotImplementedException();
        }
    }
}
