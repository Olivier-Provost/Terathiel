using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod {

	public static void ResetTransform(this Transform trans)
    {
        Vector3 reset = new Vector3();
        trans.position = reset;

    }
}
