using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlocker : MonoBehaviour
{
    public static int blockSword;
    public int internalBlockSword;

    void Update()
    {
        internalBlockSword = blockSword;

    }

}
