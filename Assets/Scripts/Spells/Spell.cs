using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell
{
    public abstract void OnTrigger(Vector2 mousePos, PlayerController p);
}
