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
    }
}
