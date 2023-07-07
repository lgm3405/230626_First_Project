using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Story
    {
        string[] screen = new string[100];
        int screen_max = 0;

        const int SLEEP = 500;

        string[] print = new string[100];
        int print_max = 0;
        int print_type = 0;

        public void String001(ref int story_step, ref int screen_type)        // 프롤로그 스토리
        {
            if (story_step == 0)
            {
                Paint paint_ = new Paint();
                screen_type = 1;
                paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                for (int i = 0; i < screen_max + 1; i++)
                {
                    Console.WriteLine("                                    {0}", screen[i]);
                }

                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     고대 전설적인 가디언들의 희생으로 봉인되어있던 고대 마왕이 다시 부활하고 있다는 소문이 머나먼 대사막에서");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     부터 소문으로 들려오자 중간계 7 왕국 연합 의회에서 기나긴 논쟁 끝에 왕국의 최고의 기사단을 연합으로 파견하여");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     대사막으로 머나먼 원정을 떠나게 되는데...");
                Thread.Sleep(SLEEP);
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
                Console.WriteLine();
                Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (story_step == 1)
            {
                Paint paint_ = new Paint();
                screen_type = 2;
                paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                for (int i = 0; i < screen_max + 1; i++)
                {
                    Console.WriteLine("                                    {0}", screen[i]);
                }

                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     기사단 연합의 발길이 대사막 입구에 내딛는 순간 창공을 가로지르는 한 무리의 브론즈 드래곤을 발견하고");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     눈 깜짝할 순간 브론즈 드래곤의 기습 공격에 기사단 연합은 혼돈의 상태에서 하나 둘 흩어져 버리게 되는데...");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그 순간, 기사단장 브라이언의 머리 위로 브론즈 드래곤의 발톱이 섬광처럼 나타나게 되고");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언은 눈앞이 깜깜해져버렸다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (story_step == 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     뜨거운 사막의 열기에 기절해있던 브라이언은 힘겹게 눈을 뜨게되는데");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     모래먼지로 가득한 눈을 힘겹게 뜨자 바로 앞에 인간의 형체가 아른거린다..");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     머리를 힘껏 흔들어 정신을 차려보니 데저트 고블린이 위에서 내려다보며 무기를 크게 휘두르려고 한다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 1;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                   {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                            <  데저트 고블린  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 없음  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (story_step == 3)
            {
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                screen_type = 3;
                paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                for (int i = 0; i < screen_max + 1; i++)
                {
                    Console.WriteLine("                          {0}", screen[i]);
                }

                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     쓰러진 고블린을 뒤로하고 저 멀리 모래바람 사이로 거대한 탑이 모습을 드러냈다.");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언은 무의식적으로 대사막 한가운데 거대한 탑으로 발걸음을 옮기기 시작했다.");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void BattleStory(ref int act, ref int act_step)       // 전투 관련 스토리
        {
            if (act == 1)
            {
                Console.WriteLine();
                Console.WriteLine("     모래바람으로 인해 시야에서 흐릿해진 거대 탑으로 계속해서 발걸음을 옮기던 중..");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     구석에 놓인 보물상자를 발견하고 호기심에 이끌려 보물상자 쪽으로 다가간다..");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("     하지만 기대감도 잠시, 곧 보물상자가 움직이며 브라이언을 죽일 기세로 다가온다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 4;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                                  <  미 믹  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 높은 방어력  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     다른 지역과 다르게 이상하게 짙은 모래 언덕을 걸어가다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     발 밑의 모래 언덕이 조금씩 흔들리는 진동이 느껴지기 시작한다..");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("     곧이어 모래 언덕에 구멍이 생기더니 샌드 웜이 튀어나와");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언을 향해 크게 입을 벌리고 잡아먹을 기세로 달려들 준비를 한다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 2;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                                 <  샌드 웜  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 흡혈 특성  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     평탄한 모래 사막 한가운데 작은 구역이 누군가가 무엇인가를 숨겨둔 것 처럼");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     볼록하게 올라와 있는 것을 발견했다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     신기한 광경이라 발로 모래를 툭툭 차보니 안에 마법 램프가 숨겨져 있었다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그 순간 갑자기 램프에서 이상하게 생긴 무엇인가가 나의 몸을 감싸기 시작했다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 7;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                             <  타락한 모래 정령  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 높은 회피율  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     여정을 떠나다보니 어느새 새까만 사막의 밤이 찾아왔다..");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     밤에 이동하는건 위험하다고 판단한 브라이언은 바위 틈에 몸을 뉘울곳을 찾게되고..");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     사막의 밤에서 짧은 잠을 청하려고 하는데...");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그때 순간 브라이언의 발 사이로 뭉클한 무엇인가가 지나가고있어 브라이언은 놀라 벌떡 일어났다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 5;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                              <  데저트 코브라  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 중독 특성  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 5)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     브라이언은 넓은 사막길을 횡단하던 중 저기 멀리서 나무 몇그루가 모여있는것을 발견하고");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     나무 열매를 먹기위해 급히 나무들이 있는곳으로 향한다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     가까이에서 보니 상당한 크기의 나무들이 있었고 그중 한 그루의 나무를 올라 나무열매를 먹으려는데");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     순간 나무가 움직이기 시작하고 브라이언은 땅으로 떨어지고 만다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 6;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                               <  모래 고목  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 높은 HP  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     브라이언은 사막 모험중에 처음으로 저기 멀리에서 사람들이 모여 춤을 추고 있는 모습을 발견했다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언은 사막 중앙의 거대한 탑에 대한 정보를 얻기 위해 서둘러 사람들이 모여있는 곳으로 달려갔다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     하지만 가까이 가보니 사람들은 무엇인가에 걸린듯이 경직된 자세로 각자 멈춰선 상태였다..");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그리고 순간 옆구리 쪽으로 무엇인가가 달려드는 기운을 느끼고 칼로 받아치는데!!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 3;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                               <  스콜피온  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 기절 특성  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 7)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     브라이언은 드디어 대사막의 탑이 조금 선명하고 더 거대하게 보이는 지점까지 걸어왔다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언은 조금의 불안함과 안도감을 안고 주위의 거대한 선인장이 있는 곳으로 가");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     더욱 뜨거워진 대사막의 태양을 피하려고 한다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     하지만 불길한 기운은 늘 빗나가지 않고 거대한 선인장은 몸을 움직여 브라이언을 공격하는데!!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 10;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                               <  거대 선인장  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 반격 특성  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 8)
            {
                Console.WriteLine();
                Console.WriteLine("     브라이언은 이제 대사막의 탑이 완벽히 거대해 보이는 지점까지 도달했다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     안도의 한숨과 약간의 불안을 안고 더 바쁘게 움직이려고 한다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그때 탑 근처에 조그만 사원 하나가 눈에 들어오고");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     대사막의 탑 근처의 사원은 무엇인가 특별하다는 생각이 들어 잠깐 탐험해보기로 한다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     사원 안에서 탐험을 계속하던 브라이언은 궁수 석상이 조금씩 움직이는 것을 보고");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     전투 태세를 준비한다!");
                Thread.Sleep(SLEEP);
                Console.WriteLine();

                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 9;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                                <  언데드 아처  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : 높은 치명타율  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (act == 9)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     브라이언은 우여곡절 끝에 대사막의 탑 입구에 도달하였다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     그때 창공에서 익숙한 울음소리가 들려오고 고개를 들어보니");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     대사막의 탑 입구 위에 브론즈 드래곤이 앉아 브라이언을 쳐다보고 있었다");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine("     브라이언은 이전의 처참히 기습당했던 기사단 연합의 복수를 위해 칼을 다시 힘껏 쥐는데...");
                Thread.Sleep(SLEEP);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Paint paint_ = new Paint();
                print_type = 8;
                paint_.MonsterPaint(ref print, ref print_max, ref print_type);

                for (int i = 0; i < print_max + 1; i++)
                {
                    Console.WriteLine("                    {0}", print[i]);
                }

                Console.WriteLine();
                Console.WriteLine("                           <  브론즈 드래곤  >");
                Console.WriteLine();
                Console.WriteLine("                         <  몬스터 특성 : ???  >");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    [  전 투 시 작  ]  <-----  [  Enter  ]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void StoryGather(ref int story_type, ref int screen_type, ref int user_select, ref int story_loop, ref int story_input_type,
            ref int user_hp, ref int user_max_hp, ref int thirsty, ref int thirsty_max, ref int user_vamp, ref int user_para,
            ref int user_pois, ref int user_cout, ref int user_atk, ref int user_dfd, ref bool storying, ref bool add_ability,
            ref int user_crt, ref int user_eva, ref int[] user_skill_count)
                           // 비전투 관련 스토리
        {
            Random random = new Random();

            int rand = 0;
            string item_name = "\0";
            string[] item_stat_name = new string[5];
            int[] item_stat_int = new int[5];
            int item_stat_count = 0;
            bool item_another = false;

            if (story_type == 1)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 4;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     탑을 향해 발걸음을 옮기던 중 앙상한 나무의 나뭇가지 사이로");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     반짝이는 무엇인가가 보였다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  나무를 올라 확인한다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  그냥 무시하고 간다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 5;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     사막의 날씨때문에 뜨거워진 나무를 올라 나뭇가지를 확인하자");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     맛있게 익은 빨간 나무 열매가 보였다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     빨간 나무 열매를 맛있게 베어물자 맛있는 과즙이 입안을 가득 채웠다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 100 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (add_ability == false)
                    {
                        if (user_hp + 100 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 100;
                        }

                        add_ability = true;
                    }

                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     힘을 아껴 더 빠르게 탑을 향해 걸어가다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     길 구석에 누군가가 우물에서 떠놓은 물통 하나를 발견했다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 6;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  목마름 50 감소  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (add_ability == false)
                    {
                        if (thirsty - 50 < 0)
                        {
                            thirsty = 0;
                        }
                        else
                        {
                            thirsty -= 50;
                        }

                        add_ability = true;
                    }

                    story_input_type = 3;
                }
            }
            else if (story_type == 2)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 7;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     탑을 향해 걸어가다 건조해진 바위틈 사이로 무엇인가 담겨있는 상자를 발견했다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     호기심에 가까이 다가가보니 조금 단단히 잠겨있는 상자가 보인다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  상자를 억지로 열어본다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  상자를 힘을 써서 부순다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 8;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     상자를 오랜시간이 걸려 억지로 열고보니 상자안에 온전한 상태의");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     능력 포션이 들어있었다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     능력 포션을 마시니 능력이 향상되는 기분이 든다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    rand = random.Next(0, 3);
                    if (rand == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  흡혈 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_vamp < 8)
                            {
                                user_vamp += 1;
                            }
                            else
                            {
                                user_vamp = 8;
                            }

                            thirsty += 5;

                            add_ability = true;
                        }
                    }
                    else if (rand == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  기절 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_para < 8)
                            {
                                user_para += 1;
                            }
                            else
                            {
                                user_para = 8;
                            }

                            thirsty += 5;

                            add_ability = true;
                        }
                    }
                    else if (rand == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  중독 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_pois < 8)
                            {
                                user_pois += 1;
                            }
                            else
                            {
                                user_pois = 8;
                            }

                            thirsty += 5;

                            add_ability = true;
                        }
                    }
                    else if (rand == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  반격 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_cout < 8)
                            {
                                user_cout += 1;
                            }
                            else
                            {
                                user_cout = 8;
                            }

                            thirsty += 5;

                            add_ability = true;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                    [  목마름 + 5  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 8;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     단기간에 무기를 사용해 상자를 부수니 충격으로 인해 약간 금이 간");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     능력 포션이 들어있었다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     능력 포션을 마시니 조금 부족하지만 능력이 향상되는 기분이 든다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    rand = random.Next(0, 1);
                    if (rand == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  공격력 + 10  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            user_atk += 10;

                            if (user_hp - 10 < 0)
                            {
                                user_hp = 0;
                            }
                            else
                            {
                                user_hp -= 10;
                            }

                            add_ability = true;
                        }
                    }
                    else if (rand == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  방어력 + 5  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            user_dfd += 5;

                            if (user_hp - 10 < 0)
                            {
                                user_hp = 0;
                            }
                            else
                            {
                                user_hp -= 10;
                            }

                            add_ability = true;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                    [  HP - 10  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 3)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 9;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     모래 바람 사이로 누군가 머물렀던 천막이 시야에 들어왔다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     호기심에 천막 근처로 발걸음을 옮겼다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
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
                    Console.WriteLine("                    [  천막 안으로 들어가본다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  천막 바깥을 살펴본다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 9;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     천막 안으로 들어가 살펴보자 누군가 두고간 아이템 하나가");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     눈에 들어왔다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (add_ability == false)
                    {
                        Looting looting_ = new Looting();
                        looting_.StoryLooting01(ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count, 
                            ref item_another, ref user_atk, ref user_dfd, ref user_hp, ref user_max_hp, ref thirsty, ref thirsty_max,
                            ref user_crt, ref user_eva, ref user_vamp, ref user_pois, ref user_para, ref user_cout, ref user_skill_count);

                        add_ability = true;
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 8;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                       {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     천막 바깥을 살펴보니 모래 속에 반쯤 묻혀있던");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     회복 포션이 눈에 들어왔다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     회복 포션을 마시니 회복의 기운이 온몸을 감싼다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 150 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        if (user_hp + 150 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 150;
                        }

                        add_ability = true;
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 4)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 10;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     탑을 향해 걸어가는 도중 심상치 않은 모래 폭풍의 기운이 느껴진다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     바람의 강도를 느껴보니 모래 폭풍은 점점 더 가까워 지고 있는것 같다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  모래 폭풍을 견디며 나아간다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  몸을 숨길 곳을 찾아본다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 10;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     모래 폭풍을 견디며 묵묵히 걸어나가자 곧이어 모래 폭풍이 멈추기 시작했다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     브라이언은 입 속에 모래알들을 뱉어가며 다시 탑으로 걸어간다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  방어력 + 5  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                    [  HP - 10  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        user_dfd += 5;

                        if (user_hp - 10 < 0)
                        {
                            user_hp = 0;
                        }
                        else
                        {
                            user_hp -= 10;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 10;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     모래 폭풍이 더 심해지기 전에 주위를 둘러보니 숨을 수 있는 작은 모래 구덩이를");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     발견했다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     브라이언은 서둘러 모래 구덩이 속에 숨어 모래 폭풍이 잠잠해 질때까지");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     기다렸다가 다시 걸어가기로 한다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 5)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 11;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                    {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     탑을 향해 걸음을 재촉하던 중 저 멀리 모래 언덕위에 쓰러져있는");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     같은 기사단 연합 성직자 원정대원을 발견했다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     서둘러 다가가자 성직자 원정대원은 자신의 생명이 얼마 안남았음을");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어필하며 마지막 최후의 축복 버프를 주려고 한다...");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     기사단 연합의 성직자 원정대원은 어떤 최후의 축복을 주려고 하는것일까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     성직자 원정대원의 최후의 축복은 무엇입니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  각성의 권능  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  축복의 권능  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 11;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                    {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     성직자 원정대원은 마지막 힘을 모아");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     브라이언에게 각성의 권능 축복 버프를 내려주었다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 150 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  목마름 100 감소  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        if (user_hp + 150 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 150;
                        }

                        if (thirsty - 100 < 0)
                        {
                            thirsty = 0;
                        }
                        else
                        {
                            thirsty -= 100;
                        }

                        add_ability = true;
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 11;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                    {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     성직자 원정대원은 마지막 힘을 모아");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     브라이언에게 축복의 권능 축복 버프를 내려주었다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    rand = random.Next(0, 2);
                    if (rand == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  공격력 + 10  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            user_atk += 10;

                            add_ability = true;
                        }
                    }
                    else if (rand == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  방어력 + 5  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            user_dfd += 5;

                            add_ability = true;
                        }
                    }
                    else if (rand == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  최대 HP + 50  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            user_max_hp += 50;

                            add_ability = true;
                        }
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 6)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 13;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     모래위를 한참을 걷다보니 모래 절벽길이 두갈래 길로 나뉘고있다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     한 쪽 길은 희미하게 붉은색 빛이 흘러나오고 있고,");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     다른 한 쪽 길은 희미하게 푸른색 빛이 흘러나오고 있다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어느 길 로 가시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  희미하게 붉은색 빛이 흘러나오는 길  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  희미하게 푸른색 빛이 흘러나오는 길  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 13;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     희미하게 붉은색 빛이 흘러나오는 길로 들어서니 바닥에 붉은빛 오오라가");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     피어나오고 있었다. 몸이 편안해지며 HP 가 회복되는 기분이다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 100 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        if (user_hp + 100 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 100;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 13;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     희미하게 푸른색 빛이 흘러나오는 길로 들어서니 바닥에 푸른빛 오오라가");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     피어나오고 있었다. 몸이 상쾌해지며 갈증이 사라지는 기분이다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  목마름 50 감소  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        if (thirsty - 50 < 0)
                        {
                            thirsty = 0;
                        }
                        else
                        {
                            thirsty -= 50;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 7)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 14;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     모래길을 걷다가 한쪽 구석에 작은 동굴을 발견하고");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     동굴을 탐험하러 들어가보니, 작은 제단이 놓여져있다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     제단에는 (피를 바쳐라) 라는 작은 글귀만 적혀있다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  피를 조금만 바친다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  피를 한 컵 만큼 많이 바친다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  제단에 놓여진 피를 마신다  ]  <-----  [  3  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 14;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     피를 조금만 바치자 작은 붉은 오오라들이 제단에서 부터");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     나와 브라이언의 온 몸을 휘감았다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  스킬 사용 횟수 증가 15  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                    [  HP - 10  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        user_skill_count[1] += 15;

                        if (user_hp - 10 < 0)
                        {
                            user_hp = 0;
                        }
                        else
                        {
                            user_hp -= 10;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 14;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     피를 한컵 만큼 많이 바치자 붉은 오오라들이 제단을 휘감으며");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     돌다가 순간 브라이언에게 돌진하여 흡수되었다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     한번도 느껴보지 못한 느낌이기에 당황스러웠지만, 이내 온몸에 힘이 솟구치는걸 느낀다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  스킬 사용 횟수 증가 20  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  최대 HP 150 증가  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                    [  HP - 30  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        user_skill_count[1] += 20;
                        user_max_hp += 150;

                        if (user_hp - 30 < 0)
                        {
                            user_hp = 0;
                        }
                        else
                        {
                            user_hp -= 30;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 14;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     제단에 놓여져 있는 피를 마시자 이상하게 역겨운 기분은 들지않고");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     맛있는 음료수를 마시는 기분이 들었다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 100 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  목마름 50 감소  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();

                    if (add_ability == false)
                    {
                        if (user_hp + 100 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 100;
                        }

                        if (thirsty - 50 < 0)
                        {
                            thirsty = 0;
                        }
                        else
                        {
                            thirsty -= 50;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 8)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 15;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     죽어있는 몬스터 옆에 어떤 책이 놓여져있다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     몬스터가 옆에서 죽어있으니 조금 찝찝한 기분이 든다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     책의 모양은 상당히 낡아 곧 흙속으로 사라질 것 같다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  찝찝하니 그냥 지나간다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  낡은 책을 주워 살펴본다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 15;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     역시 길 바닥에 있는 물건은 함부러 건드는게 아니다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어서 서둘러 대사막 탑으로 가자!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 15;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     호기심에 못이겨 죽어있는 몬스터 옆으로 조심스럽게 다가가");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     낡은 책을 주워 이리저리 살펴본다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     그러자 갑자기 낡은 책이 빛나더니 이상한 힘을 나눠주고");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     불에 타 사라져버린다!");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  스킬 사용 횟수 증가 15  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        user_skill_count[1] += 15;

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 9)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 16;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     전방에 사막의 뜨거운 열기에 못이겨 사막 전갈들이 단체로");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     익어서 죽어있다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  이건 사막의 랍스타다! 잘먹겠습니다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  모른척 지나간다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 16;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     대 사막의 태양열에 전갈이 재대로 익었다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     먹어보니 그럭저럭 먹을만하다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     포만감 까지 느껴질 정도이다..");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  HP 100 회복  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        if (user_hp + 100 > user_max_hp)
                        {
                            user_hp = user_max_hp;
                        }
                        else
                        {
                            user_hp += 100;
                        }

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 16;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     역시 아무리 사막이고 배가 고파도 사람이길 포기해선 안된다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     라고 생각하며 브라이언은 대 사막 탑으로 발걸음을 옮긴다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                    [  방어력 + 3  ]");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (add_ability == false)
                    {
                        user_dfd += 3;

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
            else if (story_type == 10)
            {
                if (story_loop == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 17;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     대 사막 한가운데 낙타 마차가 부서진 채로 폭삭 내려앉아 있다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     브라이언은 신기루가 아니길 바라면서 서둘러 마차 쪽으로 이동했다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     가까이 다가가보니 다행히도 신기루는 아니었다.");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  마차 안을 살펴 본다  ]  <-----  [  1  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  마차 바깥을 조사 해본다  ]  <-----  [  2  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 2;
                }
                else if (story_loop == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 17;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     부서진 마차 안을 살펴보니 누군가가 잘 감춰둔 보따리 하나를 발견했다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     보따리를 열어 확인해보니 전투 학습과 관련되어 있는 책이 하나 있었다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     책을 조금 훓어보니 전투 지식이 늘어나는 것만 같다!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    rand = random.Next(0, 3);
                    if (rand == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  흡혈 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_vamp < 8)
                            {
                                user_vamp += 1;
                            }
                            else
                            {
                                user_vamp = 8;
                            }

                            add_ability = true;
                        }
                    }
                    else if (rand == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  기절 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_para < 8)
                            {
                                user_para += 1;
                            }
                            else
                            {
                                user_para = 8;
                            }

                            add_ability = true;
                        }
                    }
                    else if (rand == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  중독 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_pois < 8)
                            {
                                user_pois += 1;
                            }
                            else
                            {
                                user_pois = 8;
                            }

                            add_ability = true;
                        }
                    }
                    else if (rand == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                    [  반격 능력 + 1  ]");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (add_ability == false)
                        {
                            if (user_cout < 8)
                            {
                                user_cout += 1;
                            }
                            else
                            {
                                user_cout = 8;
                            }

                            add_ability = true;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
                else if (story_loop == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    screen_type = 17;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                      {0}", screen[i]);
                    }

                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     부서진 마차 바깥을 살펴보니 마차 밑부분에 무엇인가가 깔려 있는게 보였다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     마차를 들어올려 확인해 보니 어떤 상자 하나가 있었다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();
                    Console.WriteLine("     마치 귀한 보물을 숨겨두려는 듯이 빛이 나는 장식들로 이루어진 상자였다");
                    Thread.Sleep(SLEEP);
                    Console.WriteLine();

                    if (add_ability == false)
                    {
                        Looting looting_ = new Looting();
                        looting_.StoryLooting01(ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                            ref item_another, ref user_atk, ref user_dfd, ref user_hp, ref user_max_hp, ref thirsty, ref thirsty_max,
                            ref user_crt, ref user_eva, ref user_vamp, ref user_pois, ref user_para, ref user_cout, ref user_skill_count);

                        add_ability = true;
                    }

                    Console.WriteLine();
                    Console.WriteLine("                    [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    story_input_type = 3;
                }
            }
        }
    }
}
