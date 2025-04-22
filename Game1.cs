using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_assignment_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D lakeTexture, turtleDucklingTexture, yellowTurtleDucklingTexture, brownTurtleDucklingTexture;
        Texture2D turtleDuckTexture;

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
            brownTurtleDucklingTexture = Content.Load<Texture2D>("Brown turtle duckling no background");
            turtleDuckTexture = Content.Load<Texture2D>("Turtle duck no background");
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
            _spriteBatch.Draw(yellowTurtleDucklingTexture, new Vector2(720, 500), Color.White);
            _spriteBatch.Draw(brownTurtleDucklingTexture, new Vector2(700, 300), Color.White);
            _spriteBatch.Draw(turtleDuckTexture, new Vector2(400, 375), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
