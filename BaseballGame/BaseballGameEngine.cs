using System;

namespace BaseballGame
{
    internal class BaseballGameEngine
        {
        int[] quiz = new int[3];
        int stlike = 0;
        int ball = 0;
      
      
        
        internal void Init()
        {
            //quiz내기 , 1~9까지 중복없이 배열 만들자 랜덤하게 두 자리뽑고, 교환(교체) 하자 앞 세자리를 quiz배열에 넣기
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();

            for (int n = 0; n < 100; n++) //중복 없도록 100번섞기
            {
                int i = rand.Next(0, temp.Length);//(0,9) 0~9에서 정수만 뽑아
                int j = rand.Next(0, temp.Length);

                int t = temp[i];
                temp[i] = temp[j];
                temp[j] = t;
            }

               for(int i = 0; i < quiz.Length; i++) {
                quiz[i]=temp[i];
                    }
          

            return;
        }

        internal void Play(string input)
        {
            //quiz랑 input이랑 비교해서 stlike,ball판정하자
            //quiz를 for문으로 돌고
            //input을 for문으로 돌고
            //하나씩 꺼내어 숫자가 같으면
            //자리수 같으면 stlike++
            //자릿수가 다르면 ball++
            stlike = 0;
            ball = 0;

            //Console.WriteLine("quiz:{0}{1}{2}{3}", quiz[0], quiz[1], quiz[2], quiz[3]);
            int[] inputArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i] - '0'; //'1'-'0'=1이다. 49-48이라서
            }
            for(int i = 0; i < quiz.Length; i++)
            {
                for(int j = 0; j < inputArray.Length; j++)
                {
                    if (quiz[i] == inputArray[j]) //꺼낸 숫자가 같다면~
                    {
                        if (i == j)//자릿수 까지 같다면
                        {
                            stlike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }
            
            return;
        }

        internal int GetQuizLength()
        {
            return quiz.Length;
        }

        internal int GetBall()
        {
            return ball;
        }

       internal int GerStrike()
        {
            return stlike;
        }
       
    }
}