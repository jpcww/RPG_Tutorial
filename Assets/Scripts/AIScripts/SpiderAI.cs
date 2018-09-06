using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public GameObject Player;
    public float targetDistance;
    public float allowedRange = 40;
    public GameObject spider;
    public float spiderSpeed;
    public int attackTrigger;
    public RaycastHit shot;
    public int dealDamage;

	// Update is called once per frame
	void Update ()
    {
        // look at Player
        transform.LookAt(Player.transform);

        // raycasting
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;

            // when Player is within the range of Spider
            if (targetDistance <= allowedRange)
            {
                spiderSpeed = 0.05f;

                // the first state of Spider, Walking towards Player
                if (attackTrigger == 0)
                {
                    spider.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, spiderSpeed);
                }
            }

            // when Player is out of the range of Spider,
            // Spider idling
            else
            {
                spiderSpeed = 0;
                spider.GetComponent<Animation>().Play("idle");
            }
        }

        // when the trigger is 1, spider stops and attacks
        if (attackTrigger == 1)
        {
            if (dealDamage == 0)
            {
                spiderSpeed = 0;
                spider.GetComponent<Animation>().Play("attack");
                StartCoroutine(TakingDamage());
            }
        }
	}
    
    // what happens when Play takes damage from spider
    IEnumerator TakingDamage()
    {
        //indicator is set to 2, and wait for half sec
        dealDamage = 2;
        yield return new WaitForSeconds(0.5f);

        //if spider is not dead, while attacking Player, decrease the health point of Player by 1
        if (SpiderEnemy.globalSpider != 6)
        {
            HealthMonitor.heartValue -= 1;
        }

        // and wait for half sec and set the indicator into 0 for spider to attack
        yield return new WaitForSeconds(0.5f);
        dealDamage = 0;
    }

    // when spider reaches Player's colldier
    void OnTriggerEnter(Collider other)
    {
        attackTrigger = 1;

    }

    // when spider doesn't lose Player's collider
    void OnTriggerExit()
    {
        attackTrigger = 0;
    }
}
