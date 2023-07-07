using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Information
    {
        string[] player_form = new string[16];

        public void CharacterInfo(ref int act, ref int act_max, ref int act_step, ref int user_hp, ref int user_max_hp, ref int user_atk,
                            ref int user_dfd, ref int user_crt, ref int user_eva, ref int user_vamp, ref int user_para, ref int user_pois,
                            ref int user_cout, ref int thirsty, ref int thirsty_max, ref int[] user_skill_type, ref int[] user_skill_count)
        {
            bool user_vamp_b = false;
            bool user_para_b = false;
            bool user_pois_b = false;
            bool user_cout_b = false;

            int cursor = 1;

            int user_vamp_per = 0;
            int[] user_vamp_int = new int[3];
            int user_cout_per = 0;
            int[] user_cout_int = new int[3];
            int user_pois_per = 0;
            int[] user_pois_int = new int[3];
            int user_para_per = 0;

            Skill skill_ = new Skill();
            skill_.Ability(ref user_vamp, ref user_vamp_per, ref user_vamp_int, ref user_cout, ref user_cout_per, ref user_cout_int, 
                ref user_pois, ref user_pois_per, ref user_pois_int, ref user_para, ref user_para_per);

            if (user_vamp > 0)
            {
                user_vamp_b = true;
            }
            else
            {
                user_vamp_b = false;
            }

            if (user_para > 0)
            {
                user_para_b = true;
            }
            else
            {
                user_para_b = false;
            }

            if (user_pois > 0)
            {
                user_pois_b = true;
            }
            else
            {
                user_pois_b = false;
            }

            if (user_cout > 0)
            {
                user_cout_b = true;
            }
            else
            {
                user_cout_b = false;
            }

            int user_atk_min = 0;
            int user_atk_max = 0;

            user_atk_min = user_atk - 5;
            user_atk_max = user_atk + 5;

            while (true)
            {
                if (cursor == 1)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("             -----> [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 2)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("             -----> [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 3)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("             -----> [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 4)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("             -----> [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 5)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ] <-----", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 6)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ] <-----", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 7)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ] <-----", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ]", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    
                }
                else if (cursor == 8)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  공 격 력  :  {0}  ]", user_atk);
                    if (user_vamp_b == true)
                    {
                        Console.WriteLine("                 [  흡 혈  :  {0}  ]", user_vamp);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  방 어 력  :  {0}  ]", user_dfd);
                    if (user_para_b == true)
                    {
                        Console.WriteLine("                  [  기 절  :  {0}  ]", user_para);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  치 명 타 율  :  {0} % ]", user_crt);
                    if (user_pois_b == true)
                    {
                        Console.WriteLine("             [  중  독  :  {0}  ]", user_pois);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                    [  회 피 율  :  {0} % ]", user_eva);
                    if (user_cout_b == true)
                    {
                        Console.WriteLine("                [  반  격  :  {0}  ] <-----", user_cout);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 9)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     공 격 력 : 방어력 0 을 기준으로 적에게 {0} ~ {1} 사이의", user_atk_min, user_atk_max);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                데미지를 입힙니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 10)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     방 어 력 : 적의 공격력의 {0} 만큼 데미지를 감소 시킵니다.", user_dfd);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
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
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 11)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     치 명 타 율 : 적에게 {0} % 확률로 공격력의 150 % 데미지를", user_crt);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                   입힙니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 12)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     회 피 율 : 적의 공격을 {0} 확률로 무시합니다.", user_eva);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
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
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 13)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     흡 혈 (Lv. {0}) : 적에게 공격시 {1} % 확률로 공격력의 {2} % 를", user_vamp, user_vamp_per, user_vamp_int[0]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     HP 로 회복합니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 14)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     기 절 (Lv. {0}) : 적에게 공격시 {1} % 확률로 적을 기절", user_para, user_para_per);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     시킵니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 15)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     중 독 (Lv. {0}) : 적에게 공격시 {1} % 확률로 적을 중독 상태로", user_pois, user_pois_per);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     만들어 2턴동안 매턴마다 최대 HP 의 {0} %", user_pois_int[0]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     만큼의 데미지를 입힙니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (cursor == 16)
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
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     <<  캐 릭 터 정 보  >>");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Paint paint_ = new Paint();
                    paint_.CharacterPaint(ref player_form);

                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 ┌──────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     반 격 (Lv. {0}) : 적이 공격할 때 {1} % 확률로 적의 공격력의 ", user_cout, user_cout_per);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                     {0} % 만큼의 데미지를 적에게 입힙니다.", user_cout_int[0]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                 └──────────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();
                    Console.WriteLine("               [  선 택  ]                [  나 가 기  ]");
                    Console.WriteLine();
                    Console.WriteLine("             [  Space Bar  ]                 [  Q  ]");
                    Console.WriteLine();
                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }

                ConsoleKeyInfo something = Console.ReadKey();

                if (something.Key == ConsoleKey.DownArrow)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        if (cursor == 4)
                        {
                            cursor = 4;
                        }
                        else if (cursor == 5)
                        {
                            if (user_para_b == true)
                            {
                                cursor = 6;
                            }
                            else if (user_pois_b == true)
                            {
                                cursor = 7;
                            }
                            else if (user_cout_b == true)
                            {
                                cursor = 8;
                            }
                            else
                            {
                                cursor = 5;
                            }
                        }
                        else if (cursor == 6)
                        {
                            if (user_pois_b == true)
                            {
                                cursor = 7;
                            }
                            else if (user_cout_b == true)
                            {
                                cursor = 8;
                            }
                            else
                            {
                                cursor = 6;
                            }
                        }
                        else if (cursor == 7)
                        {
                            if (user_cout_b == true)
                            {
                                cursor = 8;
                            }
                            else
                            {
                                cursor = 7;
                            }
                        }
                        else if (cursor == 8)
                        {
                            cursor = 8;
                        }
                        else
                        {
                            cursor += 1;
                        }
                    }
                    
                }
                else if (something.Key == ConsoleKey.UpArrow)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        if (cursor == 1)
                        {
                            cursor = 1;
                        }
                        else if (cursor == 8)
                        {
                            if (user_pois_b == true)
                            {
                                cursor = 7;
                            }
                            else if (user_para_b == true)
                            {
                                cursor = 6;
                            }
                            else if (user_vamp_b == true)
                            {
                                cursor = 5;
                            }
                            else
                            {
                                cursor = 8;
                            }
                        }
                        else if (cursor == 7)
                        {
                            if (user_para_b == true)
                            {
                                cursor = 6;
                            }
                            else if (user_vamp_b == true)
                            {
                                cursor = 5;
                            }
                            else
                            {
                                cursor = 7;
                            }
                        }
                        else if (cursor == 6)
                        {
                            if (user_vamp_b == true)
                            {
                                cursor = 5;
                            }
                            else
                            {
                                cursor = 6;
                            }
                        }
                        else if (cursor == 5)
                        {
                            cursor = 5;
                        }
                        else
                        {
                            cursor -= 1;
                        }
                    }
                    
                }
                else if (something.Key == ConsoleKey.RightArrow)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        if (cursor == 1)
                        {
                            if (user_vamp_b == true)
                            {
                                cursor = 5;
                            }
                            else
                            {
                                cursor = 1;
                            }
                        }
                        else if (cursor == 2)
                        {
                            if (user_para_b == true)
                            {
                                cursor = 6;
                            }
                            else
                            {
                                cursor = 2;
                            }
                        }
                        else if (cursor == 3)
                        {
                            if (user_pois_b == true)
                            {
                                cursor = 7;
                            }
                            else
                            {
                                cursor = 3;
                            }
                        }
                        else if (cursor == 4)
                        {
                            if (user_cout_b == true)
                            {
                                cursor = 8;
                            }
                            else
                            {
                                cursor = 4;
                            }
                        }
                    }
                }
                else if (something.Key == ConsoleKey.LeftArrow)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        if (cursor == 5)
                        {
                            cursor = 1;
                        }
                        else if (cursor == 6)
                        {
                            cursor = 2;
                        }
                        else if (cursor == 7)
                        {
                            cursor = 3;
                        }
                        else if (cursor == 8)
                        {
                            cursor = 4;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (something.Key == ConsoleKey.Q)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        break;
                    }
                    else if (cursor >= 9 && cursor <= 16)
                    {
                        cursor -= 8;
                    }
                }
                else if (something.Key == ConsoleKey.Spacebar)
                {
                    if (cursor >= 1 && cursor <= 8)
                    {
                        cursor += 8;
                    }
                }
            }
        }
    }
}
