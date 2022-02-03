using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject _generatedObject;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_generatedObject,transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
