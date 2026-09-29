using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageToBase;
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private int moneyToGive;

    void TakeDamage(float damage)
    {
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        BaseManager.instance.AddMoney(moneyToGive);
        Destroy(gameObject);
    }
    
    void PathToFollow()
    {
        
    }
}
