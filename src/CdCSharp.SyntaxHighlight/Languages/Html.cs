using CdCSharp.SyntaxHighlight.Patterns;
using System.Drawing;

namespace CdCSharp.SyntaxHighlight.Languages;

public partial class Definitions
{
    public static Definition HtmlDefinition = new(
        name: "Html",
        caseSensitive: false,
        style: new Style(
            new ColorPair(
                foreColor: Color.FromName("black"),
                backColor: Color.FromName("transparent")
            ),
            new Font(
                name: "monospace",
                size: 16f,
                style: FontStyle.Regular
            )
        ),
        patterns: new Dictionary<string, Pattern>()
    {
{
    "MultiLineComment", new BlockPattern(
            name: "MultiLineComment",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("green"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            beginsWith: "&lt;!--",
            endsWith: "--&gt;",
            escapesWith: ""
        )
},
{
    "Markup", new MarkupPattern(
            name: "Markup",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("maroon"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            highlightAttributes: true,
            bracketColors: new ColorPair(
                foreColor: Color.FromName("blue"),
                backColor: Color.FromName("transparent")
            ),
            attributeNameColors: new ColorPair(
                foreColor: Color.FromName("red"),
                backColor: Color.FromName("transparent")
            ),
            attributeValueColors: new ColorPair(
                foreColor: Color.FromName("blue"),
                backColor: Color.FromName("transparent")
            )
        )
},
    });
}