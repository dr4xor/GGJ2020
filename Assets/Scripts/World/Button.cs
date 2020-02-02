using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    bool activated = false;
    [SerializeField] private float cooldownSeconds; //-1 if it's not supposed to be reset
    public UnityEvent uEvent;

    private Animator animator;

    public void Start()
    {
        activated = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("YOOOOO");
        if(activated)
        {
            return;
        }


        if (other.CompareTag("FireProjectile")
        || other.CompareTag("Boulder")
        || other.CompareTag("Player"))
        {
            activated = true;
            animator.SetBool("active", true);
            uEvent.Invoke();

            if (cooldownSeconds != -1)
            {
                StartCoroutine(ButtonCooldown());
            }
        }
    }

    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(cooldownSeconds);
        activated = false;
        animator.SetBool("active", false);

    }
}
