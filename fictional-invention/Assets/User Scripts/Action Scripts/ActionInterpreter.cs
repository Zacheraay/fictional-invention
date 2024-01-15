using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ActionInterpreter {
    public static float getWishDirection(Dictionary<ActionCode, bool> action_requests) {
        Vector2 wish_direction = Vector2.zero;
        wish_direction.y = (action_requests[ActionCode.Forward] ? 1 : 0) - (action_requests[ActionCode.Backward] ? 1 : 0);
        wish_direction.x = (action_requests[ActionCode.Left] ? 1 : 0) - (action_requests[ActionCode.Right] ? 1 : 0);
        if (wish_direction == Vector2.zero)
            return 0;
        wish_direction.Normalize();
        float wish_angle = (float) Math.Acos(wish_direction.y);
        wish_angle = wish_direction.x > 0 ? -1 * wish_angle : wish_angle;
        return wish_angle;
    }
}
