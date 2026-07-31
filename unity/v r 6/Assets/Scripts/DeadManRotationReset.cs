using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManRotationReset : MonoBehaviour
{
    public DeadManRotation rotator;
    public GameObject entry;
    public GameObject exit;
    public float rotationAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Debug.Log("Resetting.");
        rotator.spun = false;
        rotator.entry = entry;
        rotator.exit = exit;
        rotator.rotationAmount = rotationAmount;
    }
}
