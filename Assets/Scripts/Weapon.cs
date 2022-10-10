using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Sprite weaponSprite;

    private int _baseDamage;
    private float _coolDown;
    private bool _canUseSkill;
    
    [SerializeField] private WeaponSkills skill;

    [SerializeField]
    private enum WeaponSkills
    {
        Skill1,
        Skill2,
        Skill3,
    }

    private void UseSkill()
    {
        switch (skill)
        {
            case WeaponSkills.Skill1:
            {
                if (Input.GetKeyDown(KeyCode.C))
                    Debug.Log("You have used Skill1");
                break;
            }
                
            case WeaponSkills.Skill2:
            {
                if (Input.GetKeyDown(KeyCode.V))
                    Debug.Log("You have used Skill2");
                break;
            }
                
            case WeaponSkills.Skill3:
            {
                if (Input.GetKeyDown(KeyCode.B))
                    Debug.Log("You have used Skill3");
                break;
            }
        }
    }

    private void Update()
    {
        UseSkill();
    }
}
