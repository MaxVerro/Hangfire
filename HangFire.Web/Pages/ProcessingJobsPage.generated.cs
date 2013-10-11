﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\ProcessingJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ProcessingJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Pages\ProcessingJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Processing Jobs" };
    
    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.ProcessingCount())
    {
        BasePageUrl = Request.LinkTo("/processing")
    };

    var processingJobs = JobStorage.ProcessingJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 20 "..\..\Pages\ProcessingJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        No jobs are being processed right now" +
".\r\n    </div>\r\n");


            
            #line 25 "..\..\Pages\ProcessingJobsPage.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Pages\ProcessingJobsPage.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Pages\ProcessingJobsPage.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Server</th>
                <th>Job type</th>
                <th>Args</th>
                <th>Started</th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 41 "..\..\Pages\ProcessingJobsPage.cshtml"
             foreach (var job in processingJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a href=\"" +
"");


            
            #line 45 "..\..\Pages\ProcessingJobsPage.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 46 "..\..\Pages\ProcessingJobsPage.cshtml"
                       Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d>");


            
            #line 49 "..\..\Pages\ProcessingJobsPage.cshtml"
                   Write(job.Value.ServerName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n                        ");


            
            #line 51 "..\..\Pages\ProcessingJobsPage.cshtml"
                   Write(HtmlHelper.QueueLabel(job.Value.QueueName));

            
            #line default
            #line hidden
WriteLiteral("&nbsp;");


            
            #line 51 "..\..\Pages\ProcessingJobsPage.cshtml"
                                                                    Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td><pre class=\"pre-args\">");


            
            #line 53 "..\..\Pages\ProcessingJobsPage.cshtml"
                                         Write(HtmlHelper.FormatProperties(job.Value.Args));

            
            #line default
            #line hidden
WriteLiteral("</pre></td>\r\n                    <td data-moment=\"");


            
            #line 54 "..\..\Pages\ProcessingJobsPage.cshtml"
                                Write(JobHelper.ToStringTimestamp(job.Value.StartedAt));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 54 "..\..\Pages\ProcessingJobsPage.cshtml"
                                                                                   Write(job.Value.StartedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");


            
            #line 56 "..\..\Pages\ProcessingJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 59 "..\..\Pages\ProcessingJobsPage.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Pages\ProcessingJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Pages\ProcessingJobsPage.cshtml"
                                        
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
