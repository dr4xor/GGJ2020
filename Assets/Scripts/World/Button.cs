using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    bool activated;
    [SerializeField] private float cooldownSeconds; //-1 if it's not supposed to be reset
    public UnityEvent uEvent;

    private float startCooldown;

    public void Start()
    {
        activated = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (cooldownSeconds == -1)
        {
            return;
        }

        if (activated == false)
        {
            if (other.CompareTag("FireProjectile")
            || other.CompareTag("Boulder")
            || other.CompareTag("Player"))
            {
                uEvent.Invoke();
            }

            startCooldown = Time.time;
        }

        StartCoroutine(ButtonCooldown());
    }

    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(cooldownSeconds);
        activated = true;

    }
}
