using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int activeQuestNumber;
    public int internalQuestNumber;

    public GameObject mainMark;
    public GameObject objective01Mark;
    public GameObject objective02Mark;
    public GameObject objective03Mark;
    public static int subQuestNumber;
    public int internalSubQuestNumber;
    public GameObject pointer;

    void Update()
    {
        // to notify what quest we are currently with numbers
        internalQuestNumber = activeQuestNumber;
        internalSubQuestNumber = subQuestNumber;

        // switch for Pointer
        if (internalSubQuestNumber == 0)
        {
            pointer.SetActive(false);
        }

        else
        {
            pointer.SetActive(true);
        }

        pointer.transform.LookAt(mainMark.transform);

        if (internalSubQuestNumber == 1)
        {
            mainMark.transform.position = objective01Mark.transform.position;
        }

        if (internalSubQuestNumber == 2)
        {
            mainMark.transform.position = objective02Mark.transform.position;
        }

        if(internalSubQuestNumber == 3)
        {
            mainMark.transform.position = objective03Mark.transform.position;
        }
    }

}
