using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Cutter : MonoBehaviour {

	public Material capMaterial;

    void OnCollisionEnter (Collision Collision)
    {
        GameObject victim = Collision.collider.gameObject;

        GameObject[] pieces = MeshCutter.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

       Destroy(pieces[1], 1);
    }

}
