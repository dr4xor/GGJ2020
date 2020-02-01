using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell
{
    public abstract void OnTriggerDown(Vector2 mousePos, PlayerController p);

    public abstract void OnTriggerMove(Vector2 mousePos, PlayerController p);

    public abstract void OnTriggerUp(Vector2 mousePos, PlayerController p);
}
