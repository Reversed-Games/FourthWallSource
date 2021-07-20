using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public Maker INSTANCE;

    public void Awake()
    {
        INSTANCE = this;
    }

    public void CreateCube(float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(PosX, PosY, PosZ);
        cube.transform.Rotate(RotX, RotY, RotZ, Space.Self);
        cube.transform.localScale = new Vector3(1, 1, 1);
    }

    public void CreateRigidCube(float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(PosX, PosY, PosZ);
        cube.transform.Rotate(RotX, RotY, RotZ, Space.Self);
        cube.transform.localScale = new Vector3(1, 1, 1);
        cube.AddComponent<Rigidbody>();
    }
    
    public void CreateScaledCube(float ScaleX, float ScaleY, float ScaleZ, float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(PosX, PosY, PosZ);
        cube.transform.Rotate(RotX, RotY, RotZ, Space.Self);
        cube.transform.localScale = new Vector3(ScaleX, ScaleY, ScaleZ);
    }

    public void CreateScaledRigidCube(float ScaleX, float ScaleY, float ScaleZ, float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(PosX, PosY, PosZ);
        cube.transform.Rotate(RotX, RotY, RotZ, Space.Self);
        cube.transform.localScale = new Vector3(ScaleX, ScaleY, ScaleZ);
        cube.AddComponent<Rigidbody>();
    }

    public void CreateWinWall(float ScaleX, float ScaleY, float ScaleZ, float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(PosX, PosY, PosZ);
        cube.transform.Rotate(RotX, RotY, RotZ, Space.Self);
        cube.transform.localScale = new Vector3(ScaleX, ScaleY, ScaleZ);
        cube.AddComponent<WallScript>();
    }
}
