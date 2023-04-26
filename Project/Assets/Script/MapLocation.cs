using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapLocation : MonoBehaviour
{
    // Start is called before the first frame update

    // 垂直排列的Group物件
    public VerticalLayoutGroup verticalGroup;

    // 子物體的寬度和高度
    public int colWidth;
    public int colHeight;

    // 圖片數量
    public int rowCount = 16;
    public int colCount = 11;

    // 存儲子物體的座標值
    public Vector3[,] positions;

    void Start()
    {
        // 初始化二維陣列
        positions = new Vector3[rowCount, colCount];

        // 遍歷Vertical Group中的所有子物體
        for (int j = 0; j < verticalGroup.transform.childCount; j++)
        {
            // 獲取當前子物體的RectTransform組件
            RectTransform row = verticalGroup.transform.GetChild(j).GetComponent<RectTransform>();

            // 遍歷Horizontal Group中的所有子物體
            for (int i = 0; i < row.transform.childCount; i++)
            {
                // 獲取當前子物體的RectTransform組件
                RectTransform col = row.transform.GetChild(i).GetComponent<RectTransform>();

                // 計算該子物體的行列索引值
                int rowIndex = j * row.transform.childCount + i;
                int rowIdx = rowIndex / colCount;
                int colIdx = rowIndex % colCount;

                // 計算該子物體的座標值
                int x = colIdx * colWidth;

                int y = -(rowIdx + 1) * colHeight;

                // 設置子物體的座標
                col.anchoredPosition = new Vector2(x, y);

                // 將座標值轉換為世界座標並存儲到二維陣列中
                positions[rowIdx, colIdx] = col.TransformPoint(new Vector3(x, y, 0));
                Debug.Log("positions[rowIdx, colIdx]" + positions[rowIdx, colIdx]);
;


            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
