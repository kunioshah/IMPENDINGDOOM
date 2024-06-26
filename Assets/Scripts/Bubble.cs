﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bubble : MonoBehaviour
{
    public float durationTime;
    public float shrinkScale;
    public BubbleManager myManager;
    public int maxBubbles;
    public Fish myFish;

    public AudioSource audioSource;
    public AudioClip clip;

    public void Update()
    {
        StartCoroutine(ScaleOverTime(durationTime, shrinkScale));
    }

    private IEnumerator ScaleOverTime(float duration, float scale)
    {
        var startScale = transform.localScale;
        var endScale = Vector3.one * scale;
        var elapsed = 0f;

        while (elapsed < duration)
        {
            var t = elapsed / duration;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            elapsed += Time.deltaTime;

            if (elapsed >= (myManager.shrinkDuration)) {
                DestroySpawn();
            }

            yield return null;
        }

        transform.localScale = endScale;
    }

    public void Destroy()
    {
        myManager.bubCount++;
        audioSource.PlayOneShot(clip, 0.5f);
        Destroy(gameObject);
        if (myManager.bubCount < maxBubbles)
        {
            myFish.spawnBubble();
        }
    }

    public void DestroySpawn() {
        myManager.fishSentencing = false;
        audioSource.PlayOneShot(clip, 0.5f);
        Destroy(gameObject);
        
    }

}
