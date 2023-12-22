using UnityEngine;
public class MenuChange : MonoBehaviour {
    public GameObject menuToShow; 
    public GameObject menuToHide; 
    public void ToMenu()
    {
        menuToShow.SetActive(true); 
        menuToHide.SetActive(false);
    }
}