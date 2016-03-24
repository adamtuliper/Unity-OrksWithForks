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
    private int Health = 100;
    private GameController _gameController;
    private int _coinScore;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    public void GotHit(int hitPoints)
    {
        Health -= hitPoints;
        if (Health < 0) Health = 0;

        //Update the UI
        _gameController.UpdatePlayerHealth(Health);
    }

    private void PowerUp(int points)
    {
        Health += points;
        if (Health > 100)
        {
            Health = 100;
        }
        _gameController.UpdatePlayerHealth(Health);
    }

    private void CoinUp(int coins)
    {
        _coinScore += coins;
        if (_coinScore > 100)
        {
            _coinScore = 100;
        }
        _gameController.UpdatePlayerCoin(_coinScore);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            //Get its coin score
            var pickupProperties = collision.gameObject.GetComponent<PickupProperties>();
            CoinUp(pickupProperties.CoinAmount);

            //TODO - get rid of the game object we just picked up
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Health")
        {
            //Get its health
            var pickupProperties = collision.gameObject.GetComponent<PickupProperties>();
            PowerUp(pickupProperties.HealthAmount);

            //TODO - get rid of the game object we just picked up
            Destroy(collision.gameObject);
        }
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

        //TODO: Play Walk animation if we've read input on the horizontal
        _animator.SetBool("Walk", _horizontal != 0);


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
