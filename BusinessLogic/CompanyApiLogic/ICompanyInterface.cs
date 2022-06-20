using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CompanyApiLogic
{
    public interface ICompanyInterface
    {
        List<Company> GetCompanies(); // get list of all companies
        Company GetCompany(int id); // get one company with id
        Company AddCompany (Company newCompany); // post Create new company
        Company UpdateCompany(Company companyToUpdate); // Put, update an existing company
        void DeleteCompany(Company companyToDelete); // Delete a company
    } 
}
