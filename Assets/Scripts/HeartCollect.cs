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
        // keep the heart rotating
		transform.Rotate(0, rotateSpeed, 0, Space.World);
	}

    // collecting hearts
    private void OnTriggerEnter(Collider other)
    {
        // Play the sound when collecting a heart
        heartCollectSount.Play();
        // Increase the heart by 1
        HealthMonitor.heartValue += 1;
        // make the heart disappear
        heart.SetActive(false);
    }
}
