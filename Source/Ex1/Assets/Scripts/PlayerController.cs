using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private bool _dead;
    private Animator _animator;
    private Rigidbody2D _rigidBody;
    public int Speed=1;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_dead)
        {
            return;
        }

        //Read the left/right input
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        //If we're moving to the right, we've flipped this character by setting localScale=-1
        var localScale = transform.localScale;

        //Flips the character left if the input is < 0 and, right if >0 
        if (horizontal < 0)
        {
            // localScale is a Vector 3, which means it contains x,y,z
            // todo rotate via FlipX when I get animations
        }
        else if (horizontal > 0f)
        {
            // todo rotate via FlipX when I get animations
        }


        transform.localScale = localScale;

        //If we're moving left or right, play the run animation
        if (horizontal != 0)
        {
           // _animator.SetBool("Run", true);
        }
        else
        {
          //  _animator.SetBool("Run", false);
        }

        //Move the actual object by setting its velocity
        _rigidBody.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }
}
