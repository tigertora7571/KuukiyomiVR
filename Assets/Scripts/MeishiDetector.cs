using TMPro;
using UnityEngine;

namespace Leap.Unity.Examples
{
  public class MeishiDetector : MonoBehaviour
  {

    public HandPoseDetector detectorRight;
    public HandPoseDetector detectorLeft;

    public GameObject textGameobject;
    public TextMeshProUGUI text;
    UserStatus userStatus;

    void Start()
    {
      userStatus = new UserStatus(); //インスタンス化
      Debug.Log(userStatus.GetSetMeishiScore);
    }


    void Update()
    {
      HandPoseScriptableObject detectedPoseRight = detectorRight.GetCurrentlyDetectedPose();
      HandPoseScriptableObject detectedPoseLeft = detectorLeft.GetCurrentlyDetectedPose();
      if (detectedPoseRight != null && detectedPoseLeft != null)
      {
        textGameobject.SetActive(true);
        // スコア上昇
        userStatus.GetSetMeishiScore = 1;

      }
      else
      {
        textGameobject.SetActive(false);
      }
      Debug.Log(userStatus.GetSetMeishiScore);
    }
  }
}