//bj10989 . b1 . 수 정렬하기 3 . 260316
//マクロスMACROSS 82-99 - Now And Forever
//정렬 문제. (계수 정렬, Counting Sort)
//이 문제는 입력 개수가 매우 많은데 반해, 수의 범위는 1~10000으로 작다.
//이럴 때는 수들을 직접 정렬하는 것보다, "각 숫자가 몇 번 나왔는지" 세는 방식이 더 알맞다.
//즉, count[x]에 x의 등장 횟수를 저장한 뒤, 1부터 순서대로 횟수만큼 출력하면 정렬 결과가 된다.
//
//또한 입력과 출력 모두 양이 많으므로,
//Console.ReadLine / Console.WriteLine 반복보다 StreamReader / StreamWriter를 쓰는 편이 안전하다.

//표준 입력 / 출력을 스트림으로 연결
using StreamReader sr = new StreamReader(Console.OpenStandardInput());
using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

//입력
int N = int.Parse(sr.ReadLine());

//1~10000 범위의 수가 들어오므로, 각 숫자의 등장 횟수를 저장 (인덱스가 0부터 시작하니까 범위+1 한거야)
int[] count = new int[10001];

for (int i = 0; i < N; i++)
{
    int number = int.Parse(sr.ReadLine());
    count[number]++;
}

//출력
//작은 수부터 확인하면, 출력 자체가 곧 오름차순 정렬 결과가 된다
for (int i = 1; i <= 10000; i++)
{
    //i가 나온 횟수만큼 i를 출력 (조건식 보면 알겠지만 0은 걸러짐)
    for (int j = 0; j < count[i]; j++)
    {
        sw.WriteLine(i);
    }
}

//남은 버퍼를 확실히 비워 준다
sw.Flush();