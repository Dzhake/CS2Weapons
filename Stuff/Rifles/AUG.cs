using DuckGame;

namespace CS2Weapons;

[EditorGroup("CS2|Rifles")]
public class AUG : AK47
{
    public AUG(float x, float y) : base(x, y)
    {
        _graphic = new Sprite(GetPath("Weapons/Aug"));
        laserSight = true;
        _laserOffsetTL = _barrelOffsetTL + new Vec2(-12f, -4f);
        _kickForce = 3f;
        _fireWait = 0.8f;
        _ammoType.range = 300f;
    }
}
