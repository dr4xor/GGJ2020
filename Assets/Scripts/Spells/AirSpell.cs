using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpell : Spell
{

    public AirSpell() { }
    private int manaCost = 10;

    private const float factor = 1500;
    public override void OnTriggerDown(Vector2 mousePos, PlayerController p)
    {
        p.anim.OnSpellExecuted();
        Vector2 direction = ((Vector2)p.transform.position - mousePos).normalized;
        p.GetComponent<Rigidbody2D>().AddForce(direction * factor);
        GameManager.Instance.DecreaseMana(manaCost);
    }

    public override void OnTriggerMove(Vector2 mousePos, PlayerController p)
    {

    }

    public override void OnTriggerUp(Vector2 mousePos, PlayerController p)
    {

    }

    public override void CalculateMana()
    {

    }
}
