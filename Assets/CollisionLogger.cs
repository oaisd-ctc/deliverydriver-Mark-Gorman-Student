using UnityEngine;
using System.Runtime.CompilerServices;

// Start is called before the first frame update
public class CollisionLogger : MonoBehaviour{
    void OnCollisionEnter2D(Collision2D collision) => Log(collision);
    void OnCollisionStay2D(Collision2D collision) => Log(collision);
    void OnCollisionExit2D(Collision2D collision) => Log(collision);
    void Log(Collision2D collision, [CallerMemberName] string message = null){
        Debug.Log($"{message} called on {name} beacause a collison with {collision.collider.name}");
    }
}
