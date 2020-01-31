using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private const float dampening = 0.1f;

    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject player;
    Rigidbody2D rb;

    private Vector3 camereaPos;
    private Vector2 playerPos;

    // Start is called before the first frame update
    void Start()
    {
      rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.playerPos = player.transform.position;
        this.camereaPos = playerPos + (rb.velocity * dampening);
        this.camereaPos.z = -10;
        camera.transform.position = this.camereaPos;
    }
}
