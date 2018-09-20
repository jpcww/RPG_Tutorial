using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject menuSlider;
    public GameObject anywhereButton;
    public GameObject anywhereText;
    public AudioSource menuMusic;
    public GameObject loadingGame;
    

    public void SlideMenu()
    {
        menuSlider.GetComponent<Animation>().Play("SideBarAnimaiton");
        anywhereButton.SetActive(false);
        anywhereText.SetActive(false);
    }

    public void NewGame()
    {
        menuMusic.Stop();
        loadingGame.SetActive(true);
        SceneManager.LoadScene(0);
    }
}
