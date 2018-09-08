using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest002Start : MonoBehaviour
{
    public float distance;
    public GameObject actionButton;
    public GameObject actionText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // get the distance between this object and Player
        distance = PlayerCasting.distanceFromTarget;
	}

    private void OnMouseOver()
    {
        if (distance <= 3)
        {
            // prevent Playe from yielding his sword
            AttackBlocker.blockSword = 1;
            // Showing UIs
            actionText.GetComponent<Text>().text = "Open Gate";
            actionText.SetActive(true);
            actionButton.SetActive(true);

            if (Input.GetButtonDown("Action"))
            {
                AttackBlocker.blockSword = 3;

                // for the mouse cursor
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                actionText.SetActive(false);
                actionButton.SetActive(false);
            }
        }
    }
}
