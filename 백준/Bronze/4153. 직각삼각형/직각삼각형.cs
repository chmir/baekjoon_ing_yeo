//bj4153 . b3 . 직각삼각형 . 260225
//Rhodes Rodosu - Sarah 愛
//직각삼각형은 한 각이 직각인 삼각형을 말한다.
//직각삼각형이라면 피타고라스 정리(a^2 + b^2 = c^2)를 만족해야 하므로,
//매 입력마다 가장 긴 변을 빗변으로 두고 성립 여부를 검사한다.

//반복 입력 (0 0 0 이 나오면 종료)
while (true)
{
    //입력 (한 줄에 세 변의 길이)
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    //종료 조건
    if (a == 0 && b == 0 && c == 0)
        break;

    //연산
    //세 변 중 가장 긴 변을 빗변으로 만들어야 하므로 정렬해서 처리
    //arr[2] = 가장 긴 변(빗변 후보), arr[0], arr[1] = 나머지 두 변
    int[] arr = { a, b, c };
    Array.Sort(arr);

    int x = arr[0];
    int y = arr[1];
    int z = arr[2]; //가장 긴(큰) 값이 들어가게 됨

    //피타고라스 정리:
    //직각삼각형이면 x^2 + y^2 == z^2
    if (x * x + y * y == z * z)
        Console.WriteLine("right");
    else
        Console.WriteLine("wrong");
}