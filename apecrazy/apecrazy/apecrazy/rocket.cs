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
    class rocket
    {
        public Vector3 position, direction;
        public bool active, exploding;
        public float speed, rotation;
        public BoundingSphere iexplosion, mexplosion, oexplosion, sphere;
        public String room, area;
        public int explosionTimeNum;
        public rocket(Vector3 rocketPosition)
        {
            position = rocketPosition;
            active = false;
            exploding = false;
            area = "road";
            room = "poolroom";
            explosionTimeNum = 0;
            rotation = 0;

        }
    }
}
