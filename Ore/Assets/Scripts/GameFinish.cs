using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{
    public GameObject finishGame;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            finishGame.SetActive(true);
        }
    }
}
