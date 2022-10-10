using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]
public class Health : MonoBehaviour
{
    [SerializeField] [Range(0, 100)] private int _currHealth = 0;
    [SerializeField] [Range(0, 100)] private int _maxHealth = 0;

    private Entity _entity;

    private int _entityMaxHealth;

    private void Start()
    {
        _entity = gameObject.GetComponent<Entity>();
        _entityMaxHealth = _entity.GetEntityMaxHealth();
        
        _currHealth = _entityMaxHealth;
        _maxHealth = _entityMaxHealth;
    }

    public int GetCurrHealth()
    {
        return _currHealth;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    public void GetDamage(int damage)
    {
        if (GetCurrHealth() - damage < 0)
            return;

        SetCurrHealth(GetCurrHealth() - damage);
    }

    private void SetCurrHealth(int currHealth)
    {
        _currHealth = currHealth;
    }
    
    private void SetMaxHealth(int maxHealth)
    {
        _maxHealth = maxHealth;
    }
}
