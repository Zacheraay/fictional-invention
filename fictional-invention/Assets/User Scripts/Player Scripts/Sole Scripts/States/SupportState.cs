using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportState : SoleState {
    public Vector3 getForceVector(Polar wish, Vector3 center_mass, SoleState other) {
        // related to normal force of COM
        return Vector3.zero;
    }
    
    public Vector3 updatePosition(Vector3 position, Polar direction) {
        return position;
    }
}
