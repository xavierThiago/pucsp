using System;
using System.Collections.Generic;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public abstract class Node : IHtmlElement
    {
        protected HashSet<HtmlAttribute> attributes;
        protected List<IHtmlElement> nodes;

        public IReadOnlyCollection<HtmlAttribute> Attributes => attributes;

        public abstract string Tag { get; }

        protected Node()
        {
            this.nodes = new List<IHtmlElement>();
            this.attributes = new HashSet<HtmlAttribute>();
        }

        protected abstract string AsTagString();

        public IHtmlElement AddNode(IHtmlElement node)
        {
            this.nodes.Add(node);

            return this;
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

            this.attributes.Add(attribute);

            return this;
        }

        public IHtmlElement RemoveAttribute(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.attributes.RemoveWhere(x => x.Name == name);

            return this;
        }

        public abstract string ToHtml();
    }
}
