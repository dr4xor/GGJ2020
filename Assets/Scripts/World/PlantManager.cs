using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    private int growState = 0;

    [SerializeField]
    private Sprite[] growStateSprites;

    private float totalGrowTime = 0;

    [SerializeField] private float neededGrowTime = 5;

    private bool isInRain = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isInRain)
        {
            if(totalGrowTime < neededGrowTime)
            {
                totalGrowTime += Time.deltaTime;
            }

            growState = Mathf.FloorToInt((totalGrowTime / neededGrowTime) * (growStateSprites.Length - 1));

        }

        spriteRenderer.sprite = growStateSprites[growState];
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if(other.CompareTag("Rain"))
        {
            isInRain = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Rain"))
        {
            isInRain = false;
        }
    }
}
