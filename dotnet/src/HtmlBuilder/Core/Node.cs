using System.Collections.Generic;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public abstract class Node
    {
        protected HashSet<HtmlAttribute> attributes;

        public IReadOnlyCollection<HtmlAttribute> Attributes => attributes;

        protected Node() => this.attributes = new HashSet<HtmlAttribute>();

        protected abstract string AsTagString();
    }
}
