﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameManager
{


    //player related
    private int score = 0;
    private int mana = 100;

    //map related
    private int level = 1;

    private readonly int START_SCORE = 0;
    private readonly int START_MANA = 100;
    private readonly int START_LEVEL = 1;



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

    public void IncreaseMana(int value)
    {
        this.mana += value;
    }

    public void LoadLevel(int level)
    {
        score = START_SCORE;
        mana = START_MANA;
        level = START_LEVEL;
    }

    public void resetLevel()
    {
        score = START_SCORE;
        mana = START_MANA;
        level = START_LEVEL;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
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
