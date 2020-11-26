using OrganizationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationService.Repositories
{
    public class OrganizationRepository : IRepositories<Organization>
    {
        static List<Organization> organizations;
        static OrganizationRepository()
        {
            organizations = new List<Organization>() { 
            new Organization(){Id=1,OrganizationName="L n T",TotalDonations="130000"},
            new Organization(){Id=2,OrganizationName="Helping Hnad",TotalDonations="20000"},
            new Organization(){Id=3,OrganizationName="HOH",TotalDonations="20000"},
            new Organization(){Id=4,OrganizationName="green homes",TotalDonations="400000"},
            new Organization(){Id=5,OrganizationName="peoples home",TotalDonations="50000"},
            }; 

        }
        public virtual void Add(Organization org)
        {
            organizations.Add(org);
        }

        public virtual IEnumerable<Organization> Get()
        {
            return organizations;
        }

        public virtual Organization GetById(int id)
        {
            return organizations.FirstOrDefault(o => o.Id == id);
        }

        public Organization Update(Organization organization)
        {
            

            foreach (var item in organizations)
            {
                if (organization.Id==item.Id)
                {
                    item.OrganizationName = organization.OrganizationName;
                    item.TotalDonations = organization.TotalDonations;
                    return item;

                }
            }
            return organization;
        }
    }
}
