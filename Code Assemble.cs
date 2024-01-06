// 1. 외부 dll파일을 import하는 부분

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2. 클래스를 선언하고, 콜론을 통해 타 클래스를 상속시켜 함수를 가용하게 만든다.
// 한 개의 스크립트에는 한 개의 클래스가 존재해야 한다.
public class Movement : MonoBehaviour
{
    // 3. 기본 자료 형식
    int health = 30;
    float level = 5;
    string playerName = "나검사";
    bool isFullLevel = false;

    public int Variable;  // 전역변수로 지정하면 외부에서 해당 값을 가져오거나 변경할 수 있다.

    string[] monsters = {"슬라임", "사막뱀",  "악마"};  // 어레이, 원소를 각각 지정해주는 경우
    int[] monsterLevel = new int[3];  // int[3]은 크기가 3인 어레이이다.
    monsterLevel[0] = 1;
    monsterLevel[1] = 9;
    monsterLevel[2] = 16;  // 개별 원소에 접근하려고 할 때.
    // 다차원 행렬도 가능하다.

    List<string> items = new List<string>();  // 컴포넌트 가져오듯 원소의 형식을 꺽쇠괄호에 넣어주면 된다.
    items.Add("생명물약30");  // append, 리스트이므로 크기에 제한이 없다.
    items.Add("마나물약30");
    items.RemoveAt(0);  // 0번째에 있는 원소를 삭제한다. 인덱스는 정렬된다.

    // 4. 함수
    int IntegerReturn(float FloatParameter) {
        int ReturnValue = FloatParameter;
        return ReturnValue;  // 반환값, 어떤 형식의 값을 반환할지 함수 앞에 지정해주고, 어떤 형식의 파라미터를 넣어야 할지 괄호 안에 지정해줘야 한다.
    }

    void ActiveFunction(bool BoolParameter) {
        BoolParameter = false;
    }  // 반환값이 없고, 동작만 있는 함수.
}