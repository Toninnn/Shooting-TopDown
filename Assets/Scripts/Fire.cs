using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FireGun()
    {
        Instantiate(gun, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
