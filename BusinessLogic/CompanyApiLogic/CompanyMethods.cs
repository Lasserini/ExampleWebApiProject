using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CompanyApiLogic
{
    public class CompanyMethods : ICompanyInterface
    {
        private readonly SampleWebApiDbEntities _db;
        public CompanyMethods(SampleWebApiDbEntities db)
        {
            _db = db;
        }

        public Company AddCompany(Company newCompany)
        {
            _db.Companies.Add(newCompany);
            _db.SaveChanges();
            return newCompany;  // Should this return something else? I.e. the end goal is to give the correct http response, 201 for succesfull creation
        }

        public void DeleteCompany(Company companyToDelete)
        {
            _db.Companies.Remove(companyToDelete);
            _db.SaveChanges();
        }

        public List<Company> GetCompanies()
        {
            return _db.Companies.ToList();
        }

        public Company GetCompany(int id)
        {
            return _db.Companies.Find(id);
        }

        public Company UpdateCompany(Company companyToUpdate)
        {
            Company companyInDatabase = _db.Companies.Find(companyToUpdate.Id);
            if (companyInDatabase != null)
            {
                companyInDatabase.Name = companyToUpdate.Name;
                companyInDatabase.CVR = companyToUpdate.CVR;
                companyInDatabase.Address1 = companyToUpdate.Address1;
                companyInDatabase.Address2 = companyToUpdate.Address2;
                companyInDatabase.PostalCode = companyToUpdate.PostalCode;
                companyInDatabase.City = companyToUpdate.City;
                companyInDatabase.Country = companyToUpdate.Country;
                companyInDatabase.PhonePrimary = companyToUpdate.PhonePrimary;
                companyInDatabase.PhoneSecondary = companyToUpdate.PhoneSecondary;
                companyInDatabase.Email = companyToUpdate.Email;
                // _db.Companies.Update(companyInDatabase);   // Update doesn't seem to work when its not Core, test if it just works without, or if a fix is required.
                // Perhaps https://github.com/mono/entityframework/blob/master/src/EntityFramework/Migrations/DbSetMigrationsExtensions.cs#L79
                _db.SaveChanges();
            }
            return companyInDatabase;
        }
    }
}
