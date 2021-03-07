using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBaseN
{
    class Component
    {
        public Component nextComponent;

        public string nameOfComponent;

        public bool isActive;

        public Component()
        {
            nextComponent = null;
            isActive = true;
        }


        public virtual void Update(GameTime gameTime, Entity currentEntity)
        {


        }

        public virtual void Draw(GameTime gameTime, Entity currentEntity, SpriteBatch spriteBatch)
        {


        }

    }
}
