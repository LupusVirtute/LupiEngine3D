using System;

namespace Engine3D.Exceptions.Shaders
{
    public class ShaderSourceNullException : Exception
    {
	    public ShaderSourceNullException() : base("Shader source was null")
	    {

	    }
    }
}
