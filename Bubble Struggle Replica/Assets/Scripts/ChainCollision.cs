using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Chain.IsFired = false;

        if (collision.tag == "Ball")
        {
            collision.GetComponent<Ball>().Split();
        }
    }
}
