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

        static int uniqueTextureId;

        static public GraphicsDevice graphicsDevice;
        


        static public void Initialize(GraphicsDevice currentGraphicsDevice)
        {
            firstTexturePack = null;
            graphicsDevice = currentGraphicsDevice;
            uniqueTextureId = 0;
        }

        static public void ClearAllImages()
        {
            
            firstTexturePack = null;
            GC.Collect();

        }

        static public int AddImage(string imageName, string imagePathAndFileName)
        {
            TexturePack stepPack = firstTexturePack;

            if(firstTexturePack != null)
            {
                // Find last texturepack
                while(stepPack.nextTexturePack != null)
                {
                    if(stepPack.textureName == imageName)
                    {
                        return stepPack.imageNumber;
                    }
                    stepPack = stepPack.nextTexturePack;
                }

                TexturePack newImage = new TexturePack(uniqueTextureId, imageName,
                                        Texture2D.FromStream(graphicsDevice,
                                        File.OpenRead(imagePathAndFileName)));
                
                uniqueTextureId++;
                stepPack.nextTexturePack = newImage;

            }
            else
            {
                TexturePack newImage = new TexturePack(uniqueTextureId, imageName,
                                        Texture2D.FromStream(graphicsDevice,
                                        File.OpenRead(imagePathAndFileName)));

                uniqueTextureId++;
                firstTexturePack = newImage;
            }

            return uniqueTextureId;
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
