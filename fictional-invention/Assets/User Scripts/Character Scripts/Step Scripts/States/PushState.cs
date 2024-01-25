using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushState : StepState {
    public Vector3 getForceVector(Vector3 center_mass, StepState other) {
        // force * multiplier (based on speed) + forward bias
        return Vector3.zero;
    }
    
    public Vector3 updatePosition(Vector3 position, Vector3 direction) {
        return position;
    }
}
