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
        //Just a test
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Game Variables
        Player playerObj;

        //Textures
        Texture2D playerSprite;
        //Backgrounds
        Texture2D testBackground;
        //Entities
        //Enemies
        Texture2D Dragon;
        Texture2D Spider;
        Texture2D Bat;
        Texture2D Wolf;
        Texture2D Slime;
        //PLayer
        Texture2D Player;

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

        //Initialize method
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        //Load content 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);



            // TODO: use this.Content to load your game content here
            playerSprite = Content.Load<Texture2D>("blue_circle");
            testBackground = Content.Load<Texture2D>("blue_sky_05");
            //playerObj = new Player(Content);
            //Load Entities
            /*Dragon = Content.Load<Texture2D>("Dragon");
            Spider = Content.Load<Texture2D>("Spider");
            Bat = Content.Load<Texture2D>("Bat");
            Wolf = Content.Load<Texture2D>("Wolf");
            Slime = Content.Load<Texture2D>("Slime");
            Player = Content.Load<Texture2D>("Player");*/
        }

        //Unload content method
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        //Update method
        protected override void Update(GameTime gameTime)
        {
            //Escape exits game window
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

<<<<<<< HEAD
            // TODO: Add your update logic here
=======
          
            //User input
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A))

            {
                
            }

            if (keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D))
            {
                
            }

            if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
            { 
            
            }

            if (keyboardState.IsKeyDown(Keys.Down) || keyboardState.IsKeyDown(Keys.S))
            { 
                
            }

            if (keyboardState.IsKeyDown(Keys.Space))
            { 
                
            }

            //Stops player from walking back(Just rough code)
            /*if (pos > viewportRect.Width || pos.X < 0)
            {
                
            }*/

           
            //Timer
>>>>>>> origin/master
            fTimeIntervalSecs = ((float)gameTime.ElapsedGameTime.Milliseconds) / 1000.0f;

            //playerObj.PlayerUpdate(gameTime);

            base.Update(gameTime);
        }

        //Draw method
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Begin drawing
            spriteBatch.Begin();
            //Draws entities
            /*spriteBatch.Draw(Dragon);
            spriteBatch.Draw(Spider);
            spriteBatch.Draw(Bat);
            spriteBatch.Draw(Wolf);
<<<<<<< HEAD
            spriteBatch.Draw(Slime); */
            
            spriteBatch.Draw(testBackground, Vector2.Zero);
            spriteBatch.Draw(playerSprite, new Vector2(50, 50), null,
        Color.White, 0f, Vector2.Zero, 0.25f, SpriteEffects.None, 0f);
            spriteBatch.End();
=======
            spriteBatch.Draw(Slime);
            spriteBatch.Draw(Player);
            spriteBatch.End();*/
>>>>>>> origin/master

            base.Draw(gameTime);
        }
    }
}
