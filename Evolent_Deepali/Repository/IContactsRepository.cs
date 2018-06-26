using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evolent_Deepali.Models;

namespace Evolent_Deepali.Repository
{

    public interface IContactsRepository
    {
        List<tblContact> GetAll();
        tblContact Details(int? id);
        void Create(tblContact tblContact);
        tblContact Edit(int? id);
        tblContact Edit(tblContact tblContact);
        void Delete(int id);
        tblContact Find(int id);
    }
}