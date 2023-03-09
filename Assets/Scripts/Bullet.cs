
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 7f;
    Animator anim;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);
    }

    public void Destructible(Vector3 position)
    {
         
    }


}
