﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HowToPool
{

    //Class inherits Entity
    class Cue : Entity
    {

        public float power;

        //Cue constructor
        public Cue(string path, Vector2 _vel, Vector2 _pos,float angle) : base(path, _vel, _pos,angle) 
        {
            

        }





    }
}
