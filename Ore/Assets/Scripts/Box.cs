using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private bool _boxOpened;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_boxOpened) return;

        if (collision.CompareTag("Player"))
        {
            OpenBox();
        }
    }

    private void OpenBox()
    {
        _animator.enabled = true;
        _boxOpened = true;
    }
}
