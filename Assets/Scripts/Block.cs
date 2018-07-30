using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    [SerializeField] AudioClip breakSound;

    // cached reference
    Level level;
    GameSession status;

        private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
        status.AddToScore();
    }

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        status = FindObjectOfType<GameSession>();
    }

}
