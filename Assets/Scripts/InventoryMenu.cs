using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{
    public bool inventoryOpen = false;
    public GameObject inventoryMenu;
    public GameObject player;


	void Update ()
    {
		if(Input.GetButtonDown("Cancel"))
        {
            // we haven't open the inventory menu yet
            if(inventoryOpen == false)
            {
                // stop the time
                Time.timeScale = 0;

                // turn on the menu
                inventoryMenu.SetActive(true);
                
                // update the bool
                inventoryOpen = true;

                //let mouse function
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                // turn off the player to prevent the camera from moving
                player.GetComponent<FirstPersonController>().enabled = false;
            }

            // when the inventory menu is open, we press ESC
            else
            {
                // turn on the player back
                player.GetComponent<FirstPersonController>().enabled = true;

                // turn off the menu
                inventoryMenu.SetActive(false);

                //update the bool
                inventoryOpen = false;

                // turn off the cursor
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                // set the time back
                Time.timeScale = 1;
            }
        }
	}
}
