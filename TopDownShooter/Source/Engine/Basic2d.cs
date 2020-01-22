#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace TopDownShooter
{
    public class Basic2d
    {

        public Vector2 pos, dimensions;
        public Texture2D model;

        public Basic2d(string path, Vector2 pos, Vector2 dimensions)
        {
            this.pos = pos;
            this.dimensions = dimensions;

            model = Globals.content.Load<Texture2D>(path);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            if (model != null)
            {
                Globals.spriteBatch.Draw(model, new Rectangle((int)pos.X, (int)pos.Y, (int)dimensions.X, (int)dimensions.Y), null, Color.White, 0.0f, new Vector2(model.Bounds.Width / 2, model.Bounds.Height / 2), new SpriteEffects(), 0);
            }
        }
    }
}
