using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace apecrazy
{
    class target
    {
        public Model model;
        public Vector3 position;
        public bool destroyed;
        public target(Vector3 melonposition)
        {
            position = melonposition;
        }
    }
}

