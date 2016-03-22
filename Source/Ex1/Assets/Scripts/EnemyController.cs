using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    private Rigidbody2D _rigidBody;
    private Vector2 _destination;
    private Vector2 _direction;
    private Animator _animator;
    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        StartCoroutine(CoMoveToNextPosition());
    }

    void SetNewDestination()
    {
        _destination = Random.insideUnitCircle;
        //normalize to be 1 based so we can multiply by speed if we'd like
        _direction = ((Vector2)(transform.position) - ((Vector2)transform.position + _destination)).normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //lets move in the opposite direction of the collision
        //        collision.transform
        SetNewDestination();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        SetNewDestination();
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

            //var x = Random.Range(-1f, 1f);
            //var y = Random.Range(-1f, 1f);
            //var direction = new Vector2(x, y);
            ////if you need the vector to have a specific length:
            //direction = direction.normalized * 2;

            //_rigidBody.velocity = _direction;
            _animator.SetBool("Walk", true);
            _rigidBody.MovePosition((Vector2)transform.position + _direction * Time.deltaTime);
            //Are we there yet or did we hit something?

            //Choose a random direction
            //Physics2D.Raycast(transform.position, Vector2.right
            yield return new WaitForFixedUpdate();
        }
    }
}
