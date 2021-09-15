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
        public Weight(int weight)
        {
            _weight = weight;
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
