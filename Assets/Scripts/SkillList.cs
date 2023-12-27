using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillList : MonoBehaviour
{
    public List<SkillData> skillDatas;

    void Awake()
    {
        SkillData[] loadedSkillDatas = Resources.LoadAll<SkillData>("SkillData");

        skillDatas.AddRange(loadedSkillDatas);

        foreach (var skillData in skillDatas)
        {
            Debug.Log("Loaded Skill Name: " + skillData.skillName);
        }
    }

}
