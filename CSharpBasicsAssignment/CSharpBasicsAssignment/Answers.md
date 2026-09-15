## 1. .csproj Properties

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
The four required properties are present:

OutputType: Exe
TargetFramework: net10.0
ImplicitUsings: enable
Nullable: enable

#region / #endregion

#region and #endregion do not change the compiled output.
They are mainly used to organize and collapse sections of code in the editor,
which can make large files easier to navigate.

// vs /// XML Documentation Comments

I would use /// XML documentation comments when documenting public
classes, methods, properties, or APIs because they can generate
documentation and provide IntelliSense information.
A normal // comment is better for short implementation notes
that are only meant for developers reading the code.

Global Variables in C#

C# does not have true global variables because variables must belong to
a type or a specific scope.
The closest equivalent is a static field inside a class, which can be accessed through the class rather than through an object instance.