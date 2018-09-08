using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour
{
    public GameObject Player;
    public GameObject noticeCamera;
    public GameObject UIQuest;
    public GameObject activeQuestBox;
    public GameObject objective01;
    public GameObject objective02;
    public GameObject objective03;
    public GameObject exMark;
    public GameObject notice;
    public GameObject noticeTrigger;
    public GameObject miniMap;

    // a function for when Accept button is pressed
    public void AcceptQuest()
    {
        // when accepting quest, turn on MiniMap
        miniMap.SetActive(true);

        // notify QuestManager that we have taken the quest and update the quest indicating nummbers
        QuestManager.subQuestNumber = 1;

        Player.SetActive(true);
        noticeCamera.SetActive(false);
        UIQuest.SetActive(false);
        exMark.SetActive(false);

        StartCoroutine(SetQuestUI ());
    }

    IEnumerator SetQuestUI()
    {
        // make things seem like I have accepted the quest
        exMark.SetActive(false);
        notice.SetActive(false);
        noticeTrigger.SetActive(false);

        // show the quests objectives
        activeQuestBox.GetComponent<Text>().text = "My First Weapon";
        objective01.GetComponent<Text>().text = "Reach the clearing in the the wood";
        objective02.GetComponent<Text>().text = "Open the Chest";
        objective03.GetComponent<Text>().text = "Retreive the weapon";

        QuestManager.activeQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);

        // make UI appear and disappear in order
        activeQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);

        objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        objective03.SetActive(true);
        yield return new WaitForSeconds(9);

        activeQuestBox.SetActive(false);
        objective01.SetActive(false);
        objective02.SetActive(false);
        objective03.SetActive(false);
    }

    public void DeclineQuest()
    {
        // when denying quest, turn on MiniMap
        miniMap.SetActive(true);

        Player.SetActive(true);
        noticeCamera.SetActive(false);
        UIQuest.SetActive(false);
    }

}
