//bj2839 . s4 . 설탕 배달 . 260310
//SAINT PEPSI - ENJOY YOURSELF 
//이 문제는 5585 거스름 돈 문제처럼 무조건 큰 봉지부터 고르면 안 된다.
//딱 맞아 떨어지면서도, 최소 개수를 구해야하니까..
//예를 들어 6kg은 5kg를 먼저 고르면 1kg가 남아 실패하지만, 3kg 2개로 가능하다.
//따라서 5kg 봉지를 최대한 써 보되, 안 되면 하나씩 줄여가며 확인한다.

//설탕의 총 무게
int N = int.Parse(Console.ReadLine());
int answer = -1; //봉지 개수

//5kg 봉지를 최대로 쓰는 경우부터 하나씩 줄여가며 확인 (five는 N을 나눌 수 있는 5kg 봉지 개수)
for (int five = N / 5; five >= 0; five--) //N이 5보다 작은 경우도 five=0 부터 검사 가능하다
{
    int remain = N - (five * 5); //5kg 봉지들을 쓰고 남은 설탕

    //남은 설탕이 3kg 봉지로 딱 나눠지면 성공
    if (remain % 3 == 0)
    {
        int three = remain / 3; //3kg 봉지 개수
        answer = five + three; //총 봉지 개수
        break; //5kg를 가장 많이 쓴 경우부터 확인했으므로 처음 성공이 최소 봉지 수
    }
}

//결과 출력
Console.WriteLine(answer);