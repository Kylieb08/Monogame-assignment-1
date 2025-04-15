using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_assignment_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D lakeTexture, turtleDucklingTexture, yellowTurtleDucklingTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 960;
            _graphics.PreferredBackBufferHeight = 641;
            _graphics.ApplyChanges();
            this.Window.Title = "Assignment 1";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            lakeTexture = Content.Load<Texture2D>("Lake");
            turtleDucklingTexture = Content.Load<Texture2D>("Turtle duckling no background");
            yellowTurtleDucklingTexture = Content.Load<Texture2D>("Yellow turtle duckling no background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(lakeTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(turtleDucklingTexture, new Vector2(100, 400), Color.White);
            _spriteBatch.Draw(yellowTurtleDucklingTexture, new Vector2(400, 200), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
