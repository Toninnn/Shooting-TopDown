using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestructibleTiles : MonoBehaviour
{
    public Sprite idleSprite;
    private SpriteRenderer spriteRenderer;
    public Sprite[] animationSprites;

    public float animationTime = 0.25f;
    public int animationFrame;

    public bool loop = true;
    public bool idle = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(this);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            InvokeRepeating(nameof(NextFrame), animationTime, animationTime);
            Destroy(gameObject);
        }
    }

    private void NextFrame()
    {
        animationFrame++;

        if (loop && animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }

        if (idle)
        {
            spriteRenderer.sprite = idleSprite;
        }
        else if (animationFrame >= 0 && animationFrame < animationSprites.Length)
        {
            spriteRenderer.sprite = animationSprites[animationFrame];
        }

    }
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

