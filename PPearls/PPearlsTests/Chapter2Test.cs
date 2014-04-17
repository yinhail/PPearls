// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Chapter2Test.cs" company="">
//   
// </copyright>
// <summary>
//   This is a test class for Chapter2Test and is intended
//   to contain all Chapter2Test Unit Tests
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PPearlsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using PPearls;

    /// <summary>
    /// This is a test class for Chapter2Test and is intended
    /// to contain all Chapter2Test Unit Tests
    /// </summary>
    [TestClass]
    public class Chapter2Test
    {
        #region Fields

        /// <summary>
        /// The test context instance.
        /// </summary>
        private TestContext testContextInstance;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return this.testContextInstance;
            }

            set
            {
                this.testContextInstance = value;
            }
        }

        #endregion

        // You can use the following additional attributes as you write your tests:
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext)
        // {
        // }
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup()
        // {
        // }
        // Use TestInitialize to run code before running each test
        // [TestInitialize()]
        // public void MyTestInitialize()
        // {
        // }
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup()
        // {
        // }
        #region Public Methods and Operators

        /// <summary>
        /// The not primer.
        /// </summary>
        [TestMethod]
        public void NotPrimer()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd' };

            Chapter2.shift(str, 2);

            Assert.AreEqual("cdab", new string(str));
        }

        /// <summary>
        /// A test for shift
        /// </summary>
        [TestMethod]
        public void Primer()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd', 'e' };

            Chapter2.shift(str, 3);

            Assert.AreEqual("cdeab", new string(str));
        }

        /// <summary>
        /// The shift by bigger than length.
        /// </summary>
        [TestMethod]
        public void ShiftByBiggerThanLength()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd', 'e' };

            Chapter2.shift(str, 37);

            Assert.AreEqual("deabc", new string(str));
        }

        /// <summary>
        /// The shift by negative.
        /// </summary>
        [TestMethod]
        public void ShiftByNegative()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd' };

            Chapter2.shift(str, -7);

            Assert.AreEqual("dabc", new string(str));
        }

        /// <summary>
        /// The shift by zero.
        /// </summary>
        [TestMethod]
        public void ShiftByZero()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd' };

            Chapter2.shift(str, 0);

            Assert.AreEqual("abcd", new string(str));
        }

        #endregion
    }
}