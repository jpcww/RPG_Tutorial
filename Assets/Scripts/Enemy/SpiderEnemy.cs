using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject spider;
    public int spiderStatus;
    public int baseEXP = 10;
    public int calculatedEXP; 

    // deduct the health of spider when it is hit
    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

	// Update is called once per frame
	void Update ()
    {
        if (enemyHealth <= 0)
        {
            if (spiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }
            
        }
	}

    // give a dealy to the death of Spider
    IEnumerator DeathSpider()
    {
        spiderStatus = 6;
        calculatedEXP = baseEXP * GlobalLevel.currentLevel;
        GlobalEXP.currentEXP += 10 + calculatedEXP;
        yield return new WaitForSeconds(0.5f);
        spider.GetComponent<Animation>().Play("die");
    }
}
