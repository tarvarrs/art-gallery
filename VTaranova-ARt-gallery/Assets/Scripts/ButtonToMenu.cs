using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MuseumMenu;

    public void ToMenu()
    {
        MainMenu.SetActive(true);
        MuseumMenu.SetActive(false);
    }
}
