using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject capsulePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //capsuleが存在するだけ取得
        GameObject[] capsules = GameObject.FindGameObjectsWithTag("capsule");
        if (capsules.Length < 2)
        {
            Vector3 position = new Vector3(Random.Range(-15f, 15f), 0, Random.Range(10f, 20f));
            Instantiate(capsulePrefab, position, transform.rotation);

        }

    }
}
