using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaFlowerController : MonoBehaviour
{
    [SerializeField] private int manaValue;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.IncreaseMana(manaValue);
            Destroy(gameObject);
        }
    }
}
