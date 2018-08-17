using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource heartCollectSount;
    public GameObject heart;

	// Update is called once per frame
	void Update ()
    {
		transform.Rotate(0, rotateSpeed, 0, Space.World);
	}

    // collecting hearts
    private void OnTriggerEnter(Collider other)
    {
        heartCollectSount.Play();
        heart.SetActive(false);
    }
}
