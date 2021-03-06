﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001ChestTrigger : MonoBehaviour
{
    public float distance;
    public GameObject chest;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject objective;
    public int closeObjective;
    public GameObject takeSword;

    Vector3 scale;

    private void Start()
    {
        scale = objective.transform.localScale;
    }

    // Update is called once per frame
    void Update ()
    {
        // mesure the distace from the object and Player
        distance = PlayerCasting.distanceFromTarget;


        //when the objective is closed
        if (closeObjective == 3)
        {
            // make the UI of this objective active 
            objective.SetActive(true);

            if (scale.y <= 0.0f)
            {
                closeObjective = 0;
                objective.SetActive(false);
            }
            else
            {
                scale.y -= 0.01f;
                objective.transform.localScale = scale;

            }
        }
	}

     void OnMouseOver()
    {
        // when the distance is less than 3
        if (distance <= 3)
        {
            actionText.GetComponent<Text>().text = "Open Chest";
            actionText.SetActive(true);
            actionDisplay.SetActive(true);

            // when Action button is pressed
            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                chest.GetComponent<Animation>().Play("Q01ChestOpen");

                // activate SwordTrigger
                takeSword.SetActive(true);

                //Flag
                closeObjective = 3;
          
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }


}
