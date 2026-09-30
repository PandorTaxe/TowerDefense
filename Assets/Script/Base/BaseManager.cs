using System;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] private int money = 0;
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

    public void TakeDamage(int damage)
    {
        health =- damage;
        if (health <= 0)
        {
            Application.Quit();
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
    
    public void AddMoney(int amount)
    {
        money += amount;
    }
}
