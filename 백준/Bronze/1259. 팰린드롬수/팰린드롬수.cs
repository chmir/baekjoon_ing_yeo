//bj1259 . b1 . 팰린드롬수 . 260304
//Earth, Wind & Fire - Let's Groove
//구현문제
//홀수면 중간 글자 무시하고... 반으로 잘라서 앞 뒤로 나눈 뒤에
//둘중 하나 반전 시켜서 맞으면 정답이겠지 뭐
//ㄴ아니 그럴필요도 없잖아. 인덱스 2개를 쓰면 돼.

while (true != false) //굳이 이럴필요 없지만 이러고 싶었어
{
    //입력
    string s = Console.ReadLine();
    //0나오면 끝
    if (s == "0") break;
    //1글자인 경우는 알아서 true가 되니 걱정 말아
    //앞열, 뒷열 인덱스
    int left = 0, right = s.Length - 1; 
    bool isP = true; //처음엔 팰린드롬이라고 가정함
    while (left < right) //인덱스 두개를 쓰면 되는거구만! (어차피 문자열 개수가 홀수개여도 중앙은 무시돼)
    {
        //Console.WriteLine($"{s[left]}/{s[right]}"); //나를 못믿어서 테스트용 출력문
        //하나라도 맞지 않다면 그건 팰린드롬수가 아님 (아니면 더 볼 필요 없으니 검증 끝)
        if (s[left] != s[right]) { isP = false; break; }
        left++; right--; //각각 앞뒤로 범위 좁힘
    }
    //팰린드롬 여부에 따라 yes or no
    Console.WriteLine(isP ? "yes" : "no");
} 