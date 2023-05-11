// using UnityEngine;

public class CharacterStats
{
    private int health = 100;
    private int strength = 10;
    
    public int Health 
    {
        get { return health; }
        // set { health = Mathf.Max(0, value); }
    }
    
    public int Strength 
    {
        get { return strength; }
        // set { strength = Mathf.Max(0, value); }
    }
    
    public void TakeDamage(int damage)
    {
        // Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        // Code to handle character death
    }
}
