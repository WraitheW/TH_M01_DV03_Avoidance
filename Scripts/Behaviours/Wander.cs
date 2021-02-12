using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : SteeringBehavior
{
    public Kinematic character;

    float maxAcceleration = 1f;

    protected virtual Vector3 getTargetPosition()
    {
        return new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        Vector3 targetPosition = getTargetPosition();

        result.linear = targetPosition - character.transform.position;

        result.linear.Normalize();
        result.linear *= maxAcceleration;

        result.angular = 0;

        return result;
    }
}
