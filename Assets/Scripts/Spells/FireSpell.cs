using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{

    public FireSpell() { }

    public override void OnTrigger(Vector2 mousePos, PlayerController p)
    {
        Debug.Log("boom");
    }

}
