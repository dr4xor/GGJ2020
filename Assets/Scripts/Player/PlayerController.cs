﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private AnimationController _anim;
    private MovementController _movement;

    public AnimationController anim => _anim;
    public MovementController movement => _movement;

    void Awake()
    {
        GameManager.Instance.player = gameObject;
        _anim = GetComponent<AnimationController>();
        _movement = GetComponent<MovementController>();
    }

}
