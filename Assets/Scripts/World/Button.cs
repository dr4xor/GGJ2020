﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class Button : MonoBehaviour
{
    bool activated = false;
    [SerializeField] private float cooldownSeconds; //-1 if it's not supposed to be reset
    [SerializeField] private string[] targets;
    public UnityEvent onActivateEvent;
    public UnityEvent onDeactivateEvent;

    private Animator animator;

    public void Start()
    {
        activated = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(activated)
        {
            return;
        }


        if (targets.Contains(other.tag))
        {
            activated = true;
            if(animator != null) 
                animator.SetBool("active", true);
            onActivateEvent.Invoke();

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
        if (animator != null)
            animator.SetBool("active", false);
        onDeactivateEvent.Invoke();

    }
}
