//bj2562 . b3 . 최댓값 . 260213
//Mint Condition - Breakin' My Heart (Pretty Brown Eyes)
//그냥 구현 문제니까 깊게 생각하지 말자

//입력 & 연산
//숫자 9개 (1~100)
int[] numbers = new int[9];
(int max, int idx) t = (0,0); //가장 큰 수, 순서
for (int i = 0; i <9; i++)
{
    numbers[i] = int.Parse(Console.ReadLine()); //입력
    //현재 입력값이 더 크다면 가장 큰 수 초기화
    if (t.max < numbers[i])
    {
        t.max = numbers[i];
        t.idx = i;
    }
}
//출력 
Console.Write($"{t.max}\n{t.idx+1}"); //순서가 1부터 시작하니까 +1
