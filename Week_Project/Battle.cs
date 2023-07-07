using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Battle
    {
        public void BattleMonster(ref int act, ref int act_step, ref int user_hp, ref int user_max_hp, ref int user_atk, 
            ref int user_dfd, ref int user_crt, ref int user_eva, ref int user_vamp, ref int user_para, ref int user_pois, 
            ref int user_cout, ref int thirsty, ref int thirsty_max, ref int character, ref int[] user_skill_count, 
            ref float user_crt_mult, ref int[] user_skill_type, ref bool story_battle, ref int act_max)
        {
            bool[] eva_check = new bool[2];           // 0 = 플레이어, 1 = 몬스터
            bool[] crt_check = new bool[2];           // 0 = 플레이어, 1 = 몬스터
            bool[] vamp_check = new bool[2];
            bool[] cout_check = new bool[2];
            bool[] pois_check = new bool[2];
            bool[] para_check = new bool[2];
            int monster_skill = 0;

            bool[] user_skill_check = new bool[10];
            bool[] mons_skill_check = new bool[10];
            int[] skill_save_int = new int[10];
            
            int[] mons_atk = new int[3];
            int[] mons_atk_conf = new int[5];
            string[] mons_word = new string[3];
            int mons_dfd = 0;
            int mons_hp = 0;
            int mons_max_hp = 0;
            int mons_crt = 0;
            float mons_crt_mult = 0;
            int mons_eva = 0;
            int mons_vamp = 0;
            int[] mons_vamp_int = new int[3];
            float mons_vamp_flt = 0;
            int mons_para = 0;
            int mons_pois = 0;
            int[] mons_pois_int = new int[3];
            float mons_pois_flt = 0;
            int mons_cout = 0;
            int[] mons_cout_int = new int[3];
            float mons_cout_flt = 0;

            int user_atk_min = 0;
            int user_atk_max = 0;
            int[] user_atk_conf = new int[5];

            int user_action = 0;
            int mons_action = 0;

            int user_vamp_per = 0;
            int[] user_vamp_int = new int[3];
            float user_vamp_flt = 0;
            int user_cout_per = 0;
            int[] user_cout_int = new int[3];
            float user_cout_flt = 0;
            int user_pois_per = 0;
            int[] user_pois_int = new int[3];
            float user_pois_flt = 0;
            int[] pois_count = new int[2];
            int user_para_per = 0;
            
            int turn = 1;
            int turn_check = 0;
            int[] rand = new int[30];

            int monster_type = 0;
            string[] print = new string[100];
            int print_max = 0;
            int print_type = 0;
            string[] player_form = new string[16];
            string[] battle_word = new string[10];

            Random random = new Random();

            Paint paint_ = new Paint();
            paint_.CharacterPaint(ref player_form);

            Monster monster_ = new Monster();

            Skill skill_ = new Skill();
            skill_.Ability(ref user_vamp, ref user_vamp_per, ref user_vamp_int, ref user_cout, ref user_cout_per, ref user_cout_int,
                ref user_pois, ref user_pois_per, ref user_pois_int, ref user_para, ref user_para_per);

            if (act == 0)              // 고블린
            {
                print_type = 1;
                monster_type = 1;
            }
            else if (act == 1)         // 미믹
            {
                print_type = 4;
                monster_type = 2;
            }
            else if (act == 2)         // 샌드 웜
            {
                print_type = 2;
                monster_type = 3;
            }
            else if (act == 3)         // 타락한 모래 정령
            {
                print_type = 7;
                monster_type = 4;
            }
            else if (act == 4)         // 데저트 코브라
            {
                print_type = 5;
                monster_type = 5;
            }
            else if (act == 5)         // 모래 고목
            {
                print_type = 6;
                monster_type = 6;
            }
            else if (act == 6)         // 스콜피온
            {
                print_type = 3;
                monster_type = 7;
            }
            else if (act == 7)         // 거대 선인장
            {
                print_type = 10;
                monster_type = 8;
            }
            else if (act == 8)         // 언데드 아처
            {
                print_type = 9;
                monster_type = 9;
            }
            else if (act == 9)         // 브론즈 드래곤
            {
                print_type = 8;
                monster_type = 10;
            }

            paint_.MonsterPaint(ref print, ref print_max, ref print_type);

            monster_.Monster_Info(ref mons_word, ref mons_atk, ref mons_dfd, ref mons_hp, ref mons_max_hp, ref mons_crt,
                    ref mons_crt_mult, ref mons_eva, ref mons_vamp, ref mons_para, ref mons_pois, ref mons_cout, ref monster_type,
                    ref monster_skill, ref mons_vamp_int, ref mons_pois_int, ref mons_cout_int);

            user_atk_min = user_atk - 5;
            user_atk_max = user_atk + 5;

            while (true)
            {
                if (turn_check == 0)
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                    Console.WriteLine();

                    for (int i = 0; i < print_max + 1; i++)
                    {
                        Console.WriteLine("          {0}", print[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                     [  H  P  :  ");
                    if (mons_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", mons_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", mons_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                    Console.WriteLine();
                    Console.Write("          ");
                    if (pois_count[1] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  [ 중독 : {0} ]", pois_count[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[1] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("                                                  ");
                    if (pois_count[0] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[0] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                                  {0}", player_form[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                                              [  H  P  :  ");
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
                    Console.WriteLine();
                    Console.Write("                    [ ( 1 ) 공 격 ]");
                    if (character == 1)
                    {
                        Console.Write("          [ ( 2 ) 철 갑 ]");
                    }
                    else if (character == 2)
                    {
                        Console.Write("          [ ( 2 ) 연 격 ]");
                    }
                    else if (character == 3)
                    {
                        Console.Write("          [ ( 2 ) 활 력 ]");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                  [ 사용 가능 : ∞ ]");
                    Console.Write("       [ 사용 가능 : {0} ]", user_skill_count[1]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(250);
                    turn_check = 1;
                }
                else if (turn_check == 1)
                {
                    if (para_check[0] == true)
                    {
                        turn_check = 9;

                        continue;
                    }

                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                    Console.WriteLine();

                    for (int i = 0; i < print_max + 1; i++)
                    {
                        Console.WriteLine("          {0}", print[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                     [  H  P  :  ");
                    if (mons_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", mons_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", mons_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                    Console.WriteLine();
                    Console.Write("          ");
                    if (pois_count[1] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[1] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("   [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    rand[0] = random.Next(0, 2);
                    Console.WriteLine("     {0}", mons_word[rand[0]]);
                    Thread.Sleep(500);

                    Console.WriteLine();
                    Console.WriteLine("     어떻게 하시겠습니까?");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("                                                  ");
                    if (pois_count[0] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[0] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                                  {0}", player_form[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                                              [  H  P  :  ");
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
                    Console.WriteLine();
                    Console.Write("                    [ ( 1 ) 공 격 ]");
                    if (character == 1)
                    {
                        Console.Write("          [ ( 2 ) 철 갑 ]");
                    }
                    else if (character == 2)
                    {
                        Console.Write("          [ ( 2 ) 연 격 ]");
                    }
                    else if (character == 3)
                    {
                        Console.Write("          [ ( 2 ) 활 력 ]");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                  [ 사용 가능 : ∞ ]");
                    Console.Write("       [ 사용 가능 : {0} ]", user_skill_count[1]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

                    mons_action = 1;

                    ConsoleKeyInfo something = Console.ReadKey();

                    if (something.Key == ConsoleKey.D1 || something.Key == ConsoleKey.NumPad1)
                    {
                        user_action = 1;
                        turn_check = 2;
                    }
                    else if (something.Key == ConsoleKey.D2 || something.Key == ConsoleKey.NumPad2)
                    {
                        if (user_skill_count[1] > 0)
                        {
                            user_action = 2;
                            turn_check = 2;
                        }
                    }
                    else if (something.Key == ConsoleKey.M)
                    {
                        user_hp = user_max_hp;
                    }
                }
                else if (turn_check == 2)          // 플레이어 공격 계산
                {
                    if (user_action == 1)
                    {
                        rand[1] = random.Next(0, 100);
                        if (rand[1] <= mons_eva)
                        {
                            eva_check[1] = true;
                        }
                        else
                        {
                            eva_check[1] = false;
                            rand[2] = random.Next(0, 100);

                            if (rand[2] <= user_crt)
                            {
                                crt_check[0] = true;
                            }
                            else
                            {
                                crt_check[0] = false;
                            }

                            rand[3] = random.Next(0, 10);
                            user_atk_conf[0] = user_atk_min + rand[3];
                            user_atk_conf[1] = user_atk_conf[0] - mons_dfd;

                            if (crt_check[0] == true)
                            {
                                user_atk_conf[2] = (int)(user_atk_conf[1] * user_crt_mult);
                                if (user_atk_conf[2] <= 0)
                                {
                                    user_atk_conf[2] = 1;
                                }
                            }
                            else
                            {
                                if (user_atk_conf[1] <= 0)
                                {
                                    user_atk_conf[1] = 1;
                                }
                            }

                            if (user_vamp > 0)
                            {
                                rand[6] = random.Next(0, 100);
                                if (rand[6] <= user_vamp_per)
                                {
                                    vamp_check[0] = true;
                                    if (crt_check[0] == true)
                                    {
                                        user_vamp_flt = user_atk_conf[2] / 100F;
                                        user_vamp_int[1] = (int)(user_vamp_flt * user_vamp_int[0]);
                                    }
                                    else
                                    {
                                        user_vamp_flt = user_atk_conf[1] / 100F;
                                        user_vamp_int[1] = (int)(user_vamp_flt * user_vamp_int[0]);
                                    }
                                }
                            }

                            if (user_pois > 0)
                            {
                                rand[8] = random.Next(0, 100);
                                if (rand[8] <= user_pois_per)
                                {
                                    pois_check[1] = true;
                                    user_pois_flt = mons_max_hp / 100F;
                                    user_pois_int[1] = (int)(user_pois_flt * user_pois_int[0]);
                                    pois_count[1] += 2;
                                }
                            }

                            if (mons_cout > 0)
                            {
                                rand[13] = random.Next(0, 100);
                                if (rand[13] <= mons_cout)
                                {
                                    cout_check[1] = true;
                                    if (crt_check[0] == true)
                                    {
                                        mons_cout_flt = user_atk_conf[2] / 100F;
                                        mons_cout_int[1] = (int)(mons_cout_flt * mons_cout_int[0]);
                                    }
                                    else
                                    {
                                        mons_cout_flt = user_atk_conf[1] / 100F;
                                        mons_cout_int[1] = (int)(mons_cout_flt * mons_cout_int[0]);
                                    }

                                    if (mons_cout_int[1] == 0)
                                    {
                                        mons_cout_int[1] = 1;
                                    }
                                }
                            }

                            if (user_para > 0)
                            {
                                rand[9] = random.Next(0, 100);
                                if (rand[9] <= user_para_per)
                                {
                                    para_check[1] = true;
                                }
                            }
                        }
                    }
                    else if (user_action == 2)
                    {
                        if (character == 1)
                        {
                            user_skill_check[1] = true;
                            skill_save_int[1] = user_dfd;
                            user_dfd += user_dfd;
                        }
                        else if (character == 2)
                        {
                            user_skill_check[2] = true;

                            rand[1] = random.Next(0, 100);
                            if (rand[1] <= mons_eva)
                            {
                                eva_check[1] = true;
                            }
                            else
                            {
                                eva_check[1] = false;
                                rand[2] = random.Next(0, 100);

                                if (rand[2] <= user_crt)
                                {
                                    crt_check[0] = true;
                                }
                                else
                                {
                                    crt_check[0] = false;
                                }

                                rand[3] = random.Next(0, 10);
                                user_atk_conf[0] = user_atk_min + rand[3];
                                user_atk_conf[1] = user_atk_conf[0] - mons_dfd;

                                if (crt_check[0] == true)
                                {
                                    user_atk_conf[2] = (int)(user_atk_conf[1] * user_crt_mult);
                                    if (user_atk_conf[2] <= 0)
                                    {
                                        user_atk_conf[2] = 1;
                                    }
                                }
                                else
                                {
                                    if (user_atk_conf[1] <= 0)
                                    {
                                        user_atk_conf[1] = 1;
                                    }
                                }

                                if (user_vamp > 0)
                                {
                                    rand[6] = random.Next(0, 100);
                                    if (rand[6] <= user_vamp_per)
                                    {
                                        vamp_check[0] = true;
                                        if (crt_check[0] == true)
                                        {
                                            user_vamp_flt = user_atk_conf[2] / 100F;
                                            user_vamp_int[1] = (int)(user_vamp_flt * user_vamp_int[0]);
                                        }
                                        else
                                        {
                                            user_vamp_flt = user_atk_conf[1] / 100F;
                                            user_vamp_int[1] = (int)(user_vamp_flt * user_vamp_int[0]);
                                        }
                                    }
                                }

                                if (user_pois > 0)
                                {
                                    rand[8] = random.Next(0, 100);
                                    if (rand[8] <= user_pois_per)
                                    {
                                        pois_check[1] = true;
                                        user_pois_flt = mons_max_hp / 100F;
                                        user_pois_int[1] = (int)(user_pois_flt * user_pois_int[0]);
                                        pois_count[1] += 2;
                                    }
                                }

                                if (mons_cout > 0)
                                {
                                    rand[13] = random.Next(0, 100);
                                    if (rand[13] <= mons_cout)
                                    {
                                        cout_check[1] = true;
                                        if (crt_check[0] == true)
                                        {
                                            mons_cout_flt = user_atk_conf[2] / 100F;
                                            mons_cout_int[1] = (int)(mons_cout_flt * mons_cout_int[0]);
                                        }
                                        else
                                        {
                                            mons_cout_flt = user_atk_conf[1] / 100F;
                                            mons_cout_int[1] = (int)(mons_cout_flt * mons_cout_int[0]);
                                        }

                                        if (mons_cout_int[1] == 0)
                                        {
                                            mons_cout_int[1] = 1;
                                        }
                                    }
                                }

                                if (user_para > 0)
                                {
                                    rand[9] = random.Next(0, 100);
                                    if (rand[9] <= user_para_per)
                                    {
                                        para_check[1] = true;
                                    }
                                }
                            }
                        }
                        else if (character == 3)
                        {
                            user_skill_check[3] = true;
                            skill_save_int[2] = user_max_hp / 10;
                        }
                    }

                    turn_check = 3;
                }
                else if (turn_check == 3)           // 플레이어 공격
                {
                    if (user_action == 1)           // 유저가 일반 공격 사용시
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (j == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine();
                                Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                Console.WriteLine();
                                if (eva_check[1] == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }
                                }

                                Console.WriteLine();
                                Console.Write("                     [  H  P  :  ");
                                if (mons_hp <= 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("{0}", mons_hp);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("{0}", mons_hp);
                                }
                                Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                Console.WriteLine();
                                Console.Write("          ");
                                if (pois_count[1] > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                if (para_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("   [ 기절 상태 ]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine();
                                if (eva_check[1] == true)
                                {
                                    battle_word[0] = "공격이 빗나가 허공을 가르고 말았습니다!";
                                    Console.WriteLine("     {0}", battle_word[0]);
                                }
                                else if (crt_check[0] == true)
                                {
                                    battle_word[0] = "적에게 치명타 일격을 가했습니다! ( ";
                                    Console.Write("     {0}", battle_word[0]);
                                    Console.Write("{0} 데미지 )", user_atk_conf[2]);
                                }
                                else
                                {
                                    battle_word[0] = "적을 공격하였습니다! ( ";
                                    Console.Write("     {0}", battle_word[0]);
                                    Console.Write("{0} 데미지 )", user_atk_conf[1]);
                                }
                                if (cout_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (vamp_check[0] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (pois_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (para_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.Write("                                                  ");
                                if (pois_count[0] > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                if (para_check[0] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("  [ 기절 상태 ]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                for (int i = 0; i < 16; i++)
                                {
                                    Console.WriteLine("                              {0}", player_form[i]);
                                }

                                Console.WriteLine();
                                Console.Write("                          [  H  P  :  ");
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
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Thread.Sleep(250);

                                if (eva_check[1] == false)
                                {
                                    if (crt_check[0] == true)
                                    {
                                        if (mons_hp - user_atk_conf[2] <= 0)
                                        {
                                            mons_hp = 0;
                                        }
                                        else
                                        {
                                            mons_hp -= user_atk_conf[2];
                                        }
                                    }
                                    else
                                    {
                                        if (mons_hp - user_atk_conf[1] <= 0)
                                        {
                                            mons_hp = 0;
                                        }
                                        else
                                        {
                                            mons_hp -= user_atk_conf[1];
                                        }
                                    }
                                }

                                if (vamp_check[0] == true)
                                {
                                    user_vamp_int[2] = user_hp + user_vamp_int[1];
                                    if (user_vamp_int[2] >= user_max_hp)
                                    {
                                        user_hp = user_max_hp;
                                    }
                                    else
                                    {
                                        user_hp += user_vamp_int[1];
                                    }
                                }

                                if (cout_check[1] == true)
                                {
                                    if (user_hp - mons_cout_int[1] <= 0)
                                    {
                                        user_hp = 0;
                                    }
                                    else
                                    {
                                        user_hp -= mons_cout_int[1];
                                    }
                                }
                            }
                            else if (j == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine();
                                Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                Console.WriteLine();

                                for (int i = 0; i < print_max + 1; i++)
                                {
                                    Console.WriteLine("          {0}", print[i]);
                                }

                                Console.WriteLine();
                                Console.Write("                     [  H  P  :  ");
                                if (mons_hp <= 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("{0}", mons_hp);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("{0}", mons_hp);
                                }
                                Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                Console.WriteLine();
                                Console.Write("          ");
                                if (pois_count[1] > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                if (para_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("   [ 기절 상태 ]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine();
                                if (eva_check[1] == true)
                                {
                                    Console.WriteLine("     {0}", battle_word[0]);
                                }
                                else if (crt_check[0] == true)
                                {
                                    Console.Write("     {0}", battle_word[0]);
                                    Console.Write("{0} 데미지 )", user_atk_conf[2]);
                                }
                                else
                                {
                                    Console.Write("     {0}", battle_word[0]);
                                    Console.Write("{0} 데미지 )", user_atk_conf[1]);
                                }
                                if (cout_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (vamp_check[0] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (pois_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (para_check[1] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.Write("                                                  ");
                                if (pois_count[0] > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                if (para_check[0] == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("  [ 기절 상태 ]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.WriteLine();

                                for (int i = 0; i < 16; i++)
                                {
                                    Console.WriteLine("                                                  {0}", player_form[i]);
                                }

                                Console.WriteLine();
                                Console.Write("                                              [  H  P  :  ");
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
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Thread.Sleep(500);

                                if (mons_hp == 0)
                                {
                                    turn_check = 10;
                                    continue;
                                }
                                else if (user_hp == 0)
                                {
                                    turn_check = 11;
                                    continue;
                                }

                                if (para_check[1] == true)
                                {
                                    turn_check = 8;
                                }
                                else
                                {
                                    turn_check = 4;
                                }
                            }
                        }
                    }
                    else if (user_action == 2)           // 유저가 1 스킬 사용시
                    {
                        if (character == 1)              // 철갑 스킬 사용시
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (j == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine();
                                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                    Console.WriteLine();

                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                     [  H  P  :  ");
                                    if (mons_hp <= 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("{0}", mons_hp);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.Write("{0}", mons_hp);
                                    }
                                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                    Console.WriteLine();
                                    Console.Write("          ");
                                    if (pois_count[1] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[1] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("   [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();
                                    battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                    Console.WriteLine("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.Write("                                                  ");
                                    if (pois_count[0] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[0] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("  [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.WriteLine("                                                  {0}", player_form[i]);
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine();
                                    Console.Write("                                              [  H  P  :  ");
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
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                    Thread.Sleep(250);
                                }
                                else if (j == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine();
                                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                    Console.WriteLine();

                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                     [  H  P  :  ");
                                    if (mons_hp <= 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("{0}", mons_hp);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.Write("{0}", mons_hp);
                                    }
                                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                    Console.WriteLine();
                                    Console.Write("          ");
                                    if (pois_count[1] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[1] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("   [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();
                                    battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                    Console.WriteLine("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.Write("                                                  ");
                                    if (pois_count[0] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[0] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("  [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.WriteLine("                                                  {0}", player_form[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                                              [  H  P  :  ");
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
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        else if (character == 2)              // 연격 스킬 사용시
                        {
                            for (int a = 0; a < 2; a++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    if (j == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                        Console.WriteLine();
                                        Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                        Console.WriteLine();
                                        if (eva_check[1] == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            for (int i = 0; i < print_max + 1; i++)
                                            {
                                                Console.WriteLine("          {0}", print[i]);
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < print_max + 1; i++)
                                            {
                                                Console.WriteLine("          {0}", print[i]);
                                            }
                                        }

                                        Console.WriteLine();
                                        Console.Write("                     [  H  P  :  ");
                                        if (mons_hp <= 30)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("{0}", mons_hp);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            Console.Write("{0}", mons_hp);
                                        }
                                        Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                        Console.WriteLine();
                                        Console.Write("          ");
                                        if (pois_count[1] > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        if (para_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write("   [ 기절 상태 ]");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                        Console.WriteLine();
                                        if (user_skill_check[1] == true)
                                        {
                                            battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                            Console.Write("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                                        }
                                        else if (user_skill_check[3] == true)
                                        {
                                            battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                            Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                                        }
                                        else if (eva_check[1] == true)
                                        {
                                            battle_word[0] = "공격이 빗나가 허공을 가르고 말았습니다!";
                                            Console.Write("     {0}", battle_word[0]);
                                        }
                                        else if (crt_check[0] == true)
                                        {
                                            battle_word[0] = "적에게 치명타 일격을 가했습니다! ( ";
                                            Console.Write("     {0}", battle_word[0]);
                                            Console.Write("{0} 데미지 )", user_atk_conf[2]);
                                        }
                                        else
                                        {
                                            battle_word[0] = "적을 공격하였습니다! ( ";
                                            Console.Write("     {0}", battle_word[0]);
                                            Console.Write("{0} 데미지 )", user_atk_conf[1]);
                                        }
                                        if (cout_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (vamp_check[0] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (pois_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (para_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.Write("                                                  ");
                                        if (pois_count[0] > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        if (para_check[0] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write("  [ 기절 상태 ]");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        for (int i = 0; i < 16; i++)
                                        {
                                            Console.WriteLine("                              {0}", player_form[i]);
                                        }

                                        Console.WriteLine();
                                        Console.Write("                          [  H  P  :  ");
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
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                        Thread.Sleep(250);

                                        if (eva_check[1] == false)
                                        {
                                            if (crt_check[0] == true)
                                            {
                                                if (mons_hp - user_atk_conf[2] <= 0)
                                                {
                                                    mons_hp = 0;
                                                }
                                                else
                                                {
                                                    mons_hp -= user_atk_conf[2];
                                                }
                                            }
                                            else
                                            {
                                                if (mons_hp - user_atk_conf[1] <= 0)
                                                {
                                                    mons_hp = 0;
                                                }
                                                else
                                                {
                                                    mons_hp -= user_atk_conf[1];
                                                }
                                            }
                                        }

                                        if (vamp_check[0] == true)
                                        {
                                            user_vamp_int[2] = user_hp + user_vamp_int[1];
                                            if (user_vamp_int[2] >= user_max_hp)
                                            {
                                                user_hp = user_max_hp;
                                            }
                                            else
                                            {
                                                user_hp += user_vamp_int[1];
                                            }
                                        }

                                        if (cout_check[1] == true)
                                        {
                                            if (user_hp - mons_cout_int[1] <= 0)
                                            {
                                                user_hp = 0;
                                            }
                                            else
                                            {
                                                user_hp -= mons_cout_int[1];
                                            }
                                        }
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                        Console.WriteLine();
                                        Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                        Console.WriteLine();

                                        for (int i = 0; i < print_max + 1; i++)
                                        {
                                            Console.WriteLine("          {0}", print[i]);
                                        }

                                        Console.WriteLine();
                                        Console.Write("                     [  H  P  :  ");
                                        if (mons_hp <= 30)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("{0}", mons_hp);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            Console.Write("{0}", mons_hp);
                                        }
                                        Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                        Console.WriteLine();
                                        Console.Write("          ");
                                        if (pois_count[1] > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        if (para_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write("   [ 기절 상태 ]");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                        Console.WriteLine();
                                        if (user_skill_check[1] == true)
                                        {
                                            battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                            Console.Write("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                                        }
                                        else if (user_skill_check[3] == true)
                                        {
                                            battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                            Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                                        }
                                        else if (eva_check[1] == true)
                                        {
                                            Console.Write("     {0}", battle_word[0]);
                                        }
                                        else if (crt_check[0] == true)
                                        {
                                            Console.Write("     {0}", battle_word[0]);
                                            Console.Write("{0} 데미지 )", user_atk_conf[2]);
                                        }
                                        else
                                        {
                                            Console.Write("     {0}", battle_word[0]);
                                            Console.Write("{0} 데미지 )", user_atk_conf[1]);
                                        }
                                        if (cout_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (vamp_check[0] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (pois_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (para_check[1] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                        Console.WriteLine();

                                        Console.WriteLine();
                                        Console.Write("                                                  ");
                                        if (pois_count[0] > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        if (para_check[0] == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write("  [ 기절 상태 ]");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.WriteLine();

                                        for (int i = 0; i < 16; i++)
                                        {
                                            Console.WriteLine("                                                  {0}", player_form[i]);
                                        }

                                        Console.WriteLine();
                                        Console.Write("                                              [  H  P  :  ");
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
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                        Thread.Sleep(500);
                                    }
                                }
                            }
                        }
                        else if (character == 3)                // 활력 스킬 사용시
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (j == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine();
                                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                    Console.WriteLine();

                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                     [  H  P  :  ");
                                    if (mons_hp <= 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("{0}", mons_hp);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.Write("{0}", mons_hp);
                                    }
                                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                    Console.WriteLine();
                                    Console.Write("          ");
                                    if (pois_count[1] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[1] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("   [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();
                                    battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                    Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.Write("                                                  ");
                                    if (pois_count[0] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[0] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("  [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.WriteLine("                                                  {0}", player_form[i]);
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine();
                                    Console.Write("                                              [  H  P  :  ");
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
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                    Thread.Sleep(250);

                                    if (user_hp + skill_save_int[2] >= user_max_hp)
                                    {
                                        user_hp = user_max_hp;
                                    }
                                    else
                                    {
                                        user_hp += skill_save_int[2];
                                    }
                                }
                                else if (j == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine();
                                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                                    Console.WriteLine();

                                    for (int i = 0; i < print_max + 1; i++)
                                    {
                                        Console.WriteLine("          {0}", print[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                     [  H  P  :  ");
                                    if (mons_hp <= 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("{0}", mons_hp);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.Write("{0}", mons_hp);
                                    }
                                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                                    Console.WriteLine();
                                    Console.Write("          ");
                                    if (pois_count[1] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[1] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("   [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();
                                    battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                    Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                    Console.WriteLine();

                                    Console.WriteLine();
                                    Console.Write("                                                  ");
                                    if (pois_count[0] > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (para_check[0] == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("  [ 기절 상태 ]");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();

                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.WriteLine("                                                  {0}", player_form[i]);
                                    }

                                    Console.WriteLine();
                                    Console.Write("                                              [  H  P  :  ");
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
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                    Thread.Sleep(500);
                                }
                            }
                        }

                        user_skill_count[1] -= 1;

                        if (user_skill_check[2] == true)
                        {
                            user_skill_check[2] = false;
                        }

                        if (mons_hp == 0)
                        {
                            turn_check = 10;
                            continue;
                        }
                        else if (user_hp == 0)
                        {
                            turn_check = 11;
                            continue;
                        }

                        if (para_check[1] == true)
                        {
                            turn_check = 8;
                        }
                        else
                        {
                            turn_check = 4;
                        }
                    }
                }
                else if (turn_check == 4)            // 몬스터 공격 계산
                {
                    if (mons_action == 1)
                    {
                        rand[4] = random.Next(0, 100);
                        if (rand[4] <= user_eva)
                        {
                            eva_check[0] = true;
                        }
                        else
                        {
                            eva_check[0] = false;
                            rand[5] = random.Next(0, 100);
                            if (rand[5] <= mons_crt)
                            {
                                crt_check[1] = true;
                            }
                            else
                            {
                                crt_check[1] = false;
                            }
                            mons_atk_conf[0] = mons_atk[rand[0]];
                            mons_atk_conf[1] = mons_atk_conf[0] - user_dfd;
                            if (crt_check[1] == true)
                            {
                                mons_atk_conf[2] = (int)(mons_atk_conf[1] * mons_crt_mult);
                                if (mons_atk_conf[2] <= 0)
                                {
                                    mons_atk_conf[2] = 1;
                                }
                            }
                            else
                            {
                                if (mons_atk_conf[1] <= 0)
                                {
                                    mons_atk_conf[1] = 1;
                                }
                            }

                            if (user_cout > 0)
                            {
                                rand[7] = random.Next(0, 100);
                                if (rand[7] <= user_cout_per)
                                {
                                    cout_check[0] = true;
                                    if (crt_check[1] == true)
                                    {
                                        user_cout_flt = mons_atk_conf[2] / 100F;
                                        user_cout_int[1] = (int)(user_cout_flt * user_cout_int[0]);
                                    }
                                    else
                                    {
                                        user_cout_flt = mons_atk_conf[1] / 100F;
                                        user_cout_int[1] = (int)(user_cout_flt * user_cout_int[0]);
                                    }

                                    if (user_cout_int[1] == 0)
                                    {
                                        user_cout_int[1] = 1;
                                    }
                                }
                            }

                            if (mons_pois > 0)
                            {
                                rand[12] = random.Next(0, 100);
                                if (rand[12] <= mons_pois)
                                {
                                    pois_check[0] = true;
                                    mons_pois_flt = user_max_hp / 100F;
                                    mons_pois_int[1] = (int)(mons_pois_flt * mons_pois_int[0]);
                                    pois_count[0] += 2;
                                }
                            }

                            if (mons_vamp > 0)
                            {
                                rand[11] = random.Next(0, 100);
                                if (rand[11] <= mons_vamp)
                                {
                                    vamp_check[1] = true;
                                    if (crt_check[1] == true)
                                    {
                                        mons_vamp_flt = mons_atk_conf[2] / 100F;
                                        mons_vamp_int[1] = (int)(mons_vamp_flt * mons_vamp_int[0]);
                                    }
                                    else
                                    {
                                        mons_vamp_flt = mons_atk_conf[1] / 100F;
                                        mons_vamp_int[1] = (int)(mons_vamp_flt * mons_vamp_int[0]);
                                    }
                                }
                            }

                            if (mons_para > 0)
                            {
                                rand[10] = random.Next(0, 100);
                                if (rand[10] <= mons_para)
                                {
                                    para_check[0] = true;
                                }
                            }
                        }
                    }
                    turn_check = 5;
                }
                else if (turn_check == 5)              // 몬스터 공격
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("                              {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                         [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            if (user_skill_check[1] == true)
                            {
                                battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                Console.Write("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                            }
                            else if (user_skill_check[3] == true)
                            {
                                battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                            }
                            else if (eva_check[1] == true)
                            {
                                Console.Write("     {0}", battle_word[0]);
                            }
                            else if (crt_check[0] == true)
                            {
                                Console.Write("     {0}", battle_word[0]);
                                Console.Write("{0} 데미지 )", user_atk_conf[2]);
                            }
                            else
                            {
                                Console.Write("     {0}", battle_word[0]);
                                Console.Write("{0} 데미지 )", user_atk_conf[1]);
                            }
                            if (cout_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (vamp_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (pois_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            if (eva_check[0] == true)
                            {
                                battle_word[1] = "적의 공격을 피했습니다!";
                                Console.WriteLine("     {0}", battle_word[1]);
                            }
                            else if (crt_check[1] == true)
                            {
                                battle_word[1] = "적의 공격에 의해 치명타 피해를 입었습니다! ( ";
                                Console.Write("     {0}", battle_word[1]);
                                Console.Write("{0} 데미지 )", mons_atk_conf[2]);
                            }
                            else
                            {
                                battle_word[1] = "적의 공격을 받았습니다! ( ";
                                Console.Write("     {0}", battle_word[1]);
                                Console.Write("{0} 데미지 )", mons_atk_conf[1]);
                            }
                            if (cout_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" ( 적의 공격 반격 성공! {0} 데미지 )", user_cout_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (vamp_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" ( 적 흡혈 성공! HP 회복 : {0} )", mons_vamp_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (pois_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" ( 중독 공격 받음! 턴마다 독 피해! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" ( 기절 공격 받음! 다음 턴 공격 무력화! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            if (eva_check[0] == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                for (int i = 0; i < 16; i++)
                                {
                                    Console.WriteLine("                                                  {0}", player_form[i]);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                for (int i = 0; i < 16; i++)
                                {
                                    Console.WriteLine("                                                  {0}", player_form[i]);
                                }
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(250);

                            if (eva_check[0] == false)
                            {
                                if (crt_check[1] == true)
                                {
                                    if (user_hp - mons_atk_conf[2] <= 0)
                                    {
                                        user_hp = 0;
                                    }
                                    else
                                    {
                                        user_hp -= mons_atk_conf[2];
                                    }
                                    
                                }
                                else
                                {
                                    if (user_hp - mons_atk_conf[1] <= 0)
                                    {
                                        user_hp = 0;
                                    }
                                    else
                                    {
                                        user_hp -= mons_atk_conf[1];
                                    }
                                }
                            }

                            if (vamp_check[1] == true)
                            {
                                mons_vamp_int[2] = mons_hp + mons_vamp_int[1];
                                if (mons_vamp_int[2] >= mons_max_hp)
                                {
                                    mons_hp = mons_max_hp;
                                }
                                else
                                {
                                    mons_hp += mons_vamp_int[1];
                                }
                            }

                            if (cout_check[0] == true)
                            {
                                if (mons_hp - user_cout_int[1] <= 0)
                                {
                                    mons_hp = 0;
                                }
                                else
                                {
                                    mons_hp -= user_cout_int[1];
                                }
                            }
                        }
                        else if (j == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            if (user_skill_check[1] == true)
                            {
                                battle_word[0] = "[ 철 갑 ] 스킬 사용!";
                                Console.Write("     {0} 이번 턴 방어력 {1} 증가!", battle_word[0], skill_save_int[1]);
                            }
                            else if (user_skill_check[3] == true)
                            {
                                battle_word[0] = "[ 활 력 ] 스킬 사용!";
                                Console.WriteLine("     {0} HP {1} 회복!", battle_word[0], skill_save_int[2]);
                            }
                            else if (eva_check[1] == true)
                            {
                                Console.WriteLine("     {0}", battle_word[0]);
                            }
                            else if (crt_check[0] == true)
                            {
                                Console.Write("     {0}", battle_word[0]);
                                Console.Write("{0} 데미지 )", user_atk_conf[2]);
                            }
                            else
                            {
                                Console.Write("     {0}", battle_word[0]);
                                Console.Write("{0} 데미지 )", user_atk_conf[1]);
                            }
                            if (cout_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" ( 적이 공격을 반격함! {0} 데미지 )", mons_cout_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (vamp_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" ( 흡혈 성공! HP 회복 : {0} )", user_vamp_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (pois_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" ( 적 중독 상태! 턴마다 독 피해! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" ( 적 기절 상태! 공격 무력화! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            if (eva_check[0] == true)
                            {
                                Console.WriteLine("     {0}", battle_word[1]);
                            }
                            else if (crt_check[1] == true)
                            {
                                Console.Write("     {0}", battle_word[1]);
                                Console.Write("{0} 데미지 )", mons_atk_conf[2]);
                            }
                            else
                            {
                                Console.Write("     {0}", battle_word[1]);
                                Console.Write("{0} 데미지 )", mons_atk_conf[1]);
                            }
                            if (cout_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" ( 적의 공격 반격 성공! {0} 데미지 )", user_cout_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (vamp_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" ( 적 흡혈 성공! HP 회복 : {0} )", mons_vamp_int[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (pois_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" ( 중독 공격 받음! 턴마다 독 피해! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" ( 기절 공격 받음! 다음 턴 공격 무력화! )");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(500);

                            if (mons_hp == 0)
                            {
                                turn_check = 10;
                                continue;
                            }
                            else if (user_hp == 0)
                            {
                                turn_check = 11;
                                continue;
                            }

                            if (pois_count[1] > 0)
                            {
                                turn_check = 6;
                            }
                            else if (pois_count[0] > 0)
                            {
                                turn_check = 7;
                            }
                            else
                            {
                                eva_check[0] = false;
                                eva_check[1] = false;
                                crt_check[0] = false;
                                crt_check[1] = false;
                                vamp_check[0] = false;
                                vamp_check[1] = false;
                                cout_check[0] = false;
                                cout_check[1] = false;
                                pois_check[0] = false;
                                pois_check[1] = false;
                                para_check[1] = false;

                                if (user_skill_check[1] == true)
                                {
                                    user_dfd = skill_save_int[1];
                                    user_skill_check[1] = false;
                                }
                                if (user_skill_check[3] == true)
                                {
                                    user_skill_check[3] = false;
                                }

                                turn += 1;
                                turn_check = 1;
                            }
                        }
                    }
                }
                else if (turn_check == 6)             // 몬스터 중독 상태
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            battle_word[0] = "적 중독 상태 ";
                            Console.WriteLine("     {0} {1} 독 피해!", battle_word[0], user_pois_int[1]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(250);

                            if (mons_hp - user_pois_int[1] <= 0)
                            {
                                mons_hp = 0;
                            }
                            else
                            {
                                mons_hp -= user_pois_int[1];
                            }
                        }
                        else if (j == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            battle_word[0] = "적 중독 상태 ";
                            Console.WriteLine("     {0} {1} 독 피해!", battle_word[0], user_pois_int[1]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(500);

                            

                            if (mons_hp == 0)
                            {
                                turn_check = 10;
                                continue;
                            }
                            else if (pois_count[0] > 0)
                            {
                                turn_check = 7;
                            }
                            else
                            {
                                eva_check[0] = false;
                                eva_check[1] = false;
                                crt_check[0] = false;
                                crt_check[1] = false;
                                vamp_check[0] = false;
                                vamp_check[1] = false;
                                cout_check[0] = false;
                                cout_check[1] = false;
                                pois_check[0] = false;
                                pois_check[1] = false;
                                para_check[1] = false;

                                if (user_skill_check[1] == true)
                                {
                                    user_dfd = skill_save_int[1];
                                    user_skill_check[1] = false;
                                }
                                if (user_skill_check[3] == true)
                                {
                                    user_skill_check[3] = false;
                                }

                                pois_count[1] -= 1;
                                turn_check = 1;
                                turn += 1;
                            }
                        }
                    }
                }
                else if (turn_check == 7)               // 플레이어 중독 상태
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }
                            
                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            battle_word[0] = "현재 중독 상태 ";
                            Console.WriteLine("     {0} {1} 독 피해!", battle_word[0], mons_pois_int[1]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(250);

                            if (user_hp - mons_pois_int[1] <= 0)
                            {
                                user_hp = 0;
                            }
                            else
                            {
                                user_hp -= mons_pois_int[1];
                            }
                        }
                        else if (j == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            battle_word[0] = "현재 중독 상태 ";
                            Console.WriteLine("     {0} {1} 독 피해!", battle_word[0], mons_pois_int[1]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(500);

                            if (user_hp == 0)
                            {
                                turn_check = 11;
                                continue;
                            }
                            else
                            {
                                eva_check[0] = false;
                                eva_check[1] = false;
                                crt_check[0] = false;
                                crt_check[1] = false;
                                vamp_check[0] = false;
                                vamp_check[1] = false;
                                cout_check[0] = false;
                                cout_check[1] = false;
                                pois_check[0] = false;
                                pois_check[1] = false;
                                para_check[1] = false;

                                if (user_skill_check[1] == true)
                                {
                                    user_dfd = skill_save_int[1];
                                    user_skill_check[1] = false;
                                }
                                if (user_skill_check[3] == true)
                                {
                                    user_skill_check[3] = false;
                                }

                                pois_count[0] -= 1;
                                turn_check = 1;
                                turn += 1;
                            }
                        }
                    }
                }
                else if (turn_check == 8)           // 몬스터 기절 상태 (해당 턴 스킵)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.White;


                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            battle_word[0] = "적 기절 상태 ";
                            Console.WriteLine("     {0} 해당 턴 무력화!", battle_word[0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(250);
                        }
                        else if (j == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            battle_word[0] = "적 기절 상태 ";
                            Console.WriteLine("     {0} 해당 턴 무력화!", battle_word[0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(500);

                            if (pois_count[1] > 0)
                            {
                                turn_check = 6;
                            }
                            else if (pois_count[0] > 0)
                            {
                                turn_check = 7;
                            }
                            else
                            {
                                eva_check[0] = false;
                                eva_check[1] = false;
                                crt_check[0] = false;
                                crt_check[1] = false;
                                vamp_check[0] = false;
                                vamp_check[1] = false;
                                cout_check[0] = false;
                                cout_check[1] = false;
                                pois_check[0] = false;
                                pois_check[1] = false;
                                para_check[1] = false;

                                if (user_skill_check[1] == true)
                                {
                                    user_dfd = skill_save_int[1];
                                    user_skill_check[1] = false;
                                }
                                if (user_skill_check[3] == true)
                                {
                                    user_skill_check[3] = false;
                                }

                                turn += 1;
                                turn_check = 1;
                            }
                        }
                    }
                }
                else if (turn_check == 9)             // 플레이어 기절 상태 (다음 턴 스킵)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            battle_word[0] = "현재 기절 상태 ";
                            Console.WriteLine("     {0} 이번 턴 무력화!", battle_word[0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(250);
                        }
                        else if (j == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine();
                            Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                            Console.WriteLine();

                            for (int i = 0; i < print_max + 1; i++)
                            {
                                Console.WriteLine("          {0}", print[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                     [  H  P  :  ");
                            if (mons_hp <= 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", mons_hp);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write("{0}", mons_hp);
                            }
                            Console.WriteLine("  /  {0}  ]", mons_max_hp);
                            Console.WriteLine();
                            Console.Write("          ");
                            if (pois_count[1] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[1] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("   [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            battle_word[0] = "현재 기절 상태 ";
                            Console.WriteLine("     {0} 이번 턴 무력화!", battle_word[0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("                                                  ");
                            if (pois_count[0] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (para_check[0] == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("  [ 기절 상태 ]");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();

                            for (int i = 0; i < 16; i++)
                            {
                                Console.WriteLine("                                                  {0}", player_form[i]);
                            }

                            Console.WriteLine();
                            Console.Write("                                              [  H  P  :  ");
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Thread.Sleep(500);

                            para_check[0] = false;
                            turn_check = 4;
                        }
                    }
                }
                else if (turn_check == 10)            // 몬스터 사망시 실행
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
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

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("          {0}", print[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                     [  H  P  :  ");
                    if (mons_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", mons_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", mons_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                    Console.WriteLine();
                    Console.Write("          ");
                    if (pois_count[1] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[1] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("   [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("     적 몬스터가 쓰러졌습니다!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("                                                  ");
                    if (pois_count[0] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[0] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                                  {0}", player_form[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                                              [  H  P  :  ");
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(1000);

                    act += 1;
                    thirsty += 10;
                    story_battle = true;

                    if (act >= 10)
                    {
                        break;
                    }
                    else
                    {
                        Looting looting_ = new Looting();
                        looting_.MonsterLooting03(ref act, ref act_step, ref user_hp, ref user_max_hp, ref user_atk, ref user_dfd,
                                ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout, ref thirsty,
                                ref thirsty_max, ref character, ref user_skill_count, ref user_crt_mult, ref user_skill_type, ref act_max);
                    }

                    break;
                }
                else if (turn_check == 11)            // 플레이어 사망시 실행
                {
                    Console.Clear();
                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine("     [  현재 턴  :  {0}  ]", turn);
                    Console.WriteLine();

                    for (int i = 0; i < print_max + 1; i++)
                    {
                        Console.WriteLine("          {0}", print[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                     [  H  P  :  ");
                    if (mons_hp <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", mons_hp);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0}", mons_hp);
                    }
                    Console.WriteLine("  /  {0}  ]", mons_max_hp);
                    Console.WriteLine();
                    Console.Write("          ");
                    if (pois_count[1] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("   [ 중독 : {0} ]", pois_count[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[1] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("   [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("     브라이언은 온 몸에 힘이 빠지고 눈앞이 깜깜해지기 시작했다...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("                                                  ");
                    if (pois_count[0] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  [ 중독 : {0} ]", pois_count[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (para_check[0] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  [ 기절 상태 ]");
                        Console.ForegroundColor = ConsoleColor.White;
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
                    Console.WriteLine();

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("                                                  {0}", player_form[i]);
                    }

                    Console.WriteLine();
                    Console.Write("                                              [  H  P  :  ");
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(1000);

                    break;
                }
            }
        }
    }
}
