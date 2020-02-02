using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CampaignButton : MonoBehaviour
{
    public Button campaign;

    public void ChangeScene()
    {
        SceneManager.LoadScene("Level0");
    }
}
