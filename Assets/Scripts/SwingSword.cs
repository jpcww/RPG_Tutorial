using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject sword;
    public int swordStatus;


	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1") && swordStatus == 0 && AttackBlocker.blockSword ==0)
        {
            StartCoroutine(SwingingSword());
        }
	}

    // action of sword has 3 status
    // since we need to wait for 1 sec, we use coroutin
    IEnumerator SwingingSword()
    {
        // 2nd status, swinging sword(playing animation)
        swordStatus = 1;
        sword.GetComponent<Animation>().Play("HeavyFullMetalSword");

        // 3rd status, waiting for 1 sec (until the animation is finished)
        swordStatus = 2;
        yield return new WaitForSeconds(1.0f);

        // 1st status, doing nothing
        swordStatus = 0;

    }
}
