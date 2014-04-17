// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Chapter2.cs" company="">
//   
// </copyright>
// <summary>
//   The chapter 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PPearls
{
    using System;

    /// <summary>
    /// The chapter 2.
    /// </summary>
    internal class Chapter2
    {
        #region Public Methods and Operators

        /// <summary>
        /// Shift the character in 
        /// <seealso cref="str"/>
        /// to the right by n.
        /// </summary>
        /// <param name="str">
        /// string
        /// </param>
        /// <param name="n">
        /// offset.
        /// </param>
        public static void shift(char[] str, int n)
        {
            if (n == 0)
            {
                return;
            }

            int length = str.Length;
            if (n > length)
            {
                n = n % length;
            }

            if (n < 0)
            {
                n = n % length + length;
            }

            int gcd = Gcd(length, n);

            for (int ii = 0; ii < gcd; ii++)
            {
                int jj = ii;
                char tmp = str[jj];
                for (int cc = 0; cc < length / gcd; cc++)
                {
                    var nextTmp = str[next(length, n, jj)];
                    str[next(length, n, jj)] = tmp;
                    tmp = nextTmp;
                    jj = next(length, n, jj);
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The gcd.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        /// <param name="b">
        /// The b.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int Gcd(int a, int b)
        {
            if (a == 0)
                throw  new InvalidOperationException("a");
            if (b == 0)
                throw  new InvalidOperationException("b");
            if (a < b)
            {
                return Gcd(b, a);
            }

            return a % b == 0 ? b : Gcd(b, a % b);
        }

        /// <summary>
        /// The next.
        /// </summary>
        /// <param name="length">
        /// The length.
        /// </param>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <param name="currentIndex">
        /// The current index.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int next(int length, int n, int currentIndex)
        {
            return (currentIndex + n) % length;
        }

        #endregion
    }
}