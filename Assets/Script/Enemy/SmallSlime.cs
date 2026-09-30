using UnityEngine;

public class SmallSlime : Enemy
{
    void Dash()
    {
        transform.position += transform.forward * 2f;
    }
}
