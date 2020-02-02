using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    [SerializeField] float attackRadius;
    [SerializeField] float attackCooldown;
    private bool attacking;

    [SerializeField] float attackChargeForce;
    private Animator animator;
    private Rigidbody2D rigidbody;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        GameObject player = GameManager.Instance.player;
        if(Vector2.Distance(player.transform.position, transform.position) < attackRadius && Time.time - startTime > attackCooldown)
        {
            startTime = Time.time;
            Attack();
        }

        if(rigidbody.velocity.x < 1)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y);
        }
        else if(rigidbody.velocity.x > 1)
        {
            transform.localScale = new Vector3(1, transform.localScale.y);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("Player"))
        {
            GameManager.Instance.DecreaseMana(10);
            other.gameObject.GetComponent<PlayerController>().anim.OnDamageTaken();
        }
        
        if(other.collider.CompareTag("FireProjectile"))
        {
            Destroy(gameObject);
        }
    }

    private void Attack()
    {

        var chargeDirection = (GameManager.Instance.player.transform.position - transform.position);
        chargeDirection.z = 0;
        if (chargeDirection.y < 0.1)
        {
            chargeDirection.y = 2;
        }

        GetComponent<Rigidbody2D>().AddForce(chargeDirection.normalized * attackChargeForce);

        animator.SetTrigger("attack");
    }
}
