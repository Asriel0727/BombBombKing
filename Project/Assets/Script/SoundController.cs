using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    void Update()
    {
        Invoke("DestroyPrefab", 1.5f);
    }

    void DestroyPrefab()
    {
        Destroy(gameObject);
    }
}
