using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("Stats/MovementStats"))]
public class MovementStats :ScriptableObject, IMovementStats
{
    [SerializeField] private float _movementSpeed;

    [SerializeField] private float _rotationSpeed;
    public float MovementSpeed { get { return _movementSpeed; } set { _movementSpeed = value; } }
    public float RotationSpeed { get { return _rotationSpeed; } set { _rotationSpeed = value; } }

}
