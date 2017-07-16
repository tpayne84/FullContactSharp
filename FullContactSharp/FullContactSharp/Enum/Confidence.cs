namespace FullContactSharp
{
	/// <summary>
	/// Required accuracy Confidence.
	/// </summary>
	public enum Confidence
	{
		/// <summary>
		/// No restrictions.
		/// </summary>
		None = 0,

        /// <summary>
		/// Returns reults with a minumum confidence level of 'Low' and greater.
		/// </summary>
		Low = 1,

		/// <summary>
		/// Returns reults with a minumum confidence level of 'Medium' and greater.
		/// </summary>
		Medium = 2,

		/// <summary>
		/// Returns reults with a minumum confidence level of 'High' and greater.
		/// </summary>
		High = 3,

		/// <summary>
		/// Returns reults with a minumum confidence level of 'Max' and greater.
		/// </summary>
		Max = 4
	}
}
