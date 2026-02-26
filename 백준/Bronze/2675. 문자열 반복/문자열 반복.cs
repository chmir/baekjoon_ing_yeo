//bj2675 . b2 . 문자열 반복 . 260215
//크리스탈 티 - 카라가 뒤집혀진 채로
//그냥 구현문제. 이런 건 안 풀어도 되긴 하는데.. 손풀기로

//테스트 케이스 수
int T = int.Parse(Console.ReadLine());
//T만큼 반복
for (int i = 0; i < T; i++)
{
    //입력을 한줄로 받아서... 
    string[] input = Console.ReadLine().Split();
    int R = int.Parse(input[0]); //문자 반복횟수 R
    string S = input[1]; //문자열 S
    //S의 length만큼 for문 써도 무관
    foreach (char c in S)
    {
        //문자 하나하나를 반복횟수반큼 출력
        for (int j = 0; j < R; j++)
        {
            Console.Write(c);
        }
    }
    //개행
    Console.WriteLine();
}