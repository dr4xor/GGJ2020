using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaBarController : MonoBehaviour
{
    [SerializeField] private RectTransform manaMask;

    private float startWidth;

    private float targetWidth;
    // Start is called before the first frame update
    void Start()
    {
        startWidth = manaMask.rect.width;
    }

    // Update is called once per frame
    void Update()
    {

        var manaProgress = GameManager.Instance.getMana() / 100f;
        targetWidth = Mathf.Lerp(0f, startWidth, manaProgress);

        manaMask.sizeDelta = Vector2.Lerp(manaMask.sizeDelta, new Vector2(targetWidth, manaMask.sizeDelta.y), Time.deltaTime * 10);
    }
}
