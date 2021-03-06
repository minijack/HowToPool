﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace HowToPool
{
    class Renderer
    {
        public void run(List<Entity> Entities,List<Ball> balls,Cue cue,PoolTable table,GameTime gameTime,SpriteBatch spriteBatch) 
        {
            //Draws all entities
            /*for (int i = 0; i < Entities.Count; i++)
            {
                Entities[i].draw(spriteBatch);
            
            }*/

            if(table.drawTable == true)
            {
                table.draw(spriteBatch);
            }

            for (int i = 0; i < balls.Count; i++) 
            {
                balls[i].draw(spriteBatch);
            }

            if (cue.drawCue == true)
            {
               
                cue.draw(spriteBatch);
                
            }

            


        }


        public List<Texture2D> ContentLoad(List<Entity> Entities,List<Ball> balls,Cue cue,PoolTable table,ContentManager content) 
        {
            //Loads all entities textures so they can be drawn
            List<Texture2D> textures = new List<Texture2D>();

            textures.Add(content.Load<Texture2D>("blueBall"));
            
            textures.Add(content.Load<Texture2D>("redBall"));

            textures.Add(content.Load<Texture2D>("whiteBall"));

            table.texture = content.Load<Texture2D>("table");
            float a = table.texture.Width;

            cue.texture = content.Load<Texture2D>("cue");
            

            return textures;


        
        }


    }
}

