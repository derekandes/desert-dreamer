using UnityEngine;
using System.Collections;

public static class Functions {

    // Maps a value from some arbitrary range to the 0 to 1 range
    public static float Map01(float value, float min, float max)
    {
        return (value - min) * 1f / (max - min);
    }

    // Maps a value from one arbitrary range to another arbitrary range
    public static float Map(float value, float leftMin, float leftMax, float rightMin, float rightMax)
    {
        return rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
    }
}
