using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] GameObject _fire;
    [SerializeField] private Animator _animator;
    [SerializeField] private int _fireSpeed;
    [SerializeField] private SpriteRenderer _healthBar;

    private float _timer;
    private float health;
    public void Fire()
    {
        var fire = Instantiate(_fire, transform);
        fire.GetComponent<Rigidbody2D>().velocity = Vector2.left * _fireSpeed;
        fire.transform.SetParent(null);
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 2.5f)
        {
            _animator.SetTrigger("Attack");
            _timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fire"))
        {
            Destroy(collision.gameObject);
            DecreaseHealth(0.1f);
        }
    }

    private void DecreaseHealth(float amount)
    {
        health += amount;
        _healthBar.transform.localPosition = new Vector2(health, _healthBar.transform.localPosition.y);
        if (health >= 1)
        {
            Die();
        }
    }

    private void Die()
    {
        enabled = false;
        _animator.SetTrigger("Die");
    }

    public void DestroyBoss()
    {
        Destroy(gameObject);
    }
}
