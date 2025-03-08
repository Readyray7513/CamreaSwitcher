using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera fpvCamera;
    public Camera overheadCamera;

    // Add references to ALL scripts to disable during overhead mode
    public MonoBehaviour[] fpvScripts;

    public float overheadHeight = 30f;
    private bool isOverhead = false;

    void Start()
    {
        fpvCamera.enabled = true;
        overheadCamera.enabled = false;
        SetFPVScripts(true);
    }

    public void SwitchCamera(Transform computerTransform)
    {
        isOverhead = !isOverhead;

        fpvCamera.enabled = !isOverhead;
        overheadCamera.enabled = isOverhead;

        if (isOverhead)
        {
            overheadCamera.transform.position = computerTransform.position + Vector3.up * overheadHeight;
            overheadCamera.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
            SetFPVScripts(false);
        }
        else
        {
            SetFPVScripts(true);
        }
    }

    void SetFPVScripts(bool enabled)
    {
        foreach (var script in fpvScripts)
            script.enabled = enabled;
    }
}
