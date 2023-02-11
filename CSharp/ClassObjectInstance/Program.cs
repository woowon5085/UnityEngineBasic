// using 키워드
// using namespace 이름 :
// 특정 namespace를 이 cs에서 어셈블리에서 사용하겠다

using ClassObjectInstance;

// 값타입, 참조타입 
// 값타입 : 값을 직접 메모리에 쓰고 읽는 형태, 일반적으로 스택영역에 할당
// 참조타입 : 데이터가 있는 메모리의 주소로 간접 쓰기/읽기를 하는 형태, 힙 영역에 할당 
 
// new 키워드
// 동적할당 키워드. 런타임에서 메모리를 동적할당할 때 사용
SwordMan swordMan = new SwordMan();

// .연산자 
// 멤버접근연산자
swordMan.Name = "검사1";
//swordMan.Attack();
//swordMan.Jump();

SwordMan swordMan2 = new SwordMan();
swordMan2.Name = "검사2";


//Orc Class 생성
Orc orc1 = new Orc(); 
orc1.Name = "상급오크";
orc1.Age = 210;
orc1.Height = 60.3;
orc1.Weight = 80.2;
orc1.Gender = '여';

Orc orc2 = new Orc();
orc2.Name = "하급오크";
orc2.Age = 140;
orc2.Height = 72.0;
orc2.Weight = 24.4;
orc2.Gender = '남';

orc1.SayMyName();
orc1.SayMyInfo(); 
orc2.SayMyName();
orc2.SayMyInfo();