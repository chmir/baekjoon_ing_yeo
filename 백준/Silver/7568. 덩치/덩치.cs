//bj7568 . s5 . 덩치 . 260225
//Architecture in Tokyo & Macross 82-99 - City Nightlife
//브루트포스 문제
//정렬로 줄 세우려 하지 말고, 각 사람보다 몸무게+키가 모두 큰 사람 수를 세어서 등수(큰 사람 수+1)를 구한다

//입력
int N = int.Parse(Console.ReadLine());

// [i, 0] = 몸무게, [i, 1] = 키
int[,] people = new int[N, 2];

for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split();
    people[i, 0] = int.Parse(input[0]); // 몸무게
    people[i, 1] = int.Parse(input[1]); // 키
}
//연산
for (int i = 0; i < N; i++)
{
    int rank = 1; // 기본 등수는 1등

    for (int j = 0; j < N; j++)
    {
        if (i == j) continue; // 자기 자신은 비교 제외

        // j가 i보다 몸무게와 키 모두 크면 i의 등수 밀림
        if (people[j, 0] > people[i, 0] && people[j, 1] > people[i, 1])
        {
            rank++;
        }
    }

    Console.Write(rank);

    //한 줄에 하나씩 출력
    if (i != N - 1) Console.Write(" ");
}