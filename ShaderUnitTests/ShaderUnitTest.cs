using System.IO;
using Engine3D.Data.Shaders;
using Engine3D.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShaderUnitTests
{
	namespace ShaderUnitTest
	{
		[TestClass]
		public class ShaderConstructTests
		{
			private string _verShaderPath;
			private string _fragShaderPath;
			[TestInitialize]
			public void SetUp()
			{
				_verShaderPath = FileDataManagment.MainVerShaderPath;
				_fragShaderPath = FileDataManagment.MainFragShaderPath;
			}
			[TestMethod]
			public void ShaderConstructor_VerShaderMissing_FileNotFoundException()
			{
				Assert.ThrowsException<FileNotFoundException>(
					() => new Shader("", "")
				);
			}
			[TestMethod]
			public void ShaderConstructor_FragShaderMissing_FileNotFoundException()
			{

				Assert.ThrowsException<FileNotFoundException>(
					() => new Shader(_verShaderPath, "")
				);
			}
			[TestMethod]
			public void ShaderConstructor_Success_ShaderCreated()
			{
				NUnit.Framework.Assert.DoesNotThrow(
				() => new Shader(_verShaderPath, _fragShaderPath)
				);
			}

		}
	}

}
