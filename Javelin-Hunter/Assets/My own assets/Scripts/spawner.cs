using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Prefab;

    // Summon a prefab inserted in public
    void Start()
    {
        GameObject instance = Instantiate(Prefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
