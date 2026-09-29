using Unity.VisualScripting;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxcollider2D; //rajouter

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        BaseManager baseManager = gameObject.GetComponent<BaseManager>();
        baseManager.TakeDamage(enemy.damageToBase);
        enemy.Die();
    }
}
