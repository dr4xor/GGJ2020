using UnityEngine;

class PlayerController : MonoBehaviour
{

    public AnimationController anim;
    public MovementController movement;

    void Awake()
    {
        anim = GetComponent<AnimationController>();
        movement = GetComponent<MovementController>();
    }

}
