//bj2439 . b4 . 별 찍기 - 2 . 260213
//김뜻돌 - 사라져

//입력
int N = int.Parse(Console.ReadLine());
//출력
//줄 (1, 2, 3, ..., N)
for(int i = 1; i <= N; i++)
{
    //공백 (N-1, N-2, N-3, ..., 0)
    for(int j = N; j > i; j--)
    {
        Console.Write(" ");
    }
    //별 (1, 2, 3, ..., N)
    for(int k = 0; k < i; k++)
    {
        Console.Write("*");
    }
    //개행 (1, 1, 1, ..., 1)
    Console.WriteLine();
}