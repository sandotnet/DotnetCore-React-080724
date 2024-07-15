using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    internal interface IRepository<T> where T : class
    {
        T[] GetAll(); //get all records
        T Get(int id); //get record by id
        void Delete(int id); //delete record
        void Update(T entity); // update record
        void Add(T entity); // add record
    }
    class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User[] GetAll()
        {
            throw new NotImplementedException();
        }
        public User Validate(string uname, string pwd)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
    class SupplierRepository : IRepository<Supplier>
    {
        public void Add(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
