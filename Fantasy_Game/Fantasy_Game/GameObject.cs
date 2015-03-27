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
    public class GameObject
    {
        //The base class for all gameobjects in the game. It contains their graphics, position, scale, rotation and velocity
        Vector2 position;
        Texture2D sprite;
        Vector2 velocity;
        Vector2 initialVelocity;
        Vector2 spriteOrigin;
        bool setOrigin;
        float scale;

        //base
        public GameObject(Texture2D _textureImage, Vector2 _position, Vector2 _velocity, bool _setOrigin, float _scale)
        {
            position = _position;
            sprite = _textureImage;
            initialVelocity = _velocity;
            velocity = _velocity;
            setOrigin = _setOrigin;
            if (setOrigin)
            {
                spriteOrigin = new Vector2(sprite.Width / 2, sprite.Height / 2);
            }
            scale = _scale;
        }
    }
}
