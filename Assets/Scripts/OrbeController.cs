using UnityEngine;

public class OrbeController : MonoBehaviour
{
    public float speed = 2f;
    public float radius = 1f;

    private Vector2 center;
    private float angle;

    void Start()
    {
        center = transform.parent.position;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;
        Vector2 offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}

