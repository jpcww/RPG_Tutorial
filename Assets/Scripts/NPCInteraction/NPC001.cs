﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPC001 : MonoBehaviour
{
    public float distance;
    public GameObject actionButton;
    public GameObject actionText;
    public GameObject player;
    public GameObject textBox;
    public GameObject NPCName;
    public GameObject NPCText;
    public GameObject gateOpen;
    public GameObject miniMap;


     void Update()
    {
        // get the distance from gameObject and Player
        distance = PlayerCasting.distanceFromTarget;
    }

    // when mouse is on the NPC
    void OnMouseOver()
    {
        // when the distance is less than 3
        if (distance <=3)
        {
            AttackBlocker.blockSword = 1;
            actionText.GetComponent<Text>().text = "Talk";
            actionText.SetActive(true);
            actionButton.GetComponent<Text>().text = "[F]";
            actionButton.SetActive(true);

            // when action button is press
            if (Input.GetButtonDown("Action"))
            {
                // block attacking
                AttackBlocker.blockSword = 2;

                //let mouse function
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                // turn off UIs
                actionText.SetActive(false);
                actionButton.SetActive(false);

                // get couroutine started
                StartCoroutine(NPC001Active());
            }
        }
    }


    // get NPC001 interact with Player
    IEnumerator NPC001Active()
    {
        if (QuestManager.activeQuestNumber == 2)
        {
            // turn off MIniMap
            miniMap.SetActive(false);

            // turn on UIs for interacting
            textBox.SetActive(true);
            NPCName.GetComponent<Text>().text = "Red";
            NPCName.SetActive(true);
            NPCText.GetComponent<Text>().text = " We have a spider problem. Can you go outside the village, kill the spiders and thier boss. Here is the key";
            NPCText.SetActive(true);

            // get to be able to open the gate
            gateOpen.SetActive(true);

            // wait for 5 sec for the user to read
            yield return new WaitForSeconds(5);

            // turn off UIs for interacting
            NPCName.SetActive(false);
            NPCText.SetActive(false);
            textBox.SetActive(false);

            // get the premier UIs back
            actionButton.SetActive(true);
            actionText.SetActive(true);
        }

        else
        {
            // turn off MIniMap
            miniMap.SetActive(false);

            // turn on UIs for interacting
            textBox.SetActive(true);
            NPCName.GetComponent<Text>().text = "Red";
            NPCName.SetActive(true);
            NPCText.GetComponent<Text>().text = "Greetings, I need your help. If you wish to, please come to me here in the afternoon";
            NPCText.SetActive(true);

            // wait for 5 sec for the user to read
            yield return new WaitForSeconds(5);

            // turn off UIs for interacting
            NPCName.SetActive(false);
            NPCText.SetActive(false);
            textBox.SetActive(false);

            // get the premier UIs back
            actionButton.SetActive(true);
            actionText.SetActive(true);

        }

    }

    // when mouse has exited from the NPC
    void OnMouseExit()
    {
        // attacking functioning
        AttackBlocker.blockSword = 0;
        print(AttackBlocker.blockSword);
        // turn off UIs
        actionText.SetActive(false);
        actionButton.SetActive(false);
    }


}
