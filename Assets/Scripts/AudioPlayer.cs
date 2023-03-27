using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageTakingClip;
    [SerializeField][Range(0f, 1f)] float damageVolume = 1f;

    public void PlayShootingClip()
    {
        if (shootingClip != null)
        {
            PlayClip(shootingClip, shootingVolume);
        }

    }

    public void PlayDamageTakenClip()
    {
        if (damageTakingClip != null)
        {
            PlayClip(damageTakingClip, damageVolume);
        }
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }


}
