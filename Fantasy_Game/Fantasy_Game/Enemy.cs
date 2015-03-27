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
    class Enemy
    {
        //This is a parent class for the enemies. Enemies inherit from this class
        public int enemyHp;
        public int attackPower;

        //States
        public bool isAlive = true;

    }

    class Spider : Enemy
    {
        Texture2D spiderSprite;

        public float movementSpeed;
    }

    class Bat : Enemy
    {
        Texture2D batSprite;

        enum BatState { idle, charging };
    }
}
