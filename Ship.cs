﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShip.Desktop
{
    public class Ship
    {
        int speed = 180;



        static public Vector2 defaultPosition = new Vector2(512, 340);
        public Vector2 position = defaultPosition;

        public void shipUpdate(GameTime gameTime, Controller gameController)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (gameController.inGame)
            {

                if (kState.IsKeyDown(Keys.Right) && position.X < 1024)
                {
                    position.X += speed * dt;
                }

                if (kState.IsKeyDown(Keys.Left) && position.X > 0)
                {
                    position.X -= speed * dt;
                }

                if (kState.IsKeyDown(Keys.Up) && position.Y > 0)
                {
                    position.Y -= speed * dt;
                }

                if (kState.IsKeyDown(Keys.Down) && position.Y < 680)
                {
                    position.Y += speed * dt;
                }
            }   
        }

    }
}
