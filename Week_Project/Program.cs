using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Week_Project;

namespace TestConsole
{
    public class Program
    { 
        static void Main()             // Main 함수 (게임 메인 진행화면으로 가기 전 게임 설정)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int character = 0;                            // 유저의 캐릭터 성향
            string[] player_form = new string[16];        // 유저 캐릭터 모양 설정

            Paint paint_ = new Paint();
            paint_.CharacterPaint(ref player_form);

            Loading loading_ = new Loading();           // 로딩 스크린 클래스 생성
            loading_.LoadingScreen();                   // 로딩 스크린 함수 실행

            Character character_ = new Character();                              // 캐릭터 성향 선택 클래스 생성
            character_.CharacterSelect(ref character, ref player_form);          // 캐릭터 성향 선택 함수 실행

            MainSystem mainsystem_ = new MainSystem();
            mainsystem_.MainScreen(character, player_form);

            //Test test_ = new Test();
            //test_.TestGroup();

        }            // End Main 함수

        public void Replay()
        {
            int character = 0;
            string[] player_form = new string[16];

            Paint paint_ = new Paint();
            paint_.CharacterPaint(ref player_form);

            Loading loading_ = new Loading();
            loading_.LoadingScreen();

            Character character_ = new Character();
            character_.CharacterSelect(ref character, ref player_form);

            MainSystem mainsystem_ = new MainSystem();
            mainsystem_.MainScreen(character, player_form);

            //Test test_ = new Test();
            //test_.TestGroup();
        }
    }
}