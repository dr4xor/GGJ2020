using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private PlayerController m_controller;
    private Rigidbody2D m_rigidbody;
    [SerializeField]
    private Animator m_animator;

    void Awake()
    {
        m_controller = GetComponent<PlayerController>();
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_animator.SetFloat("horizontal", m_rigidbody.velocity.x);
        m_animator.SetBool("grounded", m_controller.movement.IsGrounded);
        m_animator.SetFloat("vertical", m_rigidbody.velocity.y);
    }

    public void OnSpellExecuted()
    {
        m_animator.SetTrigger("hit");
    }

    public void OnDamageTaken()
    {
        m_animator.SetTrigger("autsch");

    }

}

