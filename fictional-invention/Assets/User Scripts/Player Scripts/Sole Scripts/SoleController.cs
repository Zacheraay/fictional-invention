using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoleController : MonoBehaviour {
    [SerializeField]
    private Transform sole;

    private SoleState sole_state;
    private SoleState push_state = new PushState();
    private SoleState support_state = new SupportState();
    private SoleState swing_state = new SwingState();
    
    private void Start() {
        sole_state = support_state;
    }
    
    public Polar relativeTo(Vector3 center_mass) {
        Polar polar = new Polar();

        float d_x = sole.position.x - center_mass.x;
        float d_z = sole.position.z - center_mass.z;

        polar.magnitude = Mathf.Sqrt(Mathf.Pow(d_x, 2) + Mathf.Pow(d_z, 2));
        polar.angle = Mathf.Atan2(d_z, d_x) * Mathf.Rad2Deg;

        return polar;
    }
}
