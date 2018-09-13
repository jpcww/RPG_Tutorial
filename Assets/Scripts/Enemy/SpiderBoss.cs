using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBoss : MonoBehaviour
{
    public int enemyHealth = 5;
    public GameObject spider;
    public int spiderStatus;
    public int baseEXP = 10;
    public int calculatedEXP;
    public SpiderBossAI spiderBossAI;
    public static int globalSpider;
    public GameObject oldNPC;
    public GameObject newNPC;
    public SpiderBossAttack spiderBossAttack;

    private void Start()
    {
        spiderBossAI = GetComponent<SpiderBossAI>();
        spiderBossAttack = GetComponent<SpiderBossAttack>();
    }

    // deduct the health of spider when it is hit
    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
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
        // turn off spiderAI and SPiderAttack component
        spiderBossAI.enabled = false;
        spiderBossAttack.enabled = false;

        // change the indicator to 6
        // obtain EXP
        spiderStatus = 6;
        calculatedEXP = baseEXP * GlobalLevel.currentLevel;
        GlobalEXP.currentEXP += 10 + calculatedEXP;
        yield return new WaitForSeconds(0.5f);

        // play death animation
        spider.GetComponent<Animation>().Play("Death");
        yield return new WaitForSeconds(0.3f);

        // turn off animation component
        spider.GetComponent<Animation>().enabled = false;

        oldNPC.SetActive(false);
        newNPC.SetActive(true);
    }
}

