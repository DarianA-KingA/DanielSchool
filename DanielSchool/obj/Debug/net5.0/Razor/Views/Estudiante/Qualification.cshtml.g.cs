#pragma checksum "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf83e5f5f511a832942e40c76d2812446c4d517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudiante_Qualification), @"mvc.1.0.view", @"/Views/Estudiante/Qualification.cshtml")]
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
#line 1 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\_ViewImports.cshtml"
using DanielSchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\_ViewImports.cshtml"
using DanielSchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
using DanielSchool.Core.Application.ViewModels.Calificacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
using DanielSchool.Core.Application.ViewModels.DescCalificacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf83e5f5f511a832942e40c76d2812446c4d517", @"/Views/Estudiante/Qualification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e31294422d04265a0792df4b09c58c3822b9c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Estudiante_Qualification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoadCalificacionViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
  
    ViewData["Title"] = "Student Qualification";
    string[] meses = {"Agosto","Septiembre","Octubre","Noviembre","Diciembre","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio"};
    string[] Number = {"One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Eleven","Twelve"};


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n\r\n      <div class=\"col-6\">\r\n        <div class=\"row\">\r\n          <div class=\"accordion\" id=\"accordionExample\" style=\"margin-top: 20px;\">\r\n");
#nullable restore
#line 16 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
             for(int M = 0; M<12;M++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"accordion-item\">\r\n                  <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 781, "\"", 805, 2);
            WriteAttributeValue("", 786, "heading", 786, 7, true);
#nullable restore
#line 19 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
WriteAttributeValue("", 793, Number[M], 793, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse");
#nullable restore
#line 20 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                                                                                                                            Write(Number[M]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 972, "\"", 1008, 2);
            WriteAttributeValue("", 988, "collapse", 988, 8, true);
#nullable restore
#line 20 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
WriteAttributeValue("", 996, Number[M], 996, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      ");
#nullable restore
#line 21 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                 Write(meses[M]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                  </h2>\r\n                  <div");
            BeginWriteAttribute("id", " id=\"", 1123, "\"", 1148, 2);
            WriteAttributeValue("", 1128, "collapse", 1128, 8, true);
#nullable restore
#line 24 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
WriteAttributeValue("", 1136, Number[M], 1136, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1185, "\"", 1222, 2);
            WriteAttributeValue("", 1203, "heading", 1203, 7, true);
#nullable restore
#line 24 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
WriteAttributeValue("", 1210, Number[M], 1210, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-bs-parent=""#accordionExample"">
                    <div class=""accordion-body"">
                      <table class=""table table-bordered"">
                        <thead>
                      <tr>
                        <th scope=""col"">Weeks</th>
                        <th scope=""col"">Qualifications</th>
                        <th scope=""col"">Extra points</th>
                        <th scope=""col"">Comment</th>
                      </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                         for (int s = 0; s < 4; s++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">Week ");
#nullable restore
#line 39 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                                                 Write(s+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 40 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                                Write(Model.Month[s,M].Nota<1? "--": Model.Month[s,M].Nota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                               Write(Model.Month[s,M].PuntosExtras);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                               Write(Model.Month[s,M].Comentarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 44 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 48 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                                   Write(meses[M]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                        <td> -- </td>
                        <td> -- </td>
                      </tr>
          
                    </tbody>
                    </table>
                    </div>
                  </div>
                </div>
");
#nullable restore
#line 58 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                     if (M == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-bordered"">
                            <thead>
                                  <tr>
                                    <th scope=""col"">1er Semestre</th>
                                    <th scope=""col"">Qualifications</th>
                                    <th scope=""col"">Exam</th>
                                    <th scope=""col"">Final Qualification </th>
                                  </tr>
                            </thead>
                        <tbody>
                          <tr>
                            <th scope=""row"">Agosto-Diciembre</th>
                            <td>Mark</td>
                            <td>Otto</td>
                            <td>mdo</td>
                          </tr>
                        </tbody>
                        </table>
");
#nullable restore
#line 78 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                     if (M == 11)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-bordered"">
                            <thead>
                              <tr>
                                <th scope=""col"">2do Semestre</th>
                                <th scope=""col"">Qualifications</th>
                                <th scope=""col"">Exam</th>
                                <th scope=""col"">Final Qualification </th>
                              </tr>
                            </thead>
                            <tbody>
                              <tr>
                                <th scope=""row"">Enero-Julio</th>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>mdo</td>
                              </tr>
            
                            </tbody>
                         </table>
");
            WriteLiteral(@"                         <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                  <th scope=""col"">Año escolar</th>
                                  <th scope=""col"">Final Qualifications</th>
                                  <th scope=""col"">Valoración</th>
                                  <th scope=""col"">Comment </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                  <th scope=""row"">2022-2023</th>
                                  <td>Mark</td>
                                  <td>Otto</td>
                                  <td>mdo</td>
                                </tr>
                            </tbody>
                        </table>
");
#nullable restore
#line 119 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\repositories\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>   
        </div>
        
      </div>
      <div class=""col-6"">
        <!--aqui va lo otros-->
        <div>
          <canvas id=""myChart""></canvas>
        </div>
        
        <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
        
        <script>
          const labels = [
            'Agosto',
            'Septiembre',
            'Octubre',
            'Noviembre',
            'Diciembre',
            'Enero',
            'Febrero',
            'Marzo',
            'Abril',
            'Mayo',
            'Junio',
            'Julio',
          ];
      
          const labels2 = [
            'Promedio total',
          ];
        
          const data = {
            labels: labels,
            datasets: [{
              label: 'Progreso por mes',
              backgroundColor: 'rgb(255, 99, 132)',
              borderColor: 'rgb(255, 99, 132)',
              data: [0, 10, 5, 2, 30, 10, 10, 5, 2, 20, 14, 13],
            }");
            WriteLiteral(@"]
          };
        
          const config = {
            type: 'line',
            data: data,
            options: {}
          };
        </script>
      
      <script>
        const myChart = new Chart(
          document.getElementById('myChart'),
          config
        );
      </script>
      
      <div style=""margin-top: 50px;"">
      <div style=""width: 500px; text-align:center; margin-left:20px;"">
      <canvas id=""pieChart""></canvas>
      </div>
      <script>
      var ctxP = document.getElementById(""pieChart"").getContext('2d');
        var myPieChart = new Chart(ctxP, {
          type: 'pie',
          data: {
            labels: labels2,
            datasets: [{  
              data: [90,10],
              backgroundColor: [""#F7464A"", ""#46BFBD""],
              hoverBackgroundColor: [""#FF5A5E"", ""#5AD3D""]
            }]
          },
          options: {
            responsive: true
          }
        });
      
      </script>
      </div>
      </");
            WriteLiteral("div>\r\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoadCalificacionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
