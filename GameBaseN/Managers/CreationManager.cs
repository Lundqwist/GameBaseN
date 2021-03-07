using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GameBaseN
{
    static class CreationManager
    {

        
        static public void Initialize()
        {
            //AddTestEntity();
            //AddTestAnimatedEntity();

        }

        static public void Update(GameTime gameTime)
        {

           
            
        }


        static public void AddPlatform(int xPosition, int yPosition)
        {
            Platform tmpPlatform = new Platform();


        }

        //static private void AddTestEntity()
        //{
        //    Entity tmpEntity = new Entity("Test");

        //    // Adding image  path, width, height, isAnimated
        //    //tmpEntity.AddImage("testEntity", "Content/images/notAnimated.png", 40, 40);
            
        //    // Setting up image-size incase of animation
        //    tmpEntity.collisionBox.Height = 40;
        //    tmpEntity.collisionBox.Width = 40;

        //    // setting startposition
        //    tmpEntity.position.X = 100;
        //    tmpEntity.position.Y = 100;


        //    EntityManager.AddEntity(tmpEntity);

        //}

        //static private void AddTestAnimatedEntity()
        //{
        //    Entity tmpEntity = new Entity("Animated");

        //    // Adding image  path, width, height, isAnimated
        //    //tmpEntity.AddImage("TestAnimated", "Content/images/Animated10frames.png", 40, 40, 200, 10);

        //    // Setting up image-size incase of animation
        //    tmpEntity.collisionBox.Height = 40;
        //    tmpEntity.collisionBox.Width = 40;

        //    // setting startposition
        //    tmpEntity.position.X = 200;
        //    tmpEntity.position.Y = 100;


        //    EntityManager.AddEntity(tmpEntity);
        //}

    }
}
