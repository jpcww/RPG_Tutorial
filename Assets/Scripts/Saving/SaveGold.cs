using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{
    public int loadGold;

	// Use this for initialization
	void Start ()
    {
        // when game starts, load the amount of gold saved
        loadGold = PlayerPrefs.GetInt("GoldAmountSave");
	}

}
