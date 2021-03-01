using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace GameBaseN
{
    static class ImageManager
    {

        static TexturePack firstTexturePack;

        static int counter;

        static public GraphicsDevice graphicsDevice;
        


        static public void Initialize(GraphicsDevice currentGraphicsDevice)
        {
            firstTexturePack = null;
            graphicsDevice = currentGraphicsDevice;
        }

        static public void ClearAllImages()
        {
            
            firstTexturePack = null;
            System.GC.Collect();

        }

        static public int AddImage(string imagePathAndFileName)
        {
            counter++;

            TexturePack newImage = new TexturePack(counter, Texture2D.FromStream(graphicsDevice, File.OpenRead(imagePathAndFileName)));

            TexturePack stepPack = firstTexturePack;


            if(firstTexturePack != null)
            {
                while(stepPack.nextTexturePack != null)
                {
                    stepPack = stepPack.nextTexturePack;
                }

                stepPack.nextTexturePack = newImage;

            }
            else
            {
                firstTexturePack = newImage;
            }

            return counter;
        }

        static public Texture2D GetImageWithId(int imageId)
        {
            TexturePack stepTexture = firstTexturePack;

            while (stepTexture != null)
            {
                if (stepTexture.imageNumber == imageId)
                {
                    return stepTexture.texture2D;
                }

                stepTexture = stepTexture.nextTexturePack;

            }

            return null;
        }



    }
}
