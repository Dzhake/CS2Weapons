using DuckGame;

namespace CS2Weapons;

[EditorGroup("CS2|Rifles")]
public class Scar : Sniper
{
    public Scar(float xval, float yval)
        : base(xval, yval)
    {
        _graphic = new Sprite(GetPath("Weapons/Scar"));
        _fireSound = "sniper";
        _kickForce = 1f;
        laserSight = true;
        _manualLoad = false;
        editorTooltip = "Long range automatic rifle with lazer sight.";
        loseAccuracy = 0.2f;
        maxAccuracyLost = 1f;
        ammo = 5;
    }

    public override void OnPressAction()
    {
        base.OnPressAction();
        if (ammo <= 0) return;
        _loadState = 3;
    }
}