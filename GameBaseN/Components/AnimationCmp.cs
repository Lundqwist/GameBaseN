using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBaseN
{
    class AnimationCmp:Component
    {
        public int imageNumber;
        public string imageName;

        public int numberOfImages;
        public int frameSpeed;
        private int currentFrame;
        private int currentTime;

        private Rectangle currentFrameRect;

        private int rotation;

        public AnimationCmp(int imageNumber, string imageName)
        {
            this.imageName = imageName;
            this.imageNumber = imageNumber;


            currentFrame = 0;
            currentTime = 0;
            rotation = 0;

            nameOfComponent = "Animation";
        }


        public override void Update(GameTime gameTime, Entity currentEntity)
        {
            currentTime += gameTime.ElapsedGameTime.Milliseconds;

            if(currentTime > frameSpeed)
            {
                currentTime = 0;
                currentFrame++;
                if(currentFrame >= numberOfImages)
                {
                    currentFrame = 0;
                }
            }


            base.Update(gameTime, currentEntity);
        }

        public override void Draw(GameTime gameTime, Entity currentEntity, SpriteBatch spriteBatch)
        {

            currentFrameRect.X = currentFrame * currentFrameRect.Width;
            spriteBatch.Draw(ImageManager.GetImageWithId(textureId), position, currentFrame, Color.White);



            base.Draw(gameTime, currentEntity);
        }

    }
}
