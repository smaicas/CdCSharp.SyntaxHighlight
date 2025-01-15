# CdCSharp.CodeHighlight

Syntax higlight library to generate HTML with highlight styles for code fragments.

This library is an adaptation of another [Original Library](https://github.com/thomasjo/highlight)

Adapted to .NET
Adapted to not use xml resource files
Lightened
Something else

## Features

- Supports multiple programming languages.
- Lightweight.

## Installation

Install-Package CdCSharp.SyntaxHighlight

## Usage

Here is a quick example of how to use the library:

```csharp
string input = "string text = \"Hello, World!\";";
string definitionName = "csharp";
string result = _highlighter.Highlight(definitionName, input);
```

## Supported Languages

Aspx,
C,
Cobol,
CPlusPlus,
CSharp,
Eiffel,
Fortran,
Haskell,
Html,
Java,
JavaScript,
Mercury,
Msil,
Pascal,
Perl,
Php,
Python,
Ruby,
Sql,
VBNET,
VBScript,
VisualBasic,
Xml

## Contributing

Contributions are welcome! It works but can be improved. I'll keep that in mind when I get some time.
Please check out our [Collaboration Guidelines](COLLABORATE.md) for more information on how to get involved.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or support, please open an issue or reach out to us at [cdcsharp.dev@gmail.com](mailto:cdcsharp.dev@gmail.com).

---

Enjoy!