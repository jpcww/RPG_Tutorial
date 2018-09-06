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
    public SpiderAI spiderAI;
    public static int globalSpider;

    private void Start()
    {
        spiderAI = GetComponent<SpiderAI>();
    }

    // deduct the health of spider when it is hit
    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

	// Update is called once per frame
	void Update ()
    {
        // make the spider's status global(static)
        globalSpider = spiderStatus;

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
        // turn off spiderAI component
        spiderAI.enabled = false;
        // change the indicator to 6
        spiderStatus = 6;
        calculatedEXP = baseEXP * GlobalLevel.currentLevel;
        GlobalEXP.currentEXP += 10 + calculatedEXP;
        yield return new WaitForSeconds(0.5f);
        spider.GetComponent<Animation>().Play("die");
    }
}
 