using Engine3D.Exceptions.Shaders;
using OpenTK.Graphics.OpenGL4;
using System;
using System.IO;
using System.Threading;

namespace Engine3D.Data.Shaders
{
	public class Shader : IShader
	{
		
		private int _ID  = -1;
		private string vertexShaderSource;
		private string fragShaderSource;
		private bool disposed = false;
		/// <summary>
		/// ID of shader Program
		/// </summary>
		public int ID
		{
			get => _ID;
		}
		/// <summary>
		/// Constructs a new Shader to use with 3D Objects
		/// </summary>
		/// <param name="verShaderPath"></param>
		/// <param name="fragShaderPath"></param>
		public Shader(string verShaderPath, string fragShaderPath)
		{
			if (!File.Exists(verShaderPath))
			{
				throw new FileNotFoundException("Vertex Shader File wasn't found");
			}
			using (StreamReader reader = new StreamReader(verShaderPath))
			{
				vertexShaderSource = reader.ReadToEnd();
			}

			if (!File.Exists(fragShaderPath))
			{
				throw new FileNotFoundException("Fragment Shader File wasn't found");
			}
			using (StreamReader reader = new StreamReader(fragShaderPath))
			{
				fragShaderSource = reader.ReadToEnd();
			}
			_ID = GL.CreateProgram();
			CompileShaders();
		}

		~Shader()
		{
			if (_ID != -1)
			{
				GL.DeleteProgram(_ID);
				
			}
		}
		/// <summary>
		/// Uses a Shader program
		/// </summary>
		public void Use()
		{
			if (_ID != -1)
				GL.UseProgram(_ID);
			else
				throw new ProgramNotFoundException();
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		public void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					GL.DeleteProgram(_ID);

					disposed = true;
				}	
			}
		}
		/// <summary>
		/// Compiles Shader with given ID
		/// </summary>
		/// <param name="shaderID"></param>
		/// <exception cref="ShaderCompilationException">It's thrown when shader is unable to compile</exception>
		private void CompileShader(int shaderID)
		{
			GL.CompileShader(shaderID);
			string shaderInfo = GL.GetShaderInfoLog(shaderID);
			if (shaderInfo != String.Empty)
				throw new ShaderCompilationException(shaderInfo);
		}

		/// <summary>
		/// Cleans up mess from the shader compilation into program
		/// </summary>
		/// <param name="vertexShader"></param>
		/// <param name="fragShader"></param>
		private void ShaderCleanup(int vertexShader, int fragShader)
		{
			if (!GL.IsProgram(_ID))
			{
				throw new ProgramNotFoundException();
			}
			if (!GL.IsShader(vertexShader) && !GL.IsShader(fragShader))
			{
				throw new ShaderCleaningException();
			}

			GL.DetachShader(_ID, vertexShader);
			GL.DetachShader(_ID, fragShader);
			GL.DeleteShader(fragShader);
			GL.DeleteShader(vertexShader);
		}
		/// <summary>
		/// Compiles Shaders use only if source is known
		/// </summary>
		private void CompileShaders()
		{
			if (vertexShaderSource == String.Empty || fragShaderSource == String.Empty)
				throw new ShaderSourceNullException();

			int vertexShader = GL.CreateShader(ShaderType.VertexShader);
			int fragShader = GL.CreateShader(ShaderType.FragmentShader);

			GL.ShaderSource(vertexShader, vertexShaderSource);
			GL.ShaderSource(fragShader, fragShaderSource);

			CompileShader(vertexShader);
			CompileShader(fragShader);

			GL.AttachShader(_ID, vertexShader);
			GL.AttachShader(_ID, fragShader);

			GL.LinkProgram(_ID);
			ShaderCleanup(vertexShader,fragShader);
		}
#if DEBUG
		public void ReCompileShaders(string verShaderPath,string fragShaderPath)
		{
			GL.DeleteProgram(_ID);
			_ID = -1;
			_ID = GL.CreateProgram();
			CompileShaders();
		}

#endif
	}
}