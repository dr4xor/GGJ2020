using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;

public class FireSpell : Spell
{

    private const float velocity = 750;
    private const float lifetime = 1.5f;

    public FireSpell() { }

    public override void OnTrigger(Vector2 mousePos, PlayerController p)
    {
        // PLEASE FOR FUCKS SACKE BELIEVE ME ITS A FUCKING GAME OBJECT
        GameObject fireball = (GameObject) GameObject.Instantiate(Resources.Load("FireSpell")) as GameObject;

        Vector2 direction = (mousePos - (Vector2)p.transform.position).normalized;
        fireball.transform.position = p.transform.position + new Vector3(0, 1, 0) +  (Vector3) direction*1.5f;


        //set direction of fireball sprite
        SpriteRenderer fireballSprite = fireball.GetComponent<SpriteRenderer>();
        fireballSprite.transform.right = direction;

        fireball.GetComponent<Rigidbody2D>().AddForce(direction * velocity, ForceMode2D.Force);
        GameObject.Destroy(fireball, lifetime);

    }

}
