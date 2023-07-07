using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Monster
    {
        public void Monster_Info(ref string[] mons_word, ref int[] mons_atk, ref int mons_dfd, ref int mons_hp, ref int mons_max_hp,
            ref int mons_crt, ref float mons_crt_mult, ref int mons_eva, ref int mons_vamp, ref int mons_para, ref int mons_pois,
            ref int mons_cout, ref int monster_type, ref int monster_skill, ref int[] mons_vamp_int, ref int[] mons_pois_int,
            ref int[] mons_cout_int)
        {

            if (monster_type == 1)            // 고블린
            {
                mons_word[0] = "고블린이 무기를 좌우로 휘두르며 돌격하고 있다";
                mons_word[1] = "고블린이 신중한 표정으로 무기를 찌르려는 자세를 잡는다";
                mons_word[2] = "고블린이 힘껏 무기를 들어올려 내려찍으려고 한다";

                mons_atk[0] = 5;
                mons_atk[1] = 7;
                mons_atk[2] = 10;
                mons_dfd = 1;
                mons_hp = 100;
                mons_max_hp = 100;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 10;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 2)          // 미믹
            {
                mons_word[0] = "미믹이 혀를 낼름거리며 공격할 자세를 잡는다";
                mons_word[1] = "미믹이 입을 닫고 몸을 힘껏 부딛힐 자세를 잡는다";
                mons_word[2] = "미믹이 입을 크게 벌리고 잡아먹어 버릴듯이 달려든다";

                mons_atk[0] = 7;
                mons_atk[1] = 9;
                mons_atk[2] = 13;
                mons_dfd = 4;
                mons_hp = 120;
                mons_max_hp = 120;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 10;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 3)          // 샌드 웜
            {
                mons_word[0] = "샌드 웜이 입을 벌리며 머리를 들이밀려고 자세를 잡는다";
                mons_word[1] = "샌드 웜이 촉수를 날릴 준비를 한다";
                mons_word[2] = "샌드 웜이 모래 구덩이를 파고 숨어 기습 공격할 기회를 엿본다";

                mons_atk[0] = 10;
                mons_atk[1] = 13;
                mons_atk[2] = 17;
                mons_dfd = 3;
                mons_hp = 140;
                mons_max_hp = 140;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 15;
                mons_vamp = 30;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 50;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 4)         // 타락한 모래 정령
            {
                mons_word[0] = "타락한 모래 정령이 바닥에 있는 모래들을 뭉쳐 날릴 준비를 한다";
                mons_word[1] = "타락한 모래 정령의 온몸에 노란색 기운이 모이기 시작한다";
                mons_word[2] = "타락한 모래 정령의 온몸에 검은색 기운이 모이기 시작한다";

                mons_atk[0] = 15;
                mons_atk[1] = 18;
                mons_atk[2] = 21;
                mons_dfd = 4;
                mons_hp = 160;
                mons_max_hp = 160;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 35;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 5)           // 데저트 코브라
            {
                mons_word[0] = "데저트 코브라가 온몸을 휘감으며 서서히 다가온다";
                mons_word[1] = "데저트 코브라가 멀리서 독을 뱉으려고 준비한다";
                mons_word[2] = "데저트 코브라가 두눈을 똑바로 쳐다보며 혀를 낼름거리면서 몸을 꼿꼿히 세웠다";

                mons_atk[0] = 19;
                mons_atk[1] = 23;
                mons_atk[2] = 27;
                mons_dfd = 5;
                mons_hp = 180;
                mons_max_hp = 180;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 15;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 30;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 5;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 6)          // 모래 고목
            {
                mons_word[0] = "모래 고목이 나뭇가지를 길게 늘려 찌르기를 준비한다";
                mons_word[1] = "모래 고목이 두꺼운 나무 몸통으로 부딛히려고 준비한다";
                mons_word[2] = "모래 고목이 모든것을 밟아 버릴듯이 온 힘을 모아 무아지경으로 달려온다";

                mons_atk[0] = 21;
                mons_atk[1] = 24;
                mons_atk[2] = 27;
                mons_dfd = 6;
                mons_hp = 250;
                mons_max_hp = 250;
                mons_crt = 10;
                mons_crt_mult = 1.5F;
                mons_eva = 10;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 7)          // 스콜피온
            {
                mons_word[0] = "스콜피온이 꼬리침을 좌우로 흔들며 공격하려고 준비한다";
                mons_word[1] = "스콜피온이 꼬리침을 뒤로 최대한 빼며 강력한 공격을 준비한다";
                mons_word[2] = "스콜피온이 모래땅을 파고 들어가 강력한 기습공격을 준비한다";

                mons_atk[0] = 24;
                mons_atk[1] = 28;
                mons_atk[2] = 32;
                mons_dfd = 7;
                mons_hp = 200;
                mons_max_hp = 200;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 15;
                mons_vamp = 0;
                mons_para = 30;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 8)            // 거대 선인장
            {
                mons_word[0] = "거대 선인장이 가시들을 발사해 공격하려고 준비한다";
                mons_word[1] = "거대 선인장이 몸을 둥글게 말고 가시를 앞세워 굴러오려고 준비한다";
                mons_word[2] = "거대 선인장이 가시들을 뾰족히 세우고 높이 점프하여 내려찍으려고 한다";

                mons_atk[0] = 30;
                mons_atk[1] = 34;
                mons_atk[2] = 38;
                mons_dfd = 8;
                mons_hp = 220;
                mons_max_hp = 220;
                mons_crt = 15;
                mons_crt_mult = 1.5F;
                mons_eva = 15;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 30;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 20;
                monster_skill = 0;
            }
            else if (monster_type == 9)           // 언데드 아처
            {
                mons_word[0] = "언데드 아처가 화살을 높게 들고 가까이 와 찌르려고 준비한다.";
                mons_word[1] = "언데드 아처가 뒤로 이동하며 화살을 장전하고 신중하게 활을 조준한다";
                mons_word[2] = "언데드 아처가 높은곳으로 올라가 화살을 장전하고 활을 신중하게 조준한다";

                mons_atk[0] = 37;
                mons_atk[1] = 41;
                mons_atk[2] = 45;
                mons_dfd = 9;
                mons_hp = 250;
                mons_max_hp = 250;
                mons_crt = 30;
                mons_crt_mult = 1.5F;
                mons_eva = 10;
                mons_vamp = 0;
                mons_para = 0;
                mons_pois = 0;
                mons_cout = 0;
                mons_vamp_int[0] = 0;
                mons_pois_int[0] = 0;
                mons_cout_int[0] = 0;
                monster_skill = 0;
            }
            else if (monster_type == 10)          // 브론즈 드래곤
            {
                mons_word[0] = "브론즈 드래곤이 순식간에 전방으로 날아와 큰 발톱으로 공격하려고 한다";
                mons_word[1] = "브론즈 드래곤이 입을 위로 들어올려 불을 내뿜으려고 준비한다";
                mons_word[2] = "브론즈 드래곤이 크게 포효하며 높이 날아올라 내려찍기를 준비한다";

                mons_atk[0] = 50;
                mons_atk[1] = 60;
                mons_atk[2] = 70;
                mons_dfd = 15;
                mons_hp = 400;
                mons_max_hp = 400;
                mons_crt = 30;
                mons_crt_mult = 1.5F;
                mons_eva = 20;
                mons_vamp = 25;
                mons_para = 25;
                mons_pois = 25;
                mons_cout = 25;
                mons_vamp_int[0] = 20;
                mons_pois_int[0] = 5;
                mons_cout_int[0] = 20;
                monster_skill = 0;
            }
        }
    }
}
