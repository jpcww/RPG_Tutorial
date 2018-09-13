using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001OpenGate : MonoBehaviour
{
    public float distance;
    public GameObject actionButton;
    public GameObject actionText;
    public GameObject leftGate;
    public GameObject rightGate;
	
	// Update is called once per frame
	void Update ()
    {
        distance = PlayerCasting.distanceFromTarget;
	}

    private void OnMouseOver()
    {
        if(distance <= 3)
        {
            AttackBlocker.blockSword = 1;
            actionText.GetComponent<Text>().text = "Open Gate";
            actionText.SetActive(true);
            actionButton.SetActive(true);


            if (Input.GetButtonDown("Action"))
            {
                // when action button is pressed, 
                //turn off the collider
                GetComponent<BoxCollider>().enabled = false;

                // prevent player from attacking
                AttackBlocker.blockSword = 2;

                // turn off uis
                // play animation of gate to open them
                actionButton.SetActive(false);
                actionText.SetActive(false);
                actionText.GetComponent<Text>().text = " ";
                leftGate.GetComponent<Animation>().Play("LeftGate");
                rightGate.GetComponent<Animation>().Play("RightGate");
            }
        }
    }
}
