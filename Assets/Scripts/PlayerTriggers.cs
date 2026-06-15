using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            GameManager.Instance.PickupPackage();
        }

        if (collision.CompareTag("Delivery"))
        {
            GameManager.Instance.DeliverPackage();
        }
    }
}