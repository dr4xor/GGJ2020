﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpell : Spell
{

    public AirSpell() { }

    private const float factor = 1500;
    public override void OnTrigger(Vector2 mousePos, PlayerController p)
    {
        Vector2 direction = ((Vector2)p.transform.position - mousePos).normalized;
        p.GetComponent<Rigidbody2D>().AddForce(direction * factor);
    }
}
