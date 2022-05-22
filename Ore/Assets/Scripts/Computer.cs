using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _computerScreenOn;
    [SerializeField] private TextMeshPro _pressText;
    [SerializeField] private Animator _door;

    private bool _inComputerArea;
    private bool _isPressed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isPressed) return;

        if (collision.CompareTag("Player"))
        {
            _inComputerArea = true;
            _pressText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_isPressed) return;

        if (collision.CompareTag("Player"))
        {
            _inComputerArea = false;
            _pressText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (_inComputerArea)
            {
                OpenDoor();
                _computerScreenOn.enabled = true;
                _pressText.gameObject.SetActive(false);
            }
        }
    }

    private void OpenDoor()
    {
        _door.SetTrigger("Open");
    }
}
