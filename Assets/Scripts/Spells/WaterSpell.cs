using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpell : Spell
{
    private GameObject wölkchen;
    private Vector3 currentVelocity;
    public float manaCost;
    public float timePassed;

    public WaterSpell() { }

    public override void OnTriggerDown(Vector2 mousePos, PlayerController p)
    {
        wölkchen = (GameObject)GameObject.Instantiate(Resources.Load("WaterSpell")) as GameObject;
        wölkchen.transform.position = mousePos;
        timePassed = 0;
    }

    public override void OnTriggerMove(Vector2 mousePos, PlayerController p)
    {
        wölkchen.transform.position = Vector3.SmoothDamp(wölkchen.transform.position, mousePos, ref currentVelocity, Time.deltaTime * 2, 5);
        timePassed += Time.deltaTime;
    }

    public override void OnTriggerUp(Vector2 mousePos, PlayerController p)
    {
        manaCost = timePassed;
        GameObject.Destroy(wölkchen, 1);
        wölkchen.GetComponentInChildren<ParticleSystem>()?.Stop();
        wölkchen.GetComponent<Animator>().SetTrigger("kill");
        Debug.Log(manaCost);
    }

    public override void CalculateMana()
    {

    }
}
