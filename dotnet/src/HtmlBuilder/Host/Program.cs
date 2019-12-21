using System;
using PucSp.DesignPatterns.HtmlBuilder.Core;

namespace PucSp.DesignPatterns.HtmlBuilder.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var element = new SpanElement("Here I am. This is me.");
            string html = element.AddNode(new SpanElement("inner")).AddNode(new ItalicElement("LOL!")).ToHtml();

            Console.WriteLine(html);
        }
    }
}
