
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public enum ItemType
    {
        BulletUp,
        SpeedUp,
    }

    public ItemType type;

    private void OnItemPickup(GameObject player)
    {
        switch (type)
        {
            case ItemType.BulletUp:
            player.GetComponent<Bullet>().speed++;
            break;
            case ItemType.SpeedUp:
            player.GetComponent<PlayerController>().speed++;
            break;
            

        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            OnItemPickup(other.gameObject);
        }
    }

 
}
