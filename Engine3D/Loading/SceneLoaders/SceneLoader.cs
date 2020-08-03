using System.IO;
using OpenTK.Graphics.ES11;

namespace Engine3D.Loading.SceneLoaders
{
    public class SceneLoader : Loader
    {
	    public override void Load(StreamReader file)
	    {
		    using (file)
		    {
			    
		    }
	    }

	    public override float GetLoadPercentage()
	    {
		    throw new System.NotImplementedException();
	    }

	    public override int GetLoadedObjectsNumber()
	    {
		    throw new System.NotImplementedException();
	    }

	    public override int GetObjectsNeededToLoad()
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
