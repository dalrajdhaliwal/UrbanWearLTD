using Class_Library;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<Class_Library.clsStaff> TestList = new List<Class_Library.clsStaff>();
            Class_Library.clsStaff TestItem = new Class_Library.clsStaff();



            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true;


            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);

        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Class_Library.clsStaff TestStaff = new Class_Library.clsStaff();

            TestStaff.StaffFirstName = "Kim";
            TestStaff.StaffLastName = "Amir";
            TestStaff.ContactNumber = "07876547";
            TestStaff.NINumber = "987654456.";
            TestStaff.TaxCode = "P65.";
            TestStaff.DateStarted = DateTime.Now.Date;
            TestStaff.DateEnded = DateTime.Now.Date;
            TestStaff.Salary = Convert.ToDecimal("1266.00");
            TestStaff.Shift = true;

            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<Class_Library.clsStaff> TestList = new List<Class_Library.clsStaff>();
            Class_Library.clsStaff TestItem = new Class_Library.clsStaff();


            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true;

            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Class_Library.clsStaff TestItem = new Class_Library.clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true; ;

            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Class_Library.clsStaff TestItem = new Class_Library.clsStaff();
            Int32 PrimaryKey = 0;


            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true; ;

            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Class_Library.clsStaff TestItem = new Class_Library.clsStaff();
            Int32 PrimaryKey = 0;


            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true; ;


            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffFirstName = "Kim";
            TestItem.StaffLastName = "Amir";
            TestItem.ContactNumber = "07876547";
            TestItem.NINumber = "987654456.";
            TestItem.TaxCode = "P65.";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");
            TestItem.Shift = true; ;


            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByName("");
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByName("Bob");
            Assert.AreEqual(0, FilteredStaffs.Count);

        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaffs.ReportByName("kim");

            if (FilteredStaffs.Count == 200)
            {
                if (FilteredStaffs.StaffList[0].StaffNo != 36)
                {
                    OK = false;
                }
                if (FilteredStaffs.StaffList[1].StaffNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }



    }
}


