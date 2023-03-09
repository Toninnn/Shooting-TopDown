
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD:Assets/Scripts/PlayerController.cs
    public float speed = 5f;
    public float fireSpeed = 7f;
=======
    public float moveSpeed;
    public float fireSpeed;
>>>>>>> 86511f4e31ae40fac8a67a27ca32211e0a59e605:Assets/Scipts/PlayerController.cs

    Vector2 moveInput;
    Animator anim;
    public FixedJoystick moveJoystick;
    public FixedJoystick ainJoystick;

    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = moveJoystick.Horizontal;
        moveInput.y = moveJoystick.Vertical;

        transform.Translate(moveInput * Time.deltaTime * speed);

        anim.SetBool("isWalk", (Mathf.Abs(moveInput.x) > 0 || Mathf.Abs(moveInput.y) > 0));

        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(gun, transform.position, Quaternion.identity);
        }


    }

}
