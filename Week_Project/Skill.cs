using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Skill
    {
        public void Ability(ref int user_vamp, ref int user_vamp_per, ref int[] user_vamp_int, ref int user_cout, ref int user_cout_per,
            ref int[] user_cout_int, ref int user_pois, ref int user_pois_per, ref int[] user_pois_int, ref int user_para,
            ref int user_para_per)
        {
            if (user_vamp == 0)
            {
                user_vamp_per = 0;
                user_vamp_int[0] = 0;
            }
            else if (user_vamp == 1)
            {
                user_vamp_per = 15;
                user_vamp_int[0] = 10;
            }
            else if (user_vamp == 2)
            {
                user_vamp_per = 15;
                user_vamp_int[0] = 12;
            }
            else if (user_vamp == 3)
            {
                user_vamp_per = 15;
                user_vamp_int[0] = 14;
            }
            else if (user_vamp == 4)
            {
                user_vamp_per = 20;
                user_vamp_int[0] = 14;
            }
            else if (user_vamp == 5)
            {
                user_vamp_per = 20;
                user_vamp_int[0] = 16;
            }
            else if (user_vamp == 6)
            {
                user_vamp_per = 20;
                user_vamp_int[0] = 18;
            }
            else if (user_vamp == 7)
            {
                user_vamp_per = 20;
                user_vamp_int[0] = 20;
            }
            else if (user_vamp == 8)
            {
                user_vamp_per = 25;
                user_vamp_int[0] = 20;
            }

            if (user_cout == 0)
            {
                user_cout_per = 0;
                user_cout_int[0] = 0;
            }
            else if (user_cout == 1)
            {
                user_cout_per = 15;
                user_cout_int[0] = 5;
            }
            else if (user_cout == 2)
            {
                user_cout_per = 15;
                user_cout_int[0] = 6;
            }
            else if (user_cout == 3)
            {
                user_cout_per = 15;
                user_cout_int[0] = 7;
            }
            else if (user_cout == 4)
            {
                user_cout_per = 15;
                user_cout_int[0] = 8;
            }
            else if (user_cout == 5)
            {
                user_cout_per = 20;
                user_cout_int[0] = 8;
            }
            else if (user_cout == 6)
            {
                user_cout_per = 20;
                user_cout_int[0] = 9;
            }
            else if (user_cout == 7)
            {
                user_cout_per = 20;
                user_cout_int[0] = 10;
            }
            else if (user_cout == 8)
            {
                user_cout_per = 25;
                user_cout_int[0] = 10;
            }

            if (user_pois == 0)
            {
                user_pois_per = 0;
                user_pois_int[0] = 0;
            }
            else if (user_pois == 1)
            {
                user_pois_per = 15;
                user_pois_int[0] = 2;
            }
            else if (user_pois == 2)
            {
                user_pois_per = 15;
                user_pois_int[0] = 3;
            }
            else if (user_pois == 3)
            {
                user_pois_per = 15;
                user_pois_int[0] = 4;
            }
            else if (user_pois == 4)
            {
                user_pois_per = 20;
                user_pois_int[0] = 5;
            }
            else if (user_pois == 5)
            {
                user_pois_per = 20;
                user_pois_int[0] = 6;
            }
            else if (user_pois == 6)
            {
                user_pois_per = 20;
                user_pois_int[0] = 7;
            }
            else if (user_pois == 7)
            {
                user_pois_per = 25;
                user_pois_int[0] = 8;
            }
            else if (user_pois == 8)
            {
                user_pois_per = 25;
                user_pois_int[0] = 10;
            }

            if (user_para == 0)
            {
                user_para_per = 0;
            }
            else if (user_para == 1)
            {
                user_para_per = 10;
            }
            else if (user_para == 2)
            {
                user_para_per = 11;
            }
            else if (user_para == 3)
            {
                user_para_per = 12;
            }
            else if (user_para == 4)
            {
                user_para_per = 13;
            }
            else if (user_para == 5)
            {
                user_para_per = 14;
            }
            else if (user_para == 6)
            {
                user_para_per = 16;
            }
            else if (user_para == 7)
            {
                user_para_per = 18;
            }
            else if (user_para == 8)
            {
                user_para_per = 20;
            }
        }
    }
}
