using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    private ActionControl forward;
    private ActionControl backward;
    private ActionControl left;
    private ActionControl right;
    private ActionControl jump;

    public List<string> getKeys() {
        List<string> keys = new List<string>();
        keys.Add(forward.getKey());
        keys.Add(forward.getKey());
        return null;
    }
}
