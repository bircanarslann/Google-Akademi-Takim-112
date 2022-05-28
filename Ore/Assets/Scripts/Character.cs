using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] private GameObject _restartScreen;
    [SerializeField] private SpriteRenderer _firePrefab;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Image[] _lives;

    [SerializeField] private int _fireForce;

    private int _live = 3;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _lives[3 - _live].enabled = false;
            _live--;
            if (_live <= 0)
            {
                Die();
            }
        }
        if (collision.gameObject.CompareTag("EnemyFire"))
        {
            Destroy(collision.gameObject);
            _lives[3 - _live].enabled = false;
            _live--;
            if (_live <= 0)
            {
                Die();
            }
        }

    }
    

    private void Fire()
    {
        if (!_spriteRenderer.flipX)
        {
            var go = Instantiate(_firePrefab.gameObject, transform);
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * _fireForce);
            go.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            var go = Instantiate(_firePrefab.gameObject, transform);
            go.transform.localPosition = new Vector2(go.transform.localPosition.x * -1, go.transform.localPosition.y);
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.left * _fireForce);
            go.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void Die()
    {
        _restartScreen.SetActive(true);
        Destroy(gameObject);
    }
}
