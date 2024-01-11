using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface StepState
{
    public void updatePosition();
    public void updateRotation();
    public void getForceVector();

}
