using System.Collections.Generic;

namespace PucSp.DesignPatterns.HtmlBuilder
{
    public abstract class Node
    {
        protected HashSet<KeyValuePair<string, string>> attributes;

        public IReadOnlyCollection<KeyValuePair<string, string>> Attributes => attributes;

        protected abstract string AsTagString();
    }
}
