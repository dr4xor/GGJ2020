using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenDoor()
    {
        animator.SetBool("doorOpened", true);
    }

    void CloseDoor()
    {
        animator.SetBool("doorOpened", false);
    }
}
