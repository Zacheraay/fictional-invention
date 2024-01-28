using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour {
    [SerializeField]
    private StepState left_foot;
    [SerializeField]
    private StepState right_foot;
    
    public void step(Polar wish) {
        left_foot.getForceVector(wish, Vector3.zero, right_foot);
        right_foot.getForceVector(wish, Vector3.zero, left_foot);
    }
}
