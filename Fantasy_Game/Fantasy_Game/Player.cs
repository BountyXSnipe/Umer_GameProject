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
    class Player
    {
        Texture2D playerSprite;
        Texture2D bowNArrowSprite;
        Texture2D swordSprite;

        //facial expression sprites
        Texture2D standardFace;
        Texture2D hurtFace;
        Texture2D surprisedFace; //When the player sees the dragon
        Texture2D weakFace; //When the player is low on health;
        Texture2D deadFace; 

        //States
        enum PlayerState { normal, hurt, dead };
        public bool isGrounded = false;
        enum EquippedWeapon { bow, sword };


        //Stats
        public int hp = 12; // an hp of 4 is one whole heart
        float movementSpeed = 10.0f;
        float jumpHeight = 5.0f;

        //--------------- Testing segement below
        #region
        // This variable will hold our position - make it a property so game class
        //can use it to change position when mouse moved
        protected Vector2 position;
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        //make these protected so derived classes can use it
        public Texture2D TextureImage { get; set; }
        //origin of sprite, either null or the center of the image
        protected Vector2 spriteOrigin;
        public Vector2 SpriteOrigin
        {
            get { return spriteOrigin; }
            set { spriteOrigin = value; }
        }

        //rectangle occupied by texture - bounding rectangle
        public virtual Rectangle CollisionRectangle
        {
            get
            {
                return new Rectangle((int)(Position.X - SpriteOrigin.X * Scale), (int)(Position.Y - SpriteOrigin.Y * Scale),
                    (int)(TextureImage.Width * Scale), (int)(TextureImage.Height * Scale));
            }
        }

        //vector so it has independant x and y values
        protected Vector2 velocity;
        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }
        //velocity set in constructor, needs a 
        //separate property so it doesn't get zeroed
        //when sprite idles
        //initial velocity will be used for a power up later on
        protected Vector2 initialVelocity;
        public Vector2 InitialVelocity
        {
            get { return initialVelocity; }
            set { initialVelocity = value; }
        }
        //whether to use the Origin or not
        public bool SetOrigin { get; set; }
        public float Scale { get; set; }
        protected SpriteEffects Spriteeffect { get; set; }

        //is he active or not (should he be updated and drawn?)
        public bool Alive { get; set; }

        //simpler than Sprite, missing a few properties

        // base version
        public Player(Texture2D textureImage, Vector2 position, Vector2 velocity, bool setOrigin, float scale)
        {
            Position = position;
            TextureImage = textureImage;
            InitialVelocity = velocity;
            Velocity = velocity;
            SetOrigin = setOrigin;
            if (SetOrigin)
            {
                SpriteOrigin = new Vector2(TextureImage.Width / 2, TextureImage.Height / 2);
            }
            Scale = scale;
            Alive = true;
        }
        #endregion
        //--------end test segmemnt
        public void UpdateMovement()
        {
            System.Diagnostics.Debug.WriteLine("Update movement was called");
            //The keyboard state
            KeyboardState keyState = Keyboard.GetState();

            //Moving left
            if(keyState.IsKeyDown(Keys.A))
            {
                position.X -= 10;
            }//Moving Right
            else if(keyState.IsKeyDown(Keys.D))
            {
                position.X += 10;
            }

            //Jumping
            if (keyState.IsKeyDown(Keys.W))
            {
                //Check if the player is on the ground
                if (isGrounded == true)
                {
                    //Jump

                }
                
            }
        }

        public void PlayerUpdate(GameTime gameTime)
        {
            //The update function for the player

            UpdateMovement();

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (Alive && TextureImage != null)
            {
                spriteBatch.Draw(TextureImage,
                     position,
                     null,
                     Microsoft.Xna.Framework.Color.White,
                     0f,
                     SpriteOrigin,
                     Scale,
                     Spriteeffect,
                     0);
            }
        }

    }
}
