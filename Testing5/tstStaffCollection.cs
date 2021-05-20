using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_
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
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();



            TestItem.Name = "Kim";
            TestItem.Surname = "Amir";
            TestItem.Address = "2b Cross Streey";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");

            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);

        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.Name = "Kim";
            TestStaff.Surname = "Amir";
            TestStaff.Address = "2b Cross Streey";
            TestStaff.DateStarted = DateTime.Now.Date;
            TestStaff.DateEnded = DateTime.Now.Date;
            TestStaff.Salary = Convert.ToDecimal("1266.00");

            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();


            TestItem.Name = "Kim";
            TestItem.Surname = "Amir";
            TestItem.Address = "2b Cross Streey";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");

            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.Name = "Kim";
            TestItem.Surname = "Amir";
            TestItem.Address = "2b Cross Streey";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");

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
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;


            TestItem.Name = "Kim";
            TestItem.Surname = "Amir";
            TestItem.Address = "2b Cross Streey";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");

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
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;


            TestItem.Name = "Kim";
            TestItem.Surname = "Amir";
            TestItem.Address = "2b Cross Streey";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1266.00");

            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffNo = PrimaryKey;
            TestItem.Name = "Kimea";
            TestItem.Surname = "Amirk";
            TestItem.Address = "3b Cross Street";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.DateEnded = DateTime.Now.Date;
            TestItem.Salary = Convert.ToDecimal("1566.00");

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

