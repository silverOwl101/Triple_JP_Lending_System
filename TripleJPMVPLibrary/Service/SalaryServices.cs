using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Repository;
using TripleJPUtilityLibrary.Generator;

namespace TripleJPMVPLibrary.Service
{
    internal class SalaryServices
    {
        SalaryRepo _salaryRepo;
        CollectionRepo _collectionRepo;
        public void OnSetAddSalary(Salary salary)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            _salaryRepo = new SalaryRepo();

            salary.Uid = Guid.NewGuid();
            salary.Id = idGeneratorClass.NewId();

            while (_salaryRepo.IsDuplicateUid(salary.Uid))
            {
                salary.Uid = Guid.NewGuid();
            }
            while (_salaryRepo.IsDuplicateId(salary.Id))
            {
                salary.Id = idGeneratorClass.NewId();
            }

            try
            {
                _salaryRepo.InsertSalary(salary);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public bool OnSetCheckDateValidity(DateTime date)
        {
            _collectionRepo = new CollectionRepo();
            return _collectionRepo.CheckDateValidity(date);
        }
        public decimal OnSetGetTotalSalary(DateTime date)
        {
            _salaryRepo = new SalaryRepo();
            return _salaryRepo.GetTotalSalaryInDate(date);
        }
    }
}
