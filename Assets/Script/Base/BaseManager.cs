using System;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    private int money = 0;
    [SerializeField] private int health = 10;
    public static BaseManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void TakeDamage(float damage)
    {
        
    }
    
    void AddMoney(int amount)
    {
        
    }
}
