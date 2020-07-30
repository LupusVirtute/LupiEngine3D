using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D.Exceptions.Shaders
{
    public class ProgramNotFoundException : Exception
    {
	    public ProgramNotFoundException() : base("Given ID isn't a Shader Program")
	    {

	    }
        
    }
}
