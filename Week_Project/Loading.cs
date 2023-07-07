using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Loading
    {
        public void LoadingScreen()            // 로딩 스크린 함수
        {
            const int LOADING_TIME_1 = 2000;          // 로딩 창 마다 다른 대기값 부여
            const int LOADING_TIME_2 = 1000;
            const int LOADING_TIME_3 = 250;
            const int LOADING_TIME_4 = 3000;

            int loading_gauge = 0;          // 로딩 게이지 정수값

            while (true)
            {
                if (loading_gauge == 0)       // 로딩 게이지 정수값으로 화면 전환
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - □□□□□□□□□□  0 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_1);

                    loading_gauge = 10;
                }
                else if (loading_gauge == 10)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■□□□□□□□□□  10 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_2);

                    loading_gauge = 20;
                }
                else if (loading_gauge == 20)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■□□□□□□□□  20 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 30;
                }
                else if (loading_gauge == 30)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■□□□□□□□  30 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 40;
                }
                else if (loading_gauge == 40)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■□□□□□□  40 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 50;
                }
                else if (loading_gauge == 50)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■□□□□□  50 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 60;
                }
                else if (loading_gauge == 60)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■■□□□□  60 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 70;
                }
                else if (loading_gauge == 70)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■■■□□□  70 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_3);

                    loading_gauge = 80;
                }
                else if (loading_gauge == 80)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■■■■□□  80 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_4);

                    loading_gauge = 90;
                }
                else if (loading_gauge == 90)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■■■■■□  90 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(4000);

                    loading_gauge = 100;
                }
                else if (loading_gauge == 100)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <<  사  막  의  탑  >>     v 1.2.7");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [ 전체 화면으로 플레이 하시면 더 쾌적한 게임 이용이 가능합니다 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         [ Loading ] - ■■■■■■■■■■  100 %");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Thread.Sleep(LOADING_TIME_2);

                    break;
                }
            }
        }               // End 로딩 스크린 함수
    }
}
