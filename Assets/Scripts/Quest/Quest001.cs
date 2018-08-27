using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001 : MonoBehaviour
{

    public float theDistance;
    public GameObject actionButton;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject player;
    public GameObject noticeCamera;



    // Update is called once per frame
    void Update ()
    {
        theDistance = PlayerCasting.distanceFromTarget;
	}

    // When mouse is on the quest board
     void OnMouseOver()
    {
        // when the distance from Player is less than 3
        if (theDistance <= 3)
        {
            // for the mouse cursor
            Screen.lockCursor = false;
            Cursor.visible = true;

            actionButton.SetActive(true);
            actionText.SetActive(true);

            // and when the action button is pressed
            if (Input.GetButtonDown("Action"))
            {
                actionButton.SetActive(false);
                actionText.SetActive(false);
                UIQuest.SetActive(true);
                noticeCamera.SetActive(true);
                player.SetActive(false);
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
