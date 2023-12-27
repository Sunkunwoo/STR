using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvSkillEvent : MonoBehaviour
{
    public List<int> index;
    public List<int> lvupLock;

    public void LvUpSkillGetEvent(int lv)
    {
        int listSize = index.Count;

        for (int i = 0; i < listSize; i++)
        {
            if (lv % lvupLock[i] == 0)
            {
                if (TestManager.I.player.playerSkillDatas[i] == null)
                {
                    TestManager.I.player.playerSkillDatas[i] = TestManager.I.skillList.skillDatas[i];
                }
                else
                {
                    TestManager.I.player.playerSkillDatas[i].SkillLvup();
                    Debug.Log(TestManager.I.player.playerSkillDatas[i].skillLv);
                }
            }
        }
    }
}
