namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.Jil")>]
[<assembly: AssemblyProductAttribute("Exira.Jil")>]
[<assembly: AssemblyDescriptionAttribute("MediaTypeFormatter based on Jil (https://github.com/kevin-montrose/Jil)")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
