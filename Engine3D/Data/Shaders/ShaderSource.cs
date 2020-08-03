using System;
using System.IO;
using OpenTK.Graphics.OpenGL4;

namespace Engine3D.Data.Shaders
{
    public struct ShaderSource
    {
	    private string _source;
	    private ShaderType _shaderType;

	    public string Source
	    {
		    get => _source;
	    }

	    public ShaderType type
	    {
		    get => _shaderType;
	    }
	    public ShaderSource(string source,ShaderType type)
	    {
		    _source = source;
		    _shaderType = type;
	    }

	    public static ShaderSource LoadSourceFromFile(string path,ShaderType type)
	    {
			return new ShaderSource(new StreamReader(path).ReadToEnd(), type);
	    }
    }
}
