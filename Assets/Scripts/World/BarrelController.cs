using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");
        if (collision.collider.CompareTag("FireProjectile"))
        {
            Destroy(gameObject);
        }
    }
}
