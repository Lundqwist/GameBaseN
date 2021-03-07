using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBaseN
{
    class Platform:Entity
    {

        public int imageId;


        public Platform():base("Platform")
        {


            // Jag väljer att addera image till klassens konstruktor istället för 
            // att skapa i CreationManager.
            // Detta för att jag kanske vill ha fler bilder i samma klass.

            imageId = ImageManager.AddImage("Platform", "Content/images/Platform.png");
        
        
        
        
        }

        public override void Update(GameTime gameTime)
        {


            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (!isAnimated)
            {
                spriteBatch.Draw(ImageManager.GetImageWithId(textureId), position, Color.White);

            }
            else
            {
                animationTimer += gameTime.ElapsedGameTime.Milliseconds;
                currentFrame.X = currentFrameNumber * currentFrame.Width;
                spriteBatch.Draw(ImageManager.GetImageWithId(textureId), position, currentFrame, Color.White);

                if (animationTimer > animationSpeed)
                {

                    animationTimer = 0;
                    currentFrameNumber++;
                    currentFrameNumber = currentFrameNumber % numberOfFrames;

                }

            }
            base.Draw(gameTime, spriteBatch);
        }

        

    }
}
