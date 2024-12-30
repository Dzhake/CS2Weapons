using DuckGame;

namespace CS2Weapons;

[EditorGroup("CS2|MachineGuns")]
public class M249 : Negev
{
    public M249(float x, float y) : base(x, y)
    {
        ammo = 75;
        _ammoType = new AT9mm
        {
            range = 200f,
            accuracy = 0.02f
        };
        _graphic = new SpriteMap(GetPath("Weapons/M249"), 42, 28);
        _weight = 4.5f;
        editorTooltip = "Pretty light and inaccurate, but fast machine gun.";
    }
}
