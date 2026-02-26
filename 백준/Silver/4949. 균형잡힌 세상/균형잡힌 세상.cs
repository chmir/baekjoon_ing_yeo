//bj4949 . s4 . 균형잡힌 세상 . 260226
//Mikazuki BIGWAVE - 超時空GROOVE (September Delta)
//9012번 괄호 문제와 비슷하게 풀이할 수 있다. 괄호를 열 때는 스택에 담아두고, 닫을 때만 검사
//아예 열고 닫는 괄호가 없는 경우에도, 균형잡힌 문자열로 취급한다. 

//반복
for (;;) //괜히 뭐 아는척 해보기, while(true)와 동일
{
    Stack<char> S = new Stack<char>(); //stack 생성
    string str = Console.ReadLine(); //입력 받고
    if (str == ".") break; //종료 조건
    //문자열 하나씩 대조 
    foreach (char c in str)
    {
        //닫는거면
        if (c == ')')
        {
            //닫을 괄호가 없는 경우 or 있는데 괄호가 안맞음
            if (S.Count == 0 || S.Peek() == '[')
            {
                //Console.WriteLine("no"); //밖에서 한번에 처리
                S.Push(c); //아무값이나 넣고 (스택 안의 문자 개수를 1개 이상으로 끝내서 틀린 괄호열로 처리)
                break; //해당 테스트 케이스 종료 (foreach문 나감)
            }
            //닫을 괄호 있으면
            S.Pop(); // 빼
        }
        else if (c == ']')
        {
            //닫을 괄호가 없는 경우 or 있는데 괄호가 안맞음
            if (S.Count == 0 || S.Peek() == '(')
            {
                //Console.WriteLine("no"); //밖에서 한번에 처리
                S.Push(c); //아무값이나 넣고 (스택 안의 문자 개수를 1개 이상으로 끝내서 틀린 괄호열로 처리)
                break; //해당 테스트 케이스 종료 (foreach문 나감)
            }
            //닫을 괄호 있으면
            S.Pop(); // 빼
        }
        //여는거면 (그 외의 문자들은 무시해야한다)
        else if (c == '(' || c == '[')
        {
            //여는 건 무조건 넣어주고 (따로 예외처리 할 필요 없음)
            S.Push(c);
        }
        //그 외의 문자들은 읽을 필요가 없음
    }
    //다 넣었으면 count 개수로 판별 (stack이 비어있어야 옳은 괄호
    Console.WriteLine((S.Count == 0) ? "yes" : "no");
}