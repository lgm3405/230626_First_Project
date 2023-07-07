using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Looting
    {
        int[] item_num = new int[5];
        string item_name = "\0";
        string[] item_stat_name = new string[5];
        int[] item_stat_int = new int[5];
        int item_stat_count = 0;
        bool item_another = false;

        int[,] item_num_2 = new int[5, 5];
        int[] item_grade = new int[5];
        string[] item_name_2 = new string[3];
        int[] item_stat_count_2 = new int[3];
        string[,] item_stat_name_2 = new string[3, 5];
        int[,] item_stat_int_2 = new int[3, 5];
        bool[] item_another_2 = new bool[5];

        int rand = 0;
        int loop_check = 0;

        public void MonsterLooting03(ref int act, ref int act_step, ref int user_hp, ref int user_max_hp, ref int user_atk,
            ref int user_dfd, ref int user_crt, ref int user_eva, ref int user_vamp, ref int user_para, ref int user_pois,
            ref int user_cout, ref int thirsty, ref int thirsty_max, ref int character, ref int[] user_skill_count,
            ref float user_crt_mult, ref int[] user_skill_type, ref int act_max)
        {
            
            Random random = new Random();
            Item item_ = new Item();

            int item_select = 0;

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    item_num[0] = 0;
                    item_num[1] = 0;
                    item_num[2] = 0;
                    item_name = "\0";
                    item_another = false;
                    rand = random.Next(0, 100);
                    if (rand < 15)
                    {
                        rand = random.Next(1, 15);
                        item_grade[i] = 2;
                        item_num[item_grade[i]] = rand;
                        item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                            ref item_another);
                    }
                    else if (rand >= 15 && rand < 50)
                    {
                        rand = random.Next(1, 15);
                        item_grade[i] = 1;
                        item_num[item_grade[i]] = rand;
                        item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                            ref item_another);
                    }
                    else
                    {
                        rand = random.Next(1, 15);
                        item_grade[i] = 0;
                        item_num[item_grade[i]] = rand;
                        item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                            ref item_another);
                    }

                    item_num_2[i, item_grade[i]] = item_num[item_grade[i]];
                    item_name_2[i] = item_name;
                    item_stat_count_2[i] = item_stat_count;
                    item_another_2[i] = item_another;

                    for (int j = 0; j < item_stat_count + 1; j++)
                    {
                        item_stat_name_2[i, j] = item_stat_name[j];
                        item_stat_int_2[i, j] = item_stat_int[j];
                    }
                }

                if (item_num_2[0, item_grade[0]] != item_num_2[1, item_grade[1]] && item_num_2[1, item_grade[1]] != item_num_2[2, item_grade[2]]
                    && item_num_2[0, item_grade[0]] != item_num_2[2, item_grade[2]])
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            while (true)
            {
                if (loop_check == 0)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  >   (  해당 아이템의 숫자키 입력 시 선택  )");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        if (item_grade[i] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (item_grade[i] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("          ┏─────────────────────────────────┓");
                        Console.WriteLine();
                        Console.WriteLine("                    <  {0}  >", i + 1);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("               [  {0}  ]", item_name_2[i]);
                        Console.WriteLine();
                        Console.WriteLine();

                        if (item_another_2[i] == false)
                        {
                            for (int j = 0; j < item_stat_count_2[i] + 1; j++)
                            {
                                Console.Write("               (  {0}", item_stat_name_2[i, j]);
                                Console.Write("{0}  )", item_stat_int_2[i, j]);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write("               (  {0}  )", item_stat_name_2[i, 0]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        Console.WriteLine("          ┗─────────────────────────────────┛");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                        [  ( E ) 캐릭터 정보 보기  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                    else if (something_2.Key == ConsoleKey.D1 || something_2.Key == ConsoleKey.NumPad1)
                    {
                        loop_check = 1;
                    }
                    else if (something_2.Key == ConsoleKey.D2 || something_2.Key == ConsoleKey.NumPad2)
                    {
                        loop_check = 2;
                    }
                    else if (something_2.Key == ConsoleKey.D3 || something_2.Key == ConsoleKey.NumPad3)
                    {
                        loop_check = 3;
                    }
                }
                else if (loop_check == 1)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  >   (  해당 아이템의 숫자키 입력 시 선택  )");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        if (item_grade[i] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (item_grade[i] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("          ┏─────────────────────────────────┓");
                        Console.WriteLine();
                        if (i == 0)
                        {
                            Console.WriteLine("                    <  {0}  >                         <----- ( 한번 더 누르시면 선택 확정됩니다 )", i + 1);
                        }
                        else
                        {
                            Console.WriteLine("                    <  {0}  >", i + 1);

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("               [  {0}  ]", item_name_2[i]);
                        Console.WriteLine();
                        Console.WriteLine();

                        if (item_another_2[i] == false)
                        {
                            for (int j = 0; j < item_stat_count_2[i] + 1; j++)
                            {
                                Console.Write("               (  {0}", item_stat_name_2[i, j]);
                                Console.Write("{0}  )", item_stat_int_2[i, j]);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write("               (  {0}  )", item_stat_name_2[i, 0]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        Console.WriteLine("          ┗─────────────────────────────────┛");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                        [  ( E ) 캐릭터 정보 보기  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                    else if (something_2.Key == ConsoleKey.D1 || something_2.Key == ConsoleKey.NumPad1)
                    {
                        loop_check = 4;
                    }
                    else if (something_2.Key == ConsoleKey.D2 || something_2.Key == ConsoleKey.NumPad2)
                    {
                        loop_check = 2;
                    }
                    else if (something_2.Key == ConsoleKey.D3 || something_2.Key == ConsoleKey.NumPad3)
                    {
                        loop_check = 3;
                    }
                }
                else if (loop_check == 2)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  >   (  해당 아이템의 숫자키 입력 시 선택  )");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        if (item_grade[i] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (item_grade[i] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("          ┏─────────────────────────────────┓");
                        Console.WriteLine();
                        if (i == 1)
                        {
                            Console.WriteLine("                    <  {0}  >                         <----- ( 한번 더 누르시면 선택 확정됩니다 )", i + 1);
                        }
                        else
                        {
                            Console.WriteLine("                    <  {0}  >", i + 1);

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("               [  {0}  ]", item_name_2[i]);
                        Console.WriteLine();
                        Console.WriteLine();

                        if (item_another_2[i] == false)
                        {
                            for (int j = 0; j < item_stat_count_2[i] + 1; j++)
                            {
                                Console.Write("               (  {0}", item_stat_name_2[i, j]);
                                Console.Write("{0}  )", item_stat_int_2[i, j]);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write("               (  {0}  )", item_stat_name_2[i, 0]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        Console.WriteLine("          ┗─────────────────────────────────┛");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                        [  ( E ) 캐릭터 정보 보기  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                    else if (something_2.Key == ConsoleKey.D1 || something_2.Key == ConsoleKey.NumPad1)
                    {
                        loop_check = 1;
                    }
                    else if (something_2.Key == ConsoleKey.D2 || something_2.Key == ConsoleKey.NumPad2)
                    {
                        loop_check = 5;
                    }
                    else if (something_2.Key == ConsoleKey.D3 || something_2.Key == ConsoleKey.NumPad3)
                    {
                        loop_check = 3;
                    }
                }
                else if (loop_check == 3)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  >   (  해당 아이템의 숫자키 입력 시 선택  )");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        if (item_grade[i] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (item_grade[i] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("          ┏─────────────────────────────────┓");
                        Console.WriteLine();
                        if (i == 2)
                        {
                            Console.WriteLine("                    <  {0}  >                         <----- ( 한번 더 누르시면 선택 확정됩니다 )", i + 1);
                        }
                        else
                        {
                            Console.WriteLine("                    <  {0}  >", i + 1);

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("               [  {0}  ]", item_name_2[i]);
                        Console.WriteLine();
                        Console.WriteLine();

                        if (item_another_2[i] == false)
                        {
                            for (int j = 0; j < item_stat_count_2[i] + 1; j++)
                            {
                                Console.Write("               (  {0}", item_stat_name_2[i, j]);
                                Console.Write("{0}  )", item_stat_int_2[i, j]);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write("               (  {0}  )", item_stat_name_2[i, 0]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        Console.WriteLine("          ┗─────────────────────────────────┛");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                        [  ( E ) 캐릭터 정보 보기  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.E)
                    {
                        Information information_ = new Information();
                        information_.CharacterInfo(ref act, ref act_max, ref act_step, ref user_hp, ref user_max_hp, ref user_atk,
                            ref user_dfd, ref user_crt, ref user_eva, ref user_vamp, ref user_para, ref user_pois, ref user_cout,
                            ref thirsty, ref thirsty_max, ref user_skill_type, ref user_skill_count);
                    }
                    else if (something_2.Key == ConsoleKey.D1 || something_2.Key == ConsoleKey.NumPad1)
                    {
                        loop_check = 1;
                    }
                    else if (something_2.Key == ConsoleKey.D2 || something_2.Key == ConsoleKey.NumPad2)
                    {
                        loop_check = 2;
                    }
                    else if (something_2.Key == ConsoleKey.D3 || something_2.Key == ConsoleKey.NumPad3)
                    {
                        loop_check = 6;
                    }
                }
                else if (loop_check == 4)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  완 료  >");
                    Console.WriteLine();

                    if (item_grade[0] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (item_grade[0] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         ┏─────────────────────────────────┓");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              [  {0}  ]", item_name_2[0]);
                    Console.WriteLine();
                    Console.WriteLine();
                    if (item_another_2[0] == false)
                    {
                        for (int j = 0; j < item_stat_count_2[0] + 1; j++)
                        {
                            Console.Write("                              (  {0}", item_stat_name_2[0, j]);
                            Console.Write("{0}  )", item_stat_int_2[0, j]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write("                              (  {0}  )", item_stat_name_2[0, 0]);
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("                         ┗─────────────────────────────────┛");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.Spacebar)
                    {
                        loop_check = 7;
                        item_select = 0;
                    }
                }
                else if (loop_check == 5)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  완 료  >");
                    Console.WriteLine();

                    if (item_grade[1] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (item_grade[1] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         ┏─────────────────────────────────┓");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              [  {0}  ]", item_name_2[1]);
                    Console.WriteLine();
                    Console.WriteLine();
                    if (item_another_2[1] == false)
                    {
                        for (int j = 0; j < item_stat_count_2[1] + 1; j++)
                        {
                            Console.Write("                              (  {0}", item_stat_name_2[1, j]);
                            Console.Write("{0}  )", item_stat_int_2[1, j]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write("                              (  {0}  )", item_stat_name_2[1, 0]);
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("                         ┗─────────────────────────────────┛");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.Spacebar)
                    {
                        loop_check = 7;
                        item_select = 1;
                    }
                }
                else if (loop_check == 6)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              <  전 리 품 선 택  완 료  >");
                    Console.WriteLine();

                    if (item_grade[2] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (item_grade[2] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                         ┏─────────────────────────────────┓");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                              [  {0}  ]", item_name_2[2]);
                    Console.WriteLine();
                    Console.WriteLine();
                    if (item_another_2[2] == false)
                    {
                        for (int j = 0; j < item_stat_count_2[2] + 1; j++)
                        {
                            Console.Write("                              (  {0}", item_stat_name_2[2, j]);
                            Console.Write("{0}  )", item_stat_int_2[2, j]);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write("                              (  {0}  )", item_stat_name_2[2, 0]);
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("                         ┗─────────────────────────────────┛");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       [  다 음  ]  <-----  [  Space Bar  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo something_2 = Console.ReadKey();

                    if (something_2.Key == ConsoleKey.Spacebar)
                    {
                        loop_check = 7;
                        item_select = 2;
                    }
                }
                else if (loop_check == 7)
                {
                    for (int j = 0; j < item_stat_count_2[item_select] + 1; j++)
                    {
                        if (item_stat_name_2[item_select, j] == "공격력 + ")
                        {
                            user_atk += item_stat_int_2[item_select, j];
                        }
                        else if (item_stat_name_2[item_select, j] == "방어력 + ")
                        {
                            user_dfd += item_stat_int_2[item_select, j];
                        }
                        else if (item_stat_name_2[item_select, j] == "HP + ")
                        {
                            user_max_hp += item_stat_int_2[item_select, j];
                        }
                        else if (item_stat_name_2[item_select, j] == "치명타율 + ")
                        {
                            user_crt += item_stat_int_2[item_select, j];
                        }
                        else if (item_stat_name_2[item_select, j] == "회피율 + ")
                        {
                            user_eva += item_stat_int_2[item_select, j];
                        }
                        else if (item_stat_name_2[item_select, j] == "흡혈 능력 + ")
                        {
                            if (user_vamp == 8)
                            {
                                user_vamp = 8;
                            }
                            else
                            {
                                user_vamp += item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "중독 능력 + ")
                        {
                            if (user_pois == 8)
                            {
                                user_pois = 8;
                            }
                            else
                            {
                                user_pois += item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "기절 능력 + ")
                        {
                            if (user_para == 8)
                            {
                                user_para = 8;
                            }
                            else
                            {
                                user_para += item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "반격 능력 + ")
                        {
                            if (user_cout == 8)
                            {
                                user_cout = 8;
                            }
                            else
                            {
                                user_cout += item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "HP 회복 = ")
                        {
                            if (user_hp + item_stat_int_2[item_select, j] >= user_max_hp)
                            {
                                user_hp = user_max_hp;
                            }
                            else
                            {
                                user_hp += item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "목마름 회복 = ")
                        {
                            if (thirsty - item_stat_int_2[item_select, j] <= 0)
                            {
                                thirsty = 0;
                            }
                            else
                            {
                                thirsty -= item_stat_int_2[item_select, j];
                            }
                        }
                        else if (item_stat_name_2[item_select, j] == "스킬 사용 횟수 증가 + ")
                        {
                            user_skill_count[1] += item_stat_int_2[item_select, j];
                            if (user_skill_type[2] != 0)
                            {
                                user_skill_count[2] += item_stat_int_2[item_select, j];
                            }
                            if (user_skill_type[3] != 0)
                            {
                                user_skill_count[3] += item_stat_int_2[item_select, j];
                            }
                            if (user_skill_type[4] != 0)
                            {
                                user_skill_count[4] += item_stat_int_2[item_select, j];
                            }
                        }
                    }

                    break;
                }
            }
        }

        public void StoryLooting01(ref string item_name, ref string[] item_stat_name, ref int[] item_stat_int, ref int item_stat_count,
                            ref bool item_another, ref int user_atk, ref int user_dfd, ref int user_hp, ref int user_max_hp, ref int thirsty,
                            ref int thirsty_max, ref int user_crt, ref int user_eva, ref int user_vamp, ref int user_pois, ref int user_para,
                            ref int user_cout, ref int[] user_skill_count)
        {
            Random random = new Random();
            Item item_ = new Item();

            item_num[0] = 0;
            item_name = "\0";
            item_another = false;
            rand = random.Next(0, 100);
            if (rand < 15)
            {
                rand = random.Next(1, 15);
                item_grade[0] = 2;
                item_num[item_grade[0]] = rand;
                item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                    ref item_another);
            }
            else if (rand >= 15 && rand < 50)
            {
                rand = random.Next(1, 15);
                item_grade[0] = 1;
                item_num[item_grade[0]] = rand;
                item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                    ref item_another);
            }
            else
            {
                rand = random.Next(1, 15);
                item_grade[0] = 0;
                item_num[item_grade[0]] = rand;
                item_.Collection(ref item_num, ref item_name, ref item_stat_name, ref item_stat_int, ref item_stat_count,
                    ref item_another);
            }

            item_num_2[0, item_grade[0]] = item_num[item_grade[0]];
            item_name_2[0] = item_name;
            item_stat_count_2[0] = item_stat_count;
            item_another_2[0] = item_another;

            for (int j = 0; j < item_stat_count + 1; j++)
            {
                item_stat_name_2[0, j] = item_stat_name[j];
                item_stat_int_2[0, j] = item_stat_int[j];
            }

            Console.WriteLine("               [  아이템 획득 !  ]");
            Console.WriteLine();
            Console.WriteLine();

            if (item_grade[0] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (item_grade[0] == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine("               [  {0}  ]", item_name);
            Console.WriteLine();

            if (item_another_2[0] == false)
            {
                for (int j = 0; j < item_stat_count + 1; j++)
                {
                    Console.WriteLine("               [  {0}{1}  ]", item_stat_name[j], item_stat_int[j]);
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("               [ {0} ]", item_stat_name[0]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            for (int j = 0; j < item_stat_count_2[0] + 1; j++)
            {
                if (item_stat_name_2[0, j] == "공격력 + ")
                {
                    user_atk += item_stat_int_2[0, j];
                }
                else if (item_stat_name_2[0, j] == "방어력 + ")
                {
                    user_dfd += item_stat_int_2[0, j];
                }
                else if (item_stat_name_2[0, j] == "HP + ")
                {
                    user_max_hp += item_stat_int_2[0, j];
                }
                else if (item_stat_name_2[0, j] == "치명타율 + ")
                {
                    user_crt += item_stat_int_2[0, j];
                }
                else if (item_stat_name_2[0, j] == "회피율 + ")
                {
                    user_eva += item_stat_int_2[0, j];
                }
                else if (item_stat_name_2[0, j] == "흡혈 능력 + ")
                {
                    if (user_vamp == 8)
                    {
                        user_vamp = 8;
                    }
                    else
                    {
                        user_vamp += item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "중독 능력 + ")
                {
                    if (user_pois == 8)
                    {
                        user_pois = 8;
                    }
                    else
                    {
                        user_pois += item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "기절 능력 + ")
                {
                    if (user_para == 8)
                    {
                        user_para = 8;
                    }
                    else
                    {
                        user_para += item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "반격 능력 + ")
                {
                    if (user_cout == 8)
                    {
                        user_cout = 8;
                    }
                    else
                    {
                        user_cout += item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "HP 회복 = ")
                {
                    if (user_hp + item_stat_int_2[0, j] >= user_max_hp)
                    {
                        user_hp = user_max_hp;
                    }
                    else
                    {
                        user_hp += item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "목마름 회복 = ")
                {
                    if (thirsty - item_stat_int_2[0, j] <= 0)
                    {
                        thirsty = 0;
                    }
                    else
                    {
                        thirsty -= item_stat_int_2[0, j];
                    }
                }
                else if (item_stat_name_2[0, j] == "스킬 사용 횟수 증가 + ")
                {
                    user_skill_count[1] += item_stat_int_2[0, j];



                }
            }
        }
    }
}
