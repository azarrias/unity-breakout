using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private AudioClip breakSound;
    [SerializeField] private GameObject blockParticlesPrefab;

    private Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.IncreaseNumberOfBreakableBlocks();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameSession>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.DecreaseNumberOfBreakableBlocks();
        TriggerParticles();
        Destroy(gameObject);
    }

    private void TriggerParticles()
    {
        GameObject particles = Instantiate(blockParticlesPrefab, transform.position, transform.rotation);
        Destroy(particles, 1f);
    }
}
