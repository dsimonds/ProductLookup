using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLookUp;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StoreId()
        {
            Form1 form = new Form1();

            string storeCode = "KLO";
            int storeId = 5;
            int storeLookupId;

            storeLookupId = form.StoreIdLookUp(storeCode);

            if (storeId != storeLookupId)
            {
                Console.WriteLine("Error with StoreIdLookUp function");
            }
        }

    }
}
