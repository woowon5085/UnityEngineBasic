﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 구조체 (structure)
// 멤버변수의 멤버함수를 가지며, 값타입이다 **
// 구조체를 선정하는 기준 : 
// 1. 16 byte 이하. 넘어가면 그냥 클래스 쓰는것을 권장함.
// 2. 함수의 인자 전달 혹은 값 연산이 빈번 할 경우. 

namespace Structure
{
    internal struct Stats
    {
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;

        // 구조체는 생성자에서 모든 멤버변수를 초기화 해야한다.
        // 클래스와 다르게 구조체는 비슷하게생겼지만 값타입이고, 생성자를 통해 동적 할당할 때 
        // 힙 영역이 아니라 스택영역에 저장되며,  생성자를 호출할때 원본 데이터를 가지고 할당하는게 아니라 
        // 그 크기만큼 스택공간만 할당하기 때문에 쓰레기값이 들어있다.
        public Stats()
        {
            STR = 0;
            DEX = 0;
            INT = 0;
            LUK = 0;
        }

        // 함수 오버로드 (생성자 오버로드)
        // 동일한 이름의 다른 함수를 정의하는 기능
        // 가능한 이유 : 함수 원본의 주소에 접근 할 때, 함수의 이름만가지고 접근하는 것이 아니라 
        // 파라미터타입들과 함께 접근하기때문
        public Stats(int STR, int DEX, int INT, int LUK)
        {
           this.STR = STR;
           this.DEX = DEX;
           this.INT = INT;
           this.LUK = LUK;
        }

        public int GetCombatScore()
        {
            return STR + DEX + INT + LUK;
        }
    }
}
