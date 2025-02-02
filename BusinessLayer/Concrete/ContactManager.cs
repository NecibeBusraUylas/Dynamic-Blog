﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public Contact TGetByFilter(Expression<Func<Contact, bool>> filter = null)
        {
            return filter == null ?
                _contactDal.GetByFilter() :
                _contactDal.GetByFilter(filter);
        }

        public List<Contact> TGetList(Expression<Func<Contact, bool>> filter = null)
        {
            return filter == null ?
                _contactDal.GetListAll() :
                _contactDal.GetListAll(filter);
        }

        public int TGetCount(Expression<Func<Contact, bool>> filter = null)
        {
            return filter == null ?
               _contactDal.GetCount() :
               _contactDal.GetCount();
        }
    }
}