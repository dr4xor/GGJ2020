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

    private bool isInSpell = false;

    // Start is called before the first frame update
    void Awake()
    {
        fire = new FireSpell();
        water = new WaterSpell();
        air = new AirSpell();
        earth = new EarthSpell();

        active = fire;
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.inputString)
        {
            case "1":
                active = fire;
                GameManager.Instance.SelectSpell(1);
                break;
            case "2":
                active = water;
                GameManager.Instance.SelectSpell(2);
                break;
            case "3":
                active = earth;
                GameManager.Instance.SelectSpell(3);
                break;
            case "4":
                active = air;
                GameManager.Instance.SelectSpell(4);
                break;
        }

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;

        var playerController = GetComponent<PlayerController>();

        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time - lastSpellTime > cooldown)
        {
            isInSpell = true;
            active.OnTriggerDown(Camera.main.ScreenToWorldPoint(mousePos), playerController);
            lastSpellTime = Time.time;
        }

        if(isInSpell)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                active.OnTriggerMove(Camera.main.ScreenToWorldPoint(mousePos), playerController);
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                isInSpell = false;
                active.OnTriggerUp(Camera.main.ScreenToWorldPoint(mousePos), playerController);
            }
        }
    }
}
