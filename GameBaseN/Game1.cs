using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBaseN
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            // initialiserar managers som är statics.
            ImageManager.Initialize(graphics.GraphicsDevice);
            EntityManager.Initialize();
            CreationManager.Initialize(graphics.GraphicsDevice);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            EntityManager.Update(gameTime);
            //CreationManager.Update(gameTime);



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            spriteBatch.Begin();
            
            EntityManager.Draw(gameTime, spriteBatch);
            

            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
