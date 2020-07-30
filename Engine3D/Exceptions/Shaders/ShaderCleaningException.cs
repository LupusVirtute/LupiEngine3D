using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D.Exceptions.Shaders
{
    public class ShaderCleaningException : Exception
    {
	    public ShaderCleaningException() : base("Can't clean shaders they don't exist")
	    {

	    }
    }
}
