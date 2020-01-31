using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    private CharacterController2D m_controller;
    private bool m_jump;

    [SerializeField] private float m_runSpeed;

    private bool IsGrounded
    {
        get
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down * 0.05f);
            if(hit.collider == null)
            {
                return false;
            }

            return true;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        m_controller = GetComponent<CharacterController2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            m_jump = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        m_controller.Move(horizontal * m_runSpeed * Time.fixedDeltaTime, false, m_jump);
        m_jump = false;
    }
}
