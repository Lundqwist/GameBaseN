using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna;

namespace GameBaseN
{
    class Entity
    {

        public int uniqueId;
        public bool isActive;
        public bool hasCollider;
        public string nameOfEntity;

        public Entity nextEntity;

        public Component firstComponent;

        public Rectangle collisionBox;

        #region unusedImageData
        //public int textureId;
        //private bool isAnimated;
        //private int numberOfFrames;
        //private int currentFrameNumber;
        //private Rectangle currentFrame;
        //private int animationSpeed;

        //private int animationTimer;

        #endregion

        public Vector2 position;

        public Entity(string nameOfEntity)
        {
            uniqueId = 0;
            isActive = true;
            this.nameOfEntity = nameOfEntity;

            firstComponent = null;

            nextEntity = null;
            hasCollider = false;

            //isAnimated = false;
            //numberOfFrames = 0;
            //currentFrameNumber = 0;
            
            position = Vector2.Zero;
            Tools.Debugging.Show(this.GetType().ToString());
        }

        //public virtual void AddImage(string imageName, string filePath, int imageWidth, int imageHeight, int animationSpeed = 0, int numberOfFrames = 1)
        //{
        //    textureId = ImageManager.AddImage(imageName, filePath);
        //    collisionBox.Width = imageWidth;
        //    collisionBox.Height = imageHeight;
        //    this.animationSpeed = animationSpeed;
        //    animationTimer = animationSpeed;


        //    currentFrame.Width = imageWidth;
        //    currentFrame.Height = imageHeight;
        //    currentFrame.X = 0;
        //    currentFrame.Y = 0;

        //    if(numberOfFrames != 1)
        //    {
        //        isAnimated = true;
        //        this.numberOfFrames = numberOfFrames;

        //    }
        
        
        //}

        public virtual void HasCollidedWith(Entity collidedWithEntity)
        {


        }


        public virtual void Update(GameTime gameTime)
        {
            Tools.Debugging.Show(this.GetType().ToString());

            if (firstComponent != null)
            {
                firstComponent.Update(gameTime, this);
            }


        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            //if (!isAnimated)
            //{
            //    spriteBatch.Draw(ImageManager.GetImageWithId(textureId), position, Color.White);

            //}
            //else
            //{
            //    animationTimer += gameTime.ElapsedGameTime.Milliseconds;
            //    currentFrame.X = currentFrameNumber * currentFrame.Width;
            //    spriteBatch.Draw(ImageManager.GetImageWithId(textureId), position, currentFrame, Color.White);

            //    if (animationTimer > animationSpeed)
            //    {

            //        animationTimer = 0;
            //        currentFrameNumber++;
            //        currentFrameNumber = currentFrameNumber % numberOfFrames;

            //    }

            //}

        }

    }
}
