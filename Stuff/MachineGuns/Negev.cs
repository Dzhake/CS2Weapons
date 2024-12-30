using DuckGame;

namespace CS2Weapons;

[EditorGroup("CS2|MachineGuns")]
public class Negev : Gun
{
    public Negev(float x, float y) : base(x, y)
    {
        ammo = 100;
        _ammoType = new AT9mm
        {
            range = 400f,
            accuracy = 0.8f
        };
        wideBarrel = true;
        barrelInsertOffset = new Vec2(0f, 0f);
        _type = "gun";
        _graphic = new SpriteMap(GetPath("Weapons/Negev"), 42, 28);
        _center = new Vec2(14f, 14f);
        _collisionOffset = new Vec2(-8f, -3f);
        _collisionSize = new Vec2(24f, 10f);
        _barrelOffsetTL = new Vec2(39f, 14f);
        _fireSound = "pistolFire";
        _fullAuto = true;
        _fireWait = 0.5f;
        _kickForce = 1f;
        _fireRumble = RumbleIntensity.Kick;
        _weight = 7f;
        _holdOffset = new Vec2(0f, 2f);
        editorTooltip = "Heavy, but accurate and fast machine gun.";
        _editorPreviewOffset.x -= 8f;
        _editorPreviewOffset.y -= 1f;
    }
}
