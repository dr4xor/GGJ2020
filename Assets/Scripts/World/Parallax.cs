using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float length;
    private float startposX;
    private float startpostY;
    private Camera cam;
    [SerializeField] private float parallaxEffectX;
    [SerializeField] private float parallaxEffectY;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        startposX = transform.position.x;
        startpostY = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distX = (cam.transform.position.x * parallaxEffectX);
        float distY = (cam.transform.position.y * parallaxEffectY);
        transform.position = new Vector3(startposX + distX, startpostY + distY, transform.position.z);
    }
}
