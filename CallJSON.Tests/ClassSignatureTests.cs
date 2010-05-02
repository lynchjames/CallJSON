using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CallJSON.Core;
using LitJson;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CallJSON.Tests
{
    [TestFixture]
    public class ClassSignatureTests : TestBase
    {
        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Manager Manager { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string JobTitle { get; set; }
            public List<Address> Addresses { get; set; }
        }

        public class Manager
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string JobTitle { get; set; }
            public Address Address { get; set; }
        }

        public class Address
        {
            public string PostCode { get; set; }
            public int HouseNumber { get; set; }
            public string HouseName { get; set; }
            public string City { get; set; }
        }

        [Test]
        public void Match_Similar_Class_Signatures()
        {
            var address1 = new Address()
                              {
                                  City = "Edinburgh",
                                  HouseName = "The Manor",
                                  HouseNumber = 136,
                                  PostCode = "EH3 5AS"
                              };
            var address2 = new Address()
            {
                City = "Edinburgh",
                HouseName = "The Dump",
                HouseNumber = 666,
                PostCode = "EH3 1GH"
            };
            var user = new User()
                           {
                               DateOfBirth = DateTime.Now.AddYears(-25),
                               FirstName = "John",
                               LastName = "Smith",
                               JobTitle = "Administrator",
                               Addresses = new List<Address>(){address1,address2}
                           };
            user.Manager = new Manager()
                               {
                                   DateOfBirth = DateTime.Now.AddYears(-40),
                                   FirstName = "Sam",
                                   LastName = "Taylor",
                                   JobTitle = "Line Manager",
                                   Address = address1
                               };
            var json = JsonConvert.SerializeObject(user);
            var deserializedData = JsonMapper.ToObject(json);
            var crawler = new JsonDataCrawler(deserializedData, "User");
            var signatures = crawler.Crawl();
            //Assert.AreEqual(signatures.Count, 3);
            Debug.Write(signatures.ToString());
        }
    }
}
