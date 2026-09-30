using UnityEngine;

public class BigSlime : Enemy
{
    void SpeedBoost()
    {
        float normalSpeed = speed;
        speed = speed * 2;
    }
}
