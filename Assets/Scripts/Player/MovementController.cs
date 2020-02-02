﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    private CharacterController2D m_controller;
    private bool m_jump;

    [SerializeField] private float m_runSpeed;

    public bool IsGrounded
    {
        get
        {
            return m_controller.IsGrounded;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        m_controller = GetComponent<CharacterController2D>();
    }

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            m_jump = true;
        }

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        m_controller.Move(horizontal * m_runSpeed * Time.deltaTime, false, m_jump);
        m_jump = false;
    }
}
