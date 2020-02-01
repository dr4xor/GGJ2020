using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpell : Spell
{

    public WaterSpell() { }

    public override void OnTriggerDown(Vector2 mousePos, PlayerController p)
    {
        GameObject wölkchen = (GameObject)GameObject.Instantiate(Resources.Load("WaterSpell")) as GameObject;
        wölkchen.transform.position = mousePos;

        GameObject.Destroy(wölkchen, 5);
    }

    public override void OnTriggerMove(Vector2 mousePos, PlayerController p)
    {
    }

    public override void OnTriggerUp(Vector2 mousePos, PlayerController p)
    {
    }
}
