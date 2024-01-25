using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportState : StepState {
    public Vector3 getForceVector(Vector3 center_mass, StepState other) {
        // related to normal force of COM
        return Vector3.zero;
    }
    
    public Vector3 updatePosition(Vector3 position, Vector3 direction) {
        return position;
    }
}
