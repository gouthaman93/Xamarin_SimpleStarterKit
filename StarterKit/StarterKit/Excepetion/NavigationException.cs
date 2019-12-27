using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Excepetion
{
    public class NavigationException : Exception
    {
        public string Content { get; set; }
        public NavigationException(string content)
        {
            Content = content;
        }
    }
}
