using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour {

    public static int heartValue;
    public int internalHeart;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Use this for initialization
    void Start ()
    {
        heartValue = 1;
		
	}

    // Update is called once per frame
    void Update()
    {
        internalHeart = heartValue;

        // when health is 0, load gameOver scene
        if (heartValue <= 0)
        {
            SceneManager.LoadScene(1);
        }


        if (heartValue == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }

        if (heartValue == 2)
        {
            heart2.SetActive(true);
            heart3.SetActive(false);
        }

        if(heartValue==3)
        {
            heart3.SetActive(true);
        }

	}
}
