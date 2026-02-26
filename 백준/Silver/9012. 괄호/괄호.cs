//bj9012 . s4 . 괄호 . 260216
//Yung Bae - I Can Tell
//VPS 판별 여부는 닫는 괄호 예외처리가 가장 중요하다
//Stack 자료형을 사용하지 않아도 되지만, 문제 의도에 맞게 풀어보자.

//첫줄 테스트 케이스 수 입력
int T = int.Parse(Console.ReadLine());

//반복
for (int i = 0; i < T; i++)
{
    Stack<char> S = new Stack<char>(); //stack 생성
    string str = Console.ReadLine(); //입력 받고
    //문자열 하나씩 대조 
    foreach(char c in str)
    {
        //닫는거면
        if(c == ')')
        {
            //닫을 괄호가 없는 경우
            if(S.Count == 0)
            {
                //Console.WriteLine("NO"); //밖에서 한번에 처리
                S.Push(c); //아무값이나 넣고 (1개로 끝내서 틀린 괄호열로 처리)
                break; //해당 테스트 케이스 종료 (foreach문 나감)
            }
            //닫을 괄호 있으면
            S.Pop(); // 빼
        }
        //여는거면
        else
        {
            //여는 건 무조건 넣어주고 (따로 예외처리 할 필요 없음)
            S.Push(c);
        }
    }
    //다 넣었으면 count 개수로 판별 (전부 빼져야 맞는 괄호
    Console.WriteLine((S.Count == 0) ? "YES" : "NO");
}