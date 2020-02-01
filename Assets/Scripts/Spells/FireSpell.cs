using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;

public class FireSpell : Spell
{

    private const float velocity = 1000;
    private const float lifetime = 1.5f;

    public FireSpell() { }

    public override void OnTrigger(Vector2 mousePos, PlayerController p)
    {
        // PLEASE FOR FUCKS SACKE BELIEVE ME ITS A FUCKING GAME OBJECT
        GameObject fireball = (GameObject) GameObject.Instantiate(Resources.Load("FireSpell")) as GameObject;
        fireball.transform.position = p.transform.position;

        Vector2 direction = (mousePos - (Vector2)p.transform.position).normalized;
        Vector2 forceVector = direction * velocity;

        //Debug.Log(forceVector);
        fireball.GetComponent<Rigidbody2D>().AddForce(direction * velocity, ForceMode2D.Force);
        GameObject.Destroy(fireball, lifetime);

    }

}
