using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Trigger : MonoBehaviour
{
    public GameObject objective;
    public int closedObjective;

    Vector3 scale;

    // Update is called once per frame
    void Update ()
    {
        if (closedObjective == 1)
        {
            if (objective.transform.localScale.y <= 0.0f)
            {
                closedObjective = 3;
                objective.SetActive(false);
            }

            else
            {
                scale = objective.transform.localScale;
                scale.y -= 0.01f;
                objective.transform.localScale = scale;
            }
        }
	}



    // detect when player enters the clearing
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(FinishObjective());
        }
    }

    // turn off the objective UI
    IEnumerator FinishObjective()
    {
        objective.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        closedObjective = 1;

    }
}
