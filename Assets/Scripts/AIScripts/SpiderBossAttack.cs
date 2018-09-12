using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossAttack : MonoBehaviour
{
    public GameObject enemy;
    public int attackTrigger;
    public int dealDamage;


	// Update is called once per frame
	void Update ()
    {
        if(attackTrigger == 0)
        {
            enemy.GetComponent<Animation>().Play("Walk");
        }

        if(attackTrigger == 1)
        {
            if(dealDamage == 0)
            {
                enemy.GetComponent<Animation>().Play("Attack");
                StartCoroutine(TakingDamage());
            }
        }
		
	}

    IEnumerator TakingDamage()
    {
        dealDamage = 2;
        yield return new WaitForSeconds(1.1f);

        if(SpiderEnemy.globalSpider !=6)
        {
            HealthMonitor.heartValue -= 1;
        }

        yield return new WaitForSeconds(0.5f);

        dealDamage = 0;
    }

    void OnTriggerEnter()
    {
        attackTrigger = 1;
    }

    void OnTriggerExit()
    {
        attackTrigger = 0;
    }
}
