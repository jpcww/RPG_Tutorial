using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        PlayerPrefs.SetInt("GoldAmoutSave", GlobalCash.goldAmount);
	}

}
