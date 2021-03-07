using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameBaseN
{
    class TexturePack
    {

        public TexturePack nextTexturePack;
        public Texture2D texture2D;
        public string textureName;
        public int imageNumber;

        
        public TexturePack(int imageNumber, string textureName, Texture2D texture2D)
        {
            nextTexturePack = null;
            this.imageNumber = imageNumber;
            this.texture2D = texture2D;
            this.textureName = textureName;
        }
    }
}
