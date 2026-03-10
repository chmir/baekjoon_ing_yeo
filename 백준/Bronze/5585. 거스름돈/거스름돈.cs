//bj5585 . b2 . 거스름돈 . 260310
//マクロスMACROSS 82-99 - バニラと美里BIG CITY NIGHTS 
//Kenny Lynch - Another Groovy Saturday Night
//그리디 알고리즘은 현재 내릴 수 있는 최선의 선택에만 집중하는 방식이다. 
//그리디 알고리즘을 활용할 수 있는 문제는
//현재 내린 결정이 미래의 결정에 큰 영향을 주지 않을 때, 
//더 엄밀히 말하자면 현재(부분)의 최선이 전체의 최적해로 이어지는 구조여야 한다. 
//음, 뺄 수 있는 가장 큰 수를 하나씩 빼가며 카운트하면 될 거 같구나

//거스름돈 총액과 개수
int N = 1000 - int.Parse(Console.ReadLine());
int count = 0;
//거스를 수 있는 동전의 종류 (여러 방법 중 하나일 뿐임...)
int[] coins = { 500, 100, 50, 10, 5, 1 };
//큰 동전부터 나누기 시작
foreach (int coin in coins)
{
    count += N / coin; // 현재 동전으로 거슬러 줄 수 있는 개수만큼 더한다 (현재 동전으로 안 나눠지면 몫은 0)
    N %= coin; // 현재 동전까지 거스르고 남은 금액 (마지막엔 1엔에서 전부 나눠진다) 
}
//결과 출력
Console.WriteLine(count);