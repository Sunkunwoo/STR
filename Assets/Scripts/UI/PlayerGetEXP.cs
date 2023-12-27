using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetEXP : MonoBehaviour
{
    public int exp;

    public void GetExp()
    {
        TestManager.I.player.playerLv.AddExp(exp);
        while (TestManager.I.player.playerLv.Exp >= TestManager.I.player.playerLv.MaxExp)
        {
            TestManager.I.player.playerLv.Lv++;
            TestManager.I.player.playerLv.Exp -= TestManager.I.player.playerLv.MaxExp;
            TestManager.I.player.playerLv.MaxExp *= 2;
            TestManager.I.player.playerLvSkillEvent.LvUpSkillGetEvent(TestManager.I.player.playerLv.Lv);
        }
    }
}
