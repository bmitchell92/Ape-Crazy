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
    class player
    {
        public GamePadState currentState;
        public GamePadState lastState;
        public float freeLook, Rotation, jumpspeed, oldY, fov;
        public Vector3 Position;
        public Vector3 cameralookat;
        public bool firing, reloading, canshoot, canjump, ads, dead, medichit;
        public bool godupgrade, gunnerupgrade, mgupgrade, sniperupgrade, specopupgrade;
        public int firepause, clip, reloadTimeNum, ammo9mm, ammo44magnum, ammo3006, ammo12Gauge, ammoUzi, ammo762x39, ammo357magnum, health, ammo556, medpacks, ammo762x51, ammo545, medicpause, level, ammo762x54, ammonull, ammo10Gauge, ammo600overkill, startingclip, secondaryclip, secondaryreloadtimenum, ammo20mm, ammo41, ammo45, ammo500magnum, ammorpg;
        public int godclasskills, gunnerkills, mgkills, sniperkills, specopkills;
        public string weapon, startingweapon, posture, area, room, mpclass, menu;
        public player(Vector3 playerPosition)
        {
            playerPosition = Position;
            freeLook = 0.0f;
            Rotation = 0.0f;
            jumpspeed = 0.0f;
            oldY = 16;
            cameralookat = (new Vector3(0.0f, 0.0f, -1.0f)) + Position;
            firing = false;
            reloading = false;
            canshoot = true;
            canjump = true;
            ads = false;
            firepause = 0;
            clip = 16;
            reloadTimeNum = 0;
            ammo9mm = 420;
            ammo44magnum = 54;
            ammo3006 = 60;
            ammo600overkill = 30;
            ammo12Gauge = 64;
            ammo10Gauge = 40;
            ammoUzi = 320;
            ammo762x39 = 180;
            ammo45 = 224;
            ammorpg = 5;
            ammo762x54 = 300;
            ammo500magnum = 45;
            ammo357magnum = 180;
            ammo556 = 300;
            ammonull = 0;
            medpacks = 2;
            weapon = "hipower";
            posture = "standing";
            dead = false;
            health = 100;
            startingweapon = "hipower";
            startingclip = 14;
            ammo762x51 = 100;
            ammo545 = 360;
            ammo20mm = 104;
            ammo41 = 600;
            medichit = false;
            medicpause = 1;
            level = 1;
            area = "road";
            fov = 45;
            room = "poolroom";
            mpclass = "";
            godupgrade = false;
            gunnerupgrade = false;
            mgupgrade = false;
            sniperupgrade = false;
            specopupgrade = false;
            menu = "";
            secondaryreloadtimenum = 0;
            secondaryclip = 0;
            godclasskills = 0;
            gunnerkills = 0;
            mgkills = 0;
            sniperkills = 0;
            specopkills = 0;
        }
    }
}

