using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private const float dampening = 0.1f;
    [SerializeField]
    private float lerpSpeed;


    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject player;
    Rigidbody2D rb;

    private Vector3 targetCameraPos;
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
        this.targetCameraPos = playerPos + new Vector2(rb.velocity.x * dampening, 0);
        this.targetCameraPos.z = -10;

        camera.transform.position = Vector3.Lerp(camera.transform.position, targetCameraPos, Time.deltaTime * lerpSpeed);
    }
}
