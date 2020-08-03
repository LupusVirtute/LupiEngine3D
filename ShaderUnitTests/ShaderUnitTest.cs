using System;
using System.IO;
using Engine3D.Data.Shaders;
using Engine3D.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Graphics.OpenGL4;

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
				ShaderSource[] sources = new ShaderSource[]
				{
					new ShaderSource(
						"#version 450\n" +
						"void main(){\n" +
						"}\0"
						,
						ShaderType.FragmentShader
					),
					new ShaderSource(
						"#version 450\n" +
						"void main(){\n" +
						"}\0"
						,
						ShaderType.VertexShader
					), 
				};
				try
				{
					Shader shader = new Shader(sources);
				}
				catch (Exception ex)
				{
					Assert.Fail();
				}
			}

		}
	}

}
