using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{

    private Spell fire;
    private Spell water;
    private Spell earth;
    private Spell air;

    private Spell active;

    private const float cooldown = 1;
    private float lastSpellTime;

    // Start is called before the first frame update
    void Awake()
    {
        fire = new FireSpell();
        water = new WaterSpell();

        active = water;
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.inputString)
        {
            case "1":
                active = fire;
                break;
            case "2":
                active = water;
                break;
            case "3":
                active = earth;
                break;
            case "4":
                active = air;
                break;
        }

        if(Input.GetKeyDown (KeyCode.Mouse0) && Time.time - lastSpellTime > cooldown)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            active.OnTrigger(Camera.main.ScreenToWorldPoint(mousePos), GetComponent<PlayerController>());
            lastSpellTime = Time.time;
        }

    }
}
