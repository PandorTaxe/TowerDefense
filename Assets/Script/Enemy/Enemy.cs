using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageToBase;
    [SerializeField] protected float health = 10;
    [SerializeField] protected float speed;
    [SerializeField] private int moneyToGive;

    private void Update()
    {
        PathToFollow();
    }

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
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
