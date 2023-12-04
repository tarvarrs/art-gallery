using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToMuseum : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MuseumMenu;

    public void ToMuseum()
    {
        MainMenu.SetActive(false);
        MuseumMenu.SetActive(true);
    }
}
