using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpellManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag != "Player")
        {
            Destroy(gameObject);

            GameObject explosion = GameObject.Instantiate(Resources.Load("Explosion")) as GameObject;

            var contact = collision.contacts[0];
            Vector3 contactPoint = new Vector3(contact.point.x, contact.point.y, 0);

            explosion.transform.position = contactPoint;
            Destroy(explosion, 1);

        }
    }
}
