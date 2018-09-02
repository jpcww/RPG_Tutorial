using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEXP : MonoBehaviour
{
    public static int currentEXP;
    public int internalEXP;

	// Update is called once per frame
	void Update ()
    {
        internalEXP = currentEXP;
		
	}
}
