using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;

    public float itemSpawnChance = 0.2f;
    public GameObject[] spawnablaItems;

    private void Start()
    {
        Destroy(gameObject, destructionTime);
    }

    private void OnDestroy()
    {
        if( spawnablaItems.Length > 0 && Random.value < itemSpawnChance)
        {
            int randomIndex = Random.Range(0, spawnablaItems.Length);
            Instantiate(spawnablaItems[randomIndex], transform.position, Quaternion.identity);
    }
 }
}