using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class SkillManager : MonoBehaviour
{

    void OnEnable()
    {
        SkillSlot.OnAbilityPointSpent += HandleAbilityPointSpent;
    }

    void OnDisable()
    {
        SkillSlot.OnAbilityPointSpent -= HandleAbilityPointSpent;
    }



    private void HandleAbilityPointSpent(SkillSlot slot)
    {
        string skillName = slot.skillSO.skillName;

        switch(skillName)
        {
            case "Max Health Boost":
                StatsManager.Instance.UpdateMaxHealth(1);
                GetComponent<PlayerHealth>().ChangeHealth(2);
                break;

            case "Damage Boost":
                StatsManager.Instance.UpdateStrength(1);
                break;

            default:
                Debug.LogWarning("Unknown skill:" + skillName);
                break;
        }
    }
}

