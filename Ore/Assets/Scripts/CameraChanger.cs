using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector3 _cameraPositionFirst;
    [SerializeField] private Vector3 _cameraPositionSecond;

    private Vector3 _cameraPosition;

    private void Start()
    {
        _cameraPosition = new Vector3(-4.51f, 0, -10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _cameraPosition = _cameraPositionSecond;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _cameraPosition = _cameraPositionFirst;
        }
    }

    private void Update()
    {
        _camera.transform.position = Vector3.Lerp(_camera.transform.position, _cameraPosition, Time.deltaTime * 2);
    }
}
