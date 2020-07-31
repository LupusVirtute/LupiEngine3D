using Engine3D.Data.Shaders;
using Engine3D.Files;
using NUnit.Framework;

namespace ShaderUnitTest
{
	public class ShaderUseTest
    {
        Shader shader;
        [SetUp]
        public void SetUp()
		{
            shader = new Shader(FileDataManagment.MainVerShaderPath,FileDataManagment.MainFragShaderPath);   
		}
    }
}
