using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACaptureAllMethodsStatic : MonoBehaviour
{
    public static string Recorded = "Initialized";
    public static void Record(string content)
    {
        var s = "asdf"; Debug.Log(s);
        string recordedToFile = "";
        var path = nameof(ACaptureAllMethodsStatic) + ".txt";
        if (System.IO.File.Exists(path))
        {
            recordedToFile = System.IO.File.ReadAllText(path);
        }

        var newLines = "\n\n" + Time.realtimeSinceStartup + "\n" + content;
        Recorded += newLines;
        recordedToFile += newLines;
        System.IO.File.WriteAllText(path, recordedToFile);
        var lineCount = Recorded.Split('\n').Length;
        var lineCount2 = recordedToFile.Split('\n').Length;
        Debug.Log($"A Static {lineCount}\n" + Recorded);
        Debug.Log($"B File {lineCount2}\n" + recordedToFile);
    }

    // Removed to keep tesing areas clean
    //[UnityEditor.MenuItem("Tools/ACaptureAllMethodsStatic")]
    public static void MenuClick()
    {
        Record("MenuClick()");
    }

    // Removed to keep tesing areas clean
    //[UnityEditor.MenuItem("Tools/Clear ACaptureAllMethodsStatic")]
    public static void Clear()
    {
        var path = nameof(ACaptureAllMethodsStatic) + ".txt";
        if (System.IO.File.Exists(path))
        {
            System.IO.File.Delete(path);
        }

        Recorded = "";
    }

    private void Awake()
    {
        Record("Awake()");
    }

    private void FixedUpdate()
    {
        Record("FixedUpdate()");
    }

    private void LateUpdate()
    {
        Record("LateUpdate()");
    }

    private void OnAnimatorIK(int layerIndex)
    {
        Record($"OnAnimatorIK({layerIndex})");
    }

    private void OnAnimatorMove()
    {
        Record("OnAnimatorMove()");
    }

    private void OnApplicationFocus(bool focus)
    {
        Record($"OnApplicationFocus({focus})");
    }

    private void OnApplicationPause(bool pause)
    {
        Record($"OnApplicationPause({pause})");
    }

    private void OnApplicationQuit()
    {
        Record($"OnApplicationQuit()");
    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        Record($"OnAudioFilterRead({data.ToString()}, {channels})");
    }

    private void OnBecameInvisible()
    {
        Record($"OnBecameInvisible()");
    }

    private void OnBecameVisible()
    {
        Record($"OnBecameVisible()");
    }
    private void OnBeforeTransformParentChanged()
    {
        Record($"OnBeforeTransformParentChanged()");
    }
    private void OnCanvasGroupChanged()
    {
        Record($"OnCanvasGroupChanged()");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Record($"OnCollisionEnter({collision.ToString()})");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Record($"OnCollisionEnter2D({collision.ToString()})");
    }
    private void OnCollisionExit(Collision collision)
    {
        Record($"OnCollisionExit({collision})");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Record($"OnCollisionExit2D({collision})");
    }
    private void OnCollisionStay(Collision collision)
    {
        Record($"OnCollisionStay({collision})");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Record($"OnCollisionStay2D({collision})");
    }
    private void OnConnectedToServer()
    {
        Record($"OnConnectedToServer()");
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Record($"OnControllerColliderHit({hit})");
    }
    private void OnDestroy()
    {
        Record($"OnDestroy()");
    }
    private void OnDisable()
    {
        Record($"OnDisable()");
    }
    private void OnDrawGizmos()
    {
        Record($"OnDrawGizmos()");
    }
    private void OnDrawGizmosSelected()
    {
        Record($"OnDrawGizmosSelected()");
    }
    private void OnEnable()
    {
        Record($"OnEnable()");
    }
    private void OnGUI()
    {
        //Record($"OnGUI()");
    }
    private void OnJointBreak(float breakForce)
    {
        Record($"OnJointBreak({breakForce})");
    }
    private void OnJointBreak2D(Joint2D joint)
    {
        Record($"OnJointBreak2D({joint})");
    }
    private void OnLevelWasLoaded(int level)
    {
        Record($"OnLevelWasLoaded({level})");
    }
    private void OnMouseDown()
    {
        Record($"OnMouseDown()");
    }
    private void OnMouseDrag()
    {
        Record($"OnMouseDrag()");
    }
    private void OnMouseEnter()
    {
        Record($"OnMouseEnter()");
    }
    private void OnMouseExit()
    {
        Record($"OnMouseExit()");
    }
    private void OnMouseOver()
    {
        Record($"OnMouseOver()");
    }
    private void OnMouseUp()
    {
        Record($"OnMouseUp()");
    }
    private void OnMouseUpAsButton()
    {
        Record($"OnMouseUpAsButton()");
    }
    private void OnParticleCollision(GameObject other)
    {
        Record($"OnParticleCollision({other})");
    }
    private void OnParticleSystemStopped()
    {
        Record($"OnParticleSystemStopped()");
    }
    private void OnParticleTrigger()
    {
        Record($"OnParticleTrigger()");
    }
    private void OnParticleUpdateJobScheduled()
    {
        Record($"OnParticleUpdateJobScheduled()");
    }
    private void OnPostRender()
    {
        Record($"OnPostRender()");
    }
    private void OnPreCull()
    {
        Record($"OnPreCull()");
    }
    private void OnPreRender()
    {
        Record($"OnPreRender()");
    }
    private void OnRectTransformDimensionsChange()
    {
        Record($"OnRectTransformDimensionsChange()");
    }
    private void OnRectTransformRemoved()
    {
        Record($"OnRectTransformRemoved()");
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Record($"OnRenderImage({source}, {destination})");
    }
    private void OnRenderObject()
    {
        //Record($"OnRenderObject()");
    }
    private void OnServerInitialized()
    {
        Record($"OnServerInitialized()");
    }
    private void OnTransformChildrenChanged()
    {
        Record($"OnTransformChildrenChanged()");
    }
    private void OnTransformParentChanged()
    {
        Record($"OnTransformParentChanged()");
    }
    private void OnTriggerEnter(Collider other)
    {
        Record($"OnTriggerEnter({other})");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Record($"OnTriggerEnter2D({collision})");
    }
    private void OnTriggerExit(Collider other)
    {
        Record($"OnTriggerExit({other})");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Record($"OnTriggerExit2D({collision})");
    }
    private void OnTriggerStay(Collider other)
    {
        Record($"Collider({other})");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Record($"OnTriggerStay2D({collision})");
    }
    private void OnValidate()
    {
        Record($"OnValidate()");
    }
    private void OnWillRenderObject()
    {
        Record($"OnWillRenderObject()");
    }
    private void Reset()
    {
        Record($"Reset()");
    }
    private void Start()
    {
        Record($"Start()");
    }
    private void Update()
    {
        Record($"Update()");
    }
}
