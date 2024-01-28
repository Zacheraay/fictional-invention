using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private Transform look;
    [SerializeField]
    private StepController step_controller;

    [SerializeField]
    private Transform f; // to delete

    public void move(Polar wish) {
        wish.angle += look.eulerAngles.y;
        f.eulerAngles = wish.magnitude == 0 ? Vector3.back * 90 : Vector3.up * wish.angle; // to delete
    }

    public void rotateBody(float mouse_x, float mouse_y) {
        look.Rotate(Vector3.up * mouse_x);
    }

    public float getLookDirection() {
        return look.eulerAngles.y;
    }
}
