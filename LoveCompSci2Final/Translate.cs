using System;
using System.Text.RegularExpressions;

class Translate
{

    private string _text;
    public string text
    {
        get { return _text; } set { _text = value; }
    }

    public Translate(string text)
    {
        _text = text;
    }
 
    public string ConvertAlt()
    {
        // using regular expressions

        //changing the blockquote tag.
        this._text = Regex.Replace(this._text, @">\s*([^>\n]+)(?:\n|$)", "<blockquote>$1</blockquote>\r\n");

        // changing the header tags.
        this._text = Regex.Replace(this._text, @"###\s*([^#\n]+)(?:\n|$)", "<h3>$1</h3>\r\n");
        this._text = Regex.Replace(this._text, @"##\s*([^#\n]+)(?:\n|$)", "<h2>$1</h2>\r\n");
        this._text = Regex.Replace(this._text, @"#\s*([^#\n]+)(?:\n|$)", "<h1>$1</h1>\r\n");

        //changing the horizontal rule tag
        this._text = Regex.Replace(this._text, @"^([-_*]){3,}\s*$", "<hr>\r\n", RegexOptions.Multiline);

        //changing the italic and bold tags.
        this._text = Regex.Replace(this._text, @"\*\*(.*?)\*\*", "<strong>$1</strong>");
        this._text = Regex.Replace(this._text, @"\*(.*?)\*", "<em>$1</em>");

        //changing the strikethrough tag.
        this._text = Regex.Replace(this._text, @"\~\~(.*?)\~\~", "<s>$1</s>");

        //changing the link tag.
        this._text = Regex.Replace(this._text, @"\[([^\]]+)\]\(([^)]+)\)", "<a href=\'$2\'</a>");

        //changing the code tag.
        this._text = Regex.Replace(this._text, @"\`\`\`(.*?)\`\`\`", "<code>$1</code>");
        this._text = Regex.Replace(this._text, @"\`(.*?)\`", "<code>$1</code>");

        //changing the unordered list tag.
        this._text = Regex.Replace(this._text, @"\- (.+)$", "<ul><li>$1</li></ul>\r\n", RegexOptions.Multiline);
        this._text = Regex.Replace(this._text, @"<ul>", "<ul>");
        this._text = Regex.Replace(this._text, @"</ul>", "</ul>");


        //changing the ordered list tag.
        this._text = Regex.Replace(this._text, @"\d+\. (.+)$", "<ol><li>$1</li></ol>\r\n", RegexOptions.Multiline);
        this._text = Regex.Replace(this._text, @"<ol>", "<ol>");
        this._text = Regex.Replace(this._text, @"</ol>", "</ol>");

        return this._text;
    }
}