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
            new technology{ technology_name="NodeJs", power=6},
            new technology{ technology_name="Redis", power=7},
            new technology{ technology_name="HapiJs", power=6},
            new technology{ technology_name="MongoDb", power=7},
            new technology{ technology_name=".NET", power=7},
            new technology{ technology_name="VB.NET", power=7},
            new technology{ technology_name="MVC", power=7},
            new technology{ technology_name="ASP.NET MVC", power=7},
            new technology{ technology_name="OOP", power=7},
            new technology{ technology_name="WPF", power=2},
            new technology{ technology_name="WCF", power=2},
            new technology{ technology_name="HTML", power=7},
            new technology{ technology_name="JQUERY", power=5},
            new technology{ technology_name="JAVASCRIPT", power=5},
            new technology{ technology_name="NHIBERNATE", power=5},
            new technology{ technology_name="SSIS", power=5},
            new technology{ technology_name="TFS", power=7},
            new technology{ technology_name="CSS", power=7},
            new technology{ technology_name="C++", power=2},
            new technology{ technology_name="JAVA", power=6},
            new technology{ technology_name="LINQ", power=7},
            new technology{ technology_name="XML", power=7},
            new technology{ technology_name="EF", power=7},
            new technology{ technology_name="SQL", power=7},
            new technology{ technology_name="TSQL", power=2},
            new technology{ technology_name="AJAX", power=6},
            new technology{ technology_name="SOAP", power=3},
            new technology{ technology_name="REST", power=5},
            new technology{ technology_name="AWS", power=6},
            new technology{ technology_name="AZURE", power=6},

        };



        public static List<job> jobs_list = new List<job>(){
                        new job { order=1, company="Skype", company_link="http://www.skype.com /", from= new DateTime(2014, 5, 1), to=DateTime.UtcNow , location="Palo Alto, CA", title="Senior Backend Engineer", 
                descriptions=new string[] {
                    "Developed node.js backend for new content management system that would potentially work with mobile as well through REST apis. We used the following libraries in this project: Hapi, Mongoose, Joi, Boom, Q, Angular, Mocha etc. We used a combination of SQL and MongoDB to store the data.",
                    "Developed unit tests for new node based CMS both for api routes as well as the backend functionalities.",
                    "Initiated, architected and coded a prototype for visual builder of a new internal CMS platform. The new CMS enabled content managers to design and develop websites without any need for coding it. Once the prototype was approved, I along with my team went ahead and developed a fully working product which is now being used in skype marketing. We coded it in C# with .NET libraries and used the following technology stack: ASP.NET MVC, C#, .NET, Redis, Azure storage, JavaScript, SQL, etc.",
                    "Developed SQL and NoSQL database layers to be used within the visual builder platform that we developed for marketing.",
                    "Developed recursive functions to render the websites on the fly within a reasonable timeframe by loading all the html elements if the page from database. ",
                    "Created visual builder interface which massively used jquery and ajax/api calls to reflect the changes content manager made on the pages to the database on the fly.",
                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },

            new job { order=1, company="Ancestry.com", company_link="http://www.ancestry.com /", from= new DateTime(2014, 1, 1), to=DateTime.UtcNow , location="San Francisco, CA", title="Senior Software Engineer at SEO Team", 
                descriptions=new string[] {
"	Defined circuit breaker patterns and implemented circuit breaker fallbacks in order to lower the load of servers once traffic peaks by tripping circuit breakers.",
"	Implemented SEO related elements such as canonical tags and etc. and developed related unit tests. ",
"	Implementing missing error pages.",
"	Implementing teallium tags which generate omniture scripts for generating analytics for pages.",
"	Assessment of Schema.org and Open Graph on pages to further implement the related tags and increase organic traffic through them.",
                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },

            new job { order=2, company="Aspen Marketing Services", company_link="http://www.aspenms.com/", from= new DateTime(2013, 9, 1), to=new DateTime(2014, 1, 1) , location="West Chicago, IL", title="Backend ASP.NET MVC Developer", 
                descriptions=new string[] {
"Optimized and refactoring data ORMs of existing projects to achieve faster response rate. Upgraded some projects to Hibernate in cases. Using SQL profiler to monitor the data transactions.",
"Upgraded 3-Tier projects to N-Tier project structures to achieve higher scalability.",
"Developed SSIS packages for importing the clients’ data from excel to related databases.",
"Worked in an agile environment, attending daily meetings and working within bi-weekly sprints.",
"Daily communicating with project managers face to face or through TFS to keep the projects on time and on track.",
                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            },


            new job { order=3, company="7pigs.com", company_link="http://www.7pigs.com", from= new DateTime(2010, 1, 1), to=new DateTime(2013, 9, 1) , location="San Francisco, CA", title="Full Stack ASP.NET MVC Developer", 
                descriptions=new string[] {
                    "Developed website functionalities using ASP.NET MVC, LINQ, Dapper, Entity Framework, Jquery and JavaScript. ",
                    "Developed sophisticated SQL statements for high speed data transactions where needed.",
                    "Developed sophisticated SQL statements for high speed data transactions where needed.",
                    "Set up the servers, SSL certificates and etc. Also configuring the hardware in order to handle the traffic and load on the AWS servers.",
                    "Led the programming team in Nairobi, Kenya office.",
                }, technologies=technology_list.Where(x=>x.technology_name=="C#").ToList()
                
            }
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