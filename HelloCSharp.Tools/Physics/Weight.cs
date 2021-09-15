using System;

namespace HelloCSharp.Tools.Physics
{
    /// <summary>
    /// Holds weight expressed in grams.
    /// </summary>
    public struct Weight
    {
        /// <summary>
        /// Wright in grams.
        /// </summary>
        private int _weight;

        /// <summary>
        /// Creates weight based on value expressed in grams.
        /// </summary>
        /// <param name="weight">Grams.</param>
        private Weight(int weight)
        {
            _weight = weight;
        }

        public static Weight FromGrams(int grams)
        {
            return new Weight(grams);
        }

        public static Weight FromKilograms(int kilograms)
        {
            return new Weight(kilograms * 1000);
        }

        public static Weight FromMilligrams(int milligrams)
        {
            return new Weight((int)(milligrams * 0.001));
        }

        public int GetGrams()
        {
            return _weight;
        }

		public void AddGrams(int delta)
		{
            _weight += delta;
		}
	}
}
