using System.IO;
using Engine3D.Data.Shaders;
using NUnit.Framework;
using Engine3D.Files;
using Assert = NUnit.Framework.Assert;

namespace ShaderUnitTests
{
	namespace ShaderUnitTest
	{
		public class ShaderConstructTests
		{
			private string _verShaderPath;
			private string _fragShaderPath;
			[SetUp]
			public void SetUp()
			{
				_verShaderPath = FileDataManagment.MainVerShaderPath;
				_fragShaderPath = FileDataManagment.MainFragShaderPath;
			}
			[Test]
			public void ShaderConstructor_VerShaderMissing_FileNotFoundException()
			{
				Assert.Throws<FileNotFoundException>(
					() => new Shader("", "")
				);
			}
			[Test]
			public void ShaderConstructor_FragShaderMissing_FileNotFoundException()
			{


				Assert.Throws<FileNotFoundException>(
					() => new Shader(_verShaderPath, "")
				);
			}
			[Test]
			public void ShaderConstructor_Success_ShaderCreated()
			{
				Assert.DoesNotThrow(
					() => new Shader(_verShaderPath, _fragShaderPath)
				);
			}

		}
	}

}
