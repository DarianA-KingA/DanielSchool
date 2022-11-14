#pragma checksum "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35203ecde0d81c1230b47179cf97c6055ade70ac"
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
#line 1 "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\_ViewImports.cshtml"
using DanielSchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\_ViewImports.cshtml"
using DanielSchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
using DanielSchool.Core.Application.ViewModels.Calificacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35203ecde0d81c1230b47179cf97c6055ade70ac", @"/Views/Estudiante/Qualification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e31294422d04265a0792df4b09c58c3822b9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudiante_Qualification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CalificacionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
  
    ViewData["Title"] = "Student Qualification";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">

      <div class=""col-6"">
        <div class=""row"">
          <div class=""accordion"" id=""accordionExample"" style=""margin-top: 20px;"">
            <div class=""accordion-item"">
              <h2 class=""accordion-header"" id=""headingOne"">
                <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                  Agosto
                </button>
              </h2>
              <div id=""collapseOne"" class=""accordion-collapse collapse"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample"">
                <div class=""accordion-body"">
                  <table class=""table table-bordered"">
                    <thead>
                  <tr>
                    <th scope=""col"">Weeks</th>
                    <th scope=""col"">Qualifications</th>
                    <th scope=""col"">Extra points</th>
                    <th scope=""col"">Comment</th>
     ");
            WriteLiteral("             </tr>\r\n                </thead>\r\n                <tbody>\r\n                  <tr>\r\n                    <th scope=\"row\">Week 1</th>\r\n                    <td> ");
#nullable restore
#line 32 "D:\repository\C#\Asp.net\DanielSchool\DanielSchool\Views\Estudiante\Qualification.cshtml"
                     Write(Model.Where(m=>m.Month==1 && m.Week ==1).Count()>0? Model.Where(m => m.Month == 1 && m.Week == 1).FirstOrDefault().ToString() : "--");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td></td>
                    <td></td>
                  </tr>
                  <tr>
                    <th scope=""row"">Week 2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Week 3</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Week 4</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Agosto</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
          
                </tbody>
                </table>
                </div>
              ");
            WriteLiteral(@"</div>
            </div>
          
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingTwo"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    Septiembre
                  </button>
                </h2>
                <div id=""collapseTwo"" class=""accordion-collapse collapse"" aria-labelledby=""headingTwo"" data-bs-parent=""#accordionExample"">
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
            WriteLiteral(@"             <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Septiembre</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
");
            WriteLiteral(@"                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingThree"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                    Octubre
                  </button>
                </h2>
                <div id=""collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample"">
                  <div class=""accordion-body"">
                    <table class=""table table-bordered"">
                      <thead>
                    <tr>
                      <th scope=""col"">Weeks</th>
                      <th scope=""col"">Qualifications</th>
                      <th sc");
            WriteLiteral(@"ope=""col"">Extra points</th>
                      <th scope=""col"">Comment</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                 ");
            WriteLiteral(@"   </tr>
                    <tr>
                      <th scope=""row"">Octubre</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingFour"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                    Noviembre
                  </button>
                </h2>
                <div id=""collapseFour"" class=""accordion-collapse collapse"" aria-labelledby=""headingFour"" data-bs-parent=""#accordionExample"">
                  <div class=""accordion-body"">
                    <table class=""table table-bordered"">
                      <thead>
            WriteLiteral(@"
                    <tr>
                      <th scope=""col"">Weeks</th>
                      <th scope=""col"">Qualifications</th>
                      <th scope=""col"">Extra points</th>
                      <th scope=""col"">Comment</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                   ");
            WriteLiteral(@"   <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Noviembre</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingFive"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseFive"" aria-expanded=""false"" aria-controls=""collapseFive"">
                    Diciembre
                  </button>
                </h2>
                <div id=""collapseFive"" class=""accordion-collapse collapse"" aria-labelledby=""headingFive"" data-bs");
            WriteLiteral(@"-parent=""#accordionExample"">
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
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                     ");
            WriteLiteral(@" <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Diciembre</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <table class=""table table-bordered"">
                <thead>
              <tr>
                <th scope=""col"">1er Semestre</th>
                <th scope=""col"">Qualifications</th>
                <th scope=""col"">Exam</th>
                <th scope=""col"">Final Qualification </th>
              </tr>");
            WriteLiteral(@"
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
            </div> 
            
        </div>
        <div class=""row"">
          <div class=""accordion"" id=""accordionExample"" style=""margin-top: 20px;"">
            <div class=""accordion-item"">
              <h2 class=""accordion-header"" id=""headingSix"">
                <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseSix"" aria-expanded=""false"" aria-controls=""collapseSix"">
                  Enero
                </button>
              </h2>
              <div id=""collapseSix"" class=""accordion-collapse collapse"" aria-labelledby=""headingSix"" data-bs-parent=""#accordionExample"">
                <div class=""accordion-body"">
                  <table class=");
            WriteLiteral(@"""table table-bordered"">
                    <thead>
                  <tr>
                    <th scope=""col"">Weeks</th>
                    <th scope=""col"">Qualifications</th>
                    <th scope=""col"">Extra points</th>
                    <th scope=""col"">Comment</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <th scope=""row"">Week 1</th>
                    <td>Mark</td>
                    <td>Otto</td>
                    <td>mdo</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Week 2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Week 3</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    ");
            WriteLiteral(@"<th scope=""row"">Week 4</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
                  <tr>
                    <th scope=""row"">Enero</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>fat</td>
                  </tr>
          
                </tbody>
                </table>
                </div>
              </div>
            </div>
          
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingSeven"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseSeven"" aria-expanded=""false"" aria-controls=""collapseSeven"">
                    Febrero
                  </button>
                </h2>
                <div id=""collapseSeven"" class=""accordion-collapse collapse"" aria-labelledby=""headingSeven"" data-bs-parent=""#accordionExa");
            WriteLiteral(@"mple"">
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
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
     ");
            WriteLiteral(@"                 <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Febrero</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingEigth"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseEigth"" aria-expanded=""false"" aria-controls=""collapseEigth"">
                    Marzo
                  </but");
            WriteLiteral(@"ton>
                </h2>
                <div id=""collapseEigth"" class=""accordion-collapse collapse"" aria-labelledby=""headingEigth"" data-bs-parent=""#accordionExample"">
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
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                  ");
            WriteLiteral(@"    <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Marzo</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingNine"">
                  <button class=""accordion-button collapsed"" type=""button"" ");
            WriteLiteral(@"data-bs-toggle=""collapse"" data-bs-target=""#collapseNine"" aria-expanded=""false"" aria-controls=""collapseNine"">
                    Abril
                  </button>
                </h2>
                <div id=""collapseNine"" class=""accordion-collapse collapse"" aria-labelledby=""headingNine"" data-bs-parent=""#accordionExample"">
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
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                ");
            WriteLiteral(@"    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Abril</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=");
            WriteLiteral(@"""accordion-item"">
                <h2 class=""accordion-header"" id=""headingTen"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTen"" aria-expanded=""false"" aria-controls=""collapseTen"">
                    Mayo
                  </button>
                </h2>
                <div id=""collapseTen"" class=""accordion-collapse collapse"" aria-labelledby=""headingTen"" data-bs-parent=""#accordionExample"">
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
                    <tr>
                      <th scope=""row"">Week 1</th>
 ");
            WriteLiteral(@"                     <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Mayo</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
  ");
            WriteLiteral(@"                </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingEleven"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseEleven"" aria-expanded=""false"" aria-controls=""collapseEleven"">
                    Junio
                  </button>
                </h2>
                <div id=""collapseEleven"" class=""accordion-collapse collapse"" aria-labelledby=""headingEleven"" data-bs-parent=""#accordionExample"">
                  <div class=""accordion-body"">
                    <table class=""table table-bordered"">
                      <thead>
                    <tr>
                      <th scope=""col"">Weeks</th>
                      <th scope=""col"">Qualifications</th>
                      <th scope=""col"">Extra points</th>
                      <th scope=""col"">Comment");
            WriteLiteral(@"</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">");
            WriteLiteral(@"Junio</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
          
              <div class=""accordion-item"">
                <h2 class=""accordion-header"" id=""headingTwelve"">
                  <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwelve"" aria-expanded=""false"" aria-controls=""collapseTwelve"">
                    Julio
                  </button>
                </h2>
                <div id=""collapseTwelve"" class=""accordion-collapse collapse"" aria-labelledby=""headingTwelve"" data-bs-parent=""#accordionExample"">
                  <div class=""accordion-body"">
                    <table class=""table table-bordered"">
                      <thead>
                    <tr>
                      <th scope");
            WriteLiteral(@"=""col"">Weeks</th>
                      <th scope=""col"">Qualifications</th>
                      <th scope=""col"">Extra points</th>
                      <th scope=""col"">Comment</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope=""row"">Week 1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>mdo</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 3</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Week 4</th>
                      <td>");
            WriteLiteral(@"Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
                    <tr>
                      <th scope=""row"">Julio</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>fat</td>
                    </tr>
          
                  </tbody>
                  </table>
                  </div>
                </div>
              </div>
              <table class=""table table-bordered"">
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
");
            WriteLiteral(@"            
            </tbody>
             </table>
            
             <table class=""table table-bordered"">
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
            </div>
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
            'Septi");
            WriteLiteral(@"embre',
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
              data: [0, 10, 5, 2, 20, 10, 10, 5, 2, 20, 14, 13],
            }]
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
      <d");
            WriteLiteral(@"iv style=""width: 500px; text-align:center; margin-left:20px;"">
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
      </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CalificacionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591