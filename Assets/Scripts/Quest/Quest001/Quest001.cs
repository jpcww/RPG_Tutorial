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
    public GameObject miniMap;



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
            // when approching enough to Notice Board, turn off MiniMap
            miniMap.SetActive(false);

            // for the mouse cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            //for sword not to attack
            AttackBlocker.blockSword = 3;

            actionButton.SetActive(true);
            actionText.SetActive(true);

            // and when the action button is pressed to take Quest
            if (Input.GetButtonDown("Action"))
            {
                //for the sword not to attack
                AttackBlocker.blockSword = 2;

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
        //for sword not to attack
        AttackBlocker.blockSword = 0;

        actionButton.SetActive(false);
        actionText.SetActive(false);
    }
}
