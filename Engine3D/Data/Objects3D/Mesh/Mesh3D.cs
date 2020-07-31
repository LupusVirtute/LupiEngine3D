using System;
using System.Collections.Generic;
using Engine3D.Data.Shaders;
using Engine3D.Data.Textures;
using OpenTK.Graphics.OpenGL4;

namespace Engine3D.Data.Objects3D.Mesh
{
	public class Mesh3D : IMesh3D
	{
		// Disposed value

		private bool disposed = false;

		// Mesh values

		private readonly List<Vertex> vertices;
		private readonly List<uint> indices;
		private bool isElementBuffer;

		// VAO's

		private int _vertexArray;
		
		// VBO's

		private int _vertexBuffer;

		// EBO's

		private int _ElementBufferObject;



		// ODI
		/// <summary>
		/// Stores Info will vertices change
		/// </summary>
		private ObjectDrawingInfo drawingInfo;

		public Mesh3D(Vertex[] vertices, uint[] indices,ObjectDrawingInfo drawingInfo)
		{
			this.vertices = new List<Vertex>(vertices);
			this.indices = new List<uint>(indices);
			this.drawingInfo = drawingInfo;
			
			_vertexBuffer = GL.GenBuffer();

			_vertexArray = GL.GenVertexArray();

			_ElementBufferObject = GL.GenBuffer();
			InitAB();
			if (vertices.Length / indices.Length > 0.1)
				InitEAB();
			if (!isElementBuffer)
			{
				indices = null;
			}

		}
		/// <summary>
		/// Inits Array Buffer
		/// </summary>
		private unsafe void InitAB()
		{
			GL.BindVertexArray(_vertexArray);
			GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBuffer);
			GL.BufferData(BufferTarget.ArrayBuffer,vertices.Count * sizeof(Vertex),vertices.ToArray(),(BufferUsageHint)drawingInfo);
			int stride = 3 * sizeof(float);
			GL.VertexAttribPointer(0,3,VertexAttribPointerType.Float,false,stride,0);
			stride += 3 * sizeof(float);
			GL.VertexAttribPointer(1,3,VertexAttribPointerType.Float,false,stride,0);
			stride += 2 * sizeof(float);
			GL.VertexAttribPointer(2,2,VertexAttribPointerType.Float,false,stride,0);
			GL.EnableVertexAttribArray(0);
		}
		/// <summary>
		/// Inits Element Array Buffer Object
		/// </summary>
		private void InitEAB()
		{
			isElementBuffer = true;
			GL.BindBuffer(BufferTarget.ElementArrayBuffer, _vertexBuffer);
			GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Count * 4, indices.ToArray(), (BufferUsageHint)drawingInfo);
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
					int[] buffers = new int[] {_vertexBuffer, _vertexArray, _ElementBufferObject};
					// TODO Disposing the 3D Mesh
					GL.DeleteBuffers(buffers.Length,buffers);
					disposed = true;
				}
			}
		}
		public void Draw(IShader shader)
		{
			shader.Use();
			Draw();
		}

		public void Draw()
		{
			GL.BindVertexArray(_vertexArray);
			if (isElementBuffer)
				GL.DrawElements(PrimitiveType.Triangles,indices.Count, DrawElementsType.UnsignedInt, 0);
			else
				GL.DrawArrays(PrimitiveType.Triangles,0,3);

		}
	}
}