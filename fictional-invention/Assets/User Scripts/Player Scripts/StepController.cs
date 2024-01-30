using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour {
    [SerializeField]
    private SoleController left_sole;
    [SerializeField]
    private SoleController right_sole;

    private List<SoleController> soles = new List<SoleController>();

    private void Start() {
        soles.Add(left_sole);
        soles.Add(right_sole);
    }
    
    public void step(Polar wish, Vector3 center_mass) {
        soles.Clear();
        backSoleFirst(wish, center_mass);
    }

    private void backSoleFirst(Polar wish, Vector3 center_mass) {
        Polar left = left_sole.relativeTo(center_mass);
        Polar right = right_sole.relativeTo(center_mass);

        float left_proj = left.magnitude * Mathf.Cos((wish.angle - left.angle) * Mathf.Deg2Rad);
        float right_proj = right.magnitude * Mathf.Cos((wish.angle - right.angle) * Mathf.Deg2Rad);
        
        soles.Add(left_sole);
        if (left_proj > right_proj)
            soles.Insert(0, right_sole);
        else
            soles.Add(right_sole);
    }
}