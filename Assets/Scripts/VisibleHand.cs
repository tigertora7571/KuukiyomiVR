
using TMPro;
using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;
using System.Collections.Generic;
using UnityEngine.UI;


public class VisibleHand : MonoBehaviour
{

  [SerializeField]

  LeapServiceProvider m_Provider;

  public TextMeshProUGUI scoreText; // 取得した手のトラッキングデータをUIに表示


  void Update()
  {
    Frame frame = m_Provider.CurrentFrame;

    // 右手と左手を取得する
    Hand rightHand = null;
    Hand leftHand = null;
    foreach (Hand hand in frame.Hands)
    {
      if (hand.IsRight)
      {
        rightHand = hand;
      }
      if (hand.IsLeft)
      {
        leftHand = hand;
      }
    }

    if (rightHand == null && leftHand == null)
    {
      return;
    }

    Vector3 right_normal;
    Vector3 right_direction;
    Vector3 right_position;
    Vector3 left_normal;
    Vector3 left_direction;
    Vector3 left_position;
    float distance;

    if (rightHand != null && leftHand != null)
    {
      right_normal = rightHand.PalmNormal;
      right_direction = rightHand.Direction;
      right_position = rightHand.PalmPosition;
      left_normal = leftHand.PalmNormal;
      left_direction = leftHand.Direction;
      left_position = leftHand.PalmPosition;
      distance = Vector3.Distance(right_position, left_position);
      scoreText.text = "右手の法線ベクトル: " + right_normal + "\n" +
                       "右手の方向ベクトル: " + right_direction + "\n" +
                       "右手の位置ベクトル: " + right_position + "\n" +
                       "左手の法線ベクトル: " + left_normal + "\n" +
                       "左手の方向ベクトル: " + left_direction + "\n" +
                       "左手の位置ベクトル: " + left_position + "\n" +
                       "内積: " + Vector3.Dot(right_normal, left_normal) + "\n" +
                       "中点: " + Vector3.Lerp(right_position, left_position, 0.5f) + "\n" +
                       "２点間の距離: " + distance;
    }

    if (rightHand != null && leftHand == null)
    {
      right_normal = rightHand.PalmNormal;
      right_direction = rightHand.Direction;
      right_position = rightHand.PalmPosition;
      scoreText.text = "右手の法線ベクトル: " + right_normal + "\n" +
                       "右手の方向ベクトル: " + right_direction + "\n" +
                       "右手の位置ベクトル: " + right_position;
    }
    if (rightHand == null && leftHand != null)
    {
      left_normal = leftHand.PalmNormal;
      left_direction = leftHand.Direction;
      left_position = leftHand.PalmPosition;
      scoreText.text = "左手の法線ベクトル: " + left_normal + "\n" +
                       "左手の方向ベクトル: " + left_direction + "\n" +
                       "左手の位置ベクトル: " + left_position;
    }
  }
}
