using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class MovementControls : MonoBehaviour {
    private List<ActionControl> movement_actions = new List<ActionControl>();

    private ActionControl forward = new ActionControl("w", new DoubleTapStrategy());
    private ActionControl backward = new ActionControl("s", new PressStrategy());
    private ActionControl left = new ActionControl("a", new PressStrategy());
    private ActionControl right = new ActionControl("d", new PressStrategy());
    private ActionControl jump;

    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("W");
            forward.input.press();
        }
        if (Input.GetKeyUp(KeyCode.W)) {
            forward.input.release();
        }
    }

    void FixedUpdate() {
        if (forward.isActive())
            Debug.Log(true);
    }
}
