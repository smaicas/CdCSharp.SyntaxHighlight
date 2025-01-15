using CdCSharp.SyntaxHighlight.Patterns;

namespace CdCSharp.SyntaxHighlight.Engines;

public interface IEngine
{
    string Highlight(Definition definition, string input);
}