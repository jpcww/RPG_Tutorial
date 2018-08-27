using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int activeQuestNumber;
    public int internalQuestNumber;

    private void Update()
    {
        // to notify what quest we are currently with numbers
        internalQuestNumber = activeQuestNumber;
    }

}
