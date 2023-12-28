using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<SkillData> playerSkillDatas = new List<SkillData>();
    public PlayerLv playerLv;
    public PlayerLvSkillEvent playerLvSkillEvent;
    public SkillSlotUI[] skillSlots; 

    public void Awake()
    {
        playerLv = gameObject.GetComponent<PlayerLv>();
        playerLvSkillEvent = gameObject.GetComponent<PlayerLvSkillEvent>();
    }

    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            playerSkillDatas[i] = TestManager.I.skillList.skillDatas[i];
        }
        InitializeSkillSlots();
    }

    private void InitializeSkillSlots()
    {
        for (int i = 0; i < skillSlots.Length; i++)
        {
            if (i < playerSkillDatas.Count)
            {
                skillSlots[i].SetSkillData(playerSkillDatas[i]);
            }
            else
            {
                skillSlots[i].SetSkillData(null);
            }
        }
    }
}
