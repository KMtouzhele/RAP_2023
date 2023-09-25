using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Entity;
using RAP.Controller;

namespace RAP
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicationController publicationcontroller = new PublicationController();
            List<Publication> allpublications = publicationcontroller.LoadAllPublications();
            //foreach (Publication publication in allpublications)
            //{
            //    Console.WriteLine(publication.ToString());
            //}

            ResearcherController researchercontroller = new ResearcherController();
            List<Researcher> allresearchers = researchercontroller.LoadAllResearchers();
            foreach (Researcher researcher in allresearchers)
            {
                Console.WriteLine(researcher.ToString());
            }

            Console.WriteLine("_________________");
            Console.WriteLine("_________________");

            List<Researcher> researchersbylevel = researchercontroller.FilterByLevel(allresearchers, AllEnum.EmploymentLevel.A);
            foreach (Researcher researcher in researchersbylevel)
            {
                Console.WriteLine(researcher.ToString());
            }

            Console.WriteLine("_________________");
            Console.WriteLine("_________________");

            List<Researcher> researcherbyname = researchercontroller.FilterByName(allresearchers, "Pe");
            foreach (Researcher researcher in researcherbyname)
            {
                Console.WriteLine(researcher.ToString());
            }

            Console.WriteLine("_________________");
            Console.WriteLine("_________________");

            List<Researcher_Publication> allrelations = publicationcontroller.LoadAllRelations();
            List<Researcher_Publication> doibyid = publicationcontroller.LoadDOIsFor(123469, allrelations);
            foreach (Researcher_Publication relation in doibyid)
            {
                Console.WriteLine(relation.DOI);
            }
        }
    }
}
