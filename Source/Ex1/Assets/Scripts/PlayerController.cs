using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private bool _dead;
    private Animator _animator;
    private Rigidbody2D _rigidBody;
    public int Speed = 1;
    private SpriteRenderer _spriteRenderer;
    private float _horizontal;
    private float _vertical;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        //TODO: Need to read player input here for Fire1
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("Attack");
        }
        //Read the left/right input
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        //Flips the character left if the input is < 0 and 'normal right facing' if > 0 
        _spriteRenderer.flipX = _horizontal < 0;

        //Play Walk animation if we've read input on the horizontal
        //TODO:


    }

    void FixedUpdate()
    {
        if (_dead)
        {
            return;
        }

        //Move the actual object by setting its velocity
        _rigidBody.velocity = new Vector2(_horizontal * Speed, _vertical * Speed);
    }
}
