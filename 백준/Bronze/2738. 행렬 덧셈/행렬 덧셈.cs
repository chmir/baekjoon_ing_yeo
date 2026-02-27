//bj2738 . b3 . 행렬 덧셈 . 260227
//ll nøthing ll  - all night thinking
//구현문제. 배열을 활용하자

//첫째 줄에 행렬의 크기를 입력받는다. 
int[] size = Array.ConvertAll(
    Console.ReadLine().Split(' '),
    int.Parse
);
int N = size[0];
int M = size[1];

//2개의 행렬을 입력받는다. (행렬을 2개나 만들 필요는 없다)
//첫번째 행렬 입력
int[,] arr = new int[N, M];
for (int i = 0; i < N; i++)
{
    //한 줄에 M개의 수를 입력받는다
    int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < M; j++) arr[i, j] = row[j];
}
//두번째 행렬 입력
for (int i = 0; i < N; i++)
{
    //한 줄에 M개의 수를 입력받는다
    int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < M; j++) arr[i, j] += row[j]; //기존 행렬에 값을 합해준다
}
//다 입력 받았으니 더해진 거 출력
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++) Console.Write($"{arr[i, j]} "); //한칸씩 띄워서
    Console.WriteLine(); //개행
}