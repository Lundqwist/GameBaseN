using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GameBaseN
{
    static class CreationManager
    {

        static string contentPath;
        static public void Initialize(GraphicsDevice gameGraphicsDevice)
        {
            AddTestEntity();
            AddTestAnimatedEntity();
        }

        static public void Update(GameTime gameTime)
        {


            
        }

        static private void AddTestEntity()
        {
            Entity tmpEntity = new Entity();

            // Adding image  path, width, height, isAnimated
            tmpEntity.AddImage("Content/images/notAnimated.png", 40, 40);
            
            // Setting up image-size incase of animation
            tmpEntity.collisionBox.Height = 40;
            tmpEntity.collisionBox.Width = 40;

            // setting startposition
            tmpEntity.position.X = 100;
            tmpEntity.position.Y = 100;


            EntityManager.AddEntity(tmpEntity);

        }

        static private void AddTestAnimatedEntity()
        {
            Entity tmpEntity = new Entity();

            // Adding image  path, width, height, isAnimated
            tmpEntity.AddImage("Content/images/Animated10frames.png", 40, 40, 200, 10);

            // Setting up image-size incase of animation
            tmpEntity.collisionBox.Height = 40;
            tmpEntity.collisionBox.Width = 40;

            // setting startposition
            tmpEntity.position.X = 200;
            tmpEntity.position.Y = 100;


            EntityManager.AddEntity(tmpEntity);
        }

    }
}
