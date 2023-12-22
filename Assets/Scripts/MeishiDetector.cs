using TMPro;
using UnityEngine;

namespace Leap.Unity.Examples
{
  public class MeishiDetector : MonoBehaviour
  {

    [Header("References")]
    public HandPoseDetector detector;

    void Update()
    {
      HandPoseScriptableObject detectedPose = detector.GetCurrentlyDetectedPose();
      if (detectedPose != null)
      {
        // Detect
      }
      else
      {
      }
    }
  }
}