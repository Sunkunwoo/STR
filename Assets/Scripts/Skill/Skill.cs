using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    string skillName;
    public SkillData skill;
    public int skillExp;

    void Start()
    {
        skillName = gameObject.name.Replace("(Clone)", "").Trim();
        skill = FindItem(skillName, TestManager.I.skillList.skillDatas);
        Debug.Log($"Found item: {skill.skillName}");
        Debug.Log($"Found item: {skill.index}");
    }

    SkillData FindItem(string skillName, List<SkillData> skillList)
    {
        return skillList.Find(skill => skill.skillName == skillName);
    }
}
