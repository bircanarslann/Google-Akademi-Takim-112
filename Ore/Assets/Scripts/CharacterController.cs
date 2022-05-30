using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpPower;

    private bool _isRunning;
    private bool _isGrounded;

    private bool _isFinished;


    private void Update()
    {
        if (_isFinished) return;

        var horizontal = Input.GetAxis("Horizontal");
        var jump = Input.GetKeyDown(KeyCode.Space);

        //Movement
        if (horizontal > 0)
        {
            _spriteRenderer.flipX = false;
            _animator.SetBool("IsRunning", true);
            _rigidbody.velocity = new Vector2(_movementSpeed, _rigidbody.velocity.y);
        }
        else if(horizontal < 0)
        {
            _spriteRenderer.flipX = true;
            _animator.SetBool("IsRunning", true);
            _rigidbody.velocity = new Vector2(-_movementSpeed, _rigidbody.velocity.y);
        }
        else
        {
            _animator.SetBool("IsRunning", false);
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        }

        //Jump
        if (jump && _rigidbody.velocity.y == 0)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _spriteRenderer.flipX = false;
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpPower);
    }

    public void Finish()
    {
        _isFinished = true;
        _rigidbody.velocity = new Vector2(0, 3);
        _rigidbody.gravityScale = 0;
    }
}
