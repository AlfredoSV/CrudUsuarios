#pragma checksum "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d2913a93af1b3f189daf35a22cf6a091199614b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crud_ListarPDF), @"mvc.1.0.view", @"/Views/Crud/ListarPDF.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\_ViewImports.cshtml"
using CrudUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\_ViewImports.cshtml"
using CrudUsuarios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2913a93af1b3f189daf35a22cf6a091199614b", @"/Views/Crud/ListarPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2786d1753bb2a745e561efa074d27235d1210aa0", @"/Views/_ViewImports.cshtml")]
    public class Views_Crud_ListarPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CrudUsuarios.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
  
    ViewData["Title"] = "Home Page";
	Layout = null;
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<style>

.principal,table {
	
	width:100%;
	text-aling:center;

}

</style>

<div class=""principal"">
  

 <div>


 <table border=""1"">
  
  <thead >
  
  <tr>
  <th >
   Nombre
  </th>
  <th >
   Apellido paterno
  </th>
   <th >
   Apellido materno
  </th>
   <th >
   Correo
  </th>
   <th >
   Fecha de nacimiento
  </th>

  </tr>
  
  </thead>
  
  <tbody>
  
   
");
#nullable restore
#line 55 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
   foreach(var item in @Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t <tr>\r\n\t \r\n\t   <td>\r\n  ");
#nullable restore
#line 59 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </td>\r\n\t  <td>\r\n  ");
#nullable restore
#line 62 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
Write(item.ApellidoP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </td>\r\n  \t  <td>\r\n  ");
#nullable restore
#line 65 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
Write(item.ApellidoM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </td>\r\n  \t  <td>\r\n  ");
#nullable restore
#line 68 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </td>\r\n  \t  <td>\r\n  ");
#nullable restore
#line 71 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
Write(item.FechaNacimeinto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </td>\r\n \t\r\n </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Alfredo-Ad\Desktop\CrudUsuarios\Views\Crud\ListarPDF.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n\r\n  \r\n  \r\n  </tbody>\r\n  \r\n  \r\n \r\n  \r\n    \r\n  </table>\r\n  \r\n\r\n</div>\r\n \r\n \r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CrudUsuarios.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
