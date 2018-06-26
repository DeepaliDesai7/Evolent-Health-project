using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;
using Evolent_Deepali.Models;
using System.Data.Entity;

namespace Evolent_Deepali.Repository
{
    [Export(typeof(IContactsRepository))]
    public class ContactsRepository : IContactsRepository
    {
        private EvolentHealthEntities db = new EvolentHealthEntities();

        public List<tblContact> GetAll()
        {
            using (var dbcontext = new EvolentHealthEntities())
            {
                return dbcontext.tblContacts.ToList();
            }

        }

        public tblContact Details(int? id)
        {
            tblContact Contactobj;
            if (id == null)
            {
                return null;
            }
            using (var dbcontext = new EvolentHealthEntities())
            {
                Contactobj = db.tblContacts.Find(id);
            }
            if (Contactobj == null)
            {
                return null;
            }
            return Contactobj;
        }
        public void Create(tblContact Contactobj)
        {
            using (var dbcontext = new EvolentHealthEntities())
            {
                dbcontext.tblContacts.Add(Contactobj);
                dbcontext.SaveChanges();
            }
        }
        public tblContact Edit(int? id)
        {
            tblContact Contactobj;
            using (var dbcontext = new EvolentHealthEntities())
            {
                Contactobj = dbcontext.tblContacts.Find(id);
            }
            return Contactobj;
        }
        public tblContact Edit(tblContact Contactobj)
        {
            using (var dbcontext = new EvolentHealthEntities())
            {
                dbcontext.Entry(Contactobj).State = EntityState.Modified;
                dbcontext.SaveChanges();
                return Contactobj;
            }
        }
        public void Delete(int id)
        {
            using (var dbcontext = new EvolentHealthEntities())
            {           
            tblContact Contactobj = dbcontext.tblContacts.Find(id);
            dbcontext.tblContacts.Remove(Contactobj);
            dbcontext.SaveChanges();
            }
        }

        public tblContact Find(int id)
        {
            using (var dbcontext = new EvolentHealthEntities())
            {
                tblContact Contactobj = dbcontext.tblContacts.Find(id);
                return Contactobj;
            }
        }


    }
}