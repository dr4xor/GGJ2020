using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    private int growState = 0;

    private GameObject currentStateObject;

    [SerializeField]
    private GameObject[] growStates;

    private float totalGrowTime = 0;

    [SerializeField] private float neededGrowTime = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Rain"))
        {
            if (totalGrowTime < neededGrowTime)
            {
                totalGrowTime += Time.deltaTime;
            }

            growState = Mathf.FloorToInt((totalGrowTime / neededGrowTime) * (growStates.Length - 1));

            currentStateObject?.SetActive(false);
            growStates[growState].SetActive(true);
            currentStateObject = growStates[growState];
        }
    }
}
