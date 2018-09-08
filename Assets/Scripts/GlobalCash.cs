using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int goldAmount;
    public int internalGoldAmount;
    public GameObject goldDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        internalGoldAmount = goldAmount;
        goldDisplay.GetComponent<Text>().text = "Gold : " + goldAmount;
    }
}
