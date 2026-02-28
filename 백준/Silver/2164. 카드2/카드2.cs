//bj2164 . s4 . 카드2 . 260301
//ナイトNaito - Saxxx
//맨 위 카드를 버린다. 그다음 카드는 아래 장으로 옮긴다. 이걸 하나 남을 때까지 반복한다. 
//큐 문제, 문제 설명대로 진행하면 될 듯?
//자료구조를 알면 쉬운 문제지만 재활치료 겸 ~~

//카드 개수
int N = int.Parse(Console.ReadLine());

//큐 생성 및 기본값 세팅
Queue<int> card = new Queue<int>();
for(int i = 1; i <= N; i++) //1~N
{
    card.Enqueue(i); //그럼 가장 처음으로 나오게 될 숫자는 1이 된다. 큐니까. 
}

//그리고 카드에 요소가 하나만 남을 때 까지 반복
while(card.Count > 1)
{
    card.Dequeue(); //맨 윗 장은 버린다
    card.Enqueue(card.Dequeue()); //그 다음 장은 아래로 옮긴다.(Dequeue는 제거한 값을 반환해준다.)
}

//답
Console.WriteLine(card.Peek());