﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_4
{
    public partial class Form1 : Form
    {
        int y = 0;
        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = 0;
            y = 0;
            string total = "";
            var birthday = dateTimePicker1.Value;
            var year = birthday.Year;
            var month = birthday.Month;
            var day = birthday.Day;
            int m = birthday.Month;
            int d = birthday.Day;
            if (m == 2 && d >= 20 || m == 3 && d <= 20)
            {
                label3.Text = "你的星座是:雙魚座";
                s = 12;
            }
            if (m == 1 && d >= 22 || m == 2 && d <= 19)
            {
                label3.Text = "你的星座是:水瓶座";
                s = 11;
            }
            if (m == 12 && d >= 23 || m == 1 && d <= 21)
            {
                label3.Text = "你的星座是:摩羯座";
                s = 10;
            }
            if (m == 11 && d >= 23 || m == 12 && d <= 22)
            {
                label3.Text = "你的星座是:射手座";
                s = 9;
            }
            if (m == 10 && d >= 22 || m == 11 && d <= 22)
            {
                label3.Text = "你的星座是:天蠍座";
                s = 8;
            }
            if (m == 9 && d >= 23 || m == 10 && d <= 22)
            {
                label3.Text = "你的星座是:天秤座";
                s = 7;
            }
            if (m == 8 && d >= 23 || m == 9 && d <= 22)
            {
                label3.Text = "你的星座是:處女座";
                s = 6;

            }
            if (m == 7 && d >= 23 || m == 8 && d <= 22)
            {
                label3.Text = "你的星座是:獅子座";
                s = 5;
            }
            if (m == 6 && d >= 21 || m == 7 && d <= 22)
            {
                label3.Text = "你的星座是:巨蟹座";
                s = 4;
            }
            if (m == 5 && d >= 21 || m == 6 && d <= 20)
            {
                label3.Text = "你的星座是:雙子座";
                s = 3;
            }
            if (m == 4 && d >= 21 || m == 5 && d <= 20)
            {
                label3.Text = "你的星座是:金牛座";
                s = 2;
            }
            if (m == 3 && d >= 21 || m == 4 && d <= 20)
            {
                label3.Text = "你的星座是:牡羊座";
                s = 1;
            }
            total += year.ToString();
            total += month.ToString();
            total += day.ToString();
            foreach (var i in total)
            {
                y += int.Parse(i.ToString());
            }
            for (; y > 9;)
            {
                string t = y.ToString();
                y = 0;
                foreach (char i in t)
                {
                    y += int.Parse(i.ToString());
                }
            }
            if (s == 1 && y == 1)
            {
                label2.Text = "生命靈數1：你是個主觀很強的人，只想著自己想做的事。";
            }
            if (s == 1 && y == 2)
            {
                label2.Text = "生命靈數2：你會在意別人看你的眼光，個性比較害羞一點。";
            }
            if (s == 1 && y == 3)
            {
                label2.Text = "生命靈數3：喜歡錶達自己的想法，但也要多聽聽別人的意見哦！";
            }
            if (s == 1 && y == 4)
            {
                label2.Text = "生命靈數4：你對未來很關心，很少胡思亂想，會腳踏實地的努力。";
            }
            if (s == 1 && y == 5)
            {
                label2.Text = "生命靈數5：最愛玩的Aries牧羊非你莫屬，尤其喜歡到處去湊熱鬧。";
            }
            if (s == 1 && y == 6)
            {
                label2.Text = "生命靈數6：你很固執哦！尤其是感情層面，而且非常的主觀。";
            }
            if (s == 1 && y == 7)
            {
                label2.Text = "生命靈數7：對於自己覺得有理的地方非常的堅持，不聽別人的意見。";
            }
            if (s == 1 && y == 8)
            {
                label2.Text = "生命靈數8：很重視實際層面的成就，會很努力在學習和工作上。";
            }
            if (s == 1 && y == 9)
            {
                label2.Text = "生命靈數9：你是較不切實際的人，不過你的熱情可將不可能變可能。";
            }
            if (s == 2 && y == 1)
            {
                label2.Text = "生命靈數1：你的行動力很強，對事自有一套，做法也不喜歡受干涉。";
            }
            if (s == 2 && y == 2)
            {
                label2.Text = "生命靈數2：你會重視人際關係，在與別人相處時也比較容易受影響。";
            }
            if (s == 2 && y == 3)
            {
                label2.Text = "生命靈數3：你是牛座中比較靈活的，喜歡發表自己所研究出來的事物。";
            }
            if (s == 2 && y == 4)
            {
                label2.Text = "生命靈數4：你是牛座中最固執的哦！你的想法常常和別人不太一樣。";
            }
            if (s == 2 && y == 5)
            {
                label2.Text = "生命靈數5：你是一隻多才多藝的牛，如果能夠定下來會更有成就。";
            }
            if (s == 2 && y == 6)
            {
                label2.Text = "生命靈數6：你是最念舊的牛座，對於自己重視的東西會非常呵護。";
            }
            if (s == 2 && y == 7)
            {
                label2.Text = "生命靈數7：你是有叛逆性格的牛牛，不易被別人說服，自有一套想法。";
            }
            if (s == 2 && y == 8)
            {
                label2.Text = "生命靈數8：你很重視實際層面的成就，會努力讓自己更加的優秀或成功。";
            }
            if (s == 2 && y == 9)
            {
                label2.Text = "生命靈數9：你是牛座中最有夢想的，但是要多學習如何落實在現實中。";
            }
            if (s == 3 && y == 1)
            {
                label2.Text = "生命靈數1：喜歡自由自在的你，對於自己有興趣的事情都會去鑽研哦！";
            }
            if (s == 3 && y == 2)
            {
                label2.Text = "生命靈數2：你是最喜歡與別人溝通的Gemini雙子座，不過很容易受外來的影響。";
            }
            if (s == 3 && y == 3)
            {
                label2.Text = "生命靈數3：你真的是Gemini雙子座中最為多才多藝的，什麼東西都是一學就會。";
            }
            if (s == 3 && y == 4)
            {
                label2.Text = "生命靈數4：你是比較重視生活規律的人，看來隨和但自有一套規則。";
            }
            if (s == 3 && y == 5)
            {
                label2.Text = "生命靈數5：喜歡到處亂跑的你真是交友滿天下，心性上也比較不穩定。";
            }
            if (s == 3 && y == 6)
            {
                label2.Text = "生命靈數6：你是Gemini雙子中最重視人情味的，尤其重視老朋友之間的感情。";
            }
            if (s == 3 && y == 7)
            {
                label2.Text = "生命靈數7：你是Gemini雙子中最刁鑽古怪的，常想些別人都不會想到的問題。";
            }
            if (s == 3 && y == 8)
            {
                label2.Text = "生命靈數8：你喜歡享受生活，會特別的注重自己的生活品質。";
            }
            if (s == 3 && y == 9)
            {
                label2.Text = "生命靈數9：你是Gemini雙子中最會胡思亂想的，同時也是比較熱情的。";
            }
            if (s == 4 && y == 1)
            {
                label2.Text = "生命靈數1：你個性上有點自閉哦！不容易真正和別人有好的交流。";
            }
            if (s == 4 && y == 2)
            {
                label2.Text = "生命靈數2：會很看重別人的意見，要小心因此喪失自己的意見。";
            }
            if (s == 4 && y == 3)
            {
                label2.Text = "生命靈數3：喜歡感情上的表達與溝通，在藝術上會有不錯的天份哩！";
            }
            if (s == 4 && y == 4)
            {
                label2.Text = "生命靈數4：你是蟹子中比較龜毛的，尤其重視自己生活上的規律。";
            }
            if (s == 4 && y == 5)
            {
                label2.Text = "生命靈數5：你不一定喜歡亂跑，但不能受到太多拘束，想自由自在。";
            }
            if (s == 4 && y == 6)
            {
                label2.Text = "生命靈數6：你是蟹座中最重感情的，尤其在感情世界里很要求完美。";
            }
            if (s == 4 && y == 7)
            {
                label2.Text = "生命靈數7：你是蟹子中想得最多的，表現出來的模樣也頗為固執己見。";
            }
            if (s == 4 && y == 8)
            {
                label2.Text = "生命靈數8：你很重視現實上的成就與穩定，會努力讓自己的生活更好。*-*";
            }
            if (s == 4 && y == 9)
            {
                label2.Text = "生命靈數9：你是蟹子中相當熱情的，但剛到新的環境會比較害羞。";
            }
            if (s == 5 && y == 1)
            {
                label2.Text = "生命靈數1：你是Leo獅子座中最為自我的，但可能因此造成人際問題。";
            }
            if (s == 5 && y == 2)
            {
                label2.Text = "生命靈數2：別人的肯定對你來說非常重要，可能因此而失去自我。";
            }
            if (s == 5 && y == 3)
            {
                label2.Text = "生命靈數3：你是Leo獅子座中最愛表現自己的，通常是人際關係中的佼佼者。";
            }
            if (s == 5 && y == 4)
            {
                label2.Text = "生命靈數4：你是只固執的Leo獅子，而且在行動上比較缺乏冒險犯難的精神。";
            }
            if (s == 5 && y == 5)
            {
                label2.Text = "生命靈數5：Leo獅子中最熱愛自由的就是你啦！一般來說你們是相當大方的。";
            }
            if (s == 5 && y == 6)
            {
                label2.Text = "生命靈數6：你是Leo獅子座中比較龜毛的，尤其是感情的表達上會顯得害羞。";
            }
            if (s == 5 && y == 7)
            {
                label2.Text = "生命靈數7：你是很會想的Leo獅子座哦！雖然比較主觀，但還可以溝通。";
            }
            if (s == 5 && y == 8)
            {
                label2.Text = "生命靈數8：你是一個講究生活品味的人哦！喜歡從容優渥的過日子。";
            }
            if (s == 5 && y == 9)
            {
                label2.Text = "生命靈數9：你的熱情很容易感動別人，在人群中常是人氣很旺的明星哩！";
            }
            if (s == 6 && y ==1)
            {
                label2.Text = "生命靈數1：你有點孤僻，常常覺得別人不了解你，要多與別人互動才好。";
            }
            if (s == 6 && y ==2)
            {
                label2.Text = "生命靈數2：你會很注重每個人的意見，與別人來往時也是非常誠懇的。";
            }

            if (s == 6 && y ==3)
            {
                label2.Text = "生命靈數3：能力頗佳的你，適合擔任發言或主持的任務，會勝任愉快哦！";
            }

            if (s == 6 && y ==4)
            {
                label2.Text = "生命靈數4：你是Virgo處女座中最為?t毛的，尤其容易劃地自限，要特別注意。";
            }

            if (s == 6 && y ==5)
            {
                label2.Text = "生命靈數5：你是屬於比較外向的，容易交到許多朋友，但知心的並不多。";
            }

            if (s == 6 && y ==6)
            {
                label2.Text = "生命靈數6：你是非常非常念舊的人哦！尤其是感情上，常常很難割捨。";
            }

            if (s == 6 && y ==7)
            {
                label2.Text = "生命靈數7：你的個性比較剛直，不過在與人交往上還是要多體諒別人哦！";
            }

            if (s == 6 && y ==8)
            {
                label2.Text = "生命靈數8：你是比較圓滑的人，很了解人際上的交流要如何互動。";
            }

            if (s == 6 && y ==9)
            {
                label2.Text = "生命靈數9：對你投入的事情非常的狂熱，有時甚至因此而廢寢忘食。";
            }

            if (s == 7 && y ==1)
            {
                label2.Text = "生命靈數1：你是秤子中比較獨立的，在決定事情時也比較不會猶豫不決。";
            }
            if (s == 7 && y ==2)
            {
                label2.Text = "生命靈數2：在秤子中你是最需要別人陪伴的，如果沒有伴會感到不安。";
            }
            if (s == 7 && y ==3)
            {
                label2.Text = "生命靈數3：你是秤子中最有才華的，在各項藝術領域都有不錯的天份。";
            }
            if (s == 7 && y ==4)
            {
                label2.Text = "生命靈數4：你是秤子中最為重視實際層面的，也是比較有責任感的哦！";
            }
            if (s == 7 && y ==5)
            {
                label2.Text = "生命靈數5：你是一隻喜愛交遊的Libra天秤，對感到好玩的事情都不會放過。";
            }
            if (s == 7 && y ==6)
            {
                label2.Text = "生命靈數6：感情的順利與否對你來說非常重要哦！要小心的經營才好。";
            }
            if (s == 7 && y ==7)
            {
                label2.Text = "生命靈數7：你是秤子中最喜歡思考的，對許多事都會找出合理的方法。";
            }
            if (s == 7 && y ==8)
            {
                label2.Text = "生命靈數8：很重視生活的感覺，不能忍受太差的生活環境，有雅癖傾向。";
            }
            if (s == 7 && y ==9)
            {
                label2.Text = "生命靈數9：你許多想法都有些不切實際，而且熱情常常無法持久哦！";
            }
            if (s == 8 && y ==1)
            {
                label2.Text = "生命靈數1：你很重視自己的目標，不太理睬身邊其他人在做些什麼。";
            }
            if (s == 8 && y ==2)
            {
                label2.Text = "生命靈數2：你很在乎兩人關係上的忠誠，會全心全意的對待另一半。";
            }
            if (s == 8 && y ==3)
            {
                label2.Text = "生命靈數3：對於溝通與人際關係是你的專長，總能夠得到大家幫助。";
            }
            if (s == 8 && y ==4)
            {
                label2.Text = "生命靈數4：你是非常非常固執的，一旦你決定的事就難以改變。";
            }
            if (s == 8 && y ==5)
            {
                label2.Text = "生命靈數5：你是蠍子中最開朗的，也是最容易與大家打成一片的。";
            }
            if (s == 8 && y ==6)
            {
                label2.Text = "生命靈數6：你是個完美主義者，尤其是非常重視感情方面的經營。";
            }
            if (s == 8 && y ==7)
            {
                label2.Text = "生命靈數7：你想的很多，常想到一些別人找不到的問題，非常聰明。";
            }
            if (s == 8 && y ==8)
            {
                label2.Text = "生命靈數8：你很重視自己的地社會地位，認為應該得到的就會去爭取。";
            }
            if (s == 8 && y ==9)
            {
                label2.Text = "生命靈數9：對於你喜歡或相信的事是非常狂熱的，但表面上看不出來。";
            }
            if (s == 9 && y ==1)
            {
                label2.Text = "生命靈數1：你常常我行我素，一有目標就會很快去執行，行動力很強。";
            }
            if (s == 9 && y ==2)
            {
                label2.Text = "生命靈數2：喜歡與別人溝通相處的你，在人際上會得到大家的幫忙。";
            }
            if (s == 9 && y ==3)
            {
                label2.Text = "生命靈數3：你是相當有才華的人哦！很能夠表現自己在藝術上的才華。";
            }
            if (s == 9 && y ==4)
            {
                label2.Text = "生命靈數4：你是Sagittarius射手座中最重視生活規律的，而且也很有自己的想法。";
            }
            if (s == 9 && y ==5)
            {
                label2.Text = "生命靈數5：哇！你真是超愛亂跑，一直待在同一個地方會讓你很難過。";
            }
            if (s == 9 && y ==6)
            {
                label2.Text = "生命靈數6：你是很重視親情的人哦！在人際交流上也是很有一套的。";
            }
            if (s == 9 && y ==7)
            {
                label2.Text = "生命靈數7：你真是想得太多，又有點固執的人，懷疑的心態很強哦！";
            }
            if (s == 9 && y ==8)
            {
                label2.Text = "生命靈數8：你很重視自己的成就和外在的表現，喜歡富裕的生活環境。";
            }
            if (s == 9 && y ==9)
            {
                label2.Text = "生命靈數9：你是很有理想的人，也是舉辦活動的高手，受到大家歡迎！";
            }
            if (s == 10 && y ==1)
            {
                label2.Text = "生命靈數1：你的自尊心很強哦！會默默的努力讓自己有所成就。";
            }
            if (s == 10 && y ==2)
            {
                label2.Text = "生命靈數2：你覺得與人交遊是件重要的事，另外感情也是生活重心。";
            }
            if (s == 10 && y ==3)
            {
                label2.Text = "生命靈數3：只要你多加努力就能展現出自己的才華，會很有成就哦！";
            }
            if (s == 10 && y ==4)
            {
                label2.Text = "生命靈數4：你很重視腳踏實地的生活，會努力讓自己生活穩定下來。";
            }
            if (s == 10 && y ==5)
            {
                label2.Text = "生命靈數5：你是Capricorn摩羯座中比較開朗的，對一些事比較不會那麼憂慮。";
            }
            if (s == 10 && y ==6)
            {
                label2.Text = "生命靈數6：感情是你生活平穩的重點，希望經營有未來的感情生活。";
            }
            if (s == 10 && y ==7)
            {
                label2.Text = "生命靈數7：你是一個非常聰明的人，但有時會因情緒化而下錯判斷。";
            }
            if (s == 10 && y ==8)
            {
                label2.Text = "生命靈數8：對你來說功成名就吸引力大，會努力成為重要的人物。";
            }
            if (s == 10 && y ==9)
            {
                label2.Text = "生命靈數9：你對自己想做的事非常投入，不過有時會忘了實際狀況。";
            }
            if (s == 11 && y ==1)
            {
                label2.Text = "生命靈數1：你是瓶子座中最自閉的，有時候會顯得太過我行我素了些。";
            }
            if (s == 11 && y ==2)
            {
                label2.Text = "生命靈數2：你會比較受到別人的影響，但還不會失去自己原本的主張。";
            }
            if (s == 11 && y ==3)
            {
                label2.Text = "生命靈數3：你是一隻多才多藝的瓶子哩！尤其擅長於表達與溝通哦！";
            }
            if (s == 11 && y ==4)
            {
                label2.Text = "生命靈數4：你是瓶子中比較穩定的，會習慣維持某一種生活的方式。";
            }
            if (s == 11 && y ==5)
            {
                label2.Text = "生命靈數5：常常讓人找不到的就是你這種瓶子啦！朋友也是多不勝數。";
            }
            if (s == 11 && y ==6)
            {
                label2.Text = "生命靈數6：你是比較重感情的瓶子，也比較桃花，感情問題會比較多。";
            }
            if (s == 11 && y ==7)
            {
                label2.Text = "生命靈數7：你是瓶子中最為理性的，太過聰明的話有時候會不近人情。";
            }
            if (s == 11 && y ==8)
            {
                label2.Text = "生命靈數8：你是瓶子中比較重視物質的，會去追求自己所想要的生活。";
            }
            if (s == 11 && y ==9)
            {
                label2.Text = "生命靈數9：你的理想非常高遠，如果持續努力，成功的機會是很大的。";
            }
            if (s == 12 && y ==1)
            {
                label2.Text = "生命靈數1：你容易沉溺在自己的世界的，忘掉了身邊還有別人存在。";
            }
            if (s == 12 && y ==2)
            {
                label2.Text = "生命靈數2：你很容易受到別人的引導，而忘記了自己原本的方向哦！";
            }
            if (s == 12 && y ==3)
            {
                label2.Text = "生命靈數3：你是天生的藝術家，不過還是要稍為注意一下現實環境。";
            }
            if (s == 12 && y ==4)
            {
                label2.Text = "生命靈數4：你是追求穩定生活的魚座，不喜歡太過混亂的生活。";
            }
            if (s == 12 && y ==5)
            {
                label2.Text = "生命靈數5：你比較沒有目標，幾乎什麼事都會去做做看，但都維持不久。";
            }
            if (s == 12 && y ==6)
            {
                label2.Text = "生命靈數6：感情是你最煩惱的事，常常因此而受到打擊或挫折。";
            }
            if (s == 12 && y ==7)
            {
                label2.Text = "生命靈數7：你想得很多，但是一旦遇到自己的事情就會比較主觀。";
            }
            if (s == 12 && y ==8)
            {
                label2.Text = "生命靈數8：你是喜歡享受的魚座，對於生活上的小事都非常的注意。";
            }
            if (s == 12 && y ==9)
            {
                label2.Text = "生命靈數9：你對於某些事都抱著很大的熱誠，過度的話會顯得特別偏執";
            }



        }
    }
}