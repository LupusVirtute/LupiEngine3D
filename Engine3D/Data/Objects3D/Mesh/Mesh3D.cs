using System;
using System.Collections.Generic;
using Engine3D.Data.Shaders;
using Engine3D.Data.Textures;
using OpenTK.Graphics.OpenGL4;

namespace Engine3D.Data.Objects3D.Mesh
{
	public class Mesh3D : IMesh3D
	{
		private readonly List<Vertex> vertices;
		private List<uint> indices;
		private List<Texture> textures;
		private int _vertexArray;
		private bool disposed = false;
		public Mesh3D(Vertex[] vertices, uint[] indices, List<Texture> textures)
		{
			this.vertices = new List<Vertex>(vertices);
			this.indices = new List<uint>(indices);
		}

		private void InitVBOAndVAO()
		{
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
					// TODO Disposing the 3D Mesh
					disposed = true;
				}
			}
		}
		public void Draw(IShader shader)
		{
			throw new NotImplementedException();
		}

		public void Draw()
		{

		}
	}
}