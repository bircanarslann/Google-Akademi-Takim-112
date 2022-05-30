using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    public GameObject CharacterJetpack;
    public SpriteRenderer JetpackSprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<CharacterController>().Finish();
            CharacterJetpack.SetActive(true);
            JetpackSprite.enabled = false;
        }
    }
}
