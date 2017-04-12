using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	class Droplet
	{
		//Random rnd;
		Vector2 position;

		float time;

		public Droplet()
		{
			//rnd = new Random(1234);
			time = 1000;
		}

		public void Reset()
		{
			//position = new Vector2((float)rnd.NextDouble(), (float)rnd.NextDouble());
			position = new Vector2(0.5f, 0.5f);
			time = 0;
		}

		public void Update(float _dt)
		{
			time += _dt;
		}

		public Vector3 MakeShaderParameter(float aspect)
		{
			return new Vector3(position.X * aspect, position.Y, time);
		}

	}
}
