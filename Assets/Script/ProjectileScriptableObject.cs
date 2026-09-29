using Unity.VisualScripting;
using UnityEngine;

public class ProjectileScriptableObject : ScriptableObject
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;

    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    void ApplyDamage()
    {
        
    }
}
