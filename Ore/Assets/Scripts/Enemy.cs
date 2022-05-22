using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private float _movementSpeed;
    private int _direction = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fire"))
        {
            Destroy(_collider);
            Destroy(_rigidbody);

            _animator.SetTrigger("Die");
            _direction = 0;
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if (transform.position.x <= -5.75f)
        {
            _direction = 1;
            _spriteRenderer.flipX = true;
        }

        else if (transform.position.x >= -0.75f)
        {
            _direction = -1;
            _spriteRenderer.flipX = false;
        }

        var position = transform.position;
        position.x += Time.deltaTime * _movementSpeed * _direction;
        transform.position = position;
    }

}
