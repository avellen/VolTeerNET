﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VolTeer.DomainModels.VT.Vol;
using VolTeer.BusinessLogicLayer.VT.Vol;
using UT.Volteer.BLL.HelperMethods;
using System.Data;

namespace UT.Volteer.BLL
{
    [TestClass]
    public class utVolunteer
    {
        //const string CWorkbook = "C:\\Users\\Dad\\Source\\Repos\\VolTeerNET\\UT.Volteer.BLL\\UTTestFiles\\Volunteer.xlsx";
        const string CWorkbook = "C:\\Users\\Kyle\\Source\\Repos\\VolTeerNET\\UT.Volteer.BLL\\HelperFiles\\Volunteer.xlsx";

        [TestMethod]
        public void CreateVolunteer()
        {

            DataTable dt = new DataTable();
            cExcel _cExcel = new cExcel();
            string strSheetName = "Volunteer"; 

            dt = _cExcel.ReadExcelFile(strSheetName, CWorkbook);

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {

                Console.WriteLine("--- Row ---"); // Print separator.
                string strFirstName = row["FirstName"].ToString();
                string strMiddleName = row["MiddleName"].ToString();
                string strLastName = row["LastName"].ToString();
                
                sp_Volunteer_DM insertVol = new sp_Volunteer_DM();
                sp_Volunteer_DM selectVol = new sp_Volunteer_DM();

                hVolunteer hVol = new hVolunteer();
                insertVol = hVol.hCreateVolunteer(strFirstName,strMiddleName,strLastName);


                selectVol = hVol.hSelectVolunteer(insertVol.VolID);

                Assert.AreEqual(insertVol.VolFirstName, selectVol.VolFirstName);
                Assert.AreEqual(insertVol.VolMiddleName, selectVol.VolMiddleName);
                Assert.AreEqual(insertVol.VolLastName, selectVol.VolLastName);

                Console.WriteLine(insertVol.VolID);
                System.Diagnostics.Debug.Write(insertVol.VolID);
            }



        }

        [TestMethod]
        public void TestVolunteer()
        {

            DataTable dt = new DataTable();
            cExcel _cExcel = new cExcel();
            string strSheetName = "Volunteer";

            dt = _cExcel.ReadExcelFile(strSheetName, CWorkbook);

            // listVolunteers()

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {

                string strFirstName = row["FirstName"].ToString();
                string strMiddleName = row["MiddleName"].ToString();
                string strLastName = row["LastName"].ToString();

                sp_Volunteer_DM insertVol = new sp_Volunteer_DM();
                sp_Volunteer_DM selectVol = new sp_Volunteer_DM();

                hVolunteer hVol = new hVolunteer();
                insertVol = hVol.hCreateVolunteer(strFirstName, strMiddleName, strLastName);

                selectVol = hVol.hSelectVolunteer(insertVol.VolID);

                Assert.AreEqual(insertVol.VolFirstName, selectVol.VolFirstName);
                Assert.AreEqual(insertVol.VolMiddleName, selectVol.VolMiddleName);
                Assert.AreEqual(insertVol.VolLastName, selectVol.VolLastName);

                hVol.hUpdateVolunteer(insertVol, "testFirst", "testMiddle", "testLast");
                selectVol = hVol.hSelectVolunteer(insertVol.VolID);

                Assert.AreEqual(selectVol.VolFirstName,"testFirst");
                Assert.AreEqual(selectVol.VolMiddleName,"testMiddle");
                Assert.AreEqual(selectVol.VolLastName,"testLast");

                hVol.hDeleteVolunteer(insertVol);
                selectVol = hVol.hSelectVolunteer(insertVol.VolID);

                Assert.AreEqual(selectVol.ActiveFlg, false);

            }
        }

        [TestMethod]
        public void TestVolPhone()
        {

            DataTable dt = new DataTable();
            cExcel _cExcel = new cExcel();
            string strSheetName = "VolPhone";

            dt = _cExcel.ReadExcelFile(strSheetName, CWorkbook);

            // listVolPhones()

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {

                string strFirstName = row["FirstName"].ToString();
                string strMiddleName = row["MiddleName"].ToString();
                string strLastName = row["LastName"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();

                sp_Volunteer_DM testVol = new sp_Volunteer_DM();
                sp_Phone_DM insertPhone = new sp_Phone_DM();
                sp_Phone_DM selectPhone = new sp_Phone_DM();

                hVolunteer hVol = new hVolunteer();
                testVol = hVol.hCreateVolunteer(strFirstName, strMiddleName, strLastName);

                hVolPhone hPhone = new hVolPhone();
                insertPhone = hPhone.hCreateVolPhone(phoneNumber, testVol.VolID);

                selectPhone = hPhone.hSelectVolPhone(insertPhone.PhoneID);

                Assert.AreEqual(insertPhone.PhoneNbr, selectPhone.PhoneNbr);

                hPhone.hUpdateVolPhone(insertPhone, "3335557777");
                selectPhone = hPhone.hSelectVolPhone(insertPhone.PhoneID);

                Assert.AreEqual(selectPhone.PhoneNbr, "3335557777");

                hPhone.hDeleteVolPhone(insertPhone);
                selectPhone = hPhone.hSelectVolPhone(insertPhone.PhoneID);

                Assert.AreEqual(selectPhone.ActiveFlg, false);

                hVol.hDeleteVolunteer(testVol);

            }
        }

        [TestMethod]
        public void TestVolEmail()
        {

            DataTable dt = new DataTable();
            cExcel _cExcel = new cExcel();
            string strSheetName = "VolEmail";

            dt = _cExcel.ReadExcelFile(strSheetName, CWorkbook);

            // listVolEmails()

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {

                string strFirstName = row["FirstName"].ToString();
                string strMiddleName = row["MiddleName"].ToString();
                string strLastName = row["LastName"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                sp_Volunteer_DM testVol = new sp_Volunteer_DM();
                sp_Email_DM insertEmail = new sp_Email_DM();
                sp_Email_DM selectEmail = new sp_Email_DM();

                hVolunteer hVol = new hVolunteer();
                testVol = hVol.hCreateVolunteer(strFirstName, strMiddleName, strLastName);

                hVolEmail hEmail = new hVolEmail();
                insertEmail = hEmail.hCreateVolEmail(emailAddress, testVol.VolID);

                selectEmail = hEmail.hSelectVolEmail(insertEmail.EmailID);

                Assert.AreEqual(insertEmail.EmailAddr, selectEmail.EmailAddr);

                hEmail.hUpdateVolEmail(insertEmail, "testing@tes.test");
                selectEmail = hEmail.hSelectVolEmail(insertEmail.EmailID);

                Assert.AreEqual(selectEmail.EmailAddr, "testing@tes.test");

                hEmail.hDeleteVolEmail(insertEmail);
                selectEmail = hEmail.hSelectVolEmail(insertEmail.EmailID);

                Assert.AreEqual(selectEmail.ActiveFlg, false);

                hVol.hDeleteVolunteer(testVol);

            }
        }

    }
}
