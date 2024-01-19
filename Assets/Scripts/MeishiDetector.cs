using TMPro;
using UnityEngine;

namespace Leap.Unity.Examples
{
  public class MeishiDetector : MonoBehaviour
  {

    [Header("References")]
    public HandPoseDetector detectorRight;
    [Header("References")]
    public HandPoseDetector detectorLeft;

    public GameObject textGameobject;
    public TextMeshProUGUI text;

    void Update()
    {
      HandPoseScriptableObject detectedPoseRight = detectorRight.GetCurrentlyDetectedPose();
      HandPoseScriptableObject detectedPoseLeft = detectorLeft.GetCurrentlyDetectedPose();
      if (detectedPoseRight != null && detectedPoseLeft != null)
      {
        textGameobject.SetActive(true);
      }
      else
      {
        textGameobject.SetActive(false);
      }
    }
  }
}