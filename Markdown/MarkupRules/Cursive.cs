﻿using System.Collections.Generic;

namespace Markdown.MarkupRules
{
    internal class Cursive : IMarkupRule
    {
        public string MarkupTag { get; } = "_";
        public string HtmlTag { get; } = "em";
        public bool HaveClosingMarkupTag { get; } = true;
        public bool HaveClosingHtmlTag { get; } = true;
    }
}
