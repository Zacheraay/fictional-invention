using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ActionInterpreter {
    public static float NO_WISH = 1000f;
    public static Polar getWishDirection(Dictionary<ActionCode, bool> action_requests) {
        Polar wish = new Polar();

        Vector3 wish_direction = Vector3.zero;
        wish_direction.x = (action_requests[ActionCode.Forward] ? 1 : 0) - (action_requests[ActionCode.Backward] ? 1 : 0);
        wish_direction.z = (action_requests[ActionCode.Left] ? 1 : 0) - (action_requests[ActionCode.Right] ? 1 : 0);

        if (wish_direction == Vector3.zero)
            return wish;

        wish.magnitude = 1f;
        wish.angle = Mathf.Atan2(wish_direction.z, wish_direction.x) * Mathf.Rad2Deg;
        return wish;
    }
}
