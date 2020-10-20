using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVisible : MonoBehaviour
{
    [SerializeField]
    bool isMenuVisible = false;

    public bool IsMenuVisible { get => isMenuVisible; set => isMenuVisible = value; }



    [SerializeField]
    private GameObject[] menus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsMenuVisible)
            {
                Visible();
            }
            else
            {
                Invisible();
            }
        }
    }

    void Visible()
    {
        //配列の要素一つ一つに対して処理を行う
        foreach (GameObject menu in menus)
        {
            menu.SetActive(true);
        }
        IsMenuVisible = true;
    }

    void Invisible()
    {
        //配列の要素一つ一つに対して処理を行う
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        IsMenuVisible = false;
    }
}
