using CsharpEgitimKampi301.BusinessLayer.Abstract;
using CsharpEgitimKampi301.DataAccessLayer.Abstract;
using CsharpEgitimKampi301EFProject;
using System.Collections.Generic;
using CsharpEgitimKampi301.EntityLayer.Concrete;

namespace CsharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(CsharpEgitimKampi301EFProject.Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<CsharpEgitimKampi301EFProject.Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public CsharpEgitimKampi301EFProject.Customer TGetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public void TInsert(CsharpEgitimKampi301EFProject.Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TUpdate(CsharpEgitimKampi301EFProject.Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
