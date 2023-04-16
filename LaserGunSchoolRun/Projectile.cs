﻿using Microsoft.Xna.Framework;

namespace LaserGunSchoolRun;

public class Projectile
{
    public Vector2 Position;
    public Vector2 Direction = -Vector2.UnitY; // always up

    public const float Speed = 950f;
    public const float Damage = .36f;
    public static int Width, Height;

    public Rectangle GetBounds()
    {
        return new Rectangle(
            (int)Position.X - Width / 2,
            (int)Position.Y - Height / 2,
            Width, Height);
    }

    public void Update(float dt)
    {
        Position += Direction * Speed * dt;
    }
}
