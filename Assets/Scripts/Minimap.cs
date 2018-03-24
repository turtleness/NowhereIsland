using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    public Transform IslandBottomCorner;
    public Transform IslamndTopCorner;
    public Sprite IslandImage;
    public Transform Player;
    public RectTransform IslandMap;
    private float xRatio;
    private float yRatio;

	void Start () {
        float IslandWidth = IslamndTopCorner.position.x - IslandBottomCorner.position.x;
        float IslandHeight = IslamndTopCorner.position.z - IslandBottomCorner.position.z;

        xRatio = IslandImage.texture.width / IslandWidth;
        yRatio = IslandImage.texture.height / IslandHeight;
	}
	
	
	void Update () {
        Vector3 PlayerPosition = Player.position - IslandBottomCorner.position;

        Vector3 IslandMapNewPos = new Vector3(-(PlayerPosition.x * xRatio), -(PlayerPosition.z * yRatio));
        IslandMap.anchoredPosition = IslandMapNewPos;
	}
}
