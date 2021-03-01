using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace GameBaseN
{
    class TexturePack
    {

        public TexturePack nextTexturePack;
        
        public int imageNumber;

        public Texture2D texture2D;


        public TexturePack(int imageNumber, Texture2D texture2D)
        {
            nextTexturePack = null;
            this.imageNumber = imageNumber;
            this.texture2D = texture2D;

        }
    }
}
