using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject[] itemList;
    void Start()
    {
        
        var rand = Random.Range(0, itemList.Length);
        Instantiate(itemList[rand], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
