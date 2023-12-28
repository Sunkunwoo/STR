using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSkill : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = gameObject.GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int otherLayer = other.gameObject.layer;
        string otherLayerName = LayerMask.LayerToName(otherLayer);

        if (otherLayerName == "Skill")
        {
            Skill otherSkillComponent = other.gameObject.GetComponent<Skill>();

            if (otherSkillComponent != null)
            {
                bool skillFound = false;

                for (int i = 0; i < player.playerSkillDatas.Count; i++)
                {
                    if (player.playerSkillDatas[i].index == 0)
                    {
                        player.playerSkillDatas[i] = otherSkillComponent.skill;
                        player.skillSlots[i].SetSkillData(player.playerSkillDatas[i]);
                        skillFound = true;
                        break;
                    }
                    else if (player.playerSkillDatas[i].index == otherSkillComponent.skill.index)
                    {
                        player.playerSkillDatas[i].AddSkillExp(otherSkillComponent.skillExp);
                        player.skillSlots[i].SetSkillData(player.playerSkillDatas[i]);
                        skillFound = true;
                        break;
                    }
                }

                if (!skillFound)
                {
                    player.playerSkillDatas.Add(otherSkillComponent.skill);
                    player.skillSlots[player.playerSkillDatas.Count - 1].SetSkillData(otherSkillComponent.skill);
                }

                UpdateSkillSlotUI();
            }
            Destroy(other.gameObject);
        }
    }

    private void UpdateSkillSlotUI()
    {
        foreach (SkillSlotUI skillSlot in player.skillSlots)
        {
            skillSlot.UpdateUI();
        }
    }

}
