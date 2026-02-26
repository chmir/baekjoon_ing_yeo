//bj2588 . b3 . 곱셈 . 260214
//52ND STREET - I CAN'T LET YOU GO (SCREWED&CHOPPED)
//나머지 연산 사용
//정수형 나누기는 소숫점을 버림처리 한다는 걸 기억하자. 

//입력
int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
//출력
//각 자리를 abc * def 라 했을 때
//abc * f
Console.WriteLine(N1 * (N2%10));
//abc * e
Console.WriteLine(N1 * ((N2 % 100)/10));
//abc * d
Console.WriteLine(N1 * (N2 / 100));
//abc * def
Console.WriteLine(N1 * N2);