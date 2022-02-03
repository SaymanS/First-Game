using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    float _characterSpeed = 10;

    [SerializeField]
    BoxCollider _colider;

    private void Awake()
    {
        //_colider = GetComponent<BoxCollider>();

        TryGetComponent<BoxCollider>(out _colider);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
