using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] int factionID = 0;

    float currentHP = 1;
    [SerializeField] float maxHP = 50;

    // Start is called before the first frame update
    void Start()
    {
        // Set starting HP of tower to full health
        currentHP = maxHP;
    }

    public int GetFactionID()
    {
        return factionID;
    }

    public void TakeDamage(float amount)
    {
        // Reduce the current hitpoints by the damage recieved
        currentHP -= amount;
        if(currentHP >= 0) Die();
    }
    
    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
