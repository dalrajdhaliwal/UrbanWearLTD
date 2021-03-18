using System;

using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;





namespace Testing2

{

    [TestClass]

    public class tstStock

    {

        //Good test data

        // create some test data to pass to the method

        string GameId = "3";

        string GameTitle = "A Game Title";

        string GameDescription = "A Game Description";

        string Price = "60";

        string ReleaseDate = DateTime.Now.Date.ToString();

        string StockQuantity = "1000";





        [TestMethod]

        public void InstanceOK()

        {

            clsStock AStock = new clsStock();

            Assert.IsNotNull(AStock);

        }





        [TestMethod]

        public void GameIdOK()

        {

            clsStock AStock = new clsStock();

            int TestData = 1;

            AStock.GameId = TestData;

            Assert.AreEqual(AStock.GameId, TestData);

        }





        [TestMethod]

        public void GameTitleOK()

        {

            clsStock AStock = new clsStock();

            string TestData = "A Game Title";

            AStock.GameTitle = TestData;

            Assert.AreEqual(AStock.GameTitle, TestData);

        }





        [TestMethod]

        public void InStockOK()

        {

            clsStock AStock = new clsStock();

            Boolean TestData = true;

            AStock.InStock = TestData;

            Assert.AreEqual(AStock.InStock, TestData);

        }





        [TestMethod]

        public void ReleaseDateOK()

        {

            clsStock AStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AStock.ReleaseDate = TestData;

            Assert.AreEqual(AStock.ReleaseDate, TestData);

        }





        [TestMethod]

        public void PriceOK()

        {

            clsStock AStock = new clsStock();

            decimal TestData = 60;

            AStock.Price = TestData;

            Assert.AreEqual(AStock.Price, TestData);

        }





        [TestMethod]

        public void StockQuantityOK()

        {

            clsStock AStock = new clsStock();

            Int32 TestData = 1000;

            AStock.StockQuantity = TestData;

            Assert.AreEqual(AStock.StockQuantity, TestData);

        }





        [TestMethod]

        public void GameDescriptionOK()

        {

            clsStock AStock = new clsStock();

            string TestData = "A description of the game is that it is a game";

            AStock.GameDescription = TestData;

            Assert.AreEqual(AStock.GameDescription, TestData);

        }





        [TestMethod]

        public void ValidMethodOK()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMinLessOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "a";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMinPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "aa";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMaxLessOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            GameTitle = GameTitle.PadLeft(49, '*');

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            GameTitle = GameTitle.PadLeft(50, '*');

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMaxPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            GameTitle = GameTitle.PadLeft(51, '*');

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleMid()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            GameTitle = GameTitle.PadLeft(25, '*');

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");

        }





        [TestMethod]

        public void GameTitleExtremeMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameTitle = "";

            GameTitle = GameTitle.PadLeft(1000, '*');

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }





        [TestMethod]

        public void ReleaseDateExtremeMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateMinMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-50).AddDays(-1);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-50);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateMinPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-50).AddDays(1);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(10);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateExtremeMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            String ReleaseDate = TestDate.ToString();

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void ReleaseDateInvalidData()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String ReleaseDate = "this is not a date!";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMinMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            GameDescription = "a";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMinPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            GameDescription = "aa";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMaxMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            GameDescription = GameDescription.PadLeft(char.MaxValue - 1, 'a'); ;

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            GameDescription = GameDescription.PadLeft(char.MaxValue, 'a'); ;

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void GameDescriptionMaxPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            string GameDescription = "";

            GameDescription = GameDescription.PadLeft(char.MaxValue + 1, 'a'); ;

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void PriceInvalidData()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String Price = "Owen";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void PriceExtremeMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String Price = "-10000000";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void PriceMinMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String Price = "-0.01";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void PriceMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String Price = "0.00";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void PriceMinPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String Price = "0.01";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityExtremeMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "-1000000";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMinMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "-1";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMin()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "0";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMinPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "1";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMaxMinusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "2147483646";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMax()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "2147483647";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityMaxPlusOne()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "2147483648";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void StockQuantityInvalidData()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String StockQuantity = "Owen";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }





        [TestMethod]

        public void GameIdInvalidData()

        {

            clsStock AStock = new clsStock();

            string Error = "";

            String GameId = "Owen";

            Error = AStock.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

            Assert.AreNotEqual(Error, "");





        }


      


    





    }}

