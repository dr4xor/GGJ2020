using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSpell : Spell
{

    private float mouseRadius = 0.2f;
    private Vector2 mouseStartPosition;
    private Vector2 mouseEndPosition;
    private Vector2 velocity;
    private GameObject Boulder;
    public float manaCost;

    public override void OnTriggerDown(Vector2 mousePos, PlayerController p)
    {
        Collider2D[] foundObjects;
        foundObjects = Physics2D.OverlapCircleAll(mousePos, mouseRadius);

        for(int i = 0; i < foundObjects.Length; i++)
        {
            if(foundObjects[i].CompareTag("Boulder"))
            {
                mouseStartPosition = mousePos;
                Boulder = foundObjects[i].gameObject;
            }
        }
    }

    public override void OnTriggerMove(Vector2 mousePos, PlayerController p)
    {

    }

    public override void OnTriggerUp(Vector2 mousePos, PlayerController p)
    {
        if(Boulder == null)
        {
            return;
        }
        p.anim.OnSpellExecuted();

        mouseEndPosition = mousePos;
        velocity = mouseStartPosition - mouseEndPosition;

        Boulder.GetComponent<Rigidbody2D>().AddForce(velocity * 800 *-1);

        manaCost = velocity.x * velocity.x + velocity.y * velocity.y;
        manaCost = manaCost / 7;
        GameManager.Instance.DecreaseMana((int)manaCost);
    }

    public override void CalculateMana()
    {

    }
}
