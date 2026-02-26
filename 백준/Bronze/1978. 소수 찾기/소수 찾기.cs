//bj1978 . b2 . 소수찾기 . 260224
//サクラSAKURA-LEE - My Heart Baby (Read The Description)
//소수란, 1과 자기 자신으로만 나누어 떨어지는, 1보다 큰 자연수를 말한다. 

//입력 (첫 줄: 개수 N, 문제 조건상 100 이하)
int N = int.Parse(Console.ReadLine());

//입력 (둘째 줄: 공백으로 구분된 자연수들, 문제 조건상 각 수는 1000 이하)
int[] numbers = Array.ConvertAll(
    Console.ReadLine().Split(' '),
    int.Parse
);

//연산
int count = 0; //소수 개수 카운트

//입력받은 각 숫자를 하나씩 꺼내서 소수인지 검사
foreach (int number in numbers)
{
    //0, 1은 소수가 아니므로 건너뛴다
    if (number < 2) continue;

    bool isPrime = true; //일단 소수라고 가정하고 시작

    //2부터 검사하되, number의 제곱근까지만 확인하면 충분하다
    //예: 12의 약수는 (2,6), (3,4)처럼 쌍으로 나오므로
    //작은 쪽 약수만 찾으면 된다
    //예2: 36의 제곱근은 6 -> 약수 쌍: (1*36), (2*18), (3*12), (4*9), (6*6) 딱 6에서 만난다. (큰쪽 약수, 작은쪽 약수가 제곱근을 기준으로 나뉘어짐)
    //결론1: 어떤 수 n의 약수 두 개를 a, b라고 할 때, 두 숫자가 √n보다 크다면 a*b는 √n*√n=n보다 커지기에 모순
    //  그러므로, 약수 쌍 둘 다 제곱근 보다 클 수 없으니, 둘 중 하나는 제곱근 이하에 있다. 
    //결론2: i <= number/2 로 범위를 두어도 되지만 이 편이 더 효율적이다. 
    for (int i = 2; i * i <= number; i++) //i <= √number
    {
        //나누어 떨어지는 수가 있으면 소수가 아니다
        if (number % i == 0)
        {
            isPrime = false;
            break; //더 볼 필요 없으므로 반복 종료
        }
    }

    //끝까지 나누어 떨어지는 수가 없었다면 소수이므로 카운트 증가
    if (isPrime) count++;
}

//출력 (소수의 개수)
Console.WriteLine(count);