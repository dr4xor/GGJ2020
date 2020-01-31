using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpell : Spell
{

    public WaterSpell() { }

    public override void OnTrigger(Vector2 mousePos, PlayerController p)
    {
        Debug.Log("splash");
    }

}
