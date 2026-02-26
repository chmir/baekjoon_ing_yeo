//bj1546 . b1 . 평균 . 260226
//kissmenerdygirl - Hypnotic Eyes
//여러 과목 중, 최댓값을 100점으로 만들고, 나머지 과목도 그에 맞춰 상향 조정하게 하는 문제임
//문제에서 제시한 대로 구현하면 돼서, 생각을 거치지 않아도 돼 좋았음
//원리는? 최고점이 80이라 했을 때, 100 / 80 = 1.25 
//즉 80 * 1.25 = 100이므로, 80점이 100점이 되기 위한 배율을 구한 것이며, 그에 맞춰 나머지 점수들도 그 배율만큼 올려주는 것이다. 
//구현 자체는 쉬운데, 이게 어디에 쓰일까 하고 찾아보는 재밌는 시간이 되었음. (내가 찾은 용어가 맞는진 모름, 걍 검색한거임)
//관련 용어: 최대값 기준 스케일링(Max-based scaling), 최대값 정규화(Max normalization), 선형 스케일링(Linear Scaling Rule), 최대 절댓값 스케일러(MaxAbsScaler)
//조금 다르지만 Min-Max Normalization 이거 재밌어보이네

//입력 (과목 개수 N, 1~1000)
int N = int.Parse(Console.ReadLine());

//입력 (공백으로 구분된 자연수들, 0~100)
//이따 소숫점 보여주려고 그냥 정수를 입력받긴 하지만 float 배열로 했다
float[] numbers = Array.ConvertAll(
    Console.ReadLine().Split(' '),
    float.Parse
);

//최댓값 M 구하기 (M의 테스트케이스는 적어도 0보다 큰 수라고 명시되었으니 0/0 예외처리 안 함)
//Array.Sort(numbers); //최댓값 구분하는 로직 만들기 귀찮아서 정렬 (맨 끝 번이 최댓값이 됨)
//과목이 3개가 들어가면 3인데, 그러면 할당된 인덱스가 0 1 2 잖아. 그래서 끝번을 찾으려면 길이-1 하는 것
//int M = (int)numbers[N - 1];
float M = numbers.Max(); //생각해보니 더 편한 방법이 있었네

//평균값 변수
float A = 0;

//모든 과목 점수를 변경
for(int i = 0; i < N; i++)
{
    A += numbers[i] * (100f / M); //최고점 M을 기준점으로 잡는다 (numbers[i] / M * 100 과 같은 뜻)
}
//과목 개수만큼 나눠서 평균 내기
A /= N;//numbers.Length;

Console.WriteLine(A);