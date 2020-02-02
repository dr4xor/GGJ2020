using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    [SerializeField] float attackRadius;
    [SerializeField] float attackCooldown;
    private bool attacking;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameManager.Instance.player;
        if(Vector2.Distance(player.transform.position, transform.position) > attackRadius)
        {
            attacking = false;
        }

        if (attacking = true && startTime - Time.time > attackCooldown)
        {
            attacking = false;
            startTime = Time.time;
            Attack();
        }
    }

    private void Attack()
    {

    }
}
