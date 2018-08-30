using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{

    public float theDistance;
    public GameObject actionButton;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject player;
    public GameObject exMark;
    public GameObject completeTrigger;



    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    // When mouse is on the quest board
    void OnMouseOver()
    {
        // when the distance from Player is less than 3
        if (theDistance <= 3)
        {
            actionButton.SetActive(true);
            actionButton.GetComponent<Text>().text = "Complete Quest";

            // and when the action button is pressed
            if (Input.GetButtonDown("Action"))
            {
                exMark.SetActive(false);
                GlobalEXP.currentEXP += 100;
                actionButton.SetActive(false);
                actionText.SetActive(false);
                completeTrigger.SetActive(false);
            }
        }
    }

    // when the mouse has moved away from the mission board
    void OnMouseExit()
    {
        actionButton.SetActive(false);
        actionText.SetActive(false);
    }
}
