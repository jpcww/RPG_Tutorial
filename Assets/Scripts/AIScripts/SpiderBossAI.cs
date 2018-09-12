﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderBossAI : MonoBehaviour
{

    public GameObject destination;
    NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start ()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        navMeshAgent.SetDestination(destination.transform.position);
		
	}
}
