using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _firePrefab;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [SerializeField] private int _fireForce;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            
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
}
