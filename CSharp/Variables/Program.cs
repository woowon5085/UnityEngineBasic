// 변수 (Variables)
// 아직 정해지지 않은 값  

// 변수를 사용하겠다고 '선언' 하는 것의 의미 : 
// 특정 형태의 값이 들어갈 수 있는 (쓸수있는) 매모리영역의 공간을 할당

// 변수 선언 형태
// 자료형 이름;
//
// 초기화 형태 : 
// 자료형 이름 = 초기화 값;
// = : 대입연산자. 오른쪽에있는 값을 왼쪽에 있는 변수에 대입하는 연산자.
int number1 = 25; // int : 부호가 있는 4byte 정수형
int number2 = 4;
uint number3 = 1;
int number4 = -1;
short s; // short : 부호가 있는 2byte 정수형
long l; // long : 부호가 있는 8byte 정수형
float f = 4.2f; // float : 4byte 실수형
double d = 4.2; // double : 8byte 실수형 
char c = 'k'; // char : 2 byte 문자형
string st = "안녕하세요"; // string : 2byte * 문자갯수 + 1byte (null) 문자열형 (primitive type과 예외적임)
bool isTrue = false; // bool : 1byte 논리형
