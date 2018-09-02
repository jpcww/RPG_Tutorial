using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int currentLevel = 2;
    public int internalLevel;


	// Update is called once per frame
	void Update ()
    {
        internalLevel = currentLevel;	
	}
}
