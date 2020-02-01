using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CampaignButton : MonoBehaviour
{

    void Update()
    {
        //gameObject.GetComponent<Button>().onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("MovementTest");
    }
}
