using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager singleton;

    [SerializeField] private Canvas manaIndicatorPrefab;
    private Canvas manaIndicatorObj;

    [SerializeField] private Canvas elementSelectionPrefab;
    private Canvas elementSelectionObj;

    [SerializeField] private Canvas pauseMenuPrefab;
    private Canvas pauseMenuObj;

    [SerializeField] private Canvas mainMenuPrefab;
    private Canvas mainMenuObj;


    void Awake()
    {
        singleton = this;
    }


    public void ShowMainMenu()
    {
        if (elementSelectionObj == null)
            mainMenuObj = Instantiate(mainMenuPrefab);
    }

    public void HideMainMenu()
    {
        if(mainMenuObj != null)
        {
            Destroy(mainMenuObj);
        }
    }

    public void ShowPauseMenu()
    {
        if (pauseMenuObj == null)
            pauseMenuObj = Instantiate(pauseMenuPrefab);
    }

    public void HidePauseMenu()
    {
        if (pauseMenuObj != null)
        {
            Destroy(pauseMenuObj);
        }
    }

    public void ShowElementSelection()
    {
        if(elementSelectionObj == null)
            elementSelectionObj = Instantiate(elementSelectionPrefab);
    }

    public void HideElementSelection()
    {
        if (elementSelectionObj != null)
        {
            Destroy(elementSelectionObj);
        }
    }


}

