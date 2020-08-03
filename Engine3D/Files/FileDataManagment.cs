using System;
namespace Engine3D.Files
{
    public static class FileDataManagment
    {
	    private static String _mainVerShaderPath = "../Shaders/MainShader/verShader.vert";
	    private static String _mainFragShaderPath = "../Shaders/MainShader/fragShader.frag";
	    public static String MainVerShaderPath => _mainVerShaderPath;
	    public static String MainFragShaderPath => _mainFragShaderPath;
    }
}
