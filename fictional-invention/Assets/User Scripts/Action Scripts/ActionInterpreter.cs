using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ActionInterpreter {
    public static float NO_WISH = 1000f;
    public static Polar getWishDirection(Dictionary<ActionCode, bool> action_requests) {
        Polar wish = new Polar();

        Vector2 wish_direction = Vector2.zero;
        wish_direction.y = (action_requests[ActionCode.Forward] ? 1 : 0) - (action_requests[ActionCode.Backward] ? 1 : 0);
        wish_direction.x = (action_requests[ActionCode.Left] ? 1 : 0) - (action_requests[ActionCode.Right] ? 1 : 0);

        if (wish_direction == Vector2.zero)
            return wish;

        wish.magnitude = 1f;

        wish_direction.Normalize();
        wish.angle = Mathf.Acos(wish_direction.y) * 180 / Mathf.PI;
        wish.angle = wish_direction.x > 0 ? -1 * wish.angle : wish.angle;

        return wish;
    }
}
