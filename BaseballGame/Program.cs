using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseballGameEngine 생성하자
            //게임엔진 초기화하자: quiz만들자(랜덤, 중복없어야한다)
            //quiz는 중복없이 랜덤한 숫자로 만들자
            //무한반복해서 사용자 입력을 받는다
            //게임엔진에 사용자 입력을 넘기고, strike, ball 판정한다.
            //strike의 개수와 quiz길이가 같으면 끝. 축하해주자.
            BaseballGameEngine bge = new BaseballGameEngine();
            bge.Init(); //quiz낸다
            while (true)
            {
                Console.Write("Input Number: ");
                string input = Console.ReadLine();
                bge.Play(input); //Play라는 함수로 가서 사용자가 입력한 값 처리
                Console.WriteLine("input : {0}\tStrike: {1}\tball: {2}",input,bge.GerStrike(),bge.GetBall());
                if (bge.GerStrike()==bge.GetQuizLength())// if (bge.GerStrike()==input.Length) 이렇게 하면 엔터키치면 잘 맞췄다고 나옴. 
                {
                    Console.WriteLine("축하합니다. 잘 맞췄어요.");
                    break;
                }
            }
        }
    }
}
