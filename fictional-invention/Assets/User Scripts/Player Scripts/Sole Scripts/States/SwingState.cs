using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingState : SoleState {
    public Vector3 getForceVector(Polar wish, Vector3 center_mass, SoleState other) {
        return Vector3.zero;
    }
    
    public Vector3 updatePosition(Vector3 position, Polar direction) {
        // swings in wish direction, may be related to velocity
        return position;
    }
}
