

using UnityEngine;

public class VineController : MonoBehaviour
{
    [SerializeField] private Vector2 vineDirection;
    private Vector2 startPosition;

    private float totalGrowTime = 0;
    [SerializeField] private float neededGrowTime = 5;

    void Start()
    {
        startPosition = transform.position;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Rain"))
        {
            if (totalGrowTime < neededGrowTime)
            {
                totalGrowTime += Time.deltaTime;
            } else
            {
                return;
            }

            var growProgess = (totalGrowTime / neededGrowTime);

            transform.position = Vector3.Lerp(startPosition, startPosition + vineDirection, growProgess);
        }
    }


}

