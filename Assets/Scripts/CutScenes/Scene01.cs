using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject FadeOut;
    public GameObject FadeIn;
    public GameObject Player;
    public GameObject miniMap;

	// Use this for initialization
	void Start()
    {
        StartCoroutine(CutSceneStart());
	}

    IEnumerator CutSceneStart()
    {
        // wait for 5 sec for Camera1
        yield return new WaitForSeconds(5);
        Camera1.SetActive(false);
        FadeIn.SetActive(false);

        //turn on Camera 2 and wait for 5 sec
        Camera2.SetActive(true);
        yield return new WaitForSeconds(5);

        //turn off Camera2, turn on Camera3 and waif for 5 sec
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        yield return new WaitForSeconds(5);

        //turn on fade out and wait for 4 sec
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(4);

        //turn off Camera3 and turn on Player
        FadeIn.SetActive(true);
        FadeOut.SetActive(false);
        Player.SetActive(true);
        Camera3.SetActive(false);
        yield return new WaitForSeconds(1);

        // turn on miniMap and fadeIn for the UIs
        miniMap.SetActive(true);
        FadeIn.SetActive(false);

    }

}