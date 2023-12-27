using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<SkillData> playerSkillDatas = new List<SkillData>();
    public PlayerLv playerLv;
    public PlayerLvSkillEvent playerLvSkillEvent;

    public void Awake()
    {
        playerLv = gameObject.GetComponent<PlayerLv>();
        playerLvSkillEvent = gameObject.GetComponent<PlayerLvSkillEvent>();
    }

    public void Start()
    {
        playerSkillDatas.Add(TestManager.I.skillList.skillDatas[0]);
        playerSkillDatas.Add(TestManager.I.skillList.skillDatas[1]);
        playerSkillDatas.Add(TestManager.I.skillList.skillDatas[2]);
    }
}
