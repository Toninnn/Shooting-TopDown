using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public enum Itemtype
    {
        SpeedIncrease,
        SpeedBullet,
    }

    public Itemtype type;

    private void OnItemPickup(GameObject player)
    {
        switch (type)
        {
            case Itemtype.SpeedIncrease:
                player.GetComponent<PlayerController>().moveSpeed++;
                break;

            case Itemtype.SpeedBullet:
                player.GetComponent<PlayerController>().fireSpeed ++;
                break;
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnItemPickup(other.gameObject);
        }

    }

}
