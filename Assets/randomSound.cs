using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "randomSound", menuName = "sound/randomSoundGenerator", order = 1)]
public class randomSound : ScriptableObject
{
    public List<AudioClip> clipList;

    AudioClip getrandom()
    {
        return clipList[Random.Range(0, clipList.Count)];
    }

    public void playSound()
    {
        GameObject gameObject = new GameObject();
        gameObject.name = this.name;

        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = getrandom();
        source.Play();

    }

}
