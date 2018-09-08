using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecroMancerWalkAI : MonoBehaviour
{
    public int xPosition;
    public int zPosition;
    public GameObject NPCdestination;

	// Use this for initialization
	void Start ()
    {
        xPosition = Random.Range(250, 268);
        zPosition = Random.Range(248, 283);
        NPCdestination.transform.position = new Vector3(xPosition, 0, zPosition);
        StartCoroutine(RandomWalk());
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(NPCdestination.transform);
        transform.position = Vector3.MoveTowards(transform.position, NPCdestination.transform.position, 0.08f);
	}

    IEnumerator RandomWalk()
    {
        yield return new WaitForSeconds(5);
        xPosition = Random.Range(250, 268);
        zPosition = Random.Range(248, 283);
        NPCdestination.transform.position = new Vector3(xPosition, 0, zPosition);
        StartCoroutine(RandomWalk());
    }
}
