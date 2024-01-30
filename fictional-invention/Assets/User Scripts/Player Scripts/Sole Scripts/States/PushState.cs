using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushState : SoleState {
    public Vector3 getForceVector(Polar wish, Vector3 center_mass, SoleState other) {
        // force * multiplier (based on speed) + forward bias
        return Vector3.zero;
    }
    
    public Vector3 updatePosition(Vector3 position, Polar direction) {
        return position;
    }
}
