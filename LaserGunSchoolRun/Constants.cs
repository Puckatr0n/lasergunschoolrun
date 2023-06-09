﻿namespace LaserGunSchoolRun;

public static class Constants
{
    // Internal game constants
    public const int RandomSeed = 420;
    public const int HorizontalResolution = 1280;
    public const int VerticalResolution = 720;

    // Gameplay constants
    public const float BackgroundScrollSpeed = 100f;
    public const float PlayerAcceleration = 100f;
    public const float StandardCarSpeed = 200f;
    public const float FastCarSpeed = 350f;
    public const double InitialBasicEnemyCreationDelaySeconds = 1.8;
    public const double FastCarChance = 0.10; // 10%
    public const int LaneCount = 10;
    public const int BasicRoadUserHealth = 100;
    public const int LaserSpeed = 1250;
    public const int LaserDamage = 35;
    public const int DefaultPlayerHealth = 100;
    public const int NormalRoadUserDamageToPlayer = 9;
    public const int FastRoadUserDamageToPlayer = 18;

}
