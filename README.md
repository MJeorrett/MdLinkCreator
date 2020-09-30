# Markdown Link Creator
Takes a header string as input and reuturns markdown syntax for link within the same document. For example:
```bash
> mdlink "My Section Title"
[My Section Title](#my-section-title)
```

## Installation
To build and install this tool on your local machine:
1. Build the nuget package by running `dotnet pack`.
1. Install the tool by running `dotnet tool install --add-source .\nupkg --tool-path C:\dotnet-tools MdLinkCreator`.
1. Ensure that you add C:\dotnet-tools to your PATH.