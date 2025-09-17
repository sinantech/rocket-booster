using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Everything is looking good");
                break;

            case "Finish":
                Debug.Log("You are all done");
                break;

            case "Fuel":
                Debug.Log("I am not in this game");
                break;

            default:
                Debug.Log("You have crashed");
                break;
        }
    }
}
