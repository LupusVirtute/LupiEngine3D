using System;
using OpenTK;

namespace Engine3D.Data
{
	public struct Vertex
	{
		public Vertex(Vector3 position, Vector3 normal, Vector2 texCoords)
		{
			_position = position;
			_normal = normal;
			_texCoords = texCoords;
		}

		private Vector3 _position;
		private Vector3 _normal;
		private Vector2 _texCoords;

		public Vector3 Normal
		{
			get => _normal;
			set => _normal = value;
		}

		public Vector3 Position
		{
			get => _position;
			set => _position = value;
		}

		public Vector2 TexCoord
		{
			get => _texCoords;
			set => _texCoords = value;
		}
	}
}