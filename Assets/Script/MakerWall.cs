using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakerWall : MonoBehaviour
{

    public float X = 12.25f;
    public int count = 0;
    public Maker maker;
    public int winCount = 0;

    void Update() {
        
        if (count == 15)
            return;
        
        var Y = Random.Range(0, 0.50f);
        var Z = Random.Range(0, 2);
        maker.INSTANCE.CreateScaledCube(5, 0.5f, 5, X, Y, Z, 0, 0, 0);
        X = X + 10.65f;
        count = count + 1;
    }
}
