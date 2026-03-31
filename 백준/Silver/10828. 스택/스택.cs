//bj10828 . s4 . 스택 . 260331
//iden kai - Galactica Airlines
//stack, 구현 문제. 문제 내용이 곧 설명
//시간초과나서 빠른 입출력 사용

//빠른 입출력을 위한 국밥 버퍼 사용
using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

//명령의 수 
int N = int.Parse(sr.ReadLine());
//스택 생성
Stack<int> s = new Stack<int>();

while (N-- > 0)
{
    //입력 (push가 있는 경우 생각)
    string[] input = sr.ReadLine().Split();

    switch (input[0])
    {
        case "push":
            s.Push(int.Parse(input[1]));
            break;

        case "pop":
            //TryPop은 스택 맨 위에 값이 있다면 result에 넣고 스택에서 제거한 뒤, 성공 여부를 bool값으로 반환함
            //삼항 연산자 활용으로 Pop을 성공했다면 제거한 값을 보여주고, 실패했다면 -1 반환
            sw.WriteLine(s.TryPop(out int result) ? result : -1);
            break;

        case "size":
            sw.WriteLine(s.Count);
            break;

        case "empty":
            sw.WriteLine(s.Count == 0 ? 1 : 0);
            break;

        case "top":
            //TryPeek는 스택 맨 위에 값이 있다면 result에 넣고, 성공 여부를 bool값으로 반환함
            sw.WriteLine(s.TryPeek(out int result2) ? result2 : -1);
            break;
    }
}

sw.Flush();