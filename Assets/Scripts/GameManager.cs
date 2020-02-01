using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{


    //player related
    [SerializeField] GameObject player;
    private int score;
    private int mana;

    //map related
    private int level;

    private readonly int START_SCORE = 0;
    private readonly int START_MANA = 100;
    private readonly int START_LEVEL = 1;


    private GameManager()
    {
        score = START_SCORE;
        mana = START_MANA;
        level = START_LEVEL;
    }


    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public void DecreaseMana(int value)
    {
        this.mana -= value;
    }

    public void LoadLevel(int level)
    {
        score = START_SCORE;
        mana = START_MANA;
        level = START_LEVEL;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public int getMana()
    {
        return this.mana;
    }
}
