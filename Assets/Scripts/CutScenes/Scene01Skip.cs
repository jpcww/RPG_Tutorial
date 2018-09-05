using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Skip : MonoBehaviour
{
    public GameObject fadeIn;


	// Use this for initialization
	void Start ()
    {
        StartCoroutine(FadeQuit());
	}

    IEnumerator FadeQuit()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
