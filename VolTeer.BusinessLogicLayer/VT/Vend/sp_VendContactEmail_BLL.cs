﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VolTeer.DomainModels.VT.Vend;
using VolTeer.DataAccessLayer.VT.Vend;


namespace VolTeer.BusinessLogicLayer.VT.Vend
{
    public class sp_VendContactEmail_BLL
    {
        sp_ContactEmail_DAL DAL = new sp_ContactEmail_DAL();

        public List<sp_ContactEmail_DM> ListContacts()
        {
            return DAL.ListContacts(null, null);
        }

        public List<sp_ContactEmail_DM> ListContacts(Guid? VendContact, int? EmailID)
        {
            return DAL.ListContacts(VendContact, EmailID);
        }

        public void InsertContactContext(sp_ContactEmail_DM _cVendContact)
        {
            DAL.InsertContactContext(ref _cVendContact);
        }

        public void UpdateContactContext(sp_ContactEmail_DM _cVendContact)
        {
            DAL.UpdateContactContext(_cVendContact);
        }

        public void DeleteContactContext(sp_ContactEmail_DM _cVendContact)
        {
            DAL.DeleteContactContext(_cVendContact);
        }

    }
}
