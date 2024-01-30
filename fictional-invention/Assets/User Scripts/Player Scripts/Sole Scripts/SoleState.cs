using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SoleState {
    public Vector3 getForceVector(Polar direction, Vector3 center_mass, SoleState other);
    public Vector3 updatePosition(Vector3 position, Polar direction);
}
