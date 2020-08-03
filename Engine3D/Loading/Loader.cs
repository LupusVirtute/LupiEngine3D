using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D.Loading
{
    public abstract class Loader : ILoader
    {
	    public void Load(string filePath)
	    {
		    StreamReader file = new StreamReader(filePath);
		    Load(file);
	    }

	    public abstract void Load(StreamReader file);
	    public abstract float GetLoadPercentage();
	    public abstract int GetLoadedObjectsNumber();
	    public abstract int GetObjectsNeededToLoad();
    }
}
