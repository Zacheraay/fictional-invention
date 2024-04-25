using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Observer : MonoBehaviour {
    [SerializeField]
    private SphereCollider detection_radius;
    [SerializeField]
    private float RADIUS = 5f;
    // searches radius for observable objects
    private void find() {

    }
    // Start is called before the first frame update
    void Start() {
        detection_radius.radius = RADIUS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
