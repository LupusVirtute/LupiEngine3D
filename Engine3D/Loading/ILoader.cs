using System.IO;

namespace Engine3D.Loading
{
	public interface ILoader
	{
		void Load(string filePath);
		/// <summary>
		/// Loads file into game memory
		/// </summary>
		/// <param name="file">StreamReader of File</param>
		void Load(StreamReader file);
		/// <summary>
		/// Gets Percentage of this Loader
		/// </summary>
		/// <returns>Percentage of loaded objects</returns>
		float GetLoadPercentage();
		/// <summary>
		/// Gets Number of objects alerady loaded
		/// </summary>
		/// <returns>Loaded objects</returns>
		int GetLoadedObjectsNumber();
		/// <summary>
		/// Gets maximum number of objects that program needs to load
		/// </summary>
		/// <returns>Number of all of objects that needs to load</returns>
		int GetObjectsNeededToLoad();
	}
}
