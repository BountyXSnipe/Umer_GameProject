#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
//using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Fantasy_Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Game Variables
        Player playerObj;

        //Textures
        //Backgrounds
        Texture2D testBackground;
        //Entities
        Texture2D Dragon;
        Texture2D Spider;
        Texture2D Bat;
        Texture2D Wolf;
        Texture2D Slime;

        //Time
        float fTimeIntervalSecs;

        //Physics Engine
        float pos;
        float vel;
        float accel;
        float mass;
        float force;

        //Level
        int currentLevel = 1; //up to 5 levels

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);



            // TODO: use this.Content to load your game content here

            testBackground = Content.Load<Texture2D>("blue_sky_05");
            //Load Entities
            /*Dragon = Content.Load<Texture2D>("Dragon");
            Spider = Content.Load<Texture2D>("Spider");
            Bat = Content.Load<Texture2D>("Bat");
            Wolf = Content.Load<Texture2D>("Wolf");
            Slime = Content.Load<Texture2D>("Slime");*/
        }

        //Unload content method
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        //Update method
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            fTimeIntervalSecs = ((float)gameTime.ElapsedGameTime.Milliseconds) / 1000.0f;

            base.Update(gameTime);
        }

        //Draw method
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            /*spriteBatch.Draw(Dragon);
            spriteBatch.Draw(Spider);
            spriteBatch.Draw(Bat);
            spriteBatch.Draw(Wolf);
            spriteBatch.Draw(Slime);
            spriteBatch.End();*/

            base.Draw(gameTime);
        }
    }
}
