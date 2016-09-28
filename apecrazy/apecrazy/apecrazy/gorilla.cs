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
using System.Text;

namespace apecrazy
{
    class gorilla
    {
        public float rotation;
        public bool dead, alertp1, firing, alertp2, alertbot, alertp3, alertp4;
        public Vector3 position;
        public Ray attentionrayleft, attentionraycenter, attentionrayright;
        public int firepause, respawnTime, health, clip, reloadTimeNum;
        public gorilla(Vector3 gorillaPosition)
        {
            rotation = 0.0f;
            dead = false;
            position = gorillaPosition;
            alertp1 = false;
            alertp2 = false;
            alertp3 = false;
            alertp4 = false;
            alertbot = false;
            attentionrayleft = new Ray(position, new Vector3(-(float)Math.Sin(rotation + MathHelper.ToRadians(5)), 0.0f, -(float)Math.Cos(rotation + MathHelper.ToRadians(5))));
            attentionraycenter = new Ray(position, new Vector3(-(float)Math.Sin(rotation), 0.0f, -(float)Math.Cos(rotation)));
            attentionrayright = new Ray(position, new Vector3(-(float)Math.Sin(rotation - MathHelper.ToRadians(5)), 0.0f, -(float)Math.Cos(rotation - MathHelper.ToRadians(5))));
            firepause = 0;
            respawnTime = 0;
            health = 7000;
            firing = false;
            reloadTimeNum = 0;
            clip = 1;
        }
    }
}
