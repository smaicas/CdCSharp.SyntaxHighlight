using CdCSharp.SyntaxHighlight.Engines;
using CdCSharp.SyntaxHighlight.Patterns;
using Moq;

namespace CdCSharp.SyntaxHighlight.UnitTests;

public class HighlighterTests
{
    private readonly Highlighter _highlighter;
    public HighlighterTests() => _highlighter = new Highlighter(new HtmlEngine { UseCss = true });

    [Fact]
    public void Highlight_ShouldThrowArgumentNullException_WhenDefinitionNameIsNull()
    {
        // Arrange
        Mock<IEngine> mockEngine = new();
        Highlighter highlighter = new(mockEngine.Object);

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => highlighter.Highlight(null, "sample code"));
    }

    [Fact]
    public void Highlight_ShouldThrowArgumentException_WhenDefinitionNameIsInvalid()
    {
        // Arrange
        Mock<IEngine> mockEngine = new();
        Highlighter highlighter = new(mockEngine.Object);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => highlighter.Highlight("invalidLanguage", "sample code"));
    }

    [Fact]
    public void Highlight_ShouldCallEngineHighlight_WhenDefinitionExists()
    {
        // Arrange
        Mock<IEngine> mockEngine = new();
        Definition mockDefinition = Languages.Definitions.CSharpDefinition; // Assuming you have a static definition for C#
        Highlighter highlighter = new(mockEngine.Object);

        mockEngine
            .Setup(e => e.Highlight(It.IsAny<Definition>(), It.IsAny<string>()))
            .Returns("highlighted code");

        // Act
        string result = highlighter.Highlight("csharp", "sample code");

        // Assert
        mockEngine.Verify(e => e.Highlight(mockDefinition, "sample code"), Times.Once);
        Assert.Equal("highlighted code", result);
    }

    [Fact]
    public void Highlight_ShouldHighlightCSharpKeywordsCorrectly()
    {
        // Arrange
        string input = "if (true) { return; }";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.Contains("<span class=\"CSharpStatement\">if</span>", result);
        Assert.Contains("<span class=\"CSharpKeyword\">true</span>", result);
        Assert.Contains("<span class=\"CSharpStatement\">return</span>", result);
    }

    [Fact]
    public void Highlight_ShouldHandleOperatorsCorrectly()
    {
        // Arrange
        string input = "int x = a + b;";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.Contains(@"<span class=""CSharpOperator"">=</span>", result);
        Assert.Contains(@"<span class=""CSharpOperator"">+</span>", result);
    }

    [Fact]
    public void Highlight_ShouldHighlightStringLiteralsCorrectly()
    {
        // Arrange
        string input = "string text = \"Hello, World!\";";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.Contains(@"<span class=""CSharpString"">&quot;Hello, World!&quot;</span>", result);
    }

    [Fact]
    public void Highlight_ShouldHighlightCommentsCorrectly()
    {
        // Arrange
        string input = "// This is a comment\nint x = 0;";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert 
        Assert.Contains("<span class=\"CSharpComment\">// This is a comment\n</span>", result);
    }

    [Fact]
    public void Highlight_ShouldHighlightMultilineCommentsCorrectly()
    {
        // Arrange
        string input = "/* Multi-line\nComment */\nint y = 1;";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.Contains("<span class=\"CSharpMultiLineComment\">/* Multi-line\nComment */</span>", result);
    }

    [Fact]
    public void Highlight_ShouldThrowExceptionForInvalidDefinition()
    {
        // Arrange
        string input = "int x = 0;";
        string definitionName = "invalidDefinition";

        // Act & Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
            _highlighter.Highlight(definitionName, input));
        Assert.Equal("Parameter does not match any language definition (Parameter 'definitionName')", exception.Message);
    }

    [Fact]
    public void Highlight_ShouldEscapeHtmlCharactersInInput()
    {
        // Arrange
        string input = "<div>int x = 0;</div>";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.DoesNotContain("<div>", result);
        Assert.Contains("&lt;div&gt;", result);
    }

    [Fact]
    public void Highlight_ShouldHighlightVerbatimStringLiteralsCorrectly()
    {
        // Arrange
        string input = @"string path = @""C:\Temp\Files"";";
        string definitionName = "csharp";

        // Act
        string result = _highlighter.Highlight(definitionName, input);

        // Assert
        Assert.Contains("<span class=\"CSharpVerbatimString\">@&quot;C:\\Temp\\Files&quot;</span>", result);
    }
}
