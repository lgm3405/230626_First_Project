using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole;

namespace Week_Project
{
    public class MainSystem
    {
        public void MainScreen(int character, string[] player_form)
        {
            Random random = new Random();

            bool add_ability = false;
            int act = 0;
            int act_max = 10;
            int act_step = 1;
            int story_step = 0;
            int story_type = 0;
            int screen_type = 0;
            string[] screen = new string[100];
            int screen_max = 0;
            bool story_battle = true;       // 스토리 or 전투 구분 (스토리 = true, 전투 = false)
            int before_story = 0;
            int user_select = 0;
            int story_loop = 0;
            int story_input_type = 0;
            bool storying = false;
            int rand = 0;

            int thirsty = 0;             // 목마름
            int thirsty_max = 100;       // 최대 목마름

            int user_hp = 150;           // HP
            int user_max_hp = 150;       // 최대 HP
            int user_atk = 12;            // 공격력
            int user_dfd = 1;            // 방어력
            int user_crt = 10;            // 치명타율
            float user_crt_mult = 1.5F;   // 치명타 배율
            int user_eva = 10;            // 회피율

            int user_vamp = 5;           // 흡혈
            int user_para = 5;           // 기절
            int user_pois = 5;           // 중독
            int user_cout = 5;           // 반격

            int[] user_skill_count = new int[10];
            int[] user_skill_type = new int[10];
            user_skill_count[1] = 30;

            story_step = 0;

            if (character == 1)
            {
                user_dfd = 2;
            }
            else if (character == 2)
            {
                user_atk = 14;
            }
            else if (character == 3)
            {
                user_hp = 160;
                user_max_hp = 160;
            }

            while (true)
            {
                if (act >= 10)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
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

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                           {0}", player_form[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              모 험 승 리 ! ! !");
                    Console.WriteLine();
                    Console.WriteLine("                              다음 v 2.0 업데이트 (Chapter 추가)를 기대해주세요!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              CopyRight : Lee Gyeong Min");
                    Console.WriteLine();
                    Console.WriteLine("                              Producer Email : lgm3405@naver.com");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              [ ( X ) 나가기 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.X)
                    {
                        break;
                    }
                }
                else if (user_hp <= 0 || thirsty >= 100)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
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

                    Paint paint_ = new Paint();
                    screen_type = 12;
                    paint_.ScreenPaint(ref screen_type, ref screen, ref screen_max);

                    for (int i = 0; i < screen_max + 1; i++)
                    {
                        Console.WriteLine("                                     {0}", screen[i]);
                    }

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

                    if (user_hp <= 0)
                    {
                        Console.WriteLine("                              Y O U  D I E . . .   ( Reason : HP )  ( Best : {0} Act )", act);
                    }
                    else if (thirsty >= 100)
                    {
                        Console.WriteLine("                              Y O U  D I E . . .   ( Reason : Thirsty )  ( Best : {0} Act )", act);
                    }
                    
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
                    Console.WriteLine("                              [ ( A ) 다시 도전 하기 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              [ ( X ) 나가기 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.A)
                    {
                        Program program_ = new Program();
                        program_.Replay();
                    }
                    else if (something.Key == ConsoleKey.X)
                    {
                        break;
                    }
                }
                else if (story_step == 0)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.Write("          [ 기사 단장 브라이언 ]                             [  H P  :  ");
                    if (user_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", user_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", user_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", user_max_hp);
                    Console.WriteLine();
                    Console.Write("          [  A c t  :  {0}  /  {1}  ]                          [  목 마 름  :  ", act, act_max);
                    if (thirsty >= 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", thirsty);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", thirsty);
                    }
                    Console.WriteLine("  /  {0}  ]", thirsty_max);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Story story_ = new Story();
                    story_.String001(ref story_step, ref screen_type);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("                         [  캐 릭 터 정 보  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               [  E  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.Spacebar)
                    {
                        story_step = 1;
                    }
                    else if (something.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                }
                else if (story_step == 1)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.Write("          [ 기사 단장 브라이언 ]                             [  H P  :  ");
                    if (user_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", user_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", user_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", user_max_hp);
                    Console.WriteLine();
                    Console.Write("          [  A c t  :  {0}  /  {1}  ]                          [  목 마 름  :  ", act, act_max);
                    if (thirsty >= 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", thirsty);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", thirsty);
                    }
                    Console.WriteLine("  /  {0}  ]", thirsty_max);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Story story_ = new Story();
                    story_.String001(ref story_step, ref screen_type);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("                         [  캐 릭 터 정 보  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               [  E  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.Spacebar)
                    {
                        story_step = 2;
                    }
                    else if (something.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                }
                else if (story_step == 2)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.Write("          [ 기사 단장 브라이언 ]                             [  H P  :  ");
                    if (user_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", user_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", user_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", user_max_hp);
                    Console.WriteLine();
                    Console.Write("          [  A c t  :  {0}  /  {1}  ]                          [  목 마 름  :  ", act, act_max);
                    if (thirsty >= 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", thirsty);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", thirsty);
                    }
                    Console.WriteLine("  /  {0}  ]", thirsty_max);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Story story_ = new Story();
                    story_.String001(ref story_step, ref screen_type);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("                         [  캐 릭 터 정 보  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               [  E  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.Enter)
                    {
                        story_step = 3;
                        Battle battle_ = new Battle();
                        battle_.BattleMonster(ref act, ref act_step, ref user_hp, ref user_max_hp, ref user_atk, ref user_dfd,
                            ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout, ref thirsty,
                            ref thirsty_max, ref character, ref user_skill_count, ref user_crt_mult, ref user_skill_type, ref story_battle,
                            ref act_max);
                    }
                    else if (something.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                }
                else if (story_step == 3)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.Write("          [ 기사 단장 브라이언 ]                             [  H P  :  ");
                    if (user_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", user_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", user_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", user_max_hp);
                    Console.WriteLine();
                    Console.Write("          [  A c t  :  {0}  /  {1}  ]                          [  목 마 름  :  ", act, act_max);
                    if (thirsty >= 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", thirsty);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", thirsty);
                    }
                    Console.WriteLine("  /  {0}  ]", thirsty_max);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Story story_ = new Story();
                    story_.String001(ref story_step, ref screen_type);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("                         [  캐 릭 터 정 보  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               [  E  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.Spacebar)
                    {
                        story_step = 4;
                    }
                    else if (something.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }

                }
                else if (story_step == 4)
                {
                    Story story_ = new Story();

                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.Write("          [ 기사 단장 브라이언 ]                             [  H P  :  ");
                    if (user_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", user_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", user_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", user_max_hp);
                    Console.WriteLine();
                    Console.Write("          [  A c t  :  {0}  /  {1}  ]                          [  목 마 름  :  ", act, act_max);
                    if (thirsty >= 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", thirsty);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", thirsty);
                    }
                    Console.WriteLine("  /  {0}  ]", thirsty_max);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (story_battle == false)
                    {
                        story_.BattleStory(ref act, ref act_step);
                    }
                    else
                    {
                        if (storying == false)
                        {
                            story_loop = 0;
                            rand = random.Next(1, 10);
                            while (true)
                            {
                                if (rand == before_story)
                                {
                                    rand = random.Next(1, 10);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            story_type = rand;
                            storying = true;
                            before_story = story_type;
                        }
                        story_.StoryGather(ref story_type, ref screen_type, ref user_select, ref story_loop, ref story_input_type,
                            ref user_hp, ref user_max_hp, ref thirsty, ref thirsty_max, ref user_vamp, ref user_para, ref user_pois,
                            ref user_cout, ref user_atk, ref user_dfd, ref storying, ref add_ability, ref user_crt, ref user_eva,
                            ref user_skill_count);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("                         [  캐 릭 터 정 보  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               [  E  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.Enter)
                    {
                        if (story_battle == false)
                        {
                            Battle battle_ = new Battle();
                            battle_.BattleMonster(ref act, ref act_step, ref user_hp, ref user_max_hp, ref user_atk, ref user_dfd,
                                ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout, ref thirsty,
                                ref thirsty_max, ref character, ref user_skill_count, ref user_crt_mult, ref user_skill_type,
                                ref story_battle, ref act_max);
                        }   
                    }
                    else if (something.Key == ConsoleKey.Spacebar)
                    {
                        if (story_battle == true && story_input_type == 3)
                        {
                            if (add_ability == true)
                            {
                                add_ability = false;
                            }
                            storying = false;
                            story_battle = false;
                        }
                    }
                    else if (something.Key == ConsoleKey.D1 || something.Key == ConsoleKey.NumPad1)
                    {
                        if (story_battle == true && story_input_type == 2)
                        {
                            story_loop = 1;
                        }
                    }
                    else if (something.Key == ConsoleKey.D2 || something.Key == ConsoleKey.NumPad2)
                    {
                        if (story_battle == true && story_input_type == 2)
                        {
                            story_loop = 2;
                        }
                    }
                    else if (something.Key == ConsoleKey.D3 || something.Key == ConsoleKey.NumPad3)
                    {
                        if (story_battle == true && story_input_type == 2 && story_type == 7)
                        {
                            story_loop = 3;
                        }
                    }
                    else if (something.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                    else if (something.Key == ConsoleKey.M)
                    {
                        user_hp = user_max_hp;
                    }
                    else if (something.Key == ConsoleKey.L)
                    {
                        thirsty = 0;
                    }
                }
            }
        }
    }
}
