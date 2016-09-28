using System;
using System.Collections.Generic;
using System.Text;
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
    class entrance
    {
        public Vector3 position;
        public BoundingSphere sphere;
        public entrance(Vector3 entryposition)
        {
            entryposition = position;
            sphere = new BoundingSphere(position, 30);
        }
    }
}
