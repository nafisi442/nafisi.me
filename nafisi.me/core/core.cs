using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nafisi.me.core
{
    public static class core
    {
        public static string name_uppercase = "JAMSHID NAFISI";
        public static string name_normal = "Jamshid Nafisi";
        public static string website = "www.nafisi.me";
        public static string website_link = "http://www.nafisi.me";
        public static string email = "shayan.nafisi@gmail.com";
        public static string phone_number = "+1 347 334 1219";
        public static string title = ".NET, C# Developer";
        public static string motto = "Life is ours, we live it our way...";
        public static string dob = "March 1985";
        public static string address = "San Francisco, CA";
        public static string fb_link = "https://www.facebook.com/shayan.nafisi";
        public static DateTime last_update = new DateTime(2013, 10, 9);
        public static string work_authorization = "Authorized to work in the United States without any restrictions.";




        //power from 7
        public static List<technology> technology_list = new List<technology>() { 
            new technology{ technology_name="C#", power=7},
            new technology{ technology_name=".NET", power=7},
            new technology{ technology_name="VB.NET", power=7},
            new technology{ technology_name="MVC", power=7},
            new technology{ technology_name="ASP.NET MVC", power=7},
            new technology{ technology_name="OOP", power=7},
            new technology{ technology_name="WPF", power=2},
            new technology{ technology_name="WCF", power=2},
            new technology{ technology_name="HTML", power=7},
            new technology{ technology_name="JQUERY", power=5},
            new technology{ technology_name="JAVASCRIPT", power=3},
            new technology{ technology_name="NHIBERNATE", power=5},
            new technology{ technology_name="SSIS", power=5},
            new technology{ technology_name="TFS", power=7},
            new technology{ technology_name="CSS", power=7},
            new technology{ technology_name="C++", power=2},
            new technology{ technology_name="JAVA", power=2},
            new technology{ technology_name="LINQ", power=7},
            new technology{ technology_name="XML", power=7},
            new technology{ technology_name="EF", power=7},
            new technology{ technology_name="SQL", power=7},
            new technology{ technology_name="TSQL", power=2},
            new technology{ technology_name="AJAX", power=6},
            new technology{ technology_name="SOAP", power=3},
            new technology{ technology_name="REST", power=5},
            new technology{ technology_name="AWS", power=6},
            new technology{ technology_name="AZURE", power=1},

        };



        public static List<job> jobs_list = new List<job>(){
            new job { order=1, company="Ancestry.com", company_link="http://www.Ancestry.com /", from= new DateTime(2014, 1, 1), to=DateTime.UtcNow , location="San Francisco, CA", title="Senior Software Engineer at SEO Team", 
                descriptions=new string[] {
                    "Defined circuit breakers and implemented circuit breaker fallbacks in order to lower the load of servers once traffic peaks by tripping circuit breakers.",
                    "Implemented seo related elements such as canonical tags and etc and related unit tests.",
                    "Implementing missing error pages.",
                    "Implementing teallium tags which generate omniture scripts for generating analytics for pages.",
                    "Assessment of Schema.org and Open Graph on pages to further implement the related tags and increase organic traffic through them.",

                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },

            new job { order=2, company="Aspen Marketing Services", company_link="http://www.aspenms.com/", from= new DateTime(2013, 9, 1), to=new DateTime(2014, 1, 1) , location="West Chicago, IL", title="Backend ASP.NET MVC Developer", 
                descriptions=new string[] {
                    "Optimized and refactoring data ORMs of existing projects to achieve faster response rate. Upgrading some projects to Hibernate in cases. Using SQL profiler to monitor the data transactions.",
                    "Upgraded 3-Tier projects to N-Tier project structures to achieve higher scalability.",
                    "Developed SSIS packages for  importing the clients data from excel to related databases.",
                    "Set up Nolio scripts for pushing the finalized products to Development, QA and production environments.",
                    "Worked in an agile environment, attending daily meetings and working within bi-weekly sprints.",
                    "Daily communicating with project managers face to face or through TFS to keep the projects on time and on track.",

                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },


            new job { order=3, company="7pigs.com", company_link="http://www.7pigs.com", from= new DateTime(2010, 1, 1), to=new DateTime(2013, 9, 1) , location="San Francisco, CA", title="Full Stack ASP.NET MVC Developer", 
                descriptions=new string[] {
                    "Developed website using ASP.NET MVC, LINQ, Entity Framework, JQUERY and JavaScript.",
                    "Developed sophisticated SQL statements for high speed data transactions where needed.",
                    "Developed related server applications and web services (REST).",
                    "Developed trading strategies and algorithms using C#.",
                    "Performed back tests and forward tests of the trading algorithms using MetaTrader.",
                    "Improved and changing the structure of automated trading systems as needed.",
                    "Set up the servers, SSL certificates and etc. Also configuring the hardware in order to handle the traffic and load on the AWS servers.",
                    "Led the programming team in Nairobi, Kenya office.",

                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },



            new job { order=4, company="Celar Water Equipment", company_link="", from=new DateTime(2006, 1, 1), to=new DateTime(2009, 9, 1) , location="Dubai, U.A.E.", title="Full Stack VB.NET Programmer", 
                descriptions=new string[] {
                    "Developed a ERP(Enterprise Resource Planning Package) from scratch using VB.NET, SQL server and etc.",
                    "Created interconnected databases for each department and achieved more organized data management and increased information availability for the entire company.",
                    "Designed new reporting system to monitor the resources more accurately.",
                    "Connected the ERP package to the engineering software for more accurate proposals.",
                    "Modified the old business structure of the company and achieved 30% more efficiency in workforce using C#.",

                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
            },



            new job { order=5, company="NAHOFTSazan", company_link="", from=new DateTime(2005, 5, 1), to=new DateTime(2005, 10, 1) , location="Tehran, Iran", title="Founder", 
                descriptions=new string[] {
                "Conducted presentations for potential clients and meetings for current clients.",
                "Designed small business software packages and databases.",
                "Managed company’s administration, financial and marketing issues.",
                "Estimated and calculated the job proposals. Company was awarded more than 10 projects internationally.",
                "Developed company's' projects' and led the programming team.",

                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
            },



        };




        public static List<eduction> education_list = new List<eduction>()
        {
            new eduction{ school="Portland State University", program="M.S. Engineering and Technology Management", 
                from=new DateTime(2009, 9, 1), to=new DateTime(2011, 9, 1), location="Portland, OR", order=1 },

                    new eduction{ school="University of Kerman", program="B.S. Mechanical Engineering", 
                from=new DateTime(2003, 9, 1), to=new DateTime(2008, 9, 1), location="Kerman, Iran", order=2 }

        };




    }



    public class technology
    {
        public string technology_name { get; set; }
        public int power { get; set; }
    }

    public class job
    {
        public int order { get; set; }
        public string company { get; set; }
        public string company_link { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public IEnumerable<string> descriptions { get; set; }
        public IEnumerable<technology> technologies { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; } 

        
    }


    public class eduction
    {
        public int order { get; set; }
        public string school { get; set; }
        public string school_link { get; set; }
        public string program { get; set; }
        public string location { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }

}