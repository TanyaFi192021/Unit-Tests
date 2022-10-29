using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RegistrationLibrary;

namespace ResistrationLibraryTests
{
    [TestClass]
    public class PasswordChekerTests
    {
        [TestMethod]
        public void GetPasswordStrength_AllCahrs_5Points()
        {
            // arrange
            string password = "P2ssw0rd#";
            int expected = 5;

            // act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            // Arrange
            string password = "Password";
            int expected = 3; 

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_0_4Points()
        {
            // Arrange
            string password = "Passw0rd";
            int expected = 4;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_1_4Points()
        {
            // Arrange
            string password = "Passw1rd";
            int expected = 4;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }



        // Tests for special chars

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_at_5Points()
        {
            // Arrange
            string password = "Passw0rd@";
            int expected = 5;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Hash_5Points()
        {
            // Arrange
            string password = "Passw0rd#";
            int expected = 5;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Excl_5Points()
        {
            // Arrange
            string password = "Passw0rd!";
            int expected = 5;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Doll_5Points()
        {
            // Arrange
            string password = "Passw0rd$";
            int expected = 5;

            // Act
            int actual = PasswordCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
