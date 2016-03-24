using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float Speed = 1f;
    private Rigidbody2D _rigidBody;
    private Vector2 _destination;
    private Vector2 _direction;
    private Animator _animator;
    private Coroutine _navigate;
    private Coroutine _attack;
    private SpriteRenderer _spriteRenderer;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _navigate = StartCoroutine(CoMoveToNextPosition());
    }

    void SetNewDestination()
    {
        _destination = Random.insideUnitCircle;
        //normalize to be 1 based so we can multiply by speed if we'd like
        _direction = ((Vector2)(transform.position) - ((Vector2)transform.position + _destination)).normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Collision happened, time to find a new path.
        SetNewDestination();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        //If we're stuck in a collision let's try something new
        SetNewDestination();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        //start attacking (determine if attack is right/left or top/bottom)
        if (collision.gameObject.tag == "Player")
        {

            StopCoroutine(_navigate);
            //flip right or left. We naturally look to the left, so if plauer
            _spriteRenderer.flipX = collision.transform.position.x > transform.position.x;
            _attack = StartCoroutine(CoAttack());
        }
    }

    private IEnumerator CoAttack()
    {
        //Wait for a few seconds before attacking
        _animator.SetBool("Walk", false);
        _animator.SetTrigger("Attack");
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 4));
            _animator.SetTrigger("Attack");
            //Deal damage
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ork Exit trigger");
            //Go back to navigating since we're no longer attacking.
            StopCoroutine(_attack);
            _navigate = StartCoroutine(CoMoveToNextPosition());

            //TODO: follow player. Once player is further than 1 m, stop following
        }
    }


    IEnumerator CoMoveToNextPosition()
    {

        while (true)
        {
            if (_destination == Vector2.zero)
            {
                SetNewDestination();
                Debug.Log("Normalized:" + _direction);
            }

            _animator.SetBool("Walk", true);
            //blindly move until we hit something or get triggered

            _rigidBody.MovePosition((Vector2)transform.position + _direction * Time.deltaTime * Speed);

            //As a general rule,physics should really be done every FixedUpdate() not Update
            //FixedUpdate() is timed to the physics engine calcuations
            yield return new WaitForFixedUpdate();
        }
    }
}
