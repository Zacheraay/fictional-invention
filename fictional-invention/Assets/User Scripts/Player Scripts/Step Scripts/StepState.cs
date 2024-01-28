using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface StepState {
    public Vector3 getForceVector(Polar direction, Vector3 center_mass, StepState other);
    public Vector3 updatePosition(Vector3 position, Polar direction);
}
