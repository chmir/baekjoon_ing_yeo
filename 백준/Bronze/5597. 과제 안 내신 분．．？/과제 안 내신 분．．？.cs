//bj5597 . b3 . 과제 안 내신 분..? . 260227
//smokey Robinson - sleepless nights
//구현문제. 배열을 활용하자

//학생명단, bool 배열의 기본값은 false이다.
bool[] students = new bool[31]; //0~30 인덱스 생성
//28명의 출석정보를 받는다. (가독성을 위해서 0번 인덱스는 사용하지 않는다)
for(int i = 1; i <= 28; i++)
{
    //입력받은 학생 번호의 출석 여부를 true로 설정한다
    students[int.Parse(Console.ReadLine())] = true;
}
//출석하지 않은 게으름뱅이들을 출력한다. (어차피 1번부터 순회하면 알아서 오름차순 출력이 된다)
for (int i = 1; i <= 30; i++) {
    //출석하지 않았다면 (false라면 !로 true로 바꿔주어) 출력
    if (!students[i]) Console.WriteLine(i);
}