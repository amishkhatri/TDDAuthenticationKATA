using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TDDAuthenticationSprint.Search;

namespace NUnitTDDAuthenticationKATA
{
    [TestFixture]
    public class CitySearchTest
    {

        [OneTimeSetUp]
        public void Setup()
        {

        }

        [Test]
        public void ReturnSuccess_WhenNoCityFound()
        {

            // Assign
            CitySearch citySearch = new CitySearch();

            // Act
            var result = citySearch.Search("test");

            // Assert
            Assert.AreEqual(0, result.Count);

        }


        [Test]
        public void ReturnSuccess_WhenFoundCity()
        {
            // Assign
            CitySearch citySearch = new CitySearch();

            // Act
            List<string> result = citySearch.Search("umb");

            // Assert
            Assert.AreEqual("Mumbai", result[0]);

        }

        [Test]
        public void ReturnSuccess_WhenFoundCityWithInsensitiveCase()
        {
            // Assign
            CitySearch citySearch = new CitySearch();

            // Act
            List<string> result = citySearch.Search("une");

            // Assert
            Assert.AreEqual("Pune", result[0]);

        }

        [Test]
        public void ReturnSuccess_WhenFoundCityWithMulitpleResult()
        {
            // Assign
            CitySearch citySearch = new CitySearch();


            // Act
            List<string> result = citySearch.Search("elh");


            // Assert
             Assert.AreEqual(2, result.Count);


        }

        [Test]
        public void ReturnSuccess_WhenShortQuery()
        {
            // Assign
            CitySearch citySearch = new CitySearch();


            // Act 
            List<string> result = citySearch.Search("um");

                
            // Assert
            Assert.AreEqual(0, result.Count);


        }

        [OneTimeTearDown]
        public void Remove()
        {

        }


    }
}
