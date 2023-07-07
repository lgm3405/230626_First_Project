using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Item
    {
        bool item_another = false;

        public void Collection(ref int[] item_num, ref string item_name, ref string[] item_stat_name, ref int[] item_stat_int,
            ref int item_stat_count, ref bool item_another)
        {

            if (item_num[0] == 1 || item_name == "녹슨 대검")
            {
                item_num[0] = 1;
                item_name = "녹슨 대검";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 5;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 2 || item_name == "찢어진 군화")
            {
                item_num[0] = 2;
                item_name = "찢어진 군화";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 3 || item_name == "가벼운 망토")
            {
                item_num[0] = 3;
                item_name = "가벼운 망토";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 10;
                item_stat_name[1] = "회피율 + ";
                item_stat_int[1] = 5;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[0] == 4 || item_name == "그을린 반지")
            {
                item_num[0] = 4;
                item_name = "그을린 반지";
                item_stat_name[0] = "치명타율 + ";
                item_stat_int[0] = 5;
                item_stat_name[1] = "회피율 + ";
                item_stat_int[1] = 5;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[0] == 5 || item_name == "구멍난 갑옷")
            {
                item_num[0] = 5;
                item_name = "구멍난 갑옷";
                item_stat_name[0] = "방어력 + ";
                item_stat_int[0] = 3;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 6 || item_name == "부식된 목검")
            {
                item_num[0] = 6;
                item_name = "부식된 목검";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 3;
                item_stat_name[1] = "치명타율 + ";
                item_stat_int[1] = 3;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[0] == 7 || item_name == "나무 방패")
            {
                item_num[0] = 7;
                item_name = "나무 방패";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 10;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 2;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[0] == 8 || item_name == "정찰병의 모자")
            {
                item_num[0] = 8;
                item_name = "정찰병의 모자";
                item_stat_name[0] = "방어력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "회피율 + ";
                item_stat_int[1] = 3;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[0] == 9 || item_name == "빵 조각")
            {
                item_num[0] = 9;
                item_name = "빵 조각";
                item_stat_name[0] = "HP 회복 = ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 10 || item_name == "군용 수통")
            {
                item_num[0] = 10;
                item_name = "군용 수통";
                item_stat_name[0] = "목마름 회복 = ";
                item_stat_int[0] = 10;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 11 || item_name == "뱀파이어 손톱")
            {
                item_num[0] = 11;
                item_name = "뱀파이어 손톱";
                item_stat_name[0] = "흡혈 능력 + ";
                item_stat_int[0] = 1;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 12 || item_name == "뿅망치")
            {
                item_num[0] = 12;
                item_name = "뿅망치";
                item_stat_name[0] = "기절 능력 + ";
                item_stat_int[0] = 1;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 13 || item_name == "가시 방패")
            {
                item_num[0] = 13;
                item_name = "가시 방패";
                item_stat_name[0] = "반격 능력 + ";
                item_stat_int[0] = 1;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 14 || item_name == "독 버섯")
            {
                item_num[0] = 14;
                item_name = "독 버섯";
                item_stat_name[0] = "중독 능력 + ";
                item_stat_int[0] = 1;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[0] == 15 || item_name == "오각형 목걸이")
            {
                item_num[0] = 15;
                item_name = "오각형 목걸이";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 2;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 2;
                item_stat_name[2] = "HP + ";
                item_stat_int[2] = 5;
                item_stat_name[3] = "치명타율 + ";
                item_stat_int[3] = 1;
                item_stat_name[4] = "회피율 + ";
                item_stat_int[4] = 1;
                item_stat_count = 4;
                item_another = false;
            }
            else if (item_num[1] == 1 || item_name == "롱 소드")
            {
                item_num[1] = 1;
                item_name = "롱 소드";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 10;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 2 || item_name == "데저트 메일")
            {
                item_num[1] = 2;
                item_name = "데저트 메일";
                item_stat_name[0] = "방어력 + ";
                item_stat_int[0] = 5;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 3 || item_name == "마법사 모자")
            {
                item_num[1] = 3;
                item_name = "마법사 모자";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 35;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 4 || item_name == "태양 반지")
            {
                item_num[1] = 4;
                item_name = "태양 반지";
                item_stat_name[0] = "치명타율 + ";
                item_stat_int[0] = 8;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 5 || item_name == "붉은 깃 목걸이")
            {
                item_num[1] = 5;
                item_name = "붉은 깃 목걸이";
                item_stat_name[0] = "회피율 + ";
                item_stat_int[0] = 8;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 6 || item_name == "박쥐 모양 망토")
            {
                item_num[1] = 6;
                item_name = "박쥐 모양 망토";
                item_stat_name[0] = "흡혈 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "HP + ";
                item_stat_int[1] = 5;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 7 || item_name == "번개 맞은 검")
            {
                item_num[1] = 7;
                item_name = "번개 맞은 검";
                item_stat_name[0] = "기절 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "공격력 + ";
                item_stat_int[1] = 3;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 8 || item_name == "독 화살")
            {
                item_num[1] = 8;
                item_name = "독 화살";
                item_stat_name[0] = "중독 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "치명타율 + ";
                item_stat_int[1] = 2;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 9 || item_name == "가시 갑옷")
            {
                item_num[1] = 9;
                item_name = "가시 갑옷";
                item_stat_name[0] = "반격 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 1;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 10 || item_name == "칼날 부메랑")
            {
                item_num[1] = 10;
                item_name = "칼날 부메랑";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 8;
                item_stat_name[1] = "치명타율 + ";
                item_stat_int[1] = 6;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 11 || item_name == "마녀의 거울")
            {
                item_num[1] = 11;
                item_name = "마녀의 거울";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 15;
                item_stat_name[1] = "회피율 + ";
                item_stat_int[1] = 5;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 12 || item_name == "강철 방패")
            {
                item_num[1] = 12;
                item_name = "강철 방패";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 20;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 3;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[1] == 13 || item_name == "고블린 식량 가방")
            {
                item_num[1] = 13;
                item_name = "고블린 식량 가방";
                item_stat_name[0] = "HP 회복 = ";
                item_stat_int[0] = 40;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 14 || item_name == "드워프 맥주통")
            {
                item_num[1] = 14;
                item_name = "드워프 맥주통";
                item_stat_name[0] = "목마름 회복 = ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[1] == 15 || item_name == "맛있어 보이는 버섯")
            {
                item_num[1] = 15;
                item_name = "맛있어 보이는 버섯";
                item_stat_name[0] = "스킬 사용 횟수 증가 + ";
                item_stat_int[0] = 15;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 1 || item_name == "드래곤 소드")
            {
                item_num[2] = 1;
                item_name = "드래곤 소드";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 2 || item_name == "엘븐 보우")
            {
                item_num[2] = 2;
                item_name = "엘븐 보우";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 15;
                item_stat_name[1] = "치명타율 + ";
                item_stat_int[1] = 10;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 3 || item_name == "마법사의 외눈 안경")
            {
                item_num[2] = 3;
                item_name = "마법사의 외눈 안경";
                item_stat_name[0] = "치명타율 + ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 4 || item_name == "보호 망토")
            {
                item_num[2] = 4;
                item_name = "보호 망토";
                item_stat_name[0] = "회피율 + ";
                item_stat_int[0] = 20;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 5 || item_name == "드래곤 스케일 아머")
            {
                item_num[2] = 5;
                item_name = "드래곤 스케일 아머";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 30;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 12;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 6 || item_name == "엔젤 하트 아머")
            {
                item_num[2] = 6;
                item_name = "엔젤 하트 아머";
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 50;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 8;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 7 || item_name == "천사의 열매")
            {
                item_num[2] = 7;
                item_name = "천사의 열매";
                item_stat_name[0] = "HP 회복 = ";
                item_stat_int[0] = 300;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 8 || item_name == "악마의 열매")
            {
                item_num[2] = 8;
                item_name = "악마의 열매";
                item_stat_name[0] = "목마름 회복 = ";
                item_stat_int[0] = 100;
                item_stat_count = 0;
                item_another = false;
            }
            else if (item_num[2] == 9 || item_name == "대 마법사 지팡이")
            {
                item_num[2] = 9;
                item_name = "대 마법사 지팡이";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 20;
                item_stat_name[0] = "HP + ";
                item_stat_int[0] = 40;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 10 || item_name == "피바라기")
            {
                item_num[2] = 10;
                item_name = "피바라기";
                item_stat_name[0] = "흡혈 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "공격력 + ";
                item_stat_int[1] = 15;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 11 || item_name == "토르의 망치")
            {
                item_num[2] = 11;
                item_name = "토르의 망치";
                item_stat_name[0] = "기절 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "HP + ";
                item_stat_int[1] = 30;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 12 || item_name == "거울 갑옷")
            {
                item_num[2] = 12;
                item_name = "거울 갑옷";
                item_stat_name[0] = "반격 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 12;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 13 || item_name == "암살자의 단검")
            {
                item_num[2] = 13;
                item_name = "암살자의 단검";
                item_stat_name[0] = "중독 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "치명타율 + ";
                item_stat_int[1] = 15;
                item_stat_count = 1;
                item_another = false;
            }
            else if (item_num[2] == 14 || item_name == "절대고수의 비법서")
            {
                item_num[2] = 14;
                item_name = "절대고수의 비법서";
                item_stat_name[0] = "흡혈 능력 + ";
                item_stat_int[0] = 1;
                item_stat_name[1] = "중독 능력 + ";
                item_stat_int[1] = 1;
                item_stat_name[2] = "기절 능력 + ";
                item_stat_int[2] = 1;
                item_stat_name[3] = "반격 능력 + ";
                item_stat_int[3] = 1;
                item_stat_count = 3;
                item_another = false;
            }
            else if (item_num[2] == 15 || item_name == "삼위일체")
            {
                item_num[2] = 15;
                item_name = "삼위일체";
                item_stat_name[0] = "공격력 + ";
                item_stat_int[0] = 20;
                item_stat_name[1] = "방어력 + ";
                item_stat_int[1] = 10;
                item_stat_name[2] = "HP + ";
                item_stat_int[2] = 40;
                item_stat_count = 2;
                item_another = false;

            }
        }
    }
}
