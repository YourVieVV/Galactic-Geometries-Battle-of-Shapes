using UnityEngine;

public class EmenyStats : MonoBehaviour
{
    public const string
        hpRectangle = "hpRectangle",
        shootDelayRectangle = "shootDelayRectangle",
        hpCircle = "hpCircle",
        shootDelayCircle = "shootDelayCircle",
        hpCapsule = "hpCapsule",
        shootDelayCapsule = "shootDelayCapsule",
        hpHexagon = "hpHexagon",
        shootDelayHexagon = "shootDelayHexagon",
        hpIsometric = "hpIsometric",
        shootDelayIsometric = "shootDelayIsometric",
        hpOval = "hpOval",
        shootDelayOval = "shootDelayOval";

    public const float
        initHpRectangle = 50f,
        initShootDelayRectangle = 1.6f,
        initHpIsometric = 100f,
        initShootDelayIsometric = 1.4f,
        initHpCircle = 200f,
        initShootDelayCircle = 2f,
        initHpCapsule = 200f,
        initShootDelayCapsule = 3f,
        initHpHexagon = 300f,
        initShootDelayHexagon = 0.4f,
        initHpOval = 150f,
        initShootDelayOval = 2f;
}
